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
    public partial class Form_UserAccounts : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form1 form;
        
        public Form_UserAccounts(Form1 frm)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            form = frm;
        }
        private void Form_UserAccounts_Resize(object sender, EventArgs e)
        {
            metroTabControl1.Left = (this.Width - metroTabControl1.Width)/2;
            metroTabControl1.Top = (this.Height - metroTabControl1.Height) / 2;
        }

        private void Form_UserAccounts_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabPage1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_username.Text!=""&& tft_pass.Text != ""&& tft_name.Text != ""&& cb_role.Text != "")
                {
                    if (tft_pass.Text != tft_repass.Text)
                    {
                        MessageBox.Show("Password Did not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (checkusernameexistence(tft_username.Text.ToLower()) != false)
                    {
                        con.Open();
                        cm = new SqlCommand("insert into table_users (username,password,role,name) values(@username,@password,@role,@name)", con);
                        cm.Parameters.AddWithValue("@username", tft_username.Text);
                        cm.Parameters.AddWithValue("@password", tft_pass.Text);
                        cm.Parameters.AddWithValue("@role", cb_role.Text);
                        cm.Parameters.AddWithValue("@name", tft_name.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Account has been Successfully Created!");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("User Already Exists!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
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
        public void clear()
        {
            tft_name.Clear();
            tft_pass.Clear();
            tft_repass.Clear();
            tft_username.Clear();
            cb_role.Text = "";
            tft_username.Focus();

            tft_cnewpass.Clear();
            tft_cnewpassretype.Clear();
            tft_coldpass.Clear();
            tft_cusername.Clear();
            tft_cusername.Focus();

            tft_dname.Clear();
            tft_dpassword.Clear();
            tft_dusername.Clear();
            tft_dusername.Focus();

            pictureBox_check.Image = null;
            pictureBox_duser.Image = null;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            changepass();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == tabPage2)
            {
                tft_cusername.Text = form.lbl_username.Text;
                checkbox_username.Checked = false;
            }else if (metroTabControl1.SelectedTab == tabPage3)
            {
                tft_dusername.Text = form.lbl_username.Text;
                checkbox_duser.Checked = false;
            }
        }

        private void checkbox_username_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_username.Checked ==true)
            {
                tft_cusername.Enabled = true;
            }
            else
            {
                tft_cusername.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void changepass()
        {
            try
            {
                if (checkusername()) {
                    
                    string oldpass = db.GetPassword(tft_cusername.Text);
                    if (oldpass != tft_coldpass.Text)
                    {
                        MessageBox.Show("Incorrect Old Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (tft_cnewpass.Text != tft_cnewpassretype.Text)
                    {
                        MessageBox.Show("Password did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Change Password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.Open();
                            cm = new SqlCommand("update table_users set password = @password where username = @username", con);
                            cm.Parameters.AddWithValue("@password", tft_cnewpass.Text);
                            cm.Parameters.AddWithValue("@username", tft_cusername.Text);
                            cm.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Password has been Successfully Changed", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                    }
                }
                else
                {
                    if (tft_cusername.Text != "")
                    {
                        MessageBox.Show("User Does not Exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool checkusername()
        {
            bool ch = false;
            if (tft_cusername.Text != "") {
                SqlDataAdapter da = new SqlDataAdapter("select username from table_users where username ='" + tft_cusername.Text + "'", con);
                DataTable d1 = new DataTable();
                da.Fill(d1);
                if (d1.Rows.Count >= 1)
                {
                    pictureBox_check.Image = Properties.Resources.tick_green;
                    pictureBox_check.SizeMode = PictureBoxSizeMode.StretchImage;
                    ch = true;
                }
                else
                {
                    pictureBox_check.Image = Properties.Resources.cross_red;
                    pictureBox_check.SizeMode = PictureBoxSizeMode.StretchImage;
                    ch = false;
                }
            }
            else
            {
                pictureBox_check.Image = null;
                MessageBox.Show("Please enter username first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ch;
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (tft_dusername.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("select username from table_users where username ='" + tft_dusername.Text + "'", con);
                DataTable d1 = new DataTable();
                da.Fill(d1);
                if (d1.Rows.Count >= 1)
                {
                    pictureBox_duser.Image = Properties.Resources.tick_green;
                    pictureBox_duser.SizeMode = PictureBoxSizeMode.StretchImage;
                    tft_dname.Enabled = true;
                    tft_dpassword.Enabled = true;
                    btn_delete.Enabled = true;
                }
                else
                {
                    pictureBox_duser.Image = Properties.Resources.cross_red;
                    pictureBox_duser.SizeMode = PictureBoxSizeMode.StretchImage;
                    MessageBox.Show("User Does not Exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tft_dname.Enabled = false;
                    tft_dpassword.Enabled = false;
                    btn_delete.Enabled = false;
                }
            }
            else
            {
                pictureBox_duser.Image = null;
                MessageBox.Show("Please enter username first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void deleteuser()
        {
            try
            {
                string pass = db.GetPassword(tft_dusername.Text);
                string name = db.GetName(tft_dusername.Text);

                if ((tft_dpassword.Text !="")&&(tft_dname.Text!="")) {
                    if (tft_dusername.Text.ToLower() != "admin"&& name.ToLower() != "super user") {
                        if ((pass != tft_dpassword.Text) && (name != tft_dname.Text))
                        {
                            MessageBox.Show("Incorrect Password or Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (MessageBox.Show("Delete User Account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                con.Open();
                                cm = new SqlCommand("delete from table_users where username = '" + tft_dusername.Text + "'", con);
                                cm.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Account has been Successfully Deleted!", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Cannot Delete  'Admin' Account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteuser();
        }

        private void checkbox_duser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_duser.Checked == true)
            {
                tft_dusername.Enabled = true;
            }
            else
            {
                tft_dusername.Enabled = false;
            }
        }

        private void btn_dcancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        public bool checkusernameexistence(string newuser)
        {
            //bool ch = false;
            string olduser = "";
            bool uch = true;

            SqlDataAdapter da = new SqlDataAdapter("select * from table_users", con);
            DataTable d1 = new DataTable();
            da.Fill(d1);
            if (d1.Rows.Count >= 1)
            {
                for (int i = 0; i < d1.Rows.Count; i++)
                {
                    olduser = d1.Rows[i]["username"].ToString().ToLower();
                    if (newuser == olduser)
                    {
                        uch = false;
                        return uch;
                    }
                    else
                    {
                        uch = true;
                    }
                }
                

            }
            else
            {

                return uch;
            
            }
            
            return uch;
        }

           }
}
