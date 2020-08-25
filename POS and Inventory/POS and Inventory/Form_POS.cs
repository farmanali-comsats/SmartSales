using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace POS_and_Inventory
{

    public partial class Form_POS : Form
    {
        String id;
        String price;
        int qty;
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        String stitle = "POS System";
        Form_login myform;
        public Form_POS(Form_login frm)
        {
            InitializeComponent();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
            myform = frm;
            notifycriticalitems();
            lbl_title.Text = db.getstorename();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                return;
            }
            gettransno();
            tft_searchbcode.Enabled = true;
            tft_searchbcode.Focus();
        }

        private void tft_searchbcode_Click(object sender, EventArgs e)
        {

        }
        public void getcarttotal()
        {
            double sales = Double.Parse(lbl_salestotal.Text);
            double discount = Double.Parse(lbl_discount.Text);
            double vat = sales * db.Getval();
            double vatable = sales - vat; ;
            lbl_displaytotal.Text = sales.ToString("#,##0.00");
            lbl_vat.Text = vat.ToString("#,##0.00");
            lbl_vatable.Text = vatable.ToString("#,##0.00");

        }
        public void gettransno()
        {
            try
            {
                String sdate = DateTime.Now.ToString("yyyyMMdd");
                String transno;
                int count;
                con.Open();
                cm = new SqlCommand("select top 1 transno from table_cart where transno like '" + sdate + "%' order by id desc", con);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lbl_trcode.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lbl_trcode.Text = transno;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tft_searchbcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tft_searchbcode.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    String _pcode;
                    double _price;
                    double _cost;
                    //String transno;
                    int _qty;
                    con.Open();
                    cm = new SqlCommand("select * from table_products where barcode like '" + tft_searchbcode.Text + "'", con);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        qty = int.Parse(dr["quantity"].ToString());
                        _pcode = dr["pcode"].ToString();
                        _cost = double.Parse(dr["cost"].ToString());
                        _price = double.Parse(dr["price"].ToString());
                        _qty = int.Parse(tft_qty.Text);

                        dr.Close();
                        con.Close();
                        AddtoCart(_pcode, _price, _qty, _cost);
                    }
                    else
                    {
                        dr.Close();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AddtoCart(String _pcode, double _price, int _qty, double _cost)
        {
            String id = "";
            bool found = false;
            int cart_qty = 0;
            con.Open();
            cm = new SqlCommand("select * from table_cart where transno = @transno and pcode = @pcode", con);
            cm.Parameters.AddWithValue("@transno", lbl_trcode.Text);
            cm.Parameters.AddWithValue("@pcode", _pcode);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                found = true;
                id = dr["id"].ToString();
                cart_qty = int.Parse(dr["qty"].ToString());
            }
            else
            {
                found = false;
            }
            dr.Close();
            con.Close();

            if (found == true)
            {
                if (qty < (int.Parse(tft_qty.Text) + cart_qty))
                {
                    MessageBox.Show("Unable to Proceed. Remaining quantity in stock is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                con.Open();
                cm = new SqlCommand("update table_cart set qty = (qty +" + _qty + ") where id = '" + id + "'", con);
                cm.ExecuteNonQuery();
                con.Close();

                tft_searchbcode.SelectionStart = 0;
                tft_searchbcode.SelectionLength = tft_searchbcode.Text.Length;
                loadcart();
                //this.Dispose();

            }
            else
            {
                if (qty < (int.Parse(tft_qty.Text)))
                {
                    MessageBox.Show("Unable to Proceed. Remaining quantity in stock is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                con.Open();
                cm = new SqlCommand("insert into table_cart (transno, pcode,cost, price, qty, sdate, cashier,cid,balance)values(@transno, @pcode,@cost, @price, @qty, @sdate, @cashier,@cid,@balance)", con);
                cm.Parameters.AddWithValue("@transno", lbl_trcode.Text);
                cm.Parameters.AddWithValue("@pcode", _pcode);
                cm.Parameters.AddWithValue("@cost", _cost);
                cm.Parameters.AddWithValue("@price", _price);
                cm.Parameters.AddWithValue("@qty", _qty);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cashier", lbl_username.Text);
                cm.Parameters.AddWithValue("@cid", "Default");
                cm.Parameters.AddWithValue("@balance", 0.00);
                cm.ExecuteNonQuery();
                con.Close();

                tft_searchbcode.SelectionStart = 0;
                tft_searchbcode.SelectionLength = tft_searchbcode.Text.Length;
                loadcart();
                //this.Dispose();
            }
        }



        public void loadcart()
        {
            try
            {
                Boolean hasrecord = false;
                dataGridView1.Rows.Clear();
                double total = 0;
                int i = 0;
                double discount = 0;
                con.Open();
                cm = new SqlCommand("select c.id, c.pcode,p.pdesc,c.cost, c.price,c.qty,c.disc,c.total from table_cart as c inner join table_products as p on c.pcode = p.pcode where transno like'" + lbl_trcode.Text + "' and status like 'Pending'", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += Double.Parse(dr["total"].ToString());
                    discount += Double.Parse(dr["disc"].ToString());
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"), dr["cost"].ToString());
                    hasrecord = true;
                }
                dr.Close();
                con.Close();
                lbl_salestotal.Text = total.ToString("#,##0.00");
                lbl_discount.Text = discount.ToString("#,##0.00");
                getcarttotal();
                if (hasrecord == true)
                {
                    btn_settlepayment.Enabled = true;
                    btn_discount.Enabled = true;
                    btn_cancelsales.Enabled = true;
                }
                else
                {
                    btn_settlepayment.Enabled = false;
                    btn_discount.Enabled = false;
                    btn_cancelsales.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_searchproduct_Click(object sender, EventArgs e)
        {
            if (lbl_trcode.Text == "000000000000")
            {
                return;
            }
            Form_lookup frm = new Form_lookup(this);
            frm.loadrecords();
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "DELETE")
                {
                    if (MessageBox.Show("Remove this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("delete from table_cart where id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Item has been Successfully removed", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadcart();
                    }
                }
                else if (colname == "col_add")
                {
                    int i = 0;
                    con.Open();
                    cm = new SqlCommand("select sum(quantity) as quantity from table_products where pcode like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'group by pcode", con);
                    i = int.Parse(cm.ExecuteScalar().ToString());
                    con.Close();

                    if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                    {
                        con.Open();
                        cm = new SqlCommand("update table_cart set qty = qty + " + int.Parse(tft_qty.Text) + "where transno like '" + lbl_trcode.Text + "' and pcode like'" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();

                        loadcart();
                    }
                    else
                    {
                        MessageBox.Show("Remaining Quantity in Stock is " + i + " ! ", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (colname == "col_remove")
                {
                    int i = 0;
                    con.Open();
                    cm = new SqlCommand("select sum(qty) as qty from table_cart where pcode like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'and transno like'" + lbl_trcode.Text + "'group by transno, pcode", con);
                    i = int.Parse(cm.ExecuteScalar().ToString());
                    con.Close();

                    if (i > 1)
                    {
                        con.Open();
                        cm = new SqlCommand("update table_cart set qty = qty - " + int.Parse(tft_qty.Text) + "where transno like '" + lbl_trcode.Text + "' and pcode like'" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();

                        loadcart();
                    }
                    else
                    {
                        MessageBox.Show("Remaining Quantity On Cart is " + i + " ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
            }

        }
        public void notifycriticalitems()
        {
            string critical = "";
            con.Open();
            cm = new SqlCommand("select count(*) from View_criticalStockitems", con);
            String count = cm.ExecuteScalar().ToString();
            con.Close();

            int i = 0;
            con.Open();
            cm = new SqlCommand("select * from View_criticalStockitems", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                critical += i + ". " + dr["pname"].ToString() + Environment.NewLine;
            }
            dr.Close();
            con.Close();

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.cross_red1;
            popup.TitleText = "Critical Item(s)";
            popup.ContentText = critical;
            popup.Popup();
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            double p;
            Form_discount myform = new Form_discount(this);
            myform.lbl_id.Text = id;
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1[1, i].Value.ToString();
            p = double.Parse(dataGridView1[4, i].Value.ToString());
            qty = int.Parse(dataGridView1[5,i].Value.ToString());
            myform.tft_price.Text = (p*qty).ToString();
            myform.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1[1, i].Value.ToString();
            price = dataGridView1[7, i].Value.ToString();
        }

        private void lbl_vat_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbl_sysdate.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_settlepayment_Click(object sender, EventArgs e)
        {
            Form_settlepayment form = new Form_settlepayment(this);
            form.tft_sale.Text = lbl_displaytotal.Text;
            form.ShowDialog();
        }

        private void btn_dailysales_Click(object sender, EventArgs e)
        {
            Form_Solditems form = new Form_Solditems();
            form.dt1.Enabled = false;
            form.dt2.Enabled = false;
            form.cb_cashiers.Enabled = false;
            form.picbox_cancel.Visible = true;
            form.cb_cashiers.Text = lbl_username.Text;
            form.suser = lbl_username.Text;
            form.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout. Please Cancel/Complete the Transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Logout Application?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form_login form = new Form_login();
                form.ShowDialog();
            }
        }

        private void Form_POS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btn_new_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btn_searchproduct_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btn_discount_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                btn_settlepayment_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btn_cancelsales_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                btn_dailysales_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F7)
            {
                btn_changepass_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8)
            {
                tft_searchbcode.SelectionStart = 0;
                tft_searchbcode.SelectionLength = tft_searchbcode.Text.Length;
            }
            else if (e.KeyCode == Keys.F10)
            {
                btn_close_Click(sender, e);
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F4)
            {
                btn_close_Click(sender, e);
            }
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            Form_changepass form = new Form_changepass(this);
            form.ShowDialog();
        }

        private void btn_cancelsales_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove All items from Cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                cm = new SqlCommand("delete from table_cart where transno like '" + lbl_trcode.Text + "'", con);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("All items have been successfully removed!", "Remove Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadcart();
            }
        }
    }
}
