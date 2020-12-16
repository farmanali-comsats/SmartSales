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
    public partial class Form_settlepayment : Form
    {
        Form_POS f;
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        String stitle = "POS System";
        public Form_settlepayment(Form_POS frm)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            f = frm;
            this.KeyPreview = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tft_cash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = double.Parse(tft_sale.Text);
                double cash = double.Parse(tft_cash.Text);
                double change = cash - sale;
                tft_change.Text = change.ToString("#,##0.00");

            }
            catch (Exception ex)
            {
                tft_change.Text = "0.00";
            }
        }



        private void btn_enter_Click(object sender, EventArgs e)
        {
            double balance = 0.00;
            double totalpayed = 0.00;
            double _total = double.Parse(tft_sale.Text);
            try
            {
                if (double.Parse(tft_change.Text) < 0)
                {
                    tft_change.Text = "0.00";
                }
                totalpayed = double.Parse(tft_cash.Text);
                if (tft_customer.Text == "Default")
                {
                    if (((double.Parse(tft_change.Text)) < 0) || (double.Parse(tft_cash.Text) <= 0)||(totalpayed<_total))
                    {
                        MessageBox.Show("Insufficient Amount. Please enter the correct Amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < f.dataGridView1.Rows.Count; i++)
                        {
                            con.Open();
                            cm = new SqlCommand("update table_products set quantity = quantity - " + int.Parse(f.dataGridView1.Rows[i].Cells[5].Value.ToString()) + " where pcode = '" + f.dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();

                            con.Open();
                            cm = new SqlCommand("update table_cart set status = 'Sold',totalpayed='" + totalpayed + "' where id = '" + f.dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();
                        }
                        con.Open();
                        cm = new SqlCommand("insert into table_customerpurchases (cid,transno,payed,total,tbalance,sdate,paymentdate)values(@cid,@transno,@payed,@total,@tbalance,@sdate,@paymentdate)", con);
                        cm.Parameters.AddWithValue("@cid", tft_customer.Text);
                        cm.Parameters.AddWithValue("@transno", f.lbl_trcode.Text);
                        //cm.Parameters.AddWithValue("@balance", balance);
                        cm.Parameters.AddWithValue("@payed", double.Parse(tft_cash.Text));
                        cm.Parameters.AddWithValue("@total", double.Parse(tft_sale.Text));
                        cm.Parameters.AddWithValue("@tbalance", 0.00);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.Parameters.AddWithValue("@paymentdate", DateTime.Now);
                        cm.ExecuteNonQuery();
                        con.Close();
                        Form_receipt form = new Form_receipt(f);
                        double cashto = double.Parse(tft_cash.Text);
                        string cashtos = cashto.ToString("#,##0.00");
                        double changeto = double.Parse(tft_change.Text);
                        string changetos = changeto.ToString("#,##0.00");

                        double balanceto = (_total - cashto) + changeto;
                        string balancetos = balanceto.ToString("#,##0.00");

                        form.loadreport(cashtos, changetos, tft_customer.Text,balancetos);
                        form.ShowDialog();

                        MessageBox.Show("Payment Successfull!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        f.gettransno();
                        
                        f.loadcart();
                        this.Dispose();
                    }
                }
                else if (tft_customer.Text != "Default")
                {
                    if (((double.Parse(tft_change.Text)) < 0) || (double.Parse(tft_cash.Text) <= 0) || (totalpayed < _total))
                    {
                        MessageBox.Show("Insufficient Amount. Please enter the correct Amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < f.dataGridView1.Rows.Count; i++)
                        {
                            con.Open();
                            cm = new SqlCommand("update table_products set quantity = quantity - " + int.Parse(f.dataGridView1.Rows[i].Cells[5].Value.ToString()) + " where pcode = '" + f.dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();

                            con.Open();
                            cm = new SqlCommand("update table_cart set status = 'Sold', balance = '" + balance + "', cid ='" + lbl_cid.Text + "',totalpayed ='" + totalpayed + "' where id = '" + f.dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();
                        }

                        con.Open();
                        cm = new SqlCommand("insert into table_customerpurchases (cid,transno,payed,total,sdate,paymentdate)values(@cid,@transno,@payed,@total,@sdate,@paymentdate)", con);
                        cm.Parameters.AddWithValue("@cid", lbl_cid.Text);
                        cm.Parameters.AddWithValue("@transno", f.lbl_trcode.Text);
                        //cm.Parameters.AddWithValue("@balance", balance);
                        cm.Parameters.AddWithValue("@payed", double.Parse(tft_cash.Text));
                        cm.Parameters.AddWithValue("@total", double.Parse(tft_sale.Text));
                        //cm.Parameters.AddWithValue("@change", double.Parse(tft_change.Text));
                        //cm.Parameters.AddWithValue("@tbalance", totalbalance);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.Parameters.AddWithValue("@paymentdate", DateTime.Now);
                        cm.ExecuteNonQuery();
                        con.Close();
                    }


                    double totalbalance = db.customertotalbalance(lbl_cid.Text);
                    con.Open();
                    cm = new SqlCommand("update table_customerpurchases set tbalance = '" + totalbalance + "' where cid = '" + lbl_cid.Text + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();

                    Form_receipt form = new Form_receipt(f);
                    double cashto = double.Parse(tft_cash.Text);
                    string cashtos = cashto.ToString("#,##0.00");
                    double changeto = double.Parse(tft_change.Text);
                    string changetos = changeto.ToString("#,##0.00");

                    double balanceto = (_total - cashto) + changeto;
                    string balancetos = balanceto.ToString("#,##0.00");

                    form.loadreport(cashtos, changetos,tft_customer.Text,balancetos);
                    form.ShowDialog();

                    MessageBox.Show("Payment Successfull!", "payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.gettransno();
                    f.loadcart();
                    this.Dispose();
                    return;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Insufficient Amount. Please enter the correct Amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        private void Form_settlepayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_enter_Click(sender, e);
            }
        }
        private void checkbox_customer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_customer.Checked == true)
            {
                Form_customerlist form = new Form_customerlist(this);
                form.ShowDialog();
                form.pictureBox_cancel.Visible = true;
                btn_paylater.Enabled = true;
            }
            else
            {
                lbl_cid.Text = "Default";
                tft_customer.Enabled = false;
            }
        }

        private void Form_settlepayment_Load(object sender, EventArgs e)
        {
            //btn_paylater.
        }

        private void btn_paylater_Click(object sender, EventArgs e)
        {

            double _payed = 0.00;
            double _total = 0.00;
            double balance = 0.00;
            double totalpayed = 0.00;
            try
            {
                if (MessageBox.Show("Confirm to Pay Later!", "Pay Later", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tft_customer.Text != "Default")
                    {
                        _payed = double.Parse(tft_cash.Text);
                        _total = double.Parse(tft_sale.Text);

                        totalpayed = double.Parse(tft_cash.Text);

                        if (tft_cash.Text == string.Empty)
                        {
                            _payed = 0.00;
                            totalpayed = 0.00;
                        }
                        balance = _total - _payed;
                        if (double.Parse(tft_change.Text)<0)
                        {
                            tft_change.Text = "0.00";
                        }
                        for (int i = 0; i < f.dataGridView1.Rows.Count; i++)
                        {
                            con.Open();
                            cm = new SqlCommand("update table_products set quantity = quantity - " + int.Parse(f.dataGridView1.Rows[i].Cells[5].Value.ToString()) + " where pcode = '" + f.dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();

                            double bal = (double.Parse(f.dataGridView1.Rows[i].Cells[7].Value.ToString()));

                            con.Open();
                            cm = new SqlCommand("update table_cart set status = 'Sold', balance = '" + bal + "', cid ='" + lbl_cid.Text + "' ,totalpayed ='" + totalpayed + "' where id = '" + f.dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();
                        }

                        

                        con.Open();
                        cm = new SqlCommand("insert into table_customerpurchases (cid,transno,payed,total,sdate)values(@cid,@transno,@payed,@total,@sdate)", con);
                        cm.Parameters.AddWithValue("@cid", lbl_cid.Text);
                        cm.Parameters.AddWithValue("@transno", f.lbl_trcode.Text);
                        //cm.Parameters.AddWithValue("@balance", balance);
                        cm.Parameters.AddWithValue("@payed", _payed);
                        cm.Parameters.AddWithValue("@total", _total);
                        //cm.Parameters.AddWithValue("@tbalance", totalbalance);
                        //cm.Parameters.AddWithValue("@change", 0.00);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        //cm.Parameters.AddWithValue("@paymentdate",null);
                        cm.ExecuteNonQuery();
                        con.Close();

                        double totalbalance = db.customertotalbalance(lbl_cid.Text);
                        con.Open();
                        cm = new SqlCommand("update table_customerpurchases set tbalance = '" + totalbalance + "' where cid = '" + lbl_cid.Text + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();

                        Form_receipt form = new Form_receipt(f);
                        double cashto =double.Parse(tft_cash.Text);
                        string cashtos = cashto.ToString("#,##0.00");
                        double changeto = double.Parse(tft_change.Text);
                        string changetos = changeto.ToString("#,##0.00");
                        
                        double balanceto = (_total-cashto)+changeto;
                        string balancetos = balanceto.ToString("#,##0.00");
                        
                        form.loadreport(cashtos,changetos, tft_customer.Text,balancetos);
                        form.ShowDialog();

                        MessageBox.Show("Payment Successfully Saved!", "payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        f.gettransno();
                        f.loadcart();
                        this.Dispose();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Insufficient Amount. Please enter the correct Amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void checkbox_customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void tft_cash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Form_customerlist form = new Form_customerlist(this);
                form.ShowDialog();
                form.pictureBox_cancel.Visible = true;
                btn_paylater.Enabled = true;
            }
        }
    }
}
