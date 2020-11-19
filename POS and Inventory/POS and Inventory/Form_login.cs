using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_and_Inventory
{
    public partial class Form_login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        public Form_login()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@"C:\Windows\System32\frmn.dll"))
                {
                    string _username = "", _role = "", _name = "";


                    bool found = false;

                    con.Open();
                    cm = new SqlCommand("Select * from table_users where username = @username and password = @password", con);
                    cm.Parameters.AddWithValue("@username", tft_username.Text);
                    cm.Parameters.AddWithValue("@password", tft_pass.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        found = true;
                        _username = dr["username"].ToString();
                        _role = dr["role"].ToString();
                        _name = dr["name"].ToString();
                    }
                    else
                    {
                        found = false;
                    }
                    dr.Close();
                    con.Close();

                    if (found == true)
                    {
                        if (db.trialcheck())
                        {
                            MessageBox.Show("Please Contact +923157228586 for Further Assistance!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (_role == "Cashier")
                            {
                                MessageBox.Show("Welcome " + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tft_pass.Clear();
                                tft_username.Clear();
                                this.Hide();
                                Form_POS form = new Form_POS(this);
                                form.lbl_username.Text = _username;
                                form.lbl_name.Text = _name + " | " + _role;
                                form.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Welcome " + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tft_pass.Clear();
                                tft_username.Clear();
                                this.Hide();
                                Form1 form = new Form1();
                                form.lbl_username.Text = _username;
                                form.lbl_name.Text = _name;
                                form.lbl_role.Text = _role;
                                form.ShowDialog();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btn_reset.Enabled = true;
                    }
                }

                else
                {
                    MessageBox.Show("Please Contact +923157228586 immediately");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void Form_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_cancel_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }
    }
}