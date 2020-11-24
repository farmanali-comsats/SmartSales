namespace POS_and_Inventory
{
    partial class Form_addproduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_addbrand = new System.Windows.Forms.Label();
            this.tft_pcode = new System.Windows.Forms.TextBox();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.tft_pdescription = new System.Windows.Forms.TextBox();
            this.lbl_pdesc = new System.Windows.Forms.Label();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.cb_brand = new System.Windows.Forms.ComboBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.tft_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tft_pname = new System.Windows.Forms.TextBox();
            this.lbl_pcode = new System.Windows.Forms.Label();
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.tft_barcode = new System.Windows.Forms.TextBox();
            this.tft_reorder = new System.Windows.Forms.TextBox();
            this.lbl_reorder = new System.Windows.Forms.Label();
            this.pb_brand = new System.Windows.Forms.PictureBox();
            this.pb_category = new System.Windows.Forms.PictureBox();
            this.tft_cost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tft_percent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_barcode = new System.Windows.Forms.Button();
            this.pictureBox_barcode = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_vendor = new System.Windows.Forms.ComboBox();
            this.lbl_vid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_vname = new System.Windows.Forms.ComboBox();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_brand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_top.Controls.Add(this.lbl_addbrand);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(619, 40);
            this.panel_top.TabIndex = 2;
            // 
            // lbl_addbrand
            // 
            this.lbl_addbrand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addbrand.ForeColor = System.Drawing.Color.White;
            this.lbl_addbrand.Location = new System.Drawing.Point(3, 9);
            this.lbl_addbrand.Name = "lbl_addbrand";
            this.lbl_addbrand.Size = new System.Drawing.Size(170, 25);
            this.lbl_addbrand.TabIndex = 0;
            this.lbl_addbrand.Text = "Adding Product";
            // 
            // tft_pcode
            // 
            this.tft_pcode.Enabled = false;
            this.tft_pcode.Location = new System.Drawing.Point(132, 55);
            this.tft_pcode.Name = "tft_pcode";
            this.tft_pcode.Size = new System.Drawing.Size(457, 25);
            this.tft_pcode.TabIndex = 1;
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.Location = new System.Drawing.Point(12, 172);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(92, 17);
            this.lbl_pname.TabIndex = 10;
            this.lbl_pname.Text = "Product Name";
            // 
            // tft_pdescription
            // 
            this.tft_pdescription.Location = new System.Drawing.Point(132, 209);
            this.tft_pdescription.Name = "tft_pdescription";
            this.tft_pdescription.Size = new System.Drawing.Size(457, 25);
            this.tft_pdescription.TabIndex = 5;
            // 
            // lbl_pdesc
            // 
            this.lbl_pdesc.AutoSize = true;
            this.lbl_pdesc.Location = new System.Drawing.Point(12, 212);
            this.lbl_pdesc.Name = "lbl_pdesc";
            this.lbl_pdesc.Size = new System.Drawing.Size(74, 17);
            this.lbl_pdesc.TabIndex = 12;
            this.lbl_pdesc.Text = "Description";
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(12, 252);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(42, 17);
            this.lbl_brand.TabIndex = 14;
            this.lbl_brand.Text = "Brand";
            // 
            // cb_brand
            // 
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Location = new System.Drawing.Point(132, 249);
            this.cb_brand.Name = "cb_brand";
            this.cb_brand.Size = new System.Drawing.Size(457, 25);
            this.cb_brand.TabIndex = 6;
            this.cb_brand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_brand_KeyDown);
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(132, 289);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(457, 25);
            this.cb_category.TabIndex = 7;
            this.cb_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_category_KeyDown);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(12, 292);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(61, 17);
            this.lbl_category.TabIndex = 16;
            this.lbl_category.Text = "Category";
            // 
            // tft_price
            // 
            this.tft_price.Location = new System.Drawing.Point(132, 369);
            this.tft_price.Name = "tft_price";
            this.tft_price.Size = new System.Drawing.Size(274, 25);
            this.tft_price.TabIndex = 9;
            this.tft_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tft_price_KeyPress);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(12, 372);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(36, 17);
            this.lbl_price.TabIndex = 18;
            this.lbl_price.Text = "Price";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(416, 499);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(132, 34);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(274, 499);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(132, 34);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(132, 499);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 34);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tft_pname
            // 
            this.tft_pname.Location = new System.Drawing.Point(132, 169);
            this.tft_pname.Name = "tft_pname";
            this.tft_pname.Size = new System.Drawing.Size(457, 25);
            this.tft_pname.TabIndex = 4;
            // 
            // lbl_pcode
            // 
            this.lbl_pcode.AutoSize = true;
            this.lbl_pcode.Location = new System.Drawing.Point(12, 58);
            this.lbl_pcode.Name = "lbl_pcode";
            this.lbl_pcode.Size = new System.Drawing.Size(88, 17);
            this.lbl_pcode.TabIndex = 23;
            this.lbl_pcode.Text = "Product Code";
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.AutoSize = true;
            this.lbl_barcode.Location = new System.Drawing.Point(12, 114);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(56, 17);
            this.lbl_barcode.TabIndex = 26;
            this.lbl_barcode.Text = "Barcode";
            // 
            // tft_barcode
            // 
            this.tft_barcode.Location = new System.Drawing.Point(132, 111);
            this.tft_barcode.Name = "tft_barcode";
            this.tft_barcode.Size = new System.Drawing.Size(181, 25);
            this.tft_barcode.TabIndex = 2;
            this.tft_barcode.TextChanged += new System.EventHandler(this.tft_barcode_TextChanged);
            // 
            // tft_reorder
            // 
            this.tft_reorder.Location = new System.Drawing.Point(132, 456);
            this.tft_reorder.Name = "tft_reorder";
            this.tft_reorder.Size = new System.Drawing.Size(457, 25);
            this.tft_reorder.TabIndex = 16;
            this.tft_reorder.Text = "0";
            // 
            // lbl_reorder
            // 
            this.lbl_reorder.AutoSize = true;
            this.lbl_reorder.Location = new System.Drawing.Point(12, 459);
            this.lbl_reorder.Name = "lbl_reorder";
            this.lbl_reorder.Size = new System.Drawing.Size(96, 17);
            this.lbl_reorder.TabIndex = 28;
            this.lbl_reorder.Text = "Re-Order Level";
            // 
            // pb_brand
            // 
            this.pb_brand.Image = global::POS_and_Inventory.Properties.Resources.plus1;
            this.pb_brand.Location = new System.Drawing.Point(595, 252);
            this.pb_brand.Name = "pb_brand";
            this.pb_brand.Size = new System.Drawing.Size(17, 17);
            this.pb_brand.TabIndex = 29;
            this.pb_brand.TabStop = false;
            this.pb_brand.Click += new System.EventHandler(this.pb_brand_Click);
            // 
            // pb_category
            // 
            this.pb_category.Image = global::POS_and_Inventory.Properties.Resources.plus1;
            this.pb_category.Location = new System.Drawing.Point(595, 292);
            this.pb_category.Name = "pb_category";
            this.pb_category.Size = new System.Drawing.Size(17, 17);
            this.pb_category.TabIndex = 30;
            this.pb_category.TabStop = false;
            this.pb_category.Click += new System.EventHandler(this.pb_category_Click);
            // 
            // tft_cost
            // 
            this.tft_cost.Location = new System.Drawing.Point(132, 329);
            this.tft_cost.Name = "tft_cost";
            this.tft_cost.Size = new System.Drawing.Size(457, 25);
            this.tft_cost.TabIndex = 8;
            this.tft_cost.TextChanged += new System.EventHandler(this.tft_cost_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cost";
            // 
            // tft_percent
            // 
            this.tft_percent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_percent.Location = new System.Drawing.Point(498, 369);
            this.tft_percent.Name = "tft_percent";
            this.tft_percent.Size = new System.Drawing.Size(61, 25);
            this.tft_percent.TabIndex = 10;
            this.tft_percent.Text = "0.00";
            this.tft_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tft_percent.TextChanged += new System.EventHandler(this.tft_percent_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Percentage";
            // 
            // btn_barcode
            // 
            this.btn_barcode.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_barcode.FlatAppearance.BorderSize = 0;
            this.btn_barcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_barcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barcode.ForeColor = System.Drawing.Color.White;
            this.btn_barcode.Location = new System.Drawing.Point(319, 111);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(97, 25);
            this.btn_barcode.TabIndex = 3;
            this.btn_barcode.Text = "Generate";
            this.btn_barcode.UseVisualStyleBackColor = false;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // pictureBox_barcode
            // 
            this.pictureBox_barcode.Location = new System.Drawing.Point(422, 87);
            this.pictureBox_barcode.Name = "pictureBox_barcode";
            this.pictureBox_barcode.Size = new System.Drawing.Size(167, 73);
            this.pictureBox_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_barcode.TabIndex = 37;
            this.pictureBox_barcode.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Supplier";
            // 
            // cb_vendor
            // 
            this.cb_vendor.FormattingEnabled = true;
            this.cb_vendor.Location = new System.Drawing.Point(132, 411);
            this.cb_vendor.Name = "cb_vendor";
            this.cb_vendor.Size = new System.Drawing.Size(196, 25);
            this.cb_vendor.TabIndex = 12;
            this.cb_vendor.TextChanged += new System.EventHandler(this.cb_vendor_TextChanged);
            // 
            // lbl_vid
            // 
            this.lbl_vid.AutoSize = true;
            this.lbl_vid.Location = new System.Drawing.Point(92, 416);
            this.lbl_vid.Name = "lbl_vid";
            this.lbl_vid.Size = new System.Drawing.Size(0, 17);
            this.lbl_vid.TabIndex = 41;
            this.lbl_vid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Name";
            // 
            // cb_vname
            // 
            this.cb_vname.FormattingEnabled = true;
            this.cb_vname.Location = new System.Drawing.Point(393, 411);
            this.cb_vname.Name = "cb_vname";
            this.cb_vname.Size = new System.Drawing.Size(196, 25);
            this.cb_vname.TabIndex = 14;
            this.cb_vname.TextChanged += new System.EventHandler(this.cb_vname_TextChanged);
            // 
            // Form_addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(619, 548);
            this.ControlBox = false;
            this.Controls.Add(this.cb_vname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_vid);
            this.Controls.Add(this.cb_vendor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_barcode);
            this.Controls.Add(this.btn_barcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tft_percent);
            this.Controls.Add(this.tft_cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_category);
            this.Controls.Add(this.pb_brand);
            this.Controls.Add(this.tft_reorder);
            this.Controls.Add(this.lbl_reorder);
            this.Controls.Add(this.lbl_barcode);
            this.Controls.Add(this.tft_barcode);
            this.Controls.Add(this.tft_pname);
            this.Controls.Add(this.lbl_pcode);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tft_price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cb_brand);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.tft_pdescription);
            this.Controls.Add(this.lbl_pdesc);
            this.Controls.Add(this.tft_pcode);
            this.Controls.Add(this.lbl_pname);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_addproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_addproduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_addproduct_KeyDown);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_brand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_addbrand;
        public System.Windows.Forms.TextBox tft_pcode;
        public System.Windows.Forms.TextBox tft_pdescription;
        public System.Windows.Forms.TextBox tft_price;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox tft_pname;
        public System.Windows.Forms.Label lbl_pname;
        public System.Windows.Forms.Label lbl_pdesc;
        public System.Windows.Forms.Label lbl_brand;
        public System.Windows.Forms.ComboBox cb_brand;
        public System.Windows.Forms.ComboBox cb_category;
        public System.Windows.Forms.Label lbl_category;
        public System.Windows.Forms.Label lbl_price;
        public System.Windows.Forms.Label lbl_pcode;
        public System.Windows.Forms.Label lbl_barcode;
        public System.Windows.Forms.TextBox tft_barcode;
        public System.Windows.Forms.TextBox tft_reorder;
        public System.Windows.Forms.Label lbl_reorder;
        private System.Windows.Forms.PictureBox pb_brand;
        private System.Windows.Forms.PictureBox pb_category;
        public System.Windows.Forms.TextBox tft_cost;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tft_percent;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_barcode;
        public System.Windows.Forms.PictureBox pictureBox_barcode;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cb_vendor;
        public System.Windows.Forms.Label lbl_vid;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cb_vname;
    }
}