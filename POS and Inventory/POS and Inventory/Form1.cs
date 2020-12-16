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
using Tulpep.NotificationWindow;

namespace POS_and_Inventory
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_Stocks frmst = new Form_Stocks();
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            notifycriticalitems();
            mydashboard();
            this.KeyPreview = true;
            //con.Open();
            //MessageBox.Show("Connection Successful");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            Form_Brand myform = new Form_Brand();
            myform.TopLevel = false;
            panel_main.Controls.Add(myform);
            myform.BringToFront();
            myform.Show();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            Form_category myform = new Form_category();
            myform.TopLevel = false;
            panel_main.Controls.Add(myform);
            myform.BringToFront();
            myform.LoadCategory();
            myform.Show();
        }

        private void btn_manage_products_Click(object sender, EventArgs e)
        {
            Form_products myform = new Form_products();
            myform.TopLevel = false;
            panel_main.Controls.Add(myform);
            myform.BringToFront();
            myform.loadrecords();
            myform.Show();
        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_manage_sales_Click(object sender, EventArgs e)
        {
            //Form_POS myform = new Form_POS();
            //myform.ShowDialog();
        }

        private void btn_user_setting_Click(object sender, EventArgs e)
        {
            Form_UserAccounts form = new Form_UserAccounts(this);
            form.TopLevel = false;
            panel_main.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void btn_saleshistory_Click(object sender, EventArgs e)
        {
            Form_Solditems form = new Form_Solditems();
            form.TopLevel = false;
            panel_main.Controls.Add(form);
            form.WindowState = FormWindowState.Maximized;
            form.BringToFront();
            form.Show();
        }

        private void btn_records_Click(object sender, EventArgs e)
        {
            Form_Records form = new Form_Records();
            form.TopLevel = false;
            form.loadcriticalitems();
            form.loadinventorylist();
            form.loadstockhistory();
            panel_main.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout of Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form_login form = new Form_login();
                form.ShowDialog();
            }
        }

        private void btn_sys_setting_Click(object sender, EventArgs e)
        {
            //Form_storedetails form = new Form_storedetails();
            //form.ShowDialog();
            Form_settings form = new Form_settings();
            form.TopLevel = false;
            panel_main.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        public void notifycriticalitems()
        {
            string critical = "";
            con.Open();
            cm = new SqlCommand("select count(*) from View_criticalStockitems", con);
            String count = cm.ExecuteScalar().ToString();
            con.Close();

            int i = 0;
            con.Open();
            cm = new SqlCommand("select * from View_criticalStockitems",con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                critical += i +". "+ dr["pname"].ToString()+ Environment.NewLine;
            }
            dr.Close();
            con.Close();

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.cross_red1;
            popup.TitleText = "Critical Item(s)";
            popup.ContentText = critical;
            popup.Popup();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            mydashboard();
        }
        public void mydashboard()
        {
            Form_dashboard form = new Form_dashboard();
            form.TopLevel = false;
            panel_main.Controls.Add(form);
            form.lbl_dailyprofit.Text = db.DailyProfit().ToString("#,##0.00");
            form.lbl_dailysales.Text = db.dailysales().ToString("#,##0.00");
            form.lbl_products.Text = db.Productline().ToString("#,##0");
            form.lbl_stocks.Text = db.Stockonhand().ToString("#,##0");
            form.lbl_critical.Text = db.Criticalitems().ToString("#,##0");
            form.lbl_debit.Text = db.debitedsales().ToString("#,##0.00");
            form.BringToFront();
            form.Show();
        }

        private void btn_vendor_Click(object sender, EventArgs e)
        {
            Form_vendorlist form = new Form_vendorlist();
            form.TopLevel = false;
            form.loadvendors();
            panel_main.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void btn_adjustments_Click(object sender, EventArgs e)
        {
            Form_Adjustments frm = new Form_Adjustments(this);
            frm.loadrecords();
            frm.tft_user.Text = lbl_username.Text;
            frm.getrefno();
            frm.ShowDialog();
        }

        private void btn_stocks_Click(object sender, EventArgs e)
        {
            Form_Stocks myform = new Form_Stocks();
            myform.TopLevel = false;
            panel_main.Controls.Add(myform);
            myform.BringToFront();
            //myform.loadproducts();
            myform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mydashboard();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Form_Customers myform = new Form_Customers();
            myform.TopLevel = false;
            panel_main.Controls.Add(myform);
            myform.BringToFront();
            myform.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (frmst.dataGridView2.Rows.Count>0)
                {
                    
                }
                else
                {
                    btn_dashboard_Click(sender, e);
                }
                
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F4)
            {
                btn_logout_Click(sender, e);
            }else if (e.KeyCode == Keys.F1)
            {
                btn_manage_products_Click(sender,e);
            }            
            else if (e.KeyCode == Keys.F2)
            {
                btn_vendor_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btn_stocks_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                btn_adjustments_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btn_category_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                btn_brand_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F7)
            {
                btn_records_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8)
            {
                btn_saleshistory_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F9)
            {
                btn_sys_setting_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                btn_user_setting_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F11)
            {
                btn_customer_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F12)
            {
                btn_demands_Click(sender, e);
            }
        }

        private void btn_demands_Click(object sender, EventArgs e)
        {
            Form_Demand form = new Form_Demand();
            form.TopLevel = false;
            panel_main.Controls.Add(form);
            form.BringToFront();
            form.loaddemands();
            form.Show();
        }
    }
}