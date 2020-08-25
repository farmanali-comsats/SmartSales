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

namespace POS_and_Inventory
{
    public partial class Form_Solditems : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        private double profit = 0;
        private double ttoal = 0;
        //Form_POS form;
        public String suser;
        public Form_Solditems()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            dt1.Value = DateTime.Now;
            dt2.Value = DateTime.Now;
            //loadrecords();
            loadcashiers();
            this.KeyPreview = true;

        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadrecords()
        {
            int i = 0;
            ttoal = 0;

            dataGridView1.Rows.Clear();
            try
            {
                con.Open();
                if (cb_cashiers.Text == "All Cashier")
                {
                    cm = new SqlCommand("select c.id,c.transno,c.pcode,p.pname,p.pdesc,c.price,c.qty,c.disc,c.total from table_cart as c inner join table_products as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dt1.Value.ToString("yyyy-MM-dd") + "' and '" + dt2.Value.ToString("yyyy-MM-dd") + "' and c.transno like '%" + tft_search.Text + "%'or p.pname like '%" + tft_search.Text + "%'order by c.transno", con);
                }
                else
                {
                    cm = new SqlCommand("select c.id,c.transno,c.pcode,p.pname,p.pdesc,c.price,c.qty,c.disc,c.total from table_cart as c inner join table_products as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dt1.Value.ToString("yyyy-MM-dd") + "' and '" + dt2.Value.ToString("yyyy-MM-dd") + "' and cashier like '" + cb_cashiers.Text + "'and c.transno like '%" + tft_search.Text + "%'or p.pname like '%" + tft_search.Text + "%'order by c.transno", con);
                }
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    ttoal += double.Parse(dr["total"].ToString());
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pname"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());

                }
                dr.Close();
                con.Close();
                lbl_total.Text = ttoal.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            loadrecords();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            loadrecords();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            Form_reportsold form = new Form_reportsold(this);
            form.loadsoldreport();
            form.ShowDialog();
        }

        private void cb_cashiers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void loadcashiers()
        {
            try
            {
                cb_cashiers.Items.Clear();
                cb_cashiers.Items.Add("All Cashier");
                con.Open();
                cm = new SqlCommand("select * from table_users where role like 'Cashier'", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cb_cashiers.Items.Add(dr["username"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_cashiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadrecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "col_cancel")
                {
                    Form_CancelDetails frm = new Form_CancelDetails(this);
                    frm.tft_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    frm.tft_transno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    frm.tft_pcode.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    frm.tft_desc.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    frm.tft_price.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    frm.tft_qty.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    frm.tft_discount.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    frm.tft_total.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    frm.tft_cby.Text = suser;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Solditems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (picbox_cancel.Visible == true)
                {

                    this.Dispose();
                }
            }
            else
            {
                return;
            }
        }

        private void btn_profit_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_profit.Text) != 0)
            {
                lbl_profit.Text = "0.00";
            }
            else
            {
                Profitcalculate();
            }
        }
        public void Profitcalculate()
        {
            profit = 0;
            //String sdate = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                con.Open();
                cm = new SqlCommand("select isnull(sum(costtotal),0) as costtotal from table_cart where sdate between '" + dt1.Value.ToString("yyyy-MM-dd") + "' and '" + dt2.Value.ToString("yyyy-MM-dd") + "'and status like 'Sold'", con);
                profit = double.Parse(cm.ExecuteScalar().ToString());
                profit = ttoal - profit;
                con.Close();

                lbl_profit.Text = profit.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tft_search_TextChanged(object sender, EventArgs e)
        {
            loadrecords();
        }
    }
}
