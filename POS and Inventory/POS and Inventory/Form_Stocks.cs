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
    public partial class Form_Stocks : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        String stitle = "Smart Sales System";
        public Form_Stocks()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            loadvendor();
            this.KeyPreview = true;
        }

        public void loadstockin()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            con.Open();
            cm = new SqlCommand("select * from vwstockin where refno like '" + tft_referenceno.Text + "' and status like 'Pending'", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView2.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr["vendor"].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void loadstockinhistory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            con.Open();
            cm = new SqlCommand("select * from vwstockin where cast(sdate as date) between '" + dtp_1.Value.ToString("yyyy-MM-dd") + "' and '" + dtp_2.Value.ToString("yyyy-MM-dd") + "' and status like 'Done'", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), DateTime.Parse(dr[6].ToString()).ToString("yyyy-MM-dd"), dr[7].ToString(), dr["vendor"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void Form_Stocks_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tft_referenceno.Text != string.Empty && tft_stockinby.Text != string.Empty && cb_vendor.Text != string.Empty)
            {
                FormSearchinstockin myform = new FormSearchinstockin(this);
                myform.loadproducts();
                myform.tft_search.Enabled = true;
                myform.tft_search.Focus();
                myform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Enter Mandatory Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String colname = dataGridView2.Columns[e.ColumnIndex].Name;
                int ri = dataGridView2.CurrentRow.Index;
                //MessageBox.Show(colname);
                if (colname == "DELETE")
                {
                    deletefrom(ri);

                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void deletefrom(int ri)
        {
            try
            {
                if (MessageBox.Show("Remove this item?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("delete from table_stockin where id = '" + dataGridView2.Rows[ri].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("Item has been Successfully Deleted", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadstockin();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you Sure to Save this Record?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            //update table products
                            con.Open();
                            cm = new SqlCommand("update table_products set quantity = quantity +" + int.Parse(dataGridView2.Rows[i].Cells[6].Value.ToString()) + " where pcode like '" + dataGridView2.Rows[i].Cells[3].Value.ToString() + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();

                            //update table stockin
                            con.Open();
                            cm = new SqlCommand("update table_stockin set qty = qty +" + int.Parse(dataGridView2.Rows[i].Cells[6].Value.ToString()) + ",status = 'Done' where id like'" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "'", con);
                            cm.ExecuteNonQuery();
                            con.Close();
                        }
                        clear();
                        loadstockin();
                    }

                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void loadvendor()
        {
            try
            {
                cb_vendor.Items.Clear();
                con.Open();
                cm = new SqlCommand("select * from table_vendor order by vendor", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cb_vendor.Items.Add(dr["vendor"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void clear()
        {
            //tft_stockinby.Clear();
            tft_referenceno.Clear();
            Random r = new Random();
            tft_referenceno.Text += r.Next();
            dtp_stockindate.Value = DateTime.Now;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadstockinhistory();
        }

        private void cb_vendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cb_vendor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cb_vname.Text = "";
                tft_address.Text = "";
                cb_vname.Items.Clear();
                con.Open();
                cm = new SqlCommand("select * from table_vendor where vendor like '" + cb_vendor.Text + "'", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cb_vname.Items.Add(dr["contactperson"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                dr.Close();
                con.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            Random rn = new Random();
            tft_referenceno.Clear();
            tft_referenceno.Text += rn.Next();
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cb_vname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cm = new SqlCommand("select * from table_vendor where vendor like '" + cb_vendor.Text + "' and contactperson like '"+cb_vname.Text+"'", con);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    lbl_vid.Text = dr["id"].ToString();
                    //cb_vname.Text = dr["contactperson"].ToString();
                    tft_address.Text = dr["address"].ToString();
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_vname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count>0) {
                deleteallfrom();
            }
            else
            {
                return;
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int ri = dataGridView2.CurrentRow.Index;
                deletefrom(ri);
            }else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Delete)
            {
                btn_clear_Click(sender,e);
            }else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                btn_save_Click(sender,e);
            }
        }
        public void deleteallfrom()
        {
            try
            {
                if (MessageBox.Show("CLear all items?", "Smart Sales", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("delete from table_stockin where refno like '" + tft_referenceno.Text + "' and status like 'Pending'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("Item has been Successfully Deleted", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadstockin();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
