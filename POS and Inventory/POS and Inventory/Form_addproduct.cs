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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZXing;
using System.IO;
using System.Drawing.Imaging;

namespace POS_and_Inventory
{
    public partial class Form_addproduct : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        mydatabase db = new mydatabase();
        SqlDataReader dr;
        Form_products formproduct;
        String stitle = "Smart Sales System";
        static bool ch = true;
        int mov, movx, movy;
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
            try
            {
                cb_category.Items.Clear();
                con.Open();
                cm = new SqlCommand("select category from table_category order by category ", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cb_category.Items.Add(dr[0].ToString());
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
        public void loadbrand()
        {
            try
            {
                cb_brand.Items.Clear();
                con.Open();
                cm = new SqlCommand("select brand from table_brands order by brand", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cb_brand.Items.Add(dr[0].ToString());
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
            this.Dispose();
        }

        private void Form_addproduct_Load(object sender, EventArgs e)
        {
            //loadproductcode();
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            loadbrand();
            loadcategory();
            loadvendor();
        }
        public void loadproductcode()
        {
            try
            {
                String getpcode = "", pcodetokens = "", newpcode = "";
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
                    ipcode = (int.Parse(pcodetokens)) + 1;
                    newpcode = "P" + ipcode.ToString();
                    tft_pcode.Text = newpcode;
                }
                else
                {
                    tft_pcode.Text = "P100001";
                }
                dr.Close();
                con.Close();
                tft_barcode.Text = "SR " + tft_pcode.Text;
                tft_barcode.SelectAll();
            }
            catch (Exception ex)
            {
                con.Close();
                dr.Close();
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
                dr.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] pic = null;
                MemoryStream mem;
                String receiptdir = @"D:\SmatSalesReports\Barcodes";
                if (tft_pname.Text != string.Empty && tft_pdescription.Text != string.Empty && tft_cost.Text != string.Empty && tft_price.Text != string.Empty && cb_brand.Text != "" && cb_category.Text != "" && cb_vendor.Text != "" && cb_vname.Text != "")
                {
                    if (bcodecheck(tft_barcode.Text.Trim().ToLower()))
                    {
                        MessageBox.Show("You are trying to add existing product again");
                    }
                    else
                    {
                        if (MessageBox.Show("Confirm to Save this Product", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (pictureBox_barcode.Image != null)
                            {
                                mem = new MemoryStream();
                                pictureBox_barcode.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Png);
                                pic = mem.ToArray();
                            }

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
                            if (pictureBox_barcode.Image != null)
                            {
                                cm = new SqlCommand("INSERT INTo table_products(pcode,barcode, pname, pdesc,bid,cid,cost, price,reorder,barcode_image,vid)VALUEs(@pcode,@barcode, @pname, @pdesc,@bid,@cid,@cost,@price,@reorder,@barcode_image,@vid)", con);
                            }
                            else
                            {
                                cm = new SqlCommand("INSERT INTo table_products(pcode,barcode, pname, pdesc,bid,cid,cost, price,reorder,vid)VALUEs(@pcode,@barcode, @pname, @pdesc,@bid,@cid,@cost,@price,@reorder,@vid)", con);
                            }
                            cm.Parameters.AddWithValue("@pcode", tft_pcode.Text);
                            cm.Parameters.AddWithValue("@barcode", tft_barcode.Text.Trim());
                            cm.Parameters.AddWithValue("@pname", tft_pname.Text.Trim());
                            cm.Parameters.AddWithValue("@pdesc", tft_pdescription.Text.Trim());
                            cm.Parameters.AddWithValue("@bid", bid);
                            cm.Parameters.AddWithValue("@cid", cid);
                            cm.Parameters.AddWithValue("@cost", Double.Parse(tft_cost.Text));
                            cm.Parameters.AddWithValue("@price", Double.Parse(tft_price.Text));
                            cm.Parameters.AddWithValue("@reorder", int.Parse(tft_reorder.Text));
                            cm.Parameters.AddWithValue("@vid", int.Parse(lbl_vid.Text));

                            FileStream fs;
                            if (pictureBox_barcode.Image != null)
                            {
                                cm.Parameters.AddWithValue("@barcode_image", pic);

                                string strfn = Application.StartupPath + @"\Barcodes\SR-" + tft_pcode.Text + ".png";
                                String filename1 = receiptdir+"\\SR-" + tft_pcode.Text + ".png";
                                if (!Directory.Exists(receiptdir))
                                {
                                    Directory.CreateDirectory(receiptdir);
                                }
                                if (File.Exists(strfn) || File.Exists(filename1))
                                {
                                    fs = new FileStream(strfn, FileMode.Append, FileAccess.Write);
                                    fs = new FileStream(filename1, FileMode.Append, FileAccess.Write);
                                    fs.Write(pic, 0, pic.Length);
                                    fs.Flush();
                                    fs.Close();
                                }
                                else
                                {
                                    fs = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);
                                    fs = new FileStream(filename1, FileMode.CreateNew, FileAccess.Write);
                                    fs.Write(pic, 0, pic.Length);
                                    fs.Flush();
                                    fs.Close();
                                }                                
                                

                            }
                            else
                            {
                                //cm.Parameters.AddWithValue("@barcode_image", null);
                            }

                            //saving barcodes locally



                            cm.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Product Saved Successfully");
                            clear();
                            formproduct.loadrecords();


                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Required Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                dr.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cb_vendor.Text = "";
            cb_vname.Text = "";
            tft_reorder.Clear();
            tft_barcode.Focus();
            btn_save.Enabled = true;
            tft_price.Clear();
            tft_cost.Clear();
            btn_update.Enabled = false;
            tft_reorder.Text = "1";
            tft_percent.Text = "0.00";
            lbl_vid.Text = "";
            pictureBox_barcode.Image = null;
            loadproductcode();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateptoducts();
        }

        private void tft_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {

            }
            else if (e.KeyChar == 46)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
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
                if (btn_save.Enabled == true)
                {
                    btn_save_Click(sender, e);
                }
                if (btn_update.Enabled == true)
                {
                    btn_update_Click(sender, e);
                }

            }
        }
        public void updateptoducts()
        {
            try
            {
                byte[] pic = null;
                MemoryStream mem;
                if (tft_pname.Text != string.Empty && tft_pdescription.Text != string.Empty && tft_cost.Text != string.Empty && tft_price.Text != string.Empty && cb_brand.Text != "" && cb_category.Text != "" && cb_vendor.Text != "" && cb_vname.Text != "" && ch != false)
                {
                    if (MessageBox.Show("Confirm to Update this Product", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (pictureBox_barcode.Image != null)
                        {
                            mem = new MemoryStream();
                            pictureBox_barcode.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Png);
                            pic = mem.ToArray();
                        }

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
                        if (pictureBox_barcode.Image != null)
                        {
                            cm = new SqlCommand("update table_products set  pname=@pname, pdesc=@pdesc, bid=@bid, cid=@cid,cost=@cost, price=@price, reorder=@reorder, barcode_image=@barcode_image, vid=@vid where (pcode like @pcode)", con);
                        }
                        else
                        {
                            cm = new SqlCommand("update table_products set barcode=@barcode, pname=@pname, pdesc=@pdesc, bid=@bid, cid=@cid,cost=@cost, price=@price, reorder=@reorder, vid= @vid where (pcode like @pcode)", con);
                        }
                        cm.Parameters.AddWithValue("@barcode", tft_barcode.Text);
                        cm.Parameters.AddWithValue("@pname", tft_pname.Text);
                        cm.Parameters.AddWithValue("@pdesc", tft_pdescription.Text);
                        cm.Parameters.AddWithValue("@bid", int.Parse(bid));
                        cm.Parameters.AddWithValue("@cid", int.Parse(cid));
                        cm.Parameters.AddWithValue("@cost", Double.Parse(tft_cost.Text));
                        cm.Parameters.AddWithValue("@price", Double.Parse(tft_price.Text));
                        cm.Parameters.AddWithValue("@reorder", int.Parse(tft_reorder.Text));
                        cm.Parameters.AddWithValue("@vid", int.Parse(lbl_vid.Text));
                        if (pictureBox_barcode.Image != null) { cm.Parameters.AddWithValue("@barcode_image", pic); }
                        else
                        { //cm.Parameters.AddWithValue("@barcode_image", pic); 
                        }
                        cm.Parameters.AddWithValue("@pcode", tft_pcode.Text);
                        cm.ExecuteNonQuery();

                        var rowsUpdated = cm.ExecuteNonQuery();
                        con.Close();

                        //saving barcodes locally
                        //byte[] pic;
                        //MemoryStream mem = new MemoryStream();
                        //pictureBox1.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Png);
                        //pic = mem.ToArray();
                        if (pictureBox_barcode.Image != null)
                        {
                            string filename = "SR " + tft_pcode.Text;
                            //string filepath = Application.StartupPath + @"\\Barcodes\\" + filename + ".png";
                            string strfn = Convert.ToString(Application.StartupPath + @"\\Barcodes\\" + filename + ".png");

                            FileStream fs;
                            if (File.Exists(strfn))
                            {
                                fs = new FileStream(strfn, FileMode.Append, FileAccess.Write);
                                fs.Write(pic, 0, pic.Length);
                                fs.Flush();
                                fs.Close();
                            }
                            else
                            {
                                fs = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);

                                fs.Write(pic, 0, pic.Length);
                                fs.Flush();
                                fs.Close();
                            }

                        }

                        if (rowsUpdated > 0) MessageBox.Show("Product Updated Successfully");
                        else MessageBox.Show("Product NOT Updated Successfully");


                        //("Product Updated Successfully");
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
                dr.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tft_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tft_cost.Text != String.Empty)
                {
                    double cost = double.Parse(tft_cost.Text);
                    double percent = double.Parse(tft_percent.Text);
                    double price = cost * (percent / 100);
                    price = cost + price;

                    double pricee = Math.Ceiling(price);

                    tft_price.Text = pricee.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeWriter bc = new BarcodeWriter()
                {
                    Format = BarcodeFormat.CODE_128
                };
                pictureBox_barcode.Image = bc.Write(tft_barcode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cb_vname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();
               
                    con.Open();
                    cm = new SqlCommand("select * from table_vendor where vendor like '" + cb_vendor.Text + "' and contactperson like '" + cb_vname.Text + "'", con);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        lbl_vid.Text = dr["id"].ToString();
                        //cb_vname.Text = dr["contactperson"].ToString();
                        //tft_address.Text = dr["address"].ToString();
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

        private void cb_brand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                pb_brand_Click(sender, e);
            }
        }

        private void cb_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                pb_category_Click(sender, e);
            }
        }

        private void tft_barcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] asa = new string[10];
                string bc = tft_barcode.Text.Trim().ToLower();
                if (bcodecheck(bc))
                {
                    if (btn_save.Enabled == true)
                    {
                        if ((MessageBox.Show("Load product to form ?", "Existing Product Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            con.Open();
                            cm = new SqlCommand("select pcode, pname, pdesc,b.brand,c.category,cost,price,reorder,v.vendor,v.contactperson from table_products as p inner join table_brands as b on b.id = p.bid inner join table_category as c on c.id = p.cid inner join table_vendor as v on v.id = p.vid where barcode like '" + bc + "'", con);
                            dr = cm.ExecuteReader();
                            while (dr.Read()) {
                                
                                if (dr.HasRows)
                                {
                                    tft_pcode.Text = dr["pcode"].ToString();
                                    //tft_barcode.Text = dr["barcode"].ToString();
                                    tft_pname.Text = dr["pname"].ToString();
                                    tft_pdescription.Text = dr["pdesc"].ToString();
                                    cb_brand.Text = dr["brand"].ToString();
                                    cb_category.Text = dr["category"].ToString();
                                    tft_cost.Text = dr["cost"].ToString();
                                    tft_price.Text = dr["price"].ToString();
                                    tft_reorder.Text = dr["reorder"].ToString();
                                    cb_vendor.TextChanged -= cb_vendor_TextChanged;
                                    cb_vendor.Text = dr["vendor"].ToString();
                                    cb_vname.TextChanged -= cb_vname_TextChanged;
                                    cb_vname.Text = dr["contactperson"].ToString();

                                    btn_save.Enabled = false;
                                    btn_update.Enabled = true;
                                }
                                else
                                {
                                    dr.Close();
                                    con.Close();
                                }
                            }
                            dr.Close();
                            con.Close();
                        }
                        else
                        {
                            dr.Close();
                            con.Close();
                            tft_barcode.Text = "SR " + tft_pcode.Text;
                        }
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
        public bool bcodecheck(string val)
        {
            bool chb = false;
            try
            {
                string bcode = "";
                con.Open();
                cm = new SqlCommand("SELECT barcode from table_products", con);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    bcode = dr["barcode"].ToString().ToLower();
                    if (val == bcode)
                    {
                        //("Existing product");
                        chb = true;
                        break;
                    }
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
            return chb;
        }

        private void cb_vendor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                cb_vname.Text = "";
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
                con.Close();
                dr.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.ChangedButton == MouseButton.Left)
            //this.DragMove();
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov ==1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void panel_top_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
