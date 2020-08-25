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
    public partial class Form_vendorspurchases : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        public Form_vendorspurchases()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.KeyPreview = true;
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picbox_add_Click(object sender, EventArgs e)
        {
            Form_vendortotal f = new Form_vendortotal(this);
            f.tft_vid.Text = lbl_id.Text;

            f.ShowDialog();
        }

        private void Form_vendorspurchases_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.N)
            {
                picbox_add_Click(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "select")
                {
                    if (double.Parse(dataGridView1[6, e.RowIndex].Value.ToString()) > 0)
                    {
                        Form_vendortotal f = new Form_vendortotal(this);
                        f.tft_vid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        f.tft_cbill.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        f.tft_credit.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                        f.tft_debit.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                        f.tft_total.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                        f.btn_paynow.Enabled = false;
                        f.btn_paynow.Visible = false;
                        //f.btn_update.Visible = true;
                        //f.btn_update.Enabled = true;
                        f.tft_total.Enabled = false;
                        f.ShowDialog();
                    }
                }
                else if (colname == "delete")
                {
                    string vid = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    if (MessageBox.Show("Are you sure you want to Delete this Record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("Delete from table_vendorpurchases where cbill like'" + dataGridView1[3, e.RowIndex].Value.ToString() + "' and id like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();

                        double totalbalance = db.vendortotalbalance(vid);

                        con.Open();
                        cm = new SqlCommand("update table_vendorpurchases set tbalance = '" + totalbalance + "' where vid like '" + vid + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Record has been Deleted Successfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_vendorspurchases_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        public void loadvendorpurchases()
        {
            try
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                con.Open();
                cm = new SqlCommand("select * from table_vendorpurchases where vid like '" + lbl_id.Text + "' and cbill like '" + tft_search.Text + "%'", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
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

        private void Form_vendorspurchases_Load(object sender, EventArgs e)
        {
            loadvendorpurchases();
            vtbalance();
            vtotal();
        }

        private void tft_search_TextChanged(object sender, EventArgs e)
        {
            loadvendorpurchases();
        }
        public void vtotal()
        {
            int i = 0;
            double total = 0;
            try
            {
                con.Open();

                cm = new SqlCommand("select isnull(sum(vtotal),0) from table_vendorpurchases where vid like '" + lbl_id.Text + "'", con);

                total = double.Parse(cm.ExecuteScalar().ToString());
                //dr = cm.ExecuteReader();
                //while (dr.Read())
                //{
                //    i += 1;
                //    total += double.Parse(dr["total"].ToString());
                //}
                con.Close();
                lbl_total.Text = total.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void vtbalance()
        {
            String tbal;
            con.Open();
            cm = new SqlCommand("select top 1 tbalance from table_vendorpurchases where vid like '" + lbl_id.Text + "' order by id desc", con);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                tbal = dr[0].ToString();
                lbl_tbalance.Text = tbal;
            }
            else
            {
                lbl_tbalance.Text = "0.00";
            }
            dr.Close();
            con.Close();
        }

        private void Form_vendorspurchases_Activated(object sender, EventArgs e)
        {
            Form_vendorspurchases_Load(sender, e);
        }
    }
}
