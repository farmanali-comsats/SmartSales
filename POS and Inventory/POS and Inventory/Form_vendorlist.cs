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
    public partial class Form_vendorlist : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        public Form_vendorlist()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picbox_add_Click(object sender, EventArgs e)
        {
            Form_Vendor form = new Form_Vendor(this);
            form.btn_save.Enabled = true;
            form.btn_update.Enabled = false;
            form.ShowDialog();
        }
        public void loadvendors()
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            con.Open();
            cm = new SqlCommand("select * from table_vendor", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "EDIT")
                {
                    Form_Vendor f = new Form_Vendor(this);
                    f.lbl_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    f.tft_vendor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    f.tft_address.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    f.tft_contactperson.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    f.tft_contactno.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    f.tft_email.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    f.btn_save.Enabled = false;
                    f.btn_update.Enabled = true;
                    f.ShowDialog();
                }
                else if (colname == "DELETE")
                {
                    if (MessageBox.Show("Confirm to Delete this Vendor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("delete from table_vendor where id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record has been Successfully Deleted!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadvendors();
                    }
                }
                else if (colname == "Column_vendor")
                {
                    Form_vendorspurchases f = new Form_vendorspurchases();
                    f.lbl_id.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    f.loadvendorpurchases();
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
