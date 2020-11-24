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

namespace POS_and_Inventory
{
    public partial class Form_products : Form
    {
        String stitle = "Smart Sales System";
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        public Form_products()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
        }

        private void picbox_addproduct_Click(object sender, EventArgs e)
        {
            Form_addproduct formproduct = new Form_addproduct(this);
            formproduct.btn_save.Enabled = true;
            formproduct.btn_update.Enabled = false;
            formproduct.loadbrand();
            formproduct.loadproductcode();
            formproduct.loadcategory();
            formproduct.ShowDialog();
        }
        public void loadrecords()
        {
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                con.Open();
                cm = new SqlCommand("select p.pcode, p.barcode, p.pname, p.pdesc, b.brand, c.category,p.cost, p.price, p.reorder, v.vendor from table_products as p inner join table_brands as b on b.id = p.bid inner join table_category as c on c.id = p.cid inner join table_vendor as v on v.id = p.vid where (p.pname like '%" + tft_search.Text + "%' or p.pdesc like '%" + tft_search.Text + "%' or p.barcode like '" + tft_search.Text + "%' or v.vendor like '" + tft_search.Text + "%' or b.brand like '" + tft_search.Text + "%' or c.category like '" + tft_search.Text + "%')", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                dr.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string vname = string.Empty;
                String colname = dataGridView1.Columns[e.ColumnIndex].Name;
                int ri;
                if (colname == "EDIT")
                {
                    Form_addproduct myform = new Form_addproduct(this);
                    myform.btn_save.Enabled = false;
                    myform.btn_update.Enabled = true;
                    myform.tft_pcode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    myform.tft_barcode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    myform.tft_pname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    myform.tft_pdescription.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    myform.cb_brand.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    myform.cb_category.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    myform.tft_cost.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    myform.tft_price.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    myform.tft_reorder.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    myform.cb_vendor.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    
                    ri = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    
                    vname = getvendor(ri);
                    myform.cb_vname.Text = vname;
                    String bcodde = myform.tft_barcode.Text;
                    String[] bcode;
                    if (bcodde != String.Empty)
                    {
                        bcode = bcodde.Split(' ');
                        foreach (String word in bcode)
                        {
                            if (word == "SR")
                            {
                                MemoryStream stream = new MemoryStream();
                                con.Open();
                                SqlCommand command = new SqlCommand("select barcode_image from table_products where pcode like'" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                                byte[] image = (byte[])command.ExecuteScalar();
                                stream.Write(image, 0, image.Length);
                                con.Close();
                                Bitmap bitmap = new Bitmap(stream);
                                myform.pictureBox_barcode.Image = bitmap;
                                con.Close();
                            }
                        }
                    }

                    myform.btn_save.Enabled = false;
                    myform.btn_update.Enabled = true;
                    myform.ShowDialog();
                }
                else if (colname == "DELETE")
                {
                    if (MessageBox.Show("Are you sure you want to Delete this Product?", "Delete product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("Delete from table_products where pcode like'" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product has been Deleted Successfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadrecords();
                    }
                }

            }
            catch (Exception ex)
            {
                con.Close();
                dr.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public string getvendor(int val)
        {
            String vn = "";
            try
            {
                
                Form_addproduct myform = new Form_addproduct(this);
                con.Open();
                cm = new SqlCommand("select vid from table_products where pcode like '" + dataGridView1.Rows[val].Cells[1].Value.ToString() + "'", con);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    myform.lbl_vid.Text = dr["vid"].ToString();
                    //cb_vname.Text = dr["contactperson"].ToString();
                    //tft_address.Text = dr["address"].ToString();
                }
                dr.Close();
                con.Close();

                con.Open();
                cm = new SqlCommand("select contactperson from table_vendor where id like '" + myform.lbl_vid.Text + "'", con);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    //myform.lbl_vid.Text = dr["vid"].ToString();
                    //cb_vname.Text = dr["contactperson"].ToString();
                    //tft_address.Text = dr["address"].ToString();
                    vn  = dr["contactperson"].ToString();
                    //MessageBox.Show(myform.cb_vname.Text);
                }
                dr.Close();
                con.Close();

                //myform.cb_vname.Text = vn;
            }
            catch (Exception ex)
            {
                con.Close();
                dr.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return vn;
        }
        private void Form_products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                picbox_addproduct_Click(sender, e);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                picbox_addproduct_Click(sender, e);
            }
        }

        private void tft_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                picbox_addproduct_Click(sender, e);
            }
        }
    }
}
