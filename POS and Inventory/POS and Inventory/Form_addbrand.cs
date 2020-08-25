using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_and_Inventory
{
    public partial class Form_addbrand : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        Form_Brand formbrand;
        public Form_addbrand(Form_Brand form)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            formbrand = form;
            this.KeyPreview = true;
        }
        private void Form_addbrand_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_brandname.Text != string.Empty)
                {
                    if (MessageBox.Show("Confirm to Save this Brand", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("INSERT INTo table_brands(Brand)VALUEs(@brand)", con);
                    cm.Parameters.AddWithValue("@brand", tft_brandname.Text);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Brand Added Successfully");
                    clear();
                    formbrand.LoadRecords();
                    this.Dispose();
                }
            }
                else
            {
                MessageBox.Show("Please Enter Brand Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            tft_brandname.Clear();
            tft_brandname.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_brandname.Text != string.Empty)
                {
                    if (MessageBox.Show("Are you sure you want to update this Brand?","Update Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("update table_brands set brand = @brand where id like'"+lblid.Text+"'",con);
                    cm.Parameters.AddWithValue("@brand",tft_brandname.Text);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Brand has been updated successfully");
                    clear();
                    formbrand.LoadRecords();
                    this.Dispose();
                }
                }
                else
                {
                    MessageBox.Show("Please Enter Brand Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_addbrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            
            if (e.KeyCode == Keys.Enter)
            {
                btn_save_Click(sender, e);
            }
        }
    }
}
