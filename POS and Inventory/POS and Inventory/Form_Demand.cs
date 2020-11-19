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
    public partial class Form_Demand : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        String id = String.Empty;
        public Form_Demand()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
        }
        public void savedemand()
        {
            try
            {
                if (tft_name.Text != "" && tft_desc.Text != "")
                {
                    con.Open();
                    cm = new SqlCommand("insert into table_demand (name,description,date) values(@name,@description,@date)", con);
                    cm.Parameters.AddWithValue("@name", tft_name.Text);
                    cm.Parameters.AddWithValue("@description", tft_desc.Text);
                    cm.Parameters.AddWithValue("@date", DateTime.Now);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Demand has been Added!");
                    clear();
                    loaddemands();

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
        public void updatedemand()
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("UPDATE table_demand SET name=@name, description=@description where id like @id", con);
                    cm.Parameters.AddWithValue("@id", id);
                    cm.Parameters.AddWithValue("@name", tft_name.Text);
                    cm.Parameters.AddWithValue("@description", tft_desc.Text);
                    cm.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record has been updated Successfully");
                    clear();
                    loaddemands();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void loaddemands()
        {
            try
            {
                int i = 0;
                dataGridView2.Rows.Clear();
                con.Open();
                cm = new SqlCommand("select * from table_demand order by date desc", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    dataGridView2.Rows.Add(i, dr["id"].ToString(), dr["name"].ToString(), dr["description"].ToString(), dr["date"].ToString());
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

        public void clear()
        {
            tft_name.Text = String.Empty;
            tft_desc.Text = String.Empty;
            btn_save.Enabled = true;
            btn_update.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            savedemand();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updatedemand();
        }

        private void Form_Demand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btn_save.Enabled ==true)
                {
                    btn_save_Click(sender, e);
                }else if (btn_update.Enabled==true)
                {
                    btn_update_Click(sender,e);
                }
                
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String colname = dataGridView2.Columns[e.ColumnIndex].Name;
                id = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();               
                if (colname == "col_delete")
                {
                    if (MessageBox.Show("Are you sure you want to Delete this Demand Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("Delete from table_demand where id like'" + id + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Demand has been Deleted", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddemands();
                    }
                }
                else if (colname == "Edit")
                {
                    tft_name.Text = dataGridView2[2, e.RowIndex].Value.ToString();
                    tft_desc.Text = dataGridView2[3, e.RowIndex].Value.ToString();
                    btn_save.Enabled = false;
                    btn_update.Enabled = true;
                    tft_name.Focus();

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
