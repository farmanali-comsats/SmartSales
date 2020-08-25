using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_and_Inventory
{
    public partial class Form_vendortotal : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_vendorspurchases f;
        public Form_vendortotal(Form_vendorspurchases f)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.f = f;
            this.KeyPreview = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
            this.Dispose();
        }

        private void btn_paynow_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                vendorpaymentupdate();
            }
            else
            {
                vendortotal();
            }

        }

        public void vendortotal()
        {
            try
            {
                double total = double.Parse(tft_total.Text);
                double credit = double.Parse(tft_credit.Text);
                double debit = double.Parse(tft_debit.Text);
                debit = total - credit;

                if (tft_cbill.Text != string.Empty && tft_credit.Text != string.Empty && tft_debit.Text != string.Empty && tft_total.Text != string.Empty && total >= 0 && credit >= 0)
                {
                    if (credit > total)
                    {
                        MessageBox.Show("Credit should not be greater than Total", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        if (debit == 0.00)
                        {

                            if (MessageBox.Show("Confirm to Save this Record!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                con.Open();
                                cm = new SqlCommand("insert into table_vendorpurchases(vid,cbill,vcredit,vdebit,vtotal,pdate,newdate)values(@vid,@cbill,@vcredit,@vdebit,@vtotal,@pdate,@newdate)", con);
                                cm.Parameters.AddWithValue("@vid", tft_vid.Text);
                                cm.Parameters.AddWithValue("@cbill", tft_cbill.Text);
                                cm.Parameters.AddWithValue("@vcredit", tft_credit.Text);
                                cm.Parameters.AddWithValue("@vdebit", tft_debit.Text);
                                cm.Parameters.AddWithValue("@vtotal", tft_total.Text);
                                cm.Parameters.AddWithValue("@pdate", DateTime.Now);
                                cm.Parameters.AddWithValue("@newdate", DateTime.Now);
                                cm.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Confirm to Schedule Payment!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                con.Open();
                                cm = new SqlCommand("insert into table_vendorpurchases(vid,cbill,vcredit,vdebit,vtotal,pdate)values(@vid,@cbill,@vcredit,@vdebit,@vtotal,@pdate)", con);
                                cm.Parameters.AddWithValue("@vid", tft_vid.Text);
                                cm.Parameters.AddWithValue("@cbill", tft_cbill.Text);
                                cm.Parameters.AddWithValue("@vcredit", credit);
                                cm.Parameters.AddWithValue("@vdebit", debit);
                                cm.Parameters.AddWithValue("@vtotal", total);
                                cm.Parameters.AddWithValue("@pdate", DateTime.Now);
                                //cm.Parameters.AddWithValue("@newdate", null);
                                cm.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        double totalbalance = db.vendortotalbalance(tft_vid.Text);

                        con.Open();
                        cm = new SqlCommand("update table_vendorpurchases set tbalance = '" + totalbalance + "' where vid like '" + tft_vid.Text + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Record has been Successfully Saved", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        f.loadvendorpurchases();
                        this.Dispose();

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Mandatory Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            tft_cbill.Clear();
            tft_credit.Clear();
            tft_debit.Clear();
            tft_total.Clear();
            tft_vid.Clear();
        }

        private void tft_credit_TextChanged(object sender, EventArgs e)
        {


            try
            {
                double total = double.Parse(tft_total.Text);
                double credit = double.Parse(tft_credit.Text);
                double debit = double.Parse(tft_debit.Text);
                debit = total - credit;

                tft_debit.Text = debit.ToString("#,##0.00");

            }
            catch (Exception ex)
            {
                tft_debit.Text = "0.00";
            }
        }

        public void vendorpaymentupdate()
        {
            try
            {
                double total = double.Parse(tft_total.Text);
                double credit = double.Parse(tft_credit.Text);
                double debit = double.Parse(tft_debit.Text);
                debit = total - credit;


                if (tft_credit.Text != string.Empty && credit > 0)
                {
                    if (credit > total)
                    {
                        MessageBox.Show("Maximum Debit Amount is Rs." + tft_total.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Confirm to Save this Record!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.Open();
                            if (debit==0)
                            {
                                cm = new SqlCommand("insert into table_vendorpurchases(vid,cbill,vcredit,vdebit,vtotal,pdate,newdate)values(@vid,@cbill,@vcredit,@vdebit,@vtotal,@pdate,@newdate)", con);
                                cm.Parameters.AddWithValue("@newdate", DateTime.Now);
                            }
                            else
                            {
                                cm = new SqlCommand("insert into table_vendorpurchases(vid,cbill,vcredit,vdebit,vtotal,pdate)values(@vid,@cbill,@vcredit,@vdebit,@vtotal,@pdate)", con);
                           }
                             cm.Parameters.AddWithValue("@vid", tft_vid.Text);
                            cm.Parameters.AddWithValue("@cbill", tft_cbill.Text);
                            cm.Parameters.AddWithValue("@vcredit", credit);
                            cm.Parameters.AddWithValue("@vdebit", 0.00);
                            cm.Parameters.AddWithValue("@vtotal", 0.00);
                            cm.Parameters.AddWithValue("@pdate", DateTime.Now);                            
                                                        
                            cm.ExecuteNonQuery();
                            con.Close();

                            double tbalance = db.vendortotalbalance(tft_vid.Text);
                            con.Open();
                            cm = new SqlCommand("update table_vendorpurchases set tbalance = '" + tbalance + "' where vid like'" + tft_vid.Text + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();


                            MessageBox.Show("Record has been Successfully Updated!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                            f.loadvendorpurchases();
                            this.Dispose();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the required Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_vendortotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (btn_paynow.Visible == true) btn_paynow_Click(sender, e);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                double tbalance = db.vendortotalbalance(tft_vid.Text);
                tft_total.Text = tbalance.ToString();
                tft_cbill.Text = "Payment";
                lbltotal.Text = "Previous Balance";
                lblbal.Text = "New Balance";
                tft_credit.Focus();
                tft_cbill.Enabled = false;
                tft_total.Enabled = false;
            }
            else
            {
                tft_cbill.Text = "";
                tft_total.Text = "0.00";
                lbltotal.Text = "Bill Total";
                lblbal.Text = "Debit";
                tft_cbill.Focus();
                tft_cbill.Enabled = true;
                tft_total.Enabled = true;
            }
        }
    }
}
