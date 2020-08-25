using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace POS_and_Inventory
{
    public partial class Form_Customers : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        public Form_Customers()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (metroTabControl1.SelectedTab == tabPage1)
            {
                loadcustomerid();
                panel5.Show();
                metroTabControl1.Dock = DockStyle.None;
            }
            else if (metroTabControl1.SelectedTab == tabPage2)
            {
                panel5.Hide();
                metroTabControl1.Dock = DockStyle.Fill;
                loadcustomerpurchases();
            }
        }
        public void loadcustomerid()
        {
            String getcid = "", cidtoken = "", newcid = "";
            int icid = 0;
            con.Open();
            cm = new SqlCommand("SELECT TOP 1 * FROM table_customers ORDER BY customerid desc", con);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                getcid = dr[0].ToString();
                string[] words = getcid.Split('C');
                foreach (string word in words)
                {
                    cidtoken = word;
                }
                icid = (int.Parse(cidtoken)) + 1;
                newcid = "C" + icid.ToString();
                tft_cid.Text = newcid;
            }
            else
            {
                tft_cid.Text = "C10001";
            }
            dr.Close();
            con.Close();

        }
        public void savecustomers()
        {
            try
            {
                if (tft_cname.Text != "" && tft_cmobile.Text != "" && tft_caddress.Text != "" && tft_cid.Text != "")
                {
                    con.Open();
                    cm = new SqlCommand("insert into table_customers (customerid,customername,address,contact) values(@customerid,@customername,@address,@contact)", con);
                    cm.Parameters.AddWithValue("@customerid", tft_cid.Text);
                    cm.Parameters.AddWithValue("@customername", tft_cname.Text);
                    cm.Parameters.AddWithValue("@address", tft_caddress.Text);
                    cm.Parameters.AddWithValue("@contact", tft_cmobile.Text);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been Successfully Added!");
                    clear();

                }
                else
                {
                    MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void loadcustomers()
        {
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                con.Open();
                cm = new SqlCommand("select * from table_customers order by customerid", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    dataGridView1.Rows.Add(i, dr["customerid"].ToString(), dr["customername"].ToString(), dr["address"].ToString(), dr["contact"].ToString());
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

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            loadcustomerid();
            loadcustomers();
            metroTabControl1.SelectedTab = tabPage1;

        }
        public void clear()
        {
            tft_cid.Clear();
            tft_cname.Clear();
            tft_caddress.Clear();
            tft_cmobile.Clear();
            tft_cname.Focus();
            loadcustomerid();
            loadcustomers();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            savecustomers();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "EDIT")
                {
                    tft_cid.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                    tft_cname.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                    tft_caddress.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                    tft_cmobile.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                    btn_save.Enabled = false;
                    btn_update.Enabled = true;
                    tft_cname.Focus();

                }
                else if (colname == "Column_name")
                {
                    Form_customerpurchases f = new Form_customerpurchases();
                    f.lbl_id.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                    f.lblname.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                    f.loadcpurchases();
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("UPDATE table_customers SET customername=@customername, address=@address, contact=@contact where customerid like @customerid", con);
                    cm.Parameters.AddWithValue("@customerid", tft_cid.Text);
                    cm.Parameters.AddWithValue("@customername", tft_cname.Text);
                    cm.Parameters.AddWithValue("@address", tft_caddress.Text);
                    cm.Parameters.AddWithValue("@contact", tft_cmobile.Text);
                    cm.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record has been updated Successfully");
                    clear();
                    loadcustomers();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadcustomerpurchases()
        {
            try
            {
                int i = 0;
                dataGridView2.Rows.Clear();
                con.Open();
                cm = new SqlCommand("select c.id, c.cid,p.customername, c.transno, c.balance, c.payed, c.total, c.change, c.sdate, c.paymentdate from table_customerpurchases as c Left join table_customers as p on p.customerid = c.cid order by sdate desc ", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    dataGridView2.Rows.Add(i, dr["cid"].ToString(), dr["customername"].ToString(), dr["transno"].ToString(), dr["balance"].ToString(), dr["payed"].ToString(), dr["total"].ToString(), dr["change"].ToString(), dr["sdate"].ToString(), dr["paymentdate"].ToString());
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colname = dataGridView2.Columns[e.ColumnIndex].Name;
                string cid = dataGridView2[1, e.RowIndex].Value.ToString();

                double totalbalance = db.customertotalbalance(cid);

                Form_paynow f = new Form_paynow();
                if (colname == "paynow")
                {
                    if (double.Parse(dataGridView2[4, e.RowIndex].Value.ToString()) > 0 && totalbalance > 0)
                    {
                        f.tft_cid.Text = dataGridView2[1, e.RowIndex].Value.ToString();
                        f.tft_cname.Text = dataGridView2[2, e.RowIndex].Value.ToString();
                        f.tft_date.Text = dataGridView2[8, e.RowIndex].Value.ToString();
                        f.tft_trcode.Text = dataGridView2[3, e.RowIndex].Value.ToString();
                        f.tft_total.Text = dataGridView2[6, e.RowIndex].Value.ToString();
                        f.tft_balance.Text = dataGridView2[4, e.RowIndex].Value.ToString();
                        //btn_save.Enabled = false;
                        //btn_update.Enabled = true;
                        f.tft_cash.Focus();
                        f.ShowDialog();
                        loadcustomerpurchases();
                    }


                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
