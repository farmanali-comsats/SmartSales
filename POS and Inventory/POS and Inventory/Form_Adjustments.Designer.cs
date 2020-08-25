namespace POS_and_Inventory
{
    partial class Form_Adjustments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Adjustments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_stokintitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tft_refno = new System.Windows.Forms.TextBox();
            this.tft_pcode = new System.Windows.Forms.TextBox();
            this.tft_desc = new System.Windows.Forms.TextBox();
            this.tft_qty = new System.Windows.Forms.TextBox();
            this.tft_remarks = new System.Windows.Forms.TextBox();
            this.tft_user = new System.Windows.Forms.TextBox();
            this.cb_action = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BRAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_stockonhand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.tft_search = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_stokintitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 40);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(788, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 28);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_stokintitle
            // 
            this.lbl_stokintitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stokintitle.Location = new System.Drawing.Point(3, 3);
            this.lbl_stokintitle.Name = "lbl_stokintitle";
            this.lbl_stokintitle.Size = new System.Drawing.Size(172, 31);
            this.lbl_stokintitle.TabIndex = 0;
            this.lbl_stokintitle.Text = "Stock Adjustment";
            this.lbl_stokintitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Refrence No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Command";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Remarks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "User";
            // 
            // tft_refno
            // 
            this.tft_refno.Enabled = false;
            this.tft_refno.Location = new System.Drawing.Point(86, 513);
            this.tft_refno.Name = "tft_refno";
            this.tft_refno.Size = new System.Drawing.Size(325, 23);
            this.tft_refno.TabIndex = 11;
            // 
            // tft_pcode
            // 
            this.tft_pcode.Enabled = false;
            this.tft_pcode.Location = new System.Drawing.Point(86, 550);
            this.tft_pcode.Name = "tft_pcode";
            this.tft_pcode.Size = new System.Drawing.Size(325, 23);
            this.tft_pcode.TabIndex = 12;
            // 
            // tft_desc
            // 
            this.tft_desc.Enabled = false;
            this.tft_desc.Location = new System.Drawing.Point(86, 587);
            this.tft_desc.Name = "tft_desc";
            this.tft_desc.Size = new System.Drawing.Size(325, 23);
            this.tft_desc.TabIndex = 13;
            // 
            // tft_qty
            // 
            this.tft_qty.Location = new System.Drawing.Point(86, 626);
            this.tft_qty.Name = "tft_qty";
            this.tft_qty.Size = new System.Drawing.Size(325, 23);
            this.tft_qty.TabIndex = 14;
            // 
            // tft_remarks
            // 
            this.tft_remarks.Location = new System.Drawing.Point(479, 550);
            this.tft_remarks.Name = "tft_remarks";
            this.tft_remarks.Size = new System.Drawing.Size(334, 23);
            this.tft_remarks.TabIndex = 16;
            // 
            // tft_user
            // 
            this.tft_user.Enabled = false;
            this.tft_user.Location = new System.Drawing.Point(479, 587);
            this.tft_user.Name = "tft_user";
            this.tft_user.Size = new System.Drawing.Size(334, 23);
            this.tft_user.TabIndex = 17;
            // 
            // cb_action
            // 
            this.cb_action.FormattingEnabled = true;
            this.cb_action.Items.AddRange(new object[] {
            "Add To Inventory",
            "Remove From Inventory"});
            this.cb_action.Location = new System.Drawing.Point(479, 513);
            this.cb_action.Name = "cb_action";
            this.cb_action.Size = new System.Drawing.Size(334, 23);
            this.cb_action.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.p_code,
            this.Barcode,
            this.Column_name,
            this.Column_description,
            this.Column_BRAND,
            this.Column_category,
            this.Column_price,
            this.Column_stockonhand,
            this.Select});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(816, 430);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SNo
            // 
            this.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SNo.HeaderText = "#";
            this.SNo.Name = "SNo";
            this.SNo.Width = 36;
            // 
            // p_code
            // 
            this.p_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_code.HeaderText = "Product Code";
            this.p_code.Name = "p_code";
            this.p_code.Width = 103;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 75;
            // 
            // Column_name
            // 
            this.Column_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_name.HeaderText = "Name";
            this.Column_name.Name = "Column_name";
            this.Column_name.Width = 61;
            // 
            // Column_description
            // 
            this.Column_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_description.HeaderText = "Description";
            this.Column_description.MinimumWidth = 10;
            this.Column_description.Name = "Column_description";
            // 
            // Column_BRAND
            // 
            this.Column_BRAND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_BRAND.HeaderText = "Brand";
            this.Column_BRAND.Name = "Column_BRAND";
            this.Column_BRAND.Width = 63;
            // 
            // Column_category
            // 
            this.Column_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_category.HeaderText = "Category";
            this.Column_category.Name = "Column_category";
            this.Column_category.Width = 78;
            // 
            // Column_price
            // 
            this.Column_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_price.HeaderText = "Price";
            this.Column_price.Name = "Column_price";
            this.Column_price.Width = 58;
            // 
            // Column_stockonhand
            // 
            this.Column_stockonhand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column_stockonhand.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_stockonhand.HeaderText = "Stock On Hand";
            this.Column_stockonhand.Name = "Column_stockonhand";
            this.Column_stockonhand.Width = 110;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 17;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(695, 616);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 42);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tft_search
            // 
            // 
            // 
            // 
            this.tft_search.CustomButton.Image = null;
            this.tft_search.CustomButton.Location = new System.Drawing.Point(388, 1);
            this.tft_search.CustomButton.Name = "";
            this.tft_search.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_search.CustomButton.TabIndex = 1;
            this.tft_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_search.CustomButton.UseSelectable = true;
            this.tft_search.CustomButton.Visible = false;
            this.tft_search.DisplayIcon = true;
            this.tft_search.Icon = ((System.Drawing.Image)(resources.GetObject("tft_search.Icon")));
            this.tft_search.Lines = new string[0];
            this.tft_search.Location = new System.Drawing.Point(1, 46);
            this.tft_search.MaxLength = 32767;
            this.tft_search.Name = "tft_search";
            this.tft_search.PasswordChar = '\0';
            this.tft_search.PromptText = "Search Here";
            this.tft_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_search.SelectedText = "";
            this.tft_search.SelectionLength = 0;
            this.tft_search.SelectionStart = 0;
            this.tft_search.ShortcutsEnabled = true;
            this.tft_search.Size = new System.Drawing.Size(412, 25);
            this.tft_search.TabIndex = 20;
            this.tft_search.UseSelectable = true;
            this.tft_search.WaterMark = "Search Here";
            this.tft_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tft_search.TextChanged += new System.EventHandler(this.tft_search_TextChanged);
            this.tft_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tft_search_KeyPress);
            // 
            // Form_Adjustments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(816, 666);
            this.ControlBox = false;
            this.Controls.Add(this.tft_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_action);
            this.Controls.Add(this.tft_user);
            this.Controls.Add(this.tft_remarks);
            this.Controls.Add(this.tft_qty);
            this.Controls.Add(this.tft_desc);
            this.Controls.Add(this.tft_pcode);
            this.Controls.Add(this.tft_refno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Adjustments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Adjustments_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_stokintitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_save;
        private MetroFramework.Controls.MetroTextBox tft_search;
        public System.Windows.Forms.TextBox tft_refno;
        public System.Windows.Forms.TextBox tft_pcode;
        public System.Windows.Forms.TextBox tft_desc;
        public System.Windows.Forms.TextBox tft_qty;
        public System.Windows.Forms.TextBox tft_remarks;
        public System.Windows.Forms.TextBox tft_user;
        public System.Windows.Forms.ComboBox cb_action;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BRAND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_stockonhand;
        private System.Windows.Forms.DataGridViewImageColumn Select;
    }
}