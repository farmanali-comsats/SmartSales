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
    public partial class Form_category : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        public Form_category()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
        }

        private void picbox_addcategory_Click(object sender, EventArgs e)
        {
            Form_addcategory formcategory = new Form_addcategory(this);
            formcategory.btn_save.Enabled = true;
            formcategory.btn_update.Enabled = false;
            formcategory.ShowDialog();

        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }
        public void LoadCategory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            con.Open();
            cm = new SqlCommand("select * from table_category order by category", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "EDIT")
                {
                    Form_addcategory form = new Form_addcategory(this);
                    form.lblid.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                    form.tft_categoryname.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                    form.btn_save.Enabled = false;
                    form.btn_update.Enabled = true;
                    form.ShowDialog();
                }
                else if (colname == "DELETE")
                {
                    if (MessageBox.Show("Are you sure you want to Delete this Category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("Delete from table_category where id like'" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Category has been Deleted Successfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategory();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Form_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                picbox_addcategory_Click(sender, e);
            }
        }
    }
}
