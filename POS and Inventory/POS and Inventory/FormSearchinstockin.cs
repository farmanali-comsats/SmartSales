﻿using System;
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
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        String stitle = "Simple POS System";
        Form_Stocks myform;
        public FormSearchinstockin(Form_Stocks form)
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            myform = form;
        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadproducts()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            con.Open(); cm = new SqlCommand("select pcode, pname, pdesc, quantity from table_products where pdesc like '%" + tft_search.Text + "%'or pname like '%" + tft_search.Text + "%'order by pname", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "Select")
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

        private void tft_search_Click(object sender, EventArgs e)
        {

        }
    }
}