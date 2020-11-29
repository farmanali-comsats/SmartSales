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
using Microsoft.Reporting.WinForms;

namespace POS_and_Inventory
{
    public partial class Form_receipt : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        String stitle = "POS System";
        Form_POS form;
        String Store = "";
        String Address = "";
        
        public Form_receipt(Form_POS frm)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            form = frm;
            this.KeyPreview = true;
        }

        private void Form_receipt_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public void loadreport(string pcash,string pchange,string customer,string balance)
        {
            ReportDataSource rptdatasource;
            try
            {
                string _price="";
                string _qty="";
                string _disc="";
                double total;
                int qty;
                double price;
                double disc;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report1.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                
                
                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                //DataTable dt = new DataTable("total");

                if ((double.Parse(balance))>0)
                {
                    con.Open();
                    da.SelectCommand = new SqlCommand("select c.id, c.transno, c.pcode, c.price, c.qty, c.disc, c.balance as total, c.sdate, c.status, p.pname,p.pdesc from table_cart as c inner join table_products as p on p.pcode = c.pcode where transno like '" + form.lbl_trcode.Text + "'", con);
                    da.Fill(ds.Tables["dtSold"]);
                    con.Close();
                }
                else
                {
                    con.Open();
                    da.SelectCommand = new SqlCommand("select c.id, c.transno, c.pcode, c.price, c.qty, c.disc, c.total, c.sdate, c.status, p.pname,p.pdesc from table_cart as c inner join table_products as p on p.pcode = c.pcode where transno like '" + form.lbl_trcode.Text + "'", con);
                    da.Fill(ds.Tables["dtSold"]);
                    con.Close();
                }

                

                Store = db.getstorename();
                Address = db.getstoreaddress();

               // ReportParameter pVatable = new ReportParameter("pVatable", form.lbl_vatable.Text);
                //ReportParameter pVat = new ReportParameter("pVat", form.lbl_vat.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", form.lbl_discount.Text);
                ReportParameter pTotal = new ReportParameter("PTotal", form.lbl_salestotal.Text);
                ReportParameter pCash = new ReportParameter("PCash", pcash);
                ReportParameter pChange = new ReportParameter("PChange", pchange);
                ReportParameter pStore = new ReportParameter("PStore", Store);
                ReportParameter pAddress = new ReportParameter("PAddress", Address);
                ReportParameter pTransaction = new ReportParameter("PTransaction", "Invoice #: "+ form.lbl_trcode.Text);
                ReportParameter pCashier = new ReportParameter("pCashier", form.lbl_username.Text);
                ReportParameter pcustomer = new ReportParameter("pcustomer", customer);
                ReportParameter pbalance = new ReportParameter("pbalance", balance);

                //reportViewer1.LocalReport.SetParameters(pVatable);
                //reportViewer1.LocalReport.SetParameters(pVat);
                reportViewer1.LocalReport.SetParameters(pDiscount);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pCash);
                reportViewer1.LocalReport.SetParameters(pChange);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);
                reportViewer1.LocalReport.SetParameters(pTransaction);
                reportViewer1.LocalReport.SetParameters(pCashier);
                reportViewer1.LocalReport.SetParameters(pcustomer);
                reportViewer1.LocalReport.SetParameters(pbalance);

                rptdatasource = new ReportDataSource("DataSet1",ds.Tables["dtSold"]);
                reportViewer1.LocalReport.DataSources.Add(rptdatasource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                
                reportViewer1.ZoomMode = ZoomMode.Percent;
                
                reportViewer1.ZoomPercent = 100;
                
                if (form.btn_eprt.Text == "Print-Enabled") {
                    this.reportViewer1.LocalReport.PrintToPrinter();
                }

                // Variables
                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;

                
                byte[] bytes = reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);

                String filename = Application.StartupPath + @"\Receipts\" +form.lbl_trcode.Text+".pdf";
                File.WriteAllBytes(filename,bytes);
                //System.Diagnostics.Process.Start(filename);                               

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        

        private void Form_receipt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
