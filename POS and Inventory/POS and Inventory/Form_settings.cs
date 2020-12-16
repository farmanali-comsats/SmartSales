using IronPython.Hosting;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_and_Inventory
{
    public partial class Form_settings : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        SqlDataAdapter da;
        String deftdir = @"D:\SmatSalesReports";
        public Form_settings()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save Store Detais?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int count;
                    con.Open();
                    cm = new SqlCommand("select count(*) from table_stores", con);
                    count = int.Parse(cm.ExecuteScalar().ToString());
                    con.Close();
                    if (count > 0)
                    {
                        con.Open();
                        cm = new SqlCommand("update table_stores set store = @store, address = @address", con);
                        cm.Parameters.AddWithValue("@store", tft_storename.Text);
                        cm.Parameters.AddWithValue("@address", tft_address.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        cm = new SqlCommand("insert into table_stores (store,address)values (@store,@address)", con);
                        cm.Parameters.AddWithValue("@store", tft_storename.Text);
                        cm.Parameters.AddWithValue("@address", tft_address.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Store Details have been Successfully Saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void backupdata()
        {
            try
            {
                String receiptdir = @"D:\SmatSalesReports\Backup";
                if (!Directory.Exists(receiptdir))
                {
                    Directory.CreateDirectory(receiptdir);
                }
                //string dbname = "SmartSales";
                string dbname = con.Database.ToString();
                //string dbname = con.Database.ToString();
                //string dbname = Application.StartupPath + @"\" + dbname1 + ".mdf";
                string backupdb = "BACKUP DATABASE [" + dbname + "] TO DISK='" + receiptdir + "\\" + "SmartSales" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                con.Open();
                cm = new SqlCommand(backupdb, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("BackUp Successful");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void restoredb()
        {
            con.Open();
            String database = con.Database.ToString();
            //MessageBox.Show(database);
            try
            {

                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + tft_restoredb.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();
                // s.Speak("Database Restored successfully");
                MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //button2.Enabled = false;


            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form_settings_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form_settings_Load(object sender, EventArgs e)
        {
            try
            {
                metroTabControl1.SelectedTab = tabPage1;
                con.Open();
                cm = new SqlCommand("select * from table_stores", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    tft_storename.Text = dr["Store"].ToString();
                    tft_address.Text = dr["address"].ToString();
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SmartSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_settings_Resize(object sender, EventArgs e)
        {
            metroTabControl1.Left = (this.Width - metroTabControl1.Width) / 2;
            metroTabControl1.Top = (this.Height - metroTabControl1.Height) / 2;
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm to Backup Database", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                backupdata();
            }
            else
            {
                MessageBox.Show("Backup Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_restoredb_Click(object sender, EventArgs e)
        {
            if (tft_restoredb.Text != string.Empty)
            {
                restoredb();
            }
            else
            {
                MessageBox.Show("Please Select Backup first !", "SmartSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Please Select Backup first !","SmartSales");
            }
        }

        private void btn_opendb_Click(object sender, EventArgs e)
        {
            //ofd = new OpenFileDialog();
            openbackupfile.Filter = "SQL SERVER database backup files|*.bak";
            openbackupfile.Title = "Database Restore";
            openbackupfile.InitialDirectory = deftdir;
            if (openbackupfile.ShowDialog() == DialogResult.OK)
            {
                tft_restoredb.Text = openbackupfile.FileName;
                //RestoreBtn.Enabled = true;
            }
        }

        private void btn_salepredict_Click(object sender, EventArgs e)
        {
            //var ipy = Python.CreateRuntime();
            //dynamic test = ipy.UseFile("D:\\Python Apps\\pyguitesting.py");
            //test.Simple();

            //ScriptEngine engine = Python.CreateEngine();
            //engine.ExecuteFile(@"D:\\Python Apps\\pyguitesting.py");

            //var script = @"D:\\Python Apps\\pyguitesting.py";
            //var psi = new ProcessStartInfo()
            //{
            //    FileName = "ipy.exe",
            //    Arguments = $"\"{script}\"",
            //    UseShellExecute = false,
            //    CreateNoWindow = false
            //};

            //Process python = new Process();
            //python.StartInfo = psi;

            exportdailycsv();
        }
        public void exportdailycsv()
        {
            try
            {               
                con.Open();
                cm = new SqlCommand("select (sdate) as date,ISNULL(SUM(total),0.0) as total from table_cart where status like 'Sold' group by sdate order by sdate asc", con);

                DataTable dt = new DataTable();
                da = new SqlDataAdapter(cm);
                da.Fill(dt);
                //Build the CSV file data as a Comma separated string.
                string csv = string.Empty;

                foreach (DataColumn column in dt.Columns)
                {
                    //Add the Header row for CSV file.
                    csv += column.ColumnName + ',';
                }

                //Add new line.
                csv += "\r\n";

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        //Add the Data rows.
                        csv += row[column.ColumnName].ToString().Replace(",", ";") + ',';
                    }

                    //Add new line.
                    csv += "\r\n";
                }

                //Download the CSV file.
                string folderPath = deftdir + @"\CSV Files\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string salesdata = folderPath + @"SmartSales" + DateTime.Today.ToString("dd-MM-yyyy") + ".csv";
                MessageBox.Show(salesdata);
                File.WriteAllText(salesdata, csv);
                MessageBox.Show("Successful");
                con.Close();
                dr.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sessionalpredict_Click(object sender, EventArgs e)
        {
            Form_predictionssalesdata f = new Form_predictionssalesdata();
            f.ShowDialog();
        }

        private void btn_productpredict_Click(object sender, EventArgs e)
        {
            try
            {
                var script = @"D:\\Python Apps\\pyguitesting.py";
                var psi = new ProcessStartInfo()
                {
                    FileName = "ipy.exe",
                    Arguments = $"\"{script}\"",
                    UseShellExecute = false,
                    CreateNoWindow = false
                };

                Process python = new Process();
                python.StartInfo = psi;
            }
            catch (Exception ex)
            {

            }
        }
    }
}