using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace POS_and_Inventory
{
    public class mydatabase
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private double dailysale;
        private double profit;
        private double debitsale;
        private double totalbalance;
        private double payed;
        private double total;
        private double change;
        private int productline;
        private int stockonhand;
        private int criticalitems;
        private static string cn;
        public String MyConnection()
        {
            cn = ConfigurationManager.ConnectionStrings["SmartSales"].ConnectionString;
            return cn;
        }
        public double Getval()
        {
            double vat = 0;
            con.ConnectionString = MyConnection();
            con.Open();
            cm = new SqlCommand("select * from table_vat", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            dr.Close();
            con.Close();
            return vat;
        }
        public string GetPassword(string user)
        {
            string password = "";
            con.ConnectionString = MyConnection();
            con.Open();
            cm = new SqlCommand("select * from table_users where username = @username", con);
            cm.Parameters.AddWithValue("@username", user);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                password = dr["password"].ToString();
            }
            dr.Close();
            con.Close();
            return password;
        }
        public string GetName(string user)
        {
            string name = "";
            con.ConnectionString = MyConnection();
            con.Open();
            cm = new SqlCommand("select * from table_users where username = @username", con);
            cm.Parameters.AddWithValue("@username", user);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                name = dr["name"].ToString();
            }
            dr.Close();
            con.Close();
            return name;
        }
        public double dailysales()
        {
            String sdate = DateTime.Now.ToString("yyyy-MM-dd");
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select isnull(sum(total),0) as total from table_cart where sdate between '" + sdate + "'and'" + sdate + "'and status like 'Sold'", con);
            dailysale = double.Parse(cm.ExecuteScalar().ToString());
            con.Close();
            return dailysale;
        }
        public double DailyProfit()
        {
            String sdate = DateTime.Now.ToString("yyyy-MM-dd");
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select isnull(sum(costtotal),0) as costtotal from table_cart where sdate between '" + sdate + "'and'" + sdate + "'and status like 'Sold'", con);
            profit = double.Parse(cm.ExecuteScalar().ToString());
            profit = dailysale - profit;
            con.Close();
            return profit;
        }
        public double Productline()
        {
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select count(*) from table_products", con);
            productline = int.Parse(cm.ExecuteScalar().ToString());
            con.Close();
            return productline;
        }
        public double Stockonhand()
        {
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select isnull(sum(quantity),0) as quantity from table_products", con);
            stockonhand = int.Parse(cm.ExecuteScalar().ToString());
            con.Close();
            return stockonhand;
        }
        public double Criticalitems()
        {
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select count(*) from View_criticalStockitems", con);
            criticalitems = int.Parse(cm.ExecuteScalar().ToString());
            con.Close();
            return criticalitems;
        }
        public double debitedsales()
        {
            String sdate = DateTime.Now.ToString("yyyy-MM-dd");
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select isnull(sum(balance),0) as balance from table_customerpurchases where sdate between '" + sdate + "'and'" + sdate + "'", con);
            debitsale = double.Parse(cm.ExecuteScalar().ToString());
            con.Close();
            return debitsale;
        }
        public string getstorename()
        {
            string Store = "";
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select * from table_stores", con);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Store = dr["Store"].ToString();
            }
            dr.Close();
            con.Close();
            return Store;
        }
        public string getstoreaddress()
        {
            string address = "";
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select * from table_stores", con);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                address = dr["address"].ToString();
            }
            dr.Close();
            con.Close();
            return address;
        }

        public bool trialcheck()
        {
            string s1, s2, s0;
            bool check = false;

            s0 = ConfigurationManager.AppSettings.Get("Key0");
            s1 = ConfigurationManager.AppSettings.Get("Key1");
            s2 = ConfigurationManager.AppSettings.Get("Key2");
            int v1 = int.Parse(s1);
            int v2 = int.Parse(s2);
            int v0 = int.Parse(s0);

            v0 += v1;
            if (v0 > v2)
            {
                check = true;
            }
            else
            {
                Configuration config1 = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config1.AppSettings.Settings.Remove("key0");
                config1.AppSettings.Settings.Add("key0", v0.ToString());
                config1.Save(ConfigurationSaveMode.Modified);
                //MessageBox.Show("new value is " + ConfigurationManager.AppSettings.Get("key0"));
                check = false;
            }
            return check;
        }
        public double customertotalbalance(string cid)
        {
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select isnull(sum(total),0) as total from table_customerpurchases where cid like '" + cid + "'", con);
            total = double.Parse(cm.ExecuteScalar().ToString());
            con.Close();

            con.Open();
            cm = new SqlCommand("select isnull(sum(payed),0) as payed from table_customerpurchases where cid like '" + cid + "'", con);
            payed = double.Parse(cm.ExecuteScalar().ToString());
            con.Close();

            con.Open();
            cm = new SqlCommand("select isnull(sum(change),0) as change from table_customerpurchases where cid like '" + cid + "'", con);
            change = double.Parse(cm.ExecuteScalar().ToString());
            con.Close();

            totalbalance = (total - payed) + change;

            return totalbalance;
        }
        public string Getcustomerid(string trcode)
        {
            string cid = "";
            con.ConnectionString = MyConnection();
            con.Open();
            cm = new SqlCommand("select cid from table_customerpurchases where transno = @transno", con);
            cm.Parameters.AddWithValue("@transno", trcode);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                cid = dr["cid"].ToString();
            }
            dr.Close();
            con.Close();
            return cid;
        }
        public double vendortotalbalance(string vid)
        {
            con = new SqlConnection();
            con.ConnectionString = cn;
            con.Open();
            cm = new SqlCommand("select isnull(sum(vtotal),0) as vtotal from table_vendorpurchases where vid like '" + vid + "'", con);
            total = double.Parse(cm.ExecuteScalar().ToString());
            con.Close();

            con.Open();
            cm = new SqlCommand("select isnull(sum(vcredit),0) as vcredit from table_vendorpurchases where vid like '" + vid + "'", con);
            payed = double.Parse(cm.ExecuteScalar().ToString());
            con.Close();

            //con.Open();
            //cm = new SqlCommand("select isnull(sum(change),0) as change from table_vendorpurchases where cid like '" + cid + "'", con);
            //cchange = double.Parse(cm.ExecuteScalar().ToString());
            //con.Close();

            totalbalance = (total - payed);

            return totalbalance;
        }
    }
}
