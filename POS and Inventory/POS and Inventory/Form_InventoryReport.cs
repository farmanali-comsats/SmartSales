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
    public partial class Form_InventoryReport : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_Records f;
        string Store = "";
        string Address = "";
        public Form_InventoryReport(Form_Records frm)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            f = frm;
            Store = db.getstorename();
            Address = db.getstoreaddress();
            this.KeyPreview = true;
        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_InventoryReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }
        public void loadtopreport()
        {
            ReportDataSource rptDS;
            try
            {
                //Form_Records f = new Form_Records();
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Reporttopselling.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                if (f.cb_sortby.Text == "Sort By Quantity")
                {
                    da.SelectCommand = new SqlCommand("select top 10 pcode, pdesc, sum(qty) as qty,sum(total)as total from View_Solditems where sdate between '" + f.dttop1.Value.ToString("yyyy-MM-dd") + "' and '" + f.dttop2.Value.ToString("yyyy-MM-dd") + "' and status like 'Sold' group by pcode, pdesc order by qty desc", con);
                }
                else if (f.cb_sortby.Text == "Sort By Total Amount")
                {
                    da.SelectCommand = new SqlCommand("select top 10 pcode, pdesc, isnull(sum(qty),0) as qty,isnull(sum(total),0) as total from View_Solditems where sdate between '" + f.dttop1.Value.ToString("yyyy-MM-dd") + "' and '" + f.dttop2.Value.ToString("yyyy-MM-dd") + "' and status like 'Sold' group by pcode, pdesc order by total desc", con);
                }
                
                da.Fill(ds.Tables["dttopselling"]);
                con.Close();


                ReportParameter pDate = new ReportParameter("pDate", "Date From: " + f.dttop1.Value.ToShortDateString() + " To: " + f.dttop2.Value.ToShortDateString());
                ReportParameter pHeader = new ReportParameter("pHeader", "Top 10 Selling Report");
                ReportParameter pStore = new ReportParameter("pStore", Store);
                ReportParameter pAddress = new ReportParameter("pAddress", Address);

                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pHeader);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dttopselling"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void loadsoldreport()
        {
            try
            {
                ReportDataSource rptDS;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportSolditems.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();

                da.SelectCommand = new SqlCommand("select c.pcode,p.pdesc,c.price,c.qty,c.disc as discount,c.total from table_cart as c inner join table_products as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + f.dts1.Value.ToString("yyyy-MM-dd") + "' and '" + f.dts2.Value.ToString("yyyy-MM-dd") + "'", con);

                da.Fill(ds.Tables["dtSolditemsreport"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pdate", "Date From: " + f.dts1.Value.ToShortDateString() + " To: " + f.dts2.Value.ToShortDateString());
                ReportParameter pHeader = new ReportParameter("pHeader", "Sales Report");
                ReportParameter pStore = new ReportParameter("pStore", Store);
                ReportParameter pAddress = new ReportParameter("pAddress", Address);

                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pHeader);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSolditemsreport"]);
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
        public void loadcritical()
        {
            ReportDataSource rptDS;
            try
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report3.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand("select * from View_criticalStockitems", con);
                da.Fill(ds.Tables["dtcriticalitems"]);
                con.Close();

                ReportParameter pHeader = new ReportParameter("pHeader", "Critical Items Report");
                ReportParameter pStore = new ReportParameter("pStore", Store);
                ReportParameter pAddress = new ReportParameter("pAddress", Address);

                reportViewer1.LocalReport.SetParameters(pHeader);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtcriticalitems"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void loadinventoryreport()
        {
            ReportDataSource rptDS;
            try
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report3.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand("select p.pcode,p.barcode,p.pname,p.pdesc, b.brand,c.category,p.price,p.quantity,p.reorder from table_products as p inner join table_brands as b on p.bid = b.id inner join table_category as c on p.cid = c.id", con);
                da.Fill(ds.Tables["dtInventory"]);
                con.Close();

                ReportParameter pHeader = new ReportParameter("pHeader", "Inventory Report");
                ReportParameter pStore = new ReportParameter("pStore", Store);
                ReportParameter pAddress = new ReportParameter("pAddress", Address);

                reportViewer1.LocalReport.SetParameters(pHeader);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtInventory"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void loadcancelled()
        {
            ReportDataSource rptDS;
            try
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Reportcancelled.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand("select * from ViewCancelOrders where sdate between '" + f.dtc1.Value.ToString("yyyy-MM-dd") + "' and '" + f.dtc2.Value.ToString("yyyy-MM-dd") + "'", con);
                da.Fill(ds.Tables["dtcancelled"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pdate", "Date From: " + f.dtc1.Value.ToShortDateString() + " To: " + f.dtc2.Value.ToShortDateString());
                ReportParameter pHeader = new ReportParameter("pHeader", "Cancelled Items Report");
                ReportParameter pStore = new ReportParameter("pStore", Store);
                ReportParameter pAddress = new ReportParameter("pAddress", Address);

                reportViewer1.LocalReport.SetParameters(pDate);                
                reportViewer1.LocalReport.SetParameters(pHeader);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtcancelled"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void loadstocksinhistory()
        {
            ReportDataSource rptDS;
            try
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportStockinhistory.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand("select * from vwstockin where cast(sdate as date) between '" + f.dtst1.Value.ToString("yyyy-MM-dd") + "' and '" + f.dtst2.Value.ToString("yyyy-MM-dd") + "' and status like 'Done'", con);
                da.Fill(ds.Tables["dtstockinhistory"]);
                con.Close();

                ReportParameter pdate = new ReportParameter("pDate", "Date From: " + f.dtst1.Value.ToShortDateString() + " - " + f.dtst2.Value.ToShortDateString());
                ReportParameter pStore = new ReportParameter("pStore", Store);
                ReportParameter pAddress = new ReportParameter("pAddress", Address);
                ReportParameter pHeader = new ReportParameter("pHeader", "Stock In History");

                reportViewer1.LocalReport.SetParameters(pdate);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);
                reportViewer1.LocalReport.SetParameters(pHeader);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtstockinhistory"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_InventoryReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
