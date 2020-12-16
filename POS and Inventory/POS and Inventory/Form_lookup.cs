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
    public partial class Form_lookup : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_POS myform;
        String stitle = "POS System";
        public Form_lookup(Form_POS frm)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            myform = frm;
            this.KeyPreview = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadrecords()
        {
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                con.Open();
                cm = new SqlCommand("select p.pcode, p.barcode, p.pname, p.pdesc, b.brand, c.category, p.cost,p.price, p.quantity from table_products as p inner join table_brands as b on b.id = p.bid inner join table_category as c on c.id = p.cid where p.pdesc like '%" + tft_search.Text + "%'  or p.pname like '%" + tft_search.Text + "%' or b.brand like '" + tft_search.Text + "%'or c.category like '" + tft_search.Text + "%'", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
            }
        }

        private void tft_search_TextChanged(object sender, EventArgs e)
        {
            loadrecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "Select")
                {
                    Formqty frm = new Formqty(myform);
                    frm.productdetails(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()), double.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString()), myform.lbl_trcode.Text, int.Parse(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString()));
                    dr.Close();
                    con.Close();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Form_lookup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }else if (e.KeyCode == Keys.F3)
            {
                tft_search.Focus();
                tft_search.SelectAll();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                
                if (e.KeyCode ==Keys.Enter)
                {
                    int ri = dataGridView1.CurrentRow.Index;
                    Formqty frm = new Formqty(myform);
                    frm.productdetails(dataGridView1.Rows[ri].Cells[1].Value.ToString(), double.Parse(dataGridView1.Rows[ri].Cells[7].Value.ToString()), double.Parse(dataGridView1.Rows[ri].Cells[8].Value.ToString()), myform.lbl_trcode.Text, int.Parse(dataGridView1.Rows[ri].Cells[9].Value.ToString()));
                    dr.Close();
                    con.Close();
                    frm.ShowDialog();
                }
                else if(e.KeyCode == Keys.Escape)
                {
                    this.Dispose();
                }else if (e.KeyCode == Keys.F3)
                {
                    tft_search.Focus();
                    tft_search.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
