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
    public partial class Form_customerlist : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        Form_settlepayment f;
        public Form_customerlist(Form_settlepayment f)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.f = f;
            this.KeyPreview = true;
        }

        private void Form_customerlist_Load(object sender, EventArgs e)
        {
            loadcustomers();
        }
        public void loadcustomers()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            con.Open();
            cm = new SqlCommand("select * from table_customers where customername like '" + tft_search.Text + "%'", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["customerid"].ToString(), dr["customername"].ToString(), dr["address"].ToString(), dr["contact"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "select")
                {
                    f.lbl_cid.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                    f.tft_customer.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_customerlist_Activated(object sender, EventArgs e)
        {
            loadcustomers();
        }

        private void picbox_addcustomer_Click(object sender, EventArgs e)
        {
            Form_Customers f = new Form_Customers();
            f.WindowState = FormWindowState.Normal;
            f.pictureBox_cancel.Visible = true;
            f.ShowDialog();
        }

        private void Form_customerlist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void tft_search_TextChanged(object sender, EventArgs e)
        {
            loadcustomers();
        }
    }
}
