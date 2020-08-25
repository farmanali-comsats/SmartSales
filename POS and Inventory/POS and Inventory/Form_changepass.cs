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
    public partial class Form_changepass : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        Form_POS form;
        public Form_changepass(Form_POS frm)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            form = frm;
            this.KeyPreview = true;
        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string oldpass = db.GetPassword(form.lbl_username.Text);
                if (oldpass!= tft_oldpass.Text)
                {
                    MessageBox.Show("Incorrect Old Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if (tft_newpass.Text!= tft_newpassretype.Text)
                {
                    MessageBox.Show("Password did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(MessageBox.Show("Change Password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("update table_users set password = @password where username = @username", con);
                        cm.Parameters.AddWithValue("@password",tft_newpass.Text);
                        cm.Parameters.AddWithValue("@username",form.lbl_username.Text);
                        cm.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Password has been Successfully Changed", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form_changepass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
