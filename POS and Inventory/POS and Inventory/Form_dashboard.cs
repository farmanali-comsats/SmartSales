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
using System.Windows.Forms.DataVisualization.Charting;

namespace POS_and_Inventory
{
    public partial class Form_dashboard : Form
    {
        SqlConnection con;
        SqlCommand cm;
        mydatabase db = new mydatabase();
        
        public Form_dashboard()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = db.MyConnection();
            loadchart();
        }

        private void Form_dashboard_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.Width-panel1.Width)/2;
        }
        public void loadchart()
        {
            con.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select year(sdate) as year,ISNULL(SUM(total),0.0) as total from table_cart where status like 'Sold' group by YEAR(sdate)", con);
            DataSet ds = new DataSet();

            dr.Fill(ds,"Sales");
            chart1.DataSource = ds.Tables["Sales"];
            Series series1 = chart1.Series["Series1"];
            series1.ChartType = SeriesChartType.Doughnut;

            series1.Name = "Sales";

            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "Year";
            chart.Series[series1.Name].YValueMembers = "Total";
            chart.Series[0].IsValueShownAsLabel = true;

            con.Close();
        }

        private void Form_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel_dprofit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (panel_dprofit.Visible != true)
            {

                this.SuspendLayout();
                panel_dprofit.Visible = true;
                panel_dailysale.Visible = true;
                this.ResumeLayout();
            }

            else if (panel_dprofit.Visible == true)
            {
                this.SuspendLayout();
                panel_dailysale.Visible = true;
                panel_dprofit.Visible = false;
                this.ResumeLayout();
                
            }
        }

        private void panel_dailysale_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (panel_dprofit.Visible != true)
            {

                this.SuspendLayout();
                panel_dprofit.Visible = true;
                panel_dailysale.Visible = true;
                this.ResumeLayout();
            }

            else if (panel_dprofit.Visible == true)
            {
                this.SuspendLayout();
                panel_dailysale.Visible = true;
                panel_dprofit.Visible = false;
                this.ResumeLayout();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
