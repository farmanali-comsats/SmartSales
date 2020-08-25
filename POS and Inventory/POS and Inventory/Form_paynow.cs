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
    public partial class Form_paynow : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        public Form_paynow()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
        }
        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_1.Text;
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_2.Text;
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_3.Text;
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_4.Text;
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_5.Text;
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_6.Text;
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_7.Text;
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_8.Text;
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_9.Text;
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_0.Text;
        }
        private void btn_00_Click(object sender, EventArgs e)
        {
            tft_cash.Text += btn_00.Text;
        }
        private void btn_c_Click(object sender, EventArgs e)
        {
            tft_cash.Clear();
            tft_cash.Focus();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            tft_balance.Clear();
            tft_cash.Clear();
            tft_cid.Clear();
            tft_cname.Clear();
            tft_date.Clear();
            tft_total.Clear();
            tft_trcode.Clear();
            //tft_cash.Focus();
            this.Dispose();
        }
        private void Form_paynow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void tft_cash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = double.Parse(tft_total.Text);
                double cash = double.Parse(tft_cash.Text);
                double change = cash - double.Parse(tft_balance.Text);
                tft_change.Text = change.ToString("#,##0.00");

            }
            catch (Exception ex)
            {
                tft_change.Text = "0.00";
            }
        }

        private void btn_paynow_Click(object sender, EventArgs e)
        {
            paybalance();
        }
        public void paybalance()
        {
            try
            {
                double bal = double.Parse(tft_balance.Text) - double.Parse(tft_cash.Text);
                if (bal<0)
                {
                    bal = 0.00;
                }
                con.Open();
                cm = new SqlCommand("select count(*) from table_cart where transno like'"+tft_trcode.Text+"'", con);
                String count = cm.ExecuteScalar().ToString();
                int icount = int.Parse(count);
                con.Close();
                con.Open();
                cm = new SqlCommand("select payed from table_customerpurchases where transno like'" + tft_trcode.Text + "'", con);
                double totalpayed = double.Parse(cm.ExecuteScalar().ToString());
                totalpayed = (double.Parse(tft_cash.Text) + totalpayed);
                con.Close();
                if (tft_cash.Text != string.Empty)
                {
                    for (int i = 0; i < icount; i++)
                    {                       
                        con.Open();
                        cm = new SqlCommand("update table_cart set total = (price*qty), balance = 0,totalpayed ='" + totalpayed + "' where transno like'" + tft_trcode.Text + "'", con);
                        //cm.Parameters.AddWithValue("@total", tft_cid.Text);
                        //cm.Parameters.AddWithValue("@balance", bal);
                        cm.ExecuteNonQuery();
                        con.Close();
                    }
                    con.Open();
                    cm = new SqlCommand("update table_customerpurchases set payed=@payed,total=@total,paymentdate=@paymentdate where cid like @cid and transno like @transno", con);
                    cm.Parameters.AddWithValue("@cid", tft_cid.Text);
                    cm.Parameters.AddWithValue("@transno", tft_trcode.Text);
                    //cm.Parameters.AddWithValue("@balance", bal);
                    cm.Parameters.AddWithValue("@payed", totalpayed);
                    cm.Parameters.AddWithValue("@total", tft_total.Text);
                    //cm.Parameters.AddWithValue("@change", tft_change.Text);
                    cm.Parameters.AddWithValue("@paymentdate", DateTime.Now);
                    cm.ExecuteNonQuery();
                    con.Close();

                    double totalbalance = db.customertotalbalance(tft_cid.Text);
                    con.Open();
                    cm = new SqlCommand("update table_customerpurchases set tbalance = '" + totalbalance + "' where cid = '" + tft_cid.Text + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Payment Successfully Saved!", "payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Please Enter Correct Amount","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
