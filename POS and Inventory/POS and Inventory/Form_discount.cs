using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_and_Inventory
{
    public partial class Form_discount : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_POS myform;
        String stitle = "POS System";
        public Form_discount(Form_POS frm)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            myform = frm;
            this.KeyPreview = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tft_pdiscount_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if(tft_amount.Text == string.Empty)
                {
                    tft_amount.Text = "0";
                }
                string p = "p";
                discount(p);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_pdiscount.Text != string.Empty && (double.Parse(tft_pdiscount.Text) >= 0) && (double.Parse(tft_pdiscount.Text) <= 100))
                {
                    if (MessageBox.Show("Add Discount? Click Yes to Confirm", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        double disc = Double.Parse(tft_pdiscount.Text);
                        disc = disc / 100.00;

                        con.Open();
                        cm = new SqlCommand("update table_cart set disc_percent = @disc_percent where id = @id", con);
                        //cm.Parameters.AddWithValue("@disc", Double.Parse(tft_amount.Text));
                        cm.Parameters.AddWithValue("@disc_percent", disc);
                        cm.Parameters.AddWithValue("@id", int.Parse(lbl_id.Text));
                        cm.ExecuteNonQuery();
                        con.Close();
                        myform.loadcart();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Discount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btn_confirm_Click(sender, e);
            }
        }

        private void tft_amount_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                string p = "a";
                discount(p);
            }
        }
        private void discount(string p)
        {
            try
            {
                double price = double.Parse(tft_price.Text);
                double disc = Double.Parse(tft_amount.Text);
                if (p == "a")
                {
                    if (disc > price)
                    {
                        SystemSounds.Beep.Play();
                    }
                    disc = (disc / price) * 100;
                    tft_pdiscount.Text = disc.ToString("#,##0.00000");
                }
                else
                {
                    disc = Double.Parse(tft_pdiscount.Text);
                    disc = disc / 100;
                    double discount = price * disc;
                    tft_amount.Text = discount.ToString("#,##0.00");
                    if (discount > price)
                    {
                        SystemSounds.Beep.Play();
                    }                 
                }

            }
            catch (Exception ex)
            {
                tft_amount.Text = "";
                tft_pdiscount.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tft_amount.Enabled = false;
                tft_pdiscount.Enabled = true;
                tft_amount.Text = "0";
                tft_pdiscount.Text = "0";
            }
            else
            {
                tft_amount.Enabled = true;
                tft_pdiscount.Enabled = false;
                tft_amount.Text = "0";
                tft_pdiscount.Text = "0";
            }
        }
    }
}
