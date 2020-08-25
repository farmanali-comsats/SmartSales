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
    public partial class Form_Adjustments : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form1 f;
        int _qty=0;
        public Form_Adjustments(Form1 fr)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            this.f = fr;
            this.KeyPreview = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_qty.Text != string.Empty && tft_remarks.Text != string.Empty && cb_action.Text != "")
                {
                    if (int.Parse(tft_qty.Text) > _qty)
                    {
                        MessageBox.Show("Stock on Hand should be greater than Adjustment Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (cb_action.Text == "Add To Inventory")
                    {
                        sqlstatement("update table_products set quantity = (quantity +" + int.Parse(tft_qty.Text) + ") where pcode like '" + tft_pcode.Text + "'");
                    }
                    else if (cb_action.Text == "Remove From Inventory")
                    {
                        sqlstatement("update table_products set quantity = (quantity -" + int.Parse(tft_qty.Text) + ") where pcode like '" + tft_pcode.Text + "'");
                    }
                    sqlstatement("insert into table_adjustments (refrenceno,pcode,qty,action,remarks,sdate,[user])values('" + tft_refno.Text + "','" + tft_pcode.Text + "','" + int.Parse(tft_qty.Text) + "','" + cb_action.Text + "','" + tft_remarks.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tft_user.Text + "')");

                    MessageBox.Show("Stock have been successfully adjusted", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadrecords();
                    clear();
                }
                else
                {
                    MessageBox.Show("Please Enter Mandatory Details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadrecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            con.Open();
            cm = new SqlCommand("select p.pcode, p.barcode, p.pname, p.pdesc, b.brand, c.category, p.price, p.quantity from table_products as p inner join table_brands as b on b.id = p.bid inner join table_category as c on c.id = p.cid where p.pname like '" + tft_search.Text + "%'", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void tft_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loadrecords();
            }
        }

        private void tft_search_TextChanged(object sender, EventArgs e)
        {
            loadrecords();
        }
        public void getrefno()
        {
            Random rn = new Random();
            tft_refno.Text += rn.Next();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colname == "Select")
            {
                tft_pcode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tft_desc.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()+" "+dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                _qty = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
        }
        public void sqlstatement(string _sql)
        {
            con.Open();
            cm = new SqlCommand(_sql,con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void clear()
        {
            tft_pcode.Clear();
            tft_desc.Clear();
            tft_qty.Clear();
            tft_refno.Clear();
            tft_remarks.Clear();
            cb_action.Text = "";
            getrefno();

        }

        private void Form_Adjustments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
