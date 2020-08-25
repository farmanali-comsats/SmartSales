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
    public partial class Form_voidby : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_CancelDetails form;
        public Form_voidby(Form_CancelDetails frm)
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

        private void btn_void_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_pass.Text!=String.Empty)
                {                        
                    con.Open();
                    String user;
                    cm = new SqlCommand("Select * from table_users where username = @username and password = @password ", con);
                    cm.Parameters.AddWithValue("@username",tft_username.Text);
                    cm.Parameters.AddWithValue("@password",tft_pass.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        user = dr["username"].ToString();
                        dr.Close();
                        con.Close();

                        savecancelorder(user);
                        if (form.cb_addtoinv.Text == "Yes")
                        {
                            
                            updatedata("UPDATE table_products set quantity = quantity + " + int.Parse(form.tft_cqty.Text) + " where pcode = '" + form.tft_pcode.Text + "'");
                            
                        }
                        double bal = double.Parse(lbl_bal.Text);
                        double newpaid = double.Parse(lbl_newpaid.Text);
                        //MessageBox.Show("new paid = "+newpaid);

                        updatedata("UPDATE table_cart set qty = qty - " + int.Parse(form.tft_cqty.Text) + " where id like '" + form.tft_id.Text + "'");

                        con.Open();
                        cm = new SqlCommand("select payed from table_customerpurchases where transno like '" + form.tft_transno.Text + "'", con);
                        double tpayed = double.Parse(cm.ExecuteScalar().ToString());                        
                        con.Close();

                        con.Open();
                        cm = new SqlCommand("select isnull(sum(total),0) as total from table_cart where transno like '" + form.tft_transno.Text + "'", con);
                        double total = double.Parse(cm.ExecuteScalar().ToString());
                        con.Close();

                        
                        if (tpayed>0 && tpayed>=total) {
                            updatedata("UPDATE table_cart set balance = " + 0 + "where transno like '" + form.tft_transno.Text + "'");
                            updatedata("UPDATE table_customerpurchases set total = '" + total + "' where transno like '" + form.tft_transno.Text + "'");
                        }
                        else if (tpayed < total && tpayed>0)
                        {
                            //double ttoal = total - newpaid;
                           
                                //updatedata("UPDATE table_cart set where transno like '" + form.tft_transno.Text + "'");
                                updatedata("UPDATE table_customerpurchases set total = '"+total+"' where transno like '" + form.tft_transno.Text + "'");                       
                        }
                        else
                        {
                            //updatedata("UPDATE table_cart set totalpayed = totalpayed - " + 0 + "where transno like '" + form.tft_transno.Text + "'");
                            updatedata("UPDATE table_customerpurchases set total = '" + total + "' where transno like '" + form.tft_transno.Text + "'");
                        }

                        string cid = db.Getcustomerid(form.tft_transno.Text);
                        if (cid !="Default")
                        {
                            double totalbalance = db.customertotalbalance(cid);
                            con.Open();
                            cm = new SqlCommand("update table_customerpurchases set tbalance = '" + totalbalance + "' where cid = '" + cid + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();

                        }

                        
                        MessageBox.Show("Order Cancelled Successfully !","Cancel Order",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Dispose();
                        form.refreshlist();
                        form.Dispose();
                    }
                    dr.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void savecancelorder(String user)
        {
            con.Open();
            cm = new SqlCommand("insert into table_cancel (transno,pcode,price,qty,sdate,voidby,cancelledby,reason,action)values(@transno,@pcode,@price,@qty,@sdate,@voidby,@cancelledby,@reason,@action)",con);
            //cm.Parameters.AddWithValue("@id", form.tft_id.Text);
            cm.Parameters.AddWithValue("@transno",form.tft_transno.Text);
            cm.Parameters.AddWithValue("@pcode", form.tft_pcode.Text);
            cm.Parameters.AddWithValue("@price", double.Parse(form.tft_price.Text));
            cm.Parameters.AddWithValue("@qty", int.Parse(form.tft_cqty.Text));
            cm.Parameters.AddWithValue("@sdate", DateTime.Now);
            cm.Parameters.AddWithValue("@voidby", user);
            cm.Parameters.AddWithValue("@cancelledby", form.tft_cby.Text);
            cm.Parameters.AddWithValue("@reason", form.tft_reason.Text);
            cm.Parameters.AddWithValue("@action", form.cb_addtoinv.Text);
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void updatedata(String sql)
        {
            con.Open();
            cm = new SqlCommand(sql,con);
            cm.ExecuteNonQuery();
            con.Close();
        }

        private void Form_voidby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }else if (e.KeyCode == Keys.Enter)
            {
                btn_void_Click(sender,e);
            }
        }
    }
}
