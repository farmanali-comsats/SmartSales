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
    public partial class Form_addcategory : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        Form_category formcategory;
        private Form_addproduct form_addproduct;

        public Form_addcategory(Form_category form_category)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            formcategory = form_category;
            this.KeyPreview = true;
        }

        public Form_addcategory(Form_addproduct form_addproduct)
        {
            this.form_addproduct = form_addproduct;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                if (tft_categoryname.Text !=string.Empty) {
                    if (MessageBox.Show("Confirm to Create this Category", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("INSERT INTo table_category(category)VALUEs(@category)", con);
                        cm.Parameters.AddWithValue("@category", tft_categoryname.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Category Created Successfully");
                        clear();
                        formcategory.LoadCategory();
                        this.Dispose();
                    } }
                else
                {
                    MessageBox.Show("Please Enter Category Name","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            tft_categoryname.Clear();
            tft_categoryname.Focus();
        }

        private void Form_addcategory_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_categoryname.Text != string.Empty)
                {
                    if (MessageBox.Show("Are you sure you want to update this Category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("update table_category set category = @category where id like'" + lblid.Text + "'", con);
                    cm.Parameters.AddWithValue("@category", tft_categoryname.Text);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been updated Successfully");
                    clear();
                    formcategory.LoadCategory();
                    this.Dispose();
                }
                }
                else
                {
                    MessageBox.Show("Please Enter Category Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_addcategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (btn_save.Enabled == true)
                {
                    btn_save_Click(sender, e);
                }
                else
                {
                    btn_update_Click(sender, e);
                }
            }
        }
    }

}
