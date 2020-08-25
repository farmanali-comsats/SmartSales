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
using System.Windows.Forms.VisualStyles;

namespace POS_and_Inventory
{
    public partial class Form_addproduct : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_products formproduct;
        public Form_addproduct(Form_products frm)
        {
            InitializeComponent();
            //tft_pcode.Focus();
            con = new SqlConnection(db.MyConnection());
            formproduct = frm;
            this.KeyPreview = true;
        }
        public void loadcategory()
        {
            cb_category.Items.Clear();
            con.Open();
            cm = new SqlCommand("select category from table_category",con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cb_category.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void loadbrand()
        {
            cb_brand.Items.Clear();
            con.Open();
            cm = new SqlCommand("select brand from table_brands", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cb_brand.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
            this.Dispose();
        }

        private void Form_addproduct_Load(object sender, EventArgs e)
        {
            //loadproductcode();
            loadbrand();
            loadcategory();
        }
        public void loadproductcode()
        {
            String getpcode = "", pcodetokens = "", newpcode="";
            int ipcode = 0;
            con.Open();
            cm = new SqlCommand("SELECT TOP 1 * FROM table_products ORDER BY pcode desc", con);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                getpcode = dr[0].ToString();
                string[] words = getpcode.Split('P');
                foreach (string word in words)
                {
                    pcodetokens = word;
                }
                ipcode = (int.Parse(pcodetokens))+1;
                newpcode = "P"+ipcode.ToString();
                tft_pcode.Text = newpcode;
            }
            else
            {
                tft_pcode.Text = "P100001";
            }
            dr.Close();
            con.Close();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tft_pname.Text!=string.Empty&& tft_pdescription.Text != string.Empty && tft_cost.Text != string.Empty && tft_price.Text != string.Empty&& cb_brand.Text!=""&&cb_category.Text!="") {
                    if (MessageBox.Show("Confirm to Save this Product", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String bid = "", cid = "";
                        con.Open();
                        cm = new SqlCommand("Select id from table_brands where brand like '" + cb_brand.Text + "'", con);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows) {
                            bid = dr[0].ToString();
                        }
                        dr.Close();
                        con.Close();

                        con.Open();
                        cm = new SqlCommand("Select id from table_category where category like '" + cb_category.Text + "'", con);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows) {
                            cid = dr[0].ToString();
                        }
                        dr.Close();
                        con.Close();

                        con.Open();
                        cm = new SqlCommand("INSERT INTo table_products(pcode,barcode, pname, pdesc,bid,cid,cost, price,reorder)VALUEs(@pcode,@barcode, @pname, @pdesc,@bid,@cid,@cost,@price,@reorder)", con);
                        cm.Parameters.AddWithValue("@pcode", tft_pcode.Text);
                        cm.Parameters.AddWithValue("@barcode", tft_barcode.Text);
                        cm.Parameters.AddWithValue("@pname", tft_pname.Text);
                        cm.Parameters.AddWithValue("@pdesc", tft_pdescription.Text);
                        cm.Parameters.AddWithValue("@bid", bid);
                        cm.Parameters.AddWithValue("@cid", cid);
                        cm.Parameters.AddWithValue("@cost", Double.Parse(tft_cost.Text));
                        cm.Parameters.AddWithValue("@price", Double.Parse(tft_price.Text));
                        cm.Parameters.AddWithValue("@reorder", int.Parse(tft_reorder.Text));
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product Saved Successfully");
                        clear();
                        formproduct.loadrecords();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Required Information!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                } 
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }
        public void clear()
        {
            tft_pname.Clear();
            tft_pcode.Clear();
            tft_barcode.Clear();
            tft_pdescription.Clear();
            cb_brand.Text = "";
            cb_category.Text = "";
            tft_reorder.Clear();
            tft_pname.Focus();
            btn_save.Enabled = true;
            tft_price.Clear();
            tft_cost.Clear();
            btn_update.Enabled = false;
            tft_reorder.Text = "0";
            loadproductcode();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateptoducts();
        }

        private void tft_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==8)
            {

            }else if (e.KeyChar==46)
            {

            }else if ((e.KeyChar<48)||(e.KeyChar>57))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadproductcode();
        }

        private void pb_brand_Click(object sender, EventArgs e)
        {
            Form_Brand b = new Form_Brand();
            Form_addbrand f = new Form_addbrand(b);
            f.ShowDialog();
            loadbrand();
        }

        private void pb_category_Click(object sender, EventArgs e)
        {
            Form_category c = new Form_category();
            Form_addcategory f = new Form_addcategory(c);
            f.ShowDialog();
            loadcategory();
        }

        private void Form_addproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            
            if (e.KeyCode == Keys.Enter)
            {
                btn_save_Click(sender,e);
            }
        }
        public void updateptoducts()
        {
            try
            {
                if (tft_pname.Text != string.Empty && tft_pdescription.Text != string.Empty && tft_cost.Text != string.Empty && tft_price.Text != string.Empty && cb_brand.Text != "" && cb_category.Text != "")
                {
                    if (MessageBox.Show("Confirm to Update this Product", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String bid = "", cid = "";
                        con.Open();
                        cm = new SqlCommand("Select id from table_brands where brand like '" + cb_brand.Text + "'", con);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            bid = dr[0].ToString();
                        }
                        dr.Close();
                        con.Close();

                        con.Open();
                        cm = new SqlCommand("Select id from table_category where category like '" + cb_category.Text + "'", con);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            cid = dr[0].ToString();
                        }
                        dr.Close();
                        con.Close();

                        con.Open();
                        cm = new SqlCommand("update table_products set pname=@pname, pdesc=@pdesc, bid=@bid, cid=@cid,cost=@cost, price=@price, reorder=@reorder where (pcode like @pcode)", con);
                        
                        cm.Parameters.AddWithValue("@barcode", tft_barcode.Text);
                        cm.Parameters.AddWithValue("@pname", tft_pname.Text);
                        cm.Parameters.AddWithValue("@pdesc", tft_pdescription.Text);
                        cm.Parameters.AddWithValue("@bid", bid);
                        cm.Parameters.AddWithValue("@cid", cid);
                        cm.Parameters.AddWithValue("@cost", Double.Parse(tft_cost.Text));
                        cm.Parameters.AddWithValue("@price", Double.Parse(tft_price.Text));
                        cm.Parameters.AddWithValue("@reorder", int.Parse(tft_reorder.Text));
                        cm.Parameters.AddWithValue("@pcode", tft_pcode.Text);
                        cm.ExecuteNonQuery();

                        var rowsUpdated = cm.ExecuteNonQuery();
                        con.Close();

                        if (rowsUpdated > 0) MessageBox.Show("Product Updated Successfully");
                        else MessageBox.Show("Product NOT Updated Successfully");

                       
                        //MessageBox.Show("Product Updated Successfully");
                        clear();
                        formproduct.loadrecords();
                        this.Dispose();
                    }
                }

                else
                {
                    MessageBox.Show("Please Enter the Required Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void tft_percent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cost = double.Parse(tft_cost.Text);
                double percent = double.Parse(tft_percent.Text);
                double price = cost * (percent / 100);
                price = cost + price;

                double pricee = Math.Ceiling(price);
                
                tft_price.Text = pricee.ToString();
            }
            catch (Exception ex)
            {

            }
        }       

        private void tft_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cost = double.Parse(tft_cost.Text);
                double percent = double.Parse(tft_percent.Text);
                double price = cost * (percent / 100);
                price = cost + price;

                double pricee = Math.Ceiling(price);

                tft_price.Text = pricee.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
