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
    public partial class Form_customerpurchases : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        private double total;

        public Form_customerpurchases()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_customerpurchases_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.N)
            {
                picbox_add_Click(sender, e);
            }
        }
        public void loadcpurchases()
        {
            try
            {
                int i = 0;
                dataGridView2.Rows.Clear();
                con.Open();
                cm = new SqlCommand("select c.id, c.cid,p.customername, c.transno, c.balance, c.payed, c.total,c.tbalance, c.change, c.sdate, c.paymentdate from table_customerpurchases as c Left join table_customers as p on p.customerid = c.cid where cid like '" + lbl_id.Text + "'", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    dataGridView2.Rows.Add(i, dr["cid"].ToString(), dr["customername"].ToString(), dr["transno"].ToString(), dr["total"].ToString(), dr["payed"].ToString(), dr["balance"].ToString(), dr["change"].ToString(), dr["tbalance"].ToString(), dr["sdate"].ToString(), dr["paymentdate"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ctotal()
        {
            int i = 0;
            total = 0;
            try
            {
                con.Open();

                cm = new SqlCommand("select total from table_customerpurchases where cid like '" + lbl_id.Text + "'", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    total += double.Parse(dr["total"].ToString());
                }
                con.Close();
                lbl_total.Text = total.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_customerpurchases_Load(object sender, EventArgs e)
        {
            ctotal();
            ctbalance();
            loadcpurchases();
        }

        private void ctbalance()
        {
            String tbal;
            con.Open();
            cm = new SqlCommand("select top 1 tbalance from table_customerpurchases where cid like '" + lbl_id.Text + "' order by id desc", con);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                tbal = dr[0].ToString();
                lbl_tbalance.Text = tbal;
            }
            dr.Close();
            con.Close();
        }

        private void picbox_add_Click(object sender, EventArgs e)
        {
            try
            {
                double pb = db.customertotalbalance(lbl_id.Text);
                if (dataGridView2.Rows.Count > 0 && pb > 0)
                {
                    Form_customerpayment f = new Form_customerpayment();
                    f.lblcheck.Text = "credit";
                    f.transactionno = "Payment";
                    f.lblptotal.Text = "Previous Balance";
                    f.lblpay.Text = "Current Payment";
                    f.lblnbalance.Text = "New Balance";
                    f.tft_balance.TextAlign = HorizontalAlignment.Right;
                    f.lbl_cid.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                    f.tft_balance.Text = dataGridView2.Rows[0].Cells[8].Value.ToString();
                    f.tft_cname.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
                    f.ShowDialog();
                    loadcpurchases();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picbox_debit_Click(object sender, EventArgs e)
        {
            try
            {
                Form_customerpayment f = new Form_customerpayment();
                //f.transactionno = "Debit";
                f.dtp.Visible = true;
                f.lblcheck.Text = "Debit";
                f.lblptotal.Text = "Old Bill #";
                f.lblpay.Text = "Total";
                f.lblnbalance.Text = "Payed";
                f.tft_balance.Enabled = true;
                f.tft_balance.Text = "Debit";
                f.tft_balance.TextAlign = HorizontalAlignment.Left;
                f.tft_debit.Enabled = true;
                f.tft_balance.Focus();
                f.lbl_cid.Text = lbl_id.Text;
                f.tft_cname.Text = lblname.Text;
                f.ShowDialog();
                loadcpurchases();
            }
            catch (Exception ex)
            {

            }
        }

        private void Form_customerpurchases_Activated(object sender, EventArgs e)
        {
            Form_customerpurchases_Load(sender, e);
        }
    }
}
