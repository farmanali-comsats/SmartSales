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
    public partial class Form_storedetails : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        public Form_storedetails()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save Store Detais?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int count;
                    con.Open();
                    cm = new SqlCommand("select count(*) from table_stores",con);
                    count = int.Parse(cm.ExecuteScalar().ToString());
                    con.Close();
                    if (count>0)
                    {
                        con.Open();
                        cm = new SqlCommand("update table_stores set store = @store, address = @address",con);
                        cm.Parameters.AddWithValue("@store",tft_storename.Text);
                        cm.Parameters.AddWithValue("@address",tft_address.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        cm = new SqlCommand("insert into table_stores (store,address)values (@store,@address)",con);
                        cm.Parameters.AddWithValue("@store", tft_storename.Text);
                        cm.Parameters.AddWithValue("@address", tft_address.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Store Details have been Successfully Saved!","Save Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {

        }

        private void Form_storedetails_Load(object sender, EventArgs e)
        {
            con.Open();
            cm = new SqlCommand("select * from table_stores", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                tft_storename.Text = dr["Store"].ToString();
                tft_address.Text =  dr["address"].ToString();
            }
            dr.Close();
            con.Close();
            
        }

        private void Form_storedetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
