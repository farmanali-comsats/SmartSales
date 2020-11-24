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
    public partial class FormSearchinstockin : Form
    {
        Timer timer = new Timer();
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        String stitle = "Smart Sales System";
        Form_Stocks myform;
        bool ch = false;
        public FormSearchinstockin(Form_Stocks form)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            myform = form;
            this.KeyPreview = true;
        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadproducts()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            con.Open(); cm = new SqlCommand("select pcode, pname, pdesc, c.category,quantity, v.vendor from table_products as p inner join table_vendor as v on v.id = p.vid inner join table_category as c on c.id = p.cid where (pdesc like '%" + tft_search.Text + "%'or pname like '%" + tft_search.Text + "%' or barcode like '%" + tft_search.Text + "%' or v.vendor like '%" + tft_search.Text + "%') order by pname", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void loadproductsbc()
        {
            try
            {
                timer.Interval = (4000);
                String rowipc = String.Empty;
                if (dataGridView1.Rows.Count>0)
                {
                rowipc = dataGridView1.Rows[0].Cells[1].Value.ToString();

                }
                if (checkstock(rowipc))
                {
                    //MessageBox.Show("Found");
                }
                else
                {
                    int i = 0;
                    dataGridView1.Rows.Clear();
                    con.Open(); cm = new SqlCommand("select pcode, pname, pdesc, quantity from table_products where barcode like '%" + tft_bcode.Text + "%'", con);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i++;
                        dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                    }
                    dr.Close();
                    con.Close();

                    if (dataGridView1.Rows.Count == 1)
                    {
                        
                        timer.Tick += new EventHandler(clearbarcode);
                        timer.Start();

                        con.Open();
                        cm = new SqlCommand("insert into table_stockin (refno,pcode,sdate,stockby,vendorid)values(@refno,@pcode,@sdate,@stockby,@vendorid)", con);
                        cm.Parameters.AddWithValue("@refno", myform.tft_referenceno.Text);
                        cm.Parameters.AddWithValue("@pcode", dataGridView1.Rows[0].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@sdate", myform.dtp_stockindate.Value);
                        cm.Parameters.AddWithValue("@stockby", myform.tft_stockinby.Text);
                        cm.Parameters.AddWithValue("@vendorid", myform.lbl_vid.Text);
                        cm.ExecuteNonQuery();
                        con.Close();

                        myform.loadstockin();
                    }
                    timer.Tick += new EventHandler(clearbarcode);
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                dr.Close();
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String colname = dataGridView1.Columns[e.ColumnIndex].Name;
                String rowipc = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string rpc = String.Empty;
                if (colname == "Select")
                {
                    if (checkstock(rowipc))
                    {
                        //foreach (DataGridViewRow row in myform.dataGridView2.Rows)
                        //{
                        //    //MessageBox.Show(rowipc + "<----->" + row.Cells[1].Value.ToString());
                        //    if (row.Cells[3].Value.ToString().Contains(rowipc))
                        //    {
                        //        //MessageBox.Show(rowipc+"<----->"+ row.Cells[1].Value.ToString());
                        //        //int ri = ;
                        //        //myform.dataGridView2.Rows[1].Cells[5].Value = "11";
                        //        row.Cells[5].Value = "1";
                        //    }
                                
                        //}
                        //int ri = myform.dataGridView2.
                        //myform.dataGridView2.Rows[].Cells[5].Value = 1;
                    }
                    else
                    {
                        if (myform.tft_referenceno.Text == string.Empty)
                        {
                            MessageBox.Show("Please Enter Reference No", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            myform.tft_referenceno.Focus();
                            return;
                        }
                        if (myform.tft_stockinby.Text == string.Empty)
                        {
                            MessageBox.Show("Please Enter Stock In by Name!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            myform.tft_stockinby.Focus();
                            return;
                        }
                        if (MessageBox.Show("Add this item?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.Open();
                            cm = new SqlCommand("insert into table_stockin (refno,pcode,sdate,stockby,vendorid)values(@refno,@pcode,@sdate,@stockby,@vendorid)", con);
                            cm.Parameters.AddWithValue("@refno", myform.tft_referenceno.Text);
                            cm.Parameters.AddWithValue("@pcode", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                            cm.Parameters.AddWithValue("@sdate", myform.dtp_stockindate.Value);
                            cm.Parameters.AddWithValue("@stockby", myform.tft_stockinby.Text);
                            cm.Parameters.AddWithValue("@vendorid", myform.lbl_vid.Text);
                            cm.ExecuteNonQuery();
                            con.Close();


                            //MessageBox.Show("Successfully Added!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            myform.loadstockin();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tft_search_TextChanged(object sender, EventArgs e)
        {
            loadproducts();
        }
        public void clearbarcode(object sender, EventArgs e)
        {
            tft_bcode.Text = String.Empty;
            loadproductsbc();
        }

        private void FormSearchinstockin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void chb_bcode_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_bcode.Checked == true)
            {
                tft_bcode.Enabled = true;
                tft_bcode.Visible = true;
                tft_search.Enabled = false;
                tft_search.Visible = false;
            }
            else
            {
                tft_search.Enabled = true;
                tft_search.Visible = true;
                tft_bcode.Enabled = false;
                tft_bcode.Visible = false;
            }
        }

        private void tft_bcode_TextChanged(object sender, EventArgs e)
        {
            loadproductsbc();
        }
        public bool checkstock(string val)
        {
            int i = 0;
            string pc = String.Empty;
            con.Open();
            cm = new SqlCommand("select pcode from table_stockin where refno like '%" + myform.tft_referenceno.Text + "%' and pcode like '%" + val + "%'", con);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                pc = dr["pcode"].ToString();
            }
            dr.Close();
            con.Close();

            if (val == pc)
            {

                ch = true;
            }
            else
            {

                ch = false;
            }


            return ch;

        }
        public void loadbybarcode()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            con.Open(); cm = new SqlCommand("select pcode, pname, pdesc, quantity from table_products where pdesc like '%" + tft_search.Text + "%'or pname like '%" + tft_search.Text + "%' or barcode like '%" + tft_search.Text + "%' order by pname", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();

            con.Open();
            cm = new SqlCommand("insert into table_stockin (refno,pcode,sdate,stockby,vendorid)values(@refno,@pcode,@sdate,@stockby,@vendorid)", con);
            cm.Parameters.AddWithValue("@refno", myform.tft_referenceno.Text);
            cm.Parameters.AddWithValue("@pcode", dataGridView1.Rows[0].Cells[1].Value.ToString());
            cm.Parameters.AddWithValue("@sdate", myform.dtp_stockindate.Value);
            cm.Parameters.AddWithValue("@stockby", myform.tft_stockinby.Text);
            cm.Parameters.AddWithValue("@vendorid", myform.lbl_vid.Text);
            cm.ExecuteNonQuery();
            con.Close();

        }
    }
}
