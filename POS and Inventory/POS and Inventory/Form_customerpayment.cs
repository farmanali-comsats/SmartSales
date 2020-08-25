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
    public partial class Form_customerpayment : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        public string transactionno;
        public Form_customerpayment()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_customerpayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_paynow_Click(sender, e);
            }
            //if (e.Modifiers == Keys.RShiftKey && e.KeyCode == Keys.Enter)
            //{
            //    btn_paylater_Click(sender, e);
            //}
        }

        private void btn_paynow_Click(object sender, EventArgs e)
        {
            customerpayment();
        }
        public void customerpayment()
        {
            try
            {
                double pbalance = 0;
                double credit = 0;
                double debit = 0;
                double total = 0.00;

                Form_customerpurchases f = new Form_customerpurchases();
                if (lblcheck.Text == "credit")
                {
                    pbalance = double.Parse(tft_balance.Text);
                    credit = double.Parse(tft_cash.Text);
                    debit = double.Parse(tft_debit.Text);
                    debit = pbalance - credit;
                }
                else
                {
                    pbalance = double.Parse(tft_cash.Text);
                    credit = double.Parse(tft_debit.Text);
                    transactionno = tft_balance.Text;
                    debit = pbalance - credit;
                    total = pbalance;
                }


                if (tft_cash.Text != string.Empty && tft_balance.Text != string.Empty && tft_debit.Text != string.Empty && (credit > 0 || total > 0))
                {
                    if (credit > pbalance)
                    {
                        MessageBox.Show("Credit should not be greater than " + pbalance, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Confirm to Save this Record!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.Open();
                            if (lblcheck.Text == "credit" || debit == 0)
                            {
                                cm = new SqlCommand("insert into table_customerpurchases (cid,transno,payed,total,sdate,paymentdate)values(@cid,@transno,@payed,@total,@sdate,@paymentdate)", con);
                                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                                cm.Parameters.AddWithValue("@paymentdate", DateTime.Now);
                            }
                            else
                            {
                                cm = new SqlCommand("insert into table_customerpurchases (cid,transno,payed,total,sdate)values(@cid,@transno,@payed,@total,@sdate)", con);
                                cm.Parameters.AddWithValue("@sdate", dtp.Value);
                            }
                            cm.Parameters.AddWithValue("@cid", lbl_cid.Text);
                            cm.Parameters.AddWithValue("@transno", transactionno);
                            //cm.Parameters.AddWithValue("@balance", balance);
                            cm.Parameters.AddWithValue("@payed", credit);

                            cm.Parameters.AddWithValue("@total", total);
                            //cm.Parameters.AddWithValue("@change", double.Parse(tft_change.Text));


                            cm.ExecuteNonQuery();
                            con.Close();

                            double totalbalance = db.customertotalbalance(lbl_cid.Text);
                            con.Open();
                            cm = new SqlCommand("update table_customerpurchases set tbalance = '" + totalbalance + "' where cid = '" + lbl_cid.Text + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Saved Successfully !", "Customer Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            f.loadcpurchases();
                            this.Dispose();

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void tft_cash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblcheck.Text == "credit")
                {
                    double pbalance = double.Parse(tft_balance.Text);
                    double cash = double.Parse(tft_cash.Text);
                    double debit = pbalance - cash;
                    tft_debit.Text = debit.ToString("#,##0.00");
                }
            }
            catch (Exception ex)
            {
                tft_debit.Text = "0.00";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void customerdebit()
        {
            try
            {
                Form_customerpurchases f = new Form_customerpurchases();
                double pbalance = double.Parse(tft_balance.Text);
                double credit = double.Parse(tft_cash.Text);
                double debit = double.Parse(tft_debit.Text);
                debit = pbalance - credit;

                if (tft_cash.Text != string.Empty)
                {
                    if (credit > pbalance)
                    {
                        MessageBox.Show("Credit should not be greater than " + pbalance, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Confirm to Save this Record!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.Open();
                            cm = new SqlCommand("insert into table_customerpurchases (cid,transno,payed,total,sdate,paymentdate)values(@cid,@transno,@payed,@total,@sdate,@paymentdate)", con);
                            cm.Parameters.AddWithValue("@cid", lbl_cid.Text);
                            cm.Parameters.AddWithValue("@transno", transactionno);
                            //cm.Parameters.AddWithValue("@balance", balance);
                            cm.Parameters.AddWithValue("@payed", double.Parse(tft_cash.Text));
                            cm.Parameters.AddWithValue("@total", tft_balance.Text);
                            //cm.Parameters.AddWithValue("@change", double.Parse(tft_change.Text));
                            cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                            cm.Parameters.AddWithValue("@paymentdate", DateTime.Now);
                            cm.ExecuteNonQuery();
                            con.Close();

                            double totalbalance = db.customertotalbalance(lbl_cid.Text);
                            con.Open();
                            cm = new SqlCommand("update table_customerpurchases set tbalance = '" + totalbalance + "' where cid = '" + lbl_cid.Text + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Saved Successfully !", "Customer Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            f.loadcpurchases();
                            this.Dispose();

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
