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
    public partial class Form_Records : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        private double equity;
        private double value;
        private double cost;
        private double price;
        private double quantity;
        public Form_Records()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
        }
        public void loadrecords()
        {
            try
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                con.Open();
                if (cb_sortby.Text =="Sort By Quantity")
                {
                    cm = new SqlCommand("select top 10 pcode, pdesc, isnull(sum(qty),0) as qty,isnull(sum(total),0) as total from View_Solditems where sdate between '" + dttop1.Value.ToString("yyyy-MM-dd") + "' and '" + dttop2.Value.ToString("yyyy-MM-dd") + "' and status like 'Sold' group by pcode, pdesc order by qty desc", con);
                }
                else if (cb_sortby.Text == "Sort By Total Amount")
                {
                    cm = new SqlCommand("select top 10 pcode, pdesc, isnull(sum(qty),0) as qty,isnull(sum(total),0) as total from View_Solditems where sdate between '" + dttop1.Value.ToString("yyyy-MM-dd") + "' and '" + dttop2.Value.ToString("yyyy-MM-dd") + "' and status like 'Sold' group by pcode, pdesc order by total desc", con);

                }
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i,dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(),double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void loadcriticalitems()
        {
            try
            {
                dataGridView3.Rows.Clear();
                int i = 0;
                con.Open();
                cm = new SqlCommand("select * from View_criticalStockitems", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView3.Rows.Add(i,dr[0].ToString(),dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void loadinventorylist()
        {
            try
            {
                dataGridView4.Rows.Clear();
                int i = 0;
                con.Open();
                cm = new SqlCommand("select p.pcode,p.barcode,p.pname,p.pdesc, b.brand,c.category,p.cost,p.price,p.quantity,p.reorder from table_products as p inner join table_brands as b on p.bid = b.id inner join table_category as c on p.cid = c.id", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView4.Rows.Add(i, dr["pcode"].ToString(), dr["barcode"].ToString(), dr["pname"].ToString(), dr["pdesc"].ToString(), dr["brand"].ToString(), dr["category"].ToString(), dr["cost"].ToString(), Double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["reorder"].ToString(), dr["quantity"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void loadcancelledorders()
        {
            try
            {
                dataGridView5.Rows.Clear();
                int i = 0;
                con.Open();
                cm = new SqlCommand("select * from ViewCancelOrders where sdate between '" + dtc1.Value.ToString("yyyy-MM-dd") + "' and '" + dtc2.Value.ToString("yyyy-MM-dd") + "'", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView5.Rows.Add(i, dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), Double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["qty"].ToString(), dr["total"].ToString(), dr["sdate"].ToString(), dr["voidby"].ToString(), dr["cancelledby"].ToString(), dr["reason"].ToString(), dr["action"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void loadstockhistory()
        {
            try
            {
                dataGridView6.Rows.Clear();
                int i = 0;
                dataGridView1.Rows.Clear();
                con.Open();
                cm = new SqlCommand("select * from vwstockin where cast(sdate as date) between '" + dtst1.Value.ToString("yyyy-MM-dd") + "' and '" + dtst2.Value.ToString("yyyy-MM-dd") + "' and status like 'Done'", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView6.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToString("yyyy-MM-dd"), dr[6].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linklbl_print_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView4.Rows.Count > 0)
            {
Form_InventoryReport frm = new Form_InventoryReport(this);
            frm.loadinventoryreport();
            frm.ShowDialog();
            }
            
        }

        private void btn_printcritical_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView3.Rows.Count > 0)
            {
Form_InventoryReport frm = new Form_InventoryReport(this);
            frm.loadcritical();
            frm.ShowDialog();
            }
            
        }

        private void btn_printtop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
Form_InventoryReport form = new Form_InventoryReport(this);
            form.loadtopreport();
            form.ShowDialog();
            }
            
        }

        private void btn_printsold_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (dataGridView2.Rows.Count > 0)
            {
 Form_InventoryReport form = new Form_InventoryReport(this);
            form.loadsoldreport();
            form.ShowDialog();
            }
           
        }

        private void btn_printcancelled_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView5.Rows.Count > 0)
            {
            Form_InventoryReport frm = new Form_InventoryReport(this);
            frm.loadcancelled();
            frm.ShowDialog();
            }
            
        }

        private void btn_printstockin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView6.Rows.Count>0)
            {
            Form_InventoryReport frm = new Form_InventoryReport(this);
            frm.loadstocksinhistory();
            frm.ShowDialog();
            }
            
        }

        private void cb_sortby_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void llbl_load_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cb_sortby.Text =="")
            {
                MessageBox.Show("Please select an option from the Dropdown list","Warning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            loadrecords();
            loadcharttopselling();
        }
        public void loadcharttopselling()
        {
            con.Open();
            if (cb_sortby.Text == "Sort By Quantity")
            {
                da = new SqlDataAdapter("select top 10 pcode, isnull(sum(qty),0) as qty from View_Solditems where sdate between '" + dttop1.Value.ToString("yyyy-MM-dd") + "' and '" + dttop2.Value.ToString("yyyy-MM-dd") + "' and status like 'Sold' group by pcode order by qty desc", con);
            }
            else if (cb_sortby.Text == "Sort By Total Amount")
            {
                da = new SqlDataAdapter("select top 10 pcode, isnull(sum(total),0) as total from View_Solditems where sdate between '" + dttop1.Value.ToString("yyyy-MM-dd") + "' and '" + dttop2.Value.ToString("yyyy-MM-dd") + "' and status like 'Sold' group by pcode order by total desc", con);
            }

            DataSet ds = new DataSet();
            da.Fill(ds,"Topselling");
            chart1.DataSource = ds.Tables["Topselling"];
            Series series = chart1.Series[0];
            series.ChartType = SeriesChartType.Doughnut;

            series.Name = "Top Selling";
            var chart = chart1;
            chart.Series[0].XValueMember = "pcode";
            if (cb_sortby.Text == "Sort By Quantity") { chart.Series[0].YValueMembers = "qty"; }
            if (cb_sortby.Text == "Sort By Total Amount") { chart.Series[0].YValueMembers = "total"; }
            chart.Series[0].IsValueShownAsLabel = true;
            if (cb_sortby.Text == "Sort By Quantity") { chart.Series[0].LabelFormat = "#,##0"; }
            if (cb_sortby.Text == "Sort By Total Amount") { chart.Series[0].LabelFormat = "#,##0.00"; }
            con.Close();
        }

        private void llbl_soldchart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView2.Rows.Count>0)
            {
            Form_solditemschart form = new Form_solditemschart(this);
            form.lbl_title.Text = "Sold Items[" + dts1.Value.ToShortDateString() + " - " + dts2.Value.ToShortDateString() + "]";
            form.loadsolitemschart();
            form.ShowDialog();
            }
           
        }

        private void llbl_loadcancelled_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadcancelledorders();
        }

        private void llbl_loadstockin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadstockhistory();
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_Records_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tab_topselling;
        }

        private void btn_equity_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_equity.Text) != 0)
            {
                lbl_equity.Text = "0.00";
            }
            else
            {
                equitycalculate();
            }
        }
        public void equitycalculate()
        {
            equity = 0;
            int i = 0;
            //String sdate = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                con.Open();
                cm = new SqlCommand("select cost,quantity from table_products", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    cost = double.Parse(dr["cost"].ToString());
                    quantity = double.Parse(dr["quantity"].ToString());
                    equity += (cost * quantity);
                }
                
                con.Close();
                lbl_equity.Text = equity.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void valuecalculate()
        {
            value = 0;
            int i = 0;
            //String sdate = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                con.Open();
                cm = new SqlCommand("select price,quantity from table_products", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    price = double.Parse(dr["price"].ToString());
                    quantity = double.Parse(dr["quantity"].ToString());
                    value += (price * quantity);
                }

                con.Close();

                lbl_value.Text = value.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_value_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_value.Text) != 0)
            {
                lbl_value.Text = "0.00";
            }
            else
            {
                valuecalculate();
            }
        }

        private void llbl_soldload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                int i = 0;
                con.Open();
                cm = new SqlCommand("select c.pcode, p.pname,p.pdesc,c.price, sum(c.qty) as tot_qty, sum(c.disc) as tot_disc,sum(c.total) as total from table_cart as c inner join table_products as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dts1.Value.ToString("yyyy-MM-dd") + "' and '" + dts2.Value.ToString("yyyy-MM-dd") + "' group by c.pcode, p.pdesc, c.price,p.pname", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView2.Rows.Add(i, dr["pcode"].ToString(), dr["pname"].ToString(), dr["pdesc"].ToString(), Double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["tot_qty"].ToString(), dr["tot_disc"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                con.Close();

                con.Open();
                cm = new SqlCommand("select isnull(sum(total),0) from table_cart where status like 'Sold' and sdate between '" + dts1.Value.ToString("yyyy-MM-dd") + "' and '" + dts2.Value.ToString("yyyy-MM-dd") + "'", con);
                lbl_total.Text = Double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");
                con.Close();

                con.Open();
                cm = new SqlCommand("select isnull(sum(balance),0) from table_cart where status like 'Sold' and sdate between '" + dts1.Value.ToString("yyyy-MM-dd") + "' and '" + dts2.Value.ToString("yyyy-MM-dd") + "'", con);
                lbl_debitedsales.Text = Double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");
                con.Close();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
