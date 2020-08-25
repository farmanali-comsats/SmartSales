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
    public partial class Form_Vendor : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_vendorlist f;
        public Form_Vendor(Form_vendorlist frm)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.f = frm;
            this.KeyPreview = true;
        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_vendor.Text!=string.Empty&& tft_contactno.Text != string.Empty&& tft_contactperson.Text != string.Empty) {

                    pb_vendor.Image = null;
                    pb_conp.Image = null;
                    pb_contact.Image = null;

                    if (MessageBox.Show("Confirm to Save this Record!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("insert into table_vendor(vendor,address,contactperson,telephone,email)values(@vendor,@address,@contactperson,@telephone,@email)", con);
                        cm.Parameters.AddWithValue("@vendor", tft_vendor.Text);
                        cm.Parameters.AddWithValue("@address", tft_address.Text);
                        cm.Parameters.AddWithValue("@contactperson", tft_contactperson.Text);
                        cm.Parameters.AddWithValue("@telephone", tft_contactno.Text);
                        cm.Parameters.AddWithValue("@email", tft_email.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record has been Successfully Saved", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        f.loadvendors();
                        this.Dispose();
                    }
                }
                else
                {
                    pb_vendor.Image = Properties.Resources.asterisk;
                    pb_conp.Image = Properties.Resources.asterisk;
                    pb_contact.Image = Properties.Resources.asterisk;
                    MessageBox.Show("Please Enter Mandatory Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void clear()
        {
            tft_vendor.Clear();
            tft_address.Clear();
            tft_contactperson.Clear();
            tft_contactno.Clear();
            tft_email.Clear();
            tft_vendor.Focus();
            btn_save.Enabled = true;
            btn_update.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_vendor.Text != string.Empty && tft_contactno.Text != string.Empty && tft_contactperson.Text != string.Empty)
                {

                    pb_vendor.Image = null;
                    pb_conp.Image = null;
                    pb_contact.Image = null;
                    if (MessageBox.Show("Confirm to Update this Record!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("update table_vendor set vendor=@vendor,address=@address,contactperson=@contactperson,telephone=@telephone,email=@email where id=@id", con);
                        cm.Parameters.AddWithValue("id", lbl_id.Text);
                        cm.Parameters.AddWithValue("@vendor", tft_vendor.Text);
                        cm.Parameters.AddWithValue("@address", tft_address.Text);
                        cm.Parameters.AddWithValue("@contactperson", tft_contactperson.Text);
                        cm.Parameters.AddWithValue("@telephone", tft_contactno.Text);
                        cm.Parameters.AddWithValue("@email", tft_email.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record has been Successfully Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        f.loadvendors();
                        this.Dispose();
                    }
                }
                else
                {
                    pb_vendor.Image = Properties.Resources.asterisk;
                    pb_conp.Image = Properties.Resources.asterisk;
                    pb_contact.Image = Properties.Resources.asterisk;
                    MessageBox.Show("Please Enter Mandatory Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Form_Vendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
