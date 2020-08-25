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
using Microsoft.Reporting.WinForms;

namespace POS_and_Inventory
{
    public partial class Form_reportsold : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_Solditems form;
        String stitle = "POS System";
        
        public Form_reportsold(Form_Solditems frm)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            form = frm;
        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_reportsold_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

        }
        public void loadsoldreport()
        {
            try
            {
                ReportDataSource rptDS;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report2.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                if (form.cb_cashiers.Text == "All Cashier")
                {
                    da.SelectCommand = new SqlCommand("select c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.disc as discount,c.total from table_cart as c inner join table_products as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + form.dt1.Value.ToString("yyyy-MM-dd") + "' and '" + form.dt2.Value.ToString("yyyy-MM-dd") + "'", con);
                }
                else
                {
                    da.SelectCommand = new SqlCommand("select c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.disc as discount,c.total from table_cart as c inner join table_products as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + form.dt1.Value.ToString("yyyy-MM-dd") + "' and '" + form.dt2.Value.ToString("yyyy-MM-dd") + "' and cashier like '"+form.cb_cashiers.Text+"'", con);
                }
                da.Fill(ds.Tables["dtsoldreport"]);
                con.Close();
                String Store = "";
                String Address = "";
                Store = db.getstorename();
                Address = db.getstoreaddress();

                ReportParameter pDate = new ReportParameter("pDate","Date From: "+form.dt1.Value.ToShortDateString()+" To: "+form.dt2.Value.ToShortDateString());
                ReportParameter pCashier = new ReportParameter("pCashier","Cashier: "+form.cb_cashiers.Text);
                ReportParameter pHeader = new ReportParameter("pHeader","Sales Report");
                ReportParameter pStore = new ReportParameter("pStore", Store);
                ReportParameter pAddress = new ReportParameter("pAddress", Address);


                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pCashier);
                reportViewer1.LocalReport.SetParameters(pHeader);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                rptDS = new ReportDataSource("DataSet1",ds.Tables["dtsoldreport"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
