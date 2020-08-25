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
    public partial class Form_Brand : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        mydatabase db = new mydatabase();
        public Form_Brand()
        {
            InitializeComponent();
            con = new SqlConnection(db.MyConnection());
            LoadRecords();
            this.KeyPreview = true;
        }

        private void picbox_addbrand_Click(object sender, EventArgs e)
        {
            Form_addbrand myform = new Form_addbrand(this);
            myform.ShowDialog();
        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            con.Open();
            cm = new SqlCommand("select * from table_brands order by brand", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "EDIT")
                {
                    Form_addbrand form = new Form_addbrand(this);
                    form.lblid.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                    form.tft_brandname.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                    form.btn_save.Enabled = false;
                    form.btn_update.Enabled = true;
                    form.ShowDialog();
                }
                else if (colname == "DELETE")
                {
                    if (MessageBox.Show("Are you sure you want to Delete this Brand?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cm = new SqlCommand("Delete from table_brands where id like'" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", con);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record has been Deleted Successfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRecords();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void pb_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_Brand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                picbox_addbrand_Click(sender, e);
            }
        }
    }
}
