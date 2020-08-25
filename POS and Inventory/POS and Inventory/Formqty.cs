using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_and_Inventory
{
    public partial class Formqty : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        private string pcode;
        private double price;
        private double cost;
        private String transno;
        int qty;
        Form_POS form;
        public Formqty(Form_POS fform)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            form = fform;
            this.KeyPreview = true;
        }
        public void productdetails(String pcode, double cost, double price, String transno, int qty)
        {
            this.pcode = pcode;
            this.cost = cost;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        private void Formqty_Load(object sender, EventArgs e)
        {

        }

        private void tft_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void tft_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (tft_qty.Text != String.Empty))
            {
                if ((tft_qty.Text == "0"))
                {
                    MessageBox.Show("Entered Quantity cannot be Zero (0)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String id = "";
                    int cart_qty = 0;
                    bool found = false;

                    con.Open();
                    cm = new SqlCommand("select * from table_cart where transno = @transno and pcode = @pcode", con);
                    cm.Parameters.AddWithValue("@transno", form.lbl_trcode.Text);
                    cm.Parameters.AddWithValue("@pcode", pcode);
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
                        cm = new SqlCommand("update table_cart set qty = (qty +" + int.Parse(tft_qty.Text) + ") where id = '" + id + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();

                        form.tft_searchbcode.Clear();
                        form.tft_searchbcode.Focus();
                        form.loadcart();
                        this.Dispose();

                    }
                    else
                    {
                        if (qty < (int.Parse(tft_qty.Text) + cart_qty))
                        {
                            MessageBox.Show("Unable to Proceed. Remaining quantity in stock is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        con.Open();
                        cm = new SqlCommand("insert into table_cart (transno, pcode,cost, price, qty, sdate, cashier,cid,balance,totalpayed)values(@transno, @pcode,@cost, @price, @qty, @sdate, @cashier,@cid,@balance,@totalpayed)", con);
                        cm.Parameters.AddWithValue("@transno", transno);
                        cm.Parameters.AddWithValue("@pcode", pcode);
                        cm.Parameters.AddWithValue("@cost", cost);
                        cm.Parameters.AddWithValue("@price", price);
                        cm.Parameters.AddWithValue("@qty", int.Parse(tft_qty.Text));
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.Parameters.AddWithValue("@cashier", form.lbl_username.Text);
                        cm.Parameters.AddWithValue("@cid", "Default");
                        cm.Parameters.AddWithValue("@balance", 0.00);
                        cm.Parameters.AddWithValue("@totalpayed", 0.00);
                        cm.ExecuteNonQuery();
                        con.Close();

                        form.tft_searchbcode.Clear();
                        form.tft_searchbcode.Focus();
                        form.loadcart();
                        this.Dispose();
                    }
                }

            }
        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            form.tft_searchbcode.Clear();
        }

        private void Formqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
