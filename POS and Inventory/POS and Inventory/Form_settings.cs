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
    public partial class Form_settings : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        public Form_settings()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save Store Detais?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int count;
                    con.Open();
                    cm = new SqlCommand("select count(*) from table_stores", con);
                    count = int.Parse(cm.ExecuteScalar().ToString());
                    con.Close();
                    if (count > 0)
                    {
                        con.Open();
                        cm = new SqlCommand("update table_stores set store = @store, address = @address", con);
                        cm.Parameters.AddWithValue("@store", tft_storename.Text);
                        cm.Parameters.AddWithValue("@address", tft_address.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        cm = new SqlCommand("insert into table_stores (store,address)values (@store,@address)", con);
                        cm.Parameters.AddWithValue("@store", tft_storename.Text);
                        cm.Parameters.AddWithValue("@address", tft_address.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Store Details have been Successfully Saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_settings_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form_settings_Load(object sender, EventArgs e)
        {
            try
            {
                metroTabControl1.SelectedTab = tabPage1;
                con.Open();
                cm = new SqlCommand("select * from table_stores", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    tft_storename.Text = dr["Store"].ToString();
                    tft_address.Text = dr["address"].ToString();
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_settings_Resize(object sender, EventArgs e)
        {
            metroTabControl1.Left = (this.Width - metroTabControl1.Width) / 2;
            metroTabControl1.Top = (this.Height - metroTabControl1.Height) / 2;
        }
    }
}
