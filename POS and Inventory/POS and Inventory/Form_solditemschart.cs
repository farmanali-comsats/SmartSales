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
    public partial class Form_solditemschart : Form
    {
        SqlConnection con = new SqlConnection();
        mydatabase db = new mydatabase();
        SqlDataAdapter da = new SqlDataAdapter();
        Form_Records f;


        public Form_solditemschart(Form_Records f)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.f = f;
            this.KeyPreview = true;
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadsolitemschart()
        {
            con.Open();
            da = new SqlDataAdapter("select p.pdesc,sum(c.total) as total from table_cart as c inner join table_products as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + f.dts1.Value.ToString("yyyy-MM-dd") + "' and '" + f.dts2.Value.ToString("yyyy-MM-dd") + "' group by p.pdesc order by total desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sold");
            chart1.DataSource = ds.Tables["Sold"];
            Series series = this.chart1.Series[0];
            series.ChartType = SeriesChartType.Doughnut;

            series.Name = "Sold Items";
            chart1.Series[0].XValueMember = "pdesc";
            chart1.Series[0].YValueMembers = "total";
            chart1.Series[0].LabelFormat = "#,##0.00";
            chart1.Series[0].IsValueShownAsLabel = true;
            con.Close();
        }

        private void Form_solditemschart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
