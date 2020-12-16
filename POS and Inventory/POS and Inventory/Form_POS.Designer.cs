namespace POS_and_Inventory
{
    partial class Form_POS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_POS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_eprt = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_displaytotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tft_qty = new MetroFramework.Controls.MetroTextBox();
            this.lbl_bcode = new System.Windows.Forms.Label();
            this.tft_searchbcode = new MetroFramework.Controls.MetroTextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_ldate = new System.Windows.Forms.Label();
            this.lbl_trcode = new System.Windows.Forms.Label();
            this.lbl_tno = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_salestotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_vat = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_vatable = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_sysdate = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_searchproduct = new System.Windows.Forms.Button();
            this.btn_changepass = new System.Windows.Forms.Button();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_dailysales = new System.Windows.Forms.Button();
            this.btn_settlepayment = new System.Windows.Forms.Button();
            this.btn_cancelsales = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BRAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_add = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_title.Location = new System.Drawing.Point(104, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(122, 20);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "POS Software";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel5.Controls.Add(this.btn_eprt);
            this.panel5.Controls.Add(this.lbl_name);
            this.panel5.Controls.Add(this.lbl_username);
            this.panel5.Controls.Add(this.lbl_displaytotal);
            this.panel5.Controls.Add(this.lbl_title);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1198, 84);
            this.panel5.TabIndex = 3;
            // 
            // btn_eprt
            // 
            this.btn_eprt.BackColor = System.Drawing.Color.Red;
            this.btn_eprt.FlatAppearance.BorderSize = 0;
            this.btn_eprt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_eprt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_eprt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eprt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eprt.ForeColor = System.Drawing.Color.Black;
            this.btn_eprt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eprt.Location = new System.Drawing.Point(517, 0);
            this.btn_eprt.Name = "btn_eprt";
            this.btn_eprt.Size = new System.Drawing.Size(120, 23);
            this.btn_eprt.TabIndex = 5;
            this.btn_eprt.Text = "Print-Disabled";
            this.btn_eprt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eprt.UseVisualStyleBackColor = false;
            this.btn_eprt.Click += new System.EventHandler(this.btn_eprt_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(108, 53);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(103, 16);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "POS Software";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Enabled = false;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(501, 53);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 16);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "username";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_username.Visible = false;
            // 
            // lbl_displaytotal
            // 
            this.lbl_displaytotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_displaytotal.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_displaytotal.ForeColor = System.Drawing.Color.White;
            this.lbl_displaytotal.Location = new System.Drawing.Point(931, 0);
            this.lbl_displaytotal.Name = "lbl_displaytotal";
            this.lbl_displaytotal.Size = new System.Drawing.Size(267, 84);
            this.lbl_displaytotal.TabIndex = 0;
            this.lbl_displaytotal.Text = "0.00";
            this.lbl_displaytotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.tft_qty);
            this.panel4.Controls.Add(this.lbl_bcode);
            this.panel4.Controls.Add(this.tft_searchbcode);
            this.panel4.Controls.Add(this.lbl_date);
            this.panel4.Controls.Add(this.lbl_ldate);
            this.panel4.Controls.Add(this.lbl_trcode);
            this.panel4.Controls.Add(this.lbl_tno);
            this.panel4.Location = new System.Drawing.Point(3, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(923, 84);
            this.panel4.TabIndex = 2;
            // 
            // tft_qty
            // 
            this.tft_qty.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tft_qty.CustomButton.Image = null;
            this.tft_qty.CustomButton.Location = new System.Drawing.Point(13, 2);
            this.tft_qty.CustomButton.Name = "";
            this.tft_qty.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_qty.CustomButton.TabIndex = 1;
            this.tft_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_qty.CustomButton.UseSelectable = true;
            this.tft_qty.CustomButton.Visible = false;
            this.tft_qty.Enabled = false;
            this.tft_qty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tft_qty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tft_qty.Icon = ((System.Drawing.Image)(resources.GetObject("tft_qty.Icon")));
            this.tft_qty.Lines = new string[] {
        "1"};
            this.tft_qty.Location = new System.Drawing.Point(607, 53);
            this.tft_qty.MaxLength = 32767;
            this.tft_qty.Name = "tft_qty";
            this.tft_qty.PasswordChar = '\0';
            this.tft_qty.PromptText = "Qty";
            this.tft_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_qty.SelectedText = "";
            this.tft_qty.SelectionLength = 0;
            this.tft_qty.SelectionStart = 0;
            this.tft_qty.ShortcutsEnabled = true;
            this.tft_qty.Size = new System.Drawing.Size(39, 28);
            this.tft_qty.TabIndex = 6;
            this.tft_qty.Text = "1";
            this.tft_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tft_qty.UseSelectable = true;
            this.tft_qty.WaterMark = "Qty";
            this.tft_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_bcode
            // 
            this.lbl_bcode.AutoSize = true;
            this.lbl_bcode.Location = new System.Drawing.Point(21, 64);
            this.lbl_bcode.Name = "lbl_bcode";
            this.lbl_bcode.Size = new System.Drawing.Size(82, 15);
            this.lbl_bcode.TabIndex = 5;
            this.lbl_bcode.Text = "[ F8 ] Barcode";
            // 
            // tft_searchbcode
            // 
            this.tft_searchbcode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tft_searchbcode.CustomButton.Image = null;
            this.tft_searchbcode.CustomButton.Location = new System.Drawing.Point(455, 2);
            this.tft_searchbcode.CustomButton.Name = "";
            this.tft_searchbcode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_searchbcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_searchbcode.CustomButton.TabIndex = 1;
            this.tft_searchbcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_searchbcode.CustomButton.UseSelectable = true;
            this.tft_searchbcode.CustomButton.Visible = false;
            this.tft_searchbcode.DisplayIcon = true;
            this.tft_searchbcode.Icon = ((System.Drawing.Image)(resources.GetObject("tft_searchbcode.Icon")));
            this.tft_searchbcode.Lines = new string[0];
            this.tft_searchbcode.Location = new System.Drawing.Point(120, 53);
            this.tft_searchbcode.MaxLength = 32767;
            this.tft_searchbcode.Name = "tft_searchbcode";
            this.tft_searchbcode.PasswordChar = '\0';
            this.tft_searchbcode.PromptText = "Search Barcode Here";
            this.tft_searchbcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_searchbcode.SelectedText = "";
            this.tft_searchbcode.SelectionLength = 0;
            this.tft_searchbcode.SelectionStart = 0;
            this.tft_searchbcode.ShortcutsEnabled = true;
            this.tft_searchbcode.Size = new System.Drawing.Size(481, 28);
            this.tft_searchbcode.TabIndex = 4;
            this.tft_searchbcode.UseSelectable = true;
            this.tft_searchbcode.WaterMark = "Search Barcode Here";
            this.tft_searchbcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_searchbcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tft_searchbcode.TextChanged += new System.EventHandler(this.tft_searchbcode_TextChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(117, 36);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(98, 15);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "0000000000000";
            // 
            // lbl_ldate
            // 
            this.lbl_ldate.AutoSize = true;
            this.lbl_ldate.Location = new System.Drawing.Point(21, 36);
            this.lbl_ldate.Name = "lbl_ldate";
            this.lbl_ldate.Size = new System.Drawing.Size(33, 15);
            this.lbl_ldate.TabIndex = 2;
            this.lbl_ldate.Text = "Date";
            // 
            // lbl_trcode
            // 
            this.lbl_trcode.AutoSize = true;
            this.lbl_trcode.Location = new System.Drawing.Point(117, 9);
            this.lbl_trcode.Name = "lbl_trcode";
            this.lbl_trcode.Size = new System.Drawing.Size(91, 15);
            this.lbl_trcode.TabIndex = 1;
            this.lbl_trcode.Text = "000000000000";
            // 
            // lbl_tno
            // 
            this.lbl_tno.AutoSize = true;
            this.lbl_tno.Location = new System.Drawing.Point(21, 9);
            this.lbl_tno.Name = "lbl_tno";
            this.lbl_tno.Size = new System.Drawing.Size(90, 15);
            this.lbl_tno.TabIndex = 0;
            this.lbl_tno.Text = "Transaction No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.Column_ID,
            this.col_pcode,
            this.Column_BRAND,
            this.col_price,
            this.col_qty,
            this.col_discount,
            this.col_total,
            this.col_cost,
            this.col_add,
            this.col_remove,
            this.DELETE});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(923, 427);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sales Total";
            // 
            // lbl_salestotal
            // 
            this.lbl_salestotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_salestotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salestotal.Location = new System.Drawing.Point(203, 8);
            this.lbl_salestotal.Name = "lbl_salestotal";
            this.lbl_salestotal.Size = new System.Drawing.Size(106, 20);
            this.lbl_salestotal.TabIndex = 1;
            this.lbl_salestotal.Text = "0.00";
            this.lbl_salestotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Discount";
            // 
            // lbl_discount
            // 
            this.lbl_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.Location = new System.Drawing.Point(203, 43);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(106, 20);
            this.lbl_discount.TabIndex = 3;
            this.lbl_discount.Text = "0.00";
            this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "VAT";
            // 
            // lbl_vat
            // 
            this.lbl_vat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vat.Location = new System.Drawing.Point(203, 74);
            this.lbl_vat.Name = "lbl_vat";
            this.lbl_vat.Size = new System.Drawing.Size(106, 20);
            this.lbl_vat.TabIndex = 5;
            this.lbl_vat.Text = "0.00";
            this.lbl_vat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_vat.Click += new System.EventHandler(this.lbl_vat_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Vatable";
            // 
            // lbl_vatable
            // 
            this.lbl_vatable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vatable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vatable.Location = new System.Drawing.Point(203, 105);
            this.lbl_vatable.Name = "lbl_vatable";
            this.lbl_vatable.Size = new System.Drawing.Size(106, 20);
            this.lbl_vatable.TabIndex = 7;
            this.lbl_vatable.Text = "0.00";
            this.lbl_vatable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.lbl_vatable);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.lbl_vat);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.lbl_discount);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.lbl_salestotal);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(580, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(342, 138);
            this.panel7.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.lbl_sysdate);
            this.panel2.Controls.Add(this.lbl_timer);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(3, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 138);
            this.panel2.TabIndex = 8;
            // 
            // lbl_sysdate
            // 
            this.lbl_sysdate.AutoSize = true;
            this.lbl_sysdate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sysdate.Location = new System.Drawing.Point(17, 83);
            this.lbl_sysdate.Name = "lbl_sysdate";
            this.lbl_sysdate.Size = new System.Drawing.Size(0, 25);
            this.lbl_sysdate.TabIndex = 1;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(3, 8);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(312, 75);
            this.lbl_timer.TabIndex = 0;
            this.lbl_timer.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btn_new, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_close, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_searchproduct, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_changepass, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_discount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_dailysales, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_settlepayment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancelsales, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(931, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.443405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.443405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.443405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.443405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.443405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.443405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.443405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.443405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.45275F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 665);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_new.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(3, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(261, 56);
            this.btn_new.TabIndex = 4;
            this.btn_new.Text = "  [ F1 ] New Transaction";
            this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(3, 437);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(261, 56);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "  [ F10 ] Logout";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_searchproduct
            // 
            this.btn_searchproduct.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_searchproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchproduct.FlatAppearance.BorderSize = 0;
            this.btn_searchproduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_searchproduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_searchproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchproduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_searchproduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_searchproduct.Image")));
            this.btn_searchproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchproduct.Location = new System.Drawing.Point(3, 65);
            this.btn_searchproduct.Name = "btn_searchproduct";
            this.btn_searchproduct.Size = new System.Drawing.Size(261, 56);
            this.btn_searchproduct.TabIndex = 5;
            this.btn_searchproduct.Text = "  [ F2 ] Search Product";
            this.btn_searchproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_searchproduct.UseVisualStyleBackColor = false;
            this.btn_searchproduct.Click += new System.EventHandler(this.btn_searchproduct_Click);
            // 
            // btn_changepass
            // 
            this.btn_changepass.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_changepass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_changepass.FlatAppearance.BorderSize = 0;
            this.btn_changepass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_changepass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_changepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changepass.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_changepass.Image = ((System.Drawing.Image)(resources.GetObject("btn_changepass.Image")));
            this.btn_changepass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changepass.Location = new System.Drawing.Point(3, 375);
            this.btn_changepass.Name = "btn_changepass";
            this.btn_changepass.Size = new System.Drawing.Size(261, 56);
            this.btn_changepass.TabIndex = 10;
            this.btn_changepass.Text = "  [ F7 ] Change Password";
            this.btn_changepass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changepass.UseVisualStyleBackColor = false;
            this.btn_changepass.Click += new System.EventHandler(this.btn_changepass_Click);
            // 
            // btn_discount
            // 
            this.btn_discount.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_discount.Enabled = false;
            this.btn_discount.FlatAppearance.BorderSize = 0;
            this.btn_discount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_discount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discount.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_discount.Image = ((System.Drawing.Image)(resources.GetObject("btn_discount.Image")));
            this.btn_discount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_discount.Location = new System.Drawing.Point(3, 127);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(261, 56);
            this.btn_discount.TabIndex = 6;
            this.btn_discount.Text = "  [ F3 ] Add Discount";
            this.btn_discount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_discount.UseVisualStyleBackColor = false;
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // btn_dailysales
            // 
            this.btn_dailysales.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_dailysales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dailysales.FlatAppearance.BorderSize = 0;
            this.btn_dailysales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_dailysales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_dailysales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dailysales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dailysales.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dailysales.Image = ((System.Drawing.Image)(resources.GetObject("btn_dailysales.Image")));
            this.btn_dailysales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dailysales.Location = new System.Drawing.Point(3, 313);
            this.btn_dailysales.Name = "btn_dailysales";
            this.btn_dailysales.Size = new System.Drawing.Size(261, 56);
            this.btn_dailysales.TabIndex = 9;
            this.btn_dailysales.Text = "  [ F6 ] Daily Sales";
            this.btn_dailysales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dailysales.UseVisualStyleBackColor = false;
            this.btn_dailysales.Click += new System.EventHandler(this.btn_dailysales_Click);
            // 
            // btn_settlepayment
            // 
            this.btn_settlepayment.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_settlepayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_settlepayment.Enabled = false;
            this.btn_settlepayment.FlatAppearance.BorderSize = 0;
            this.btn_settlepayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_settlepayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_settlepayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settlepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settlepayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_settlepayment.Image = ((System.Drawing.Image)(resources.GetObject("btn_settlepayment.Image")));
            this.btn_settlepayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settlepayment.Location = new System.Drawing.Point(3, 189);
            this.btn_settlepayment.Name = "btn_settlepayment";
            this.btn_settlepayment.Size = new System.Drawing.Size(261, 56);
            this.btn_settlepayment.TabIndex = 7;
            this.btn_settlepayment.Text = "  [ F4 ] Settle Payment";
            this.btn_settlepayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settlepayment.UseVisualStyleBackColor = false;
            this.btn_settlepayment.Click += new System.EventHandler(this.btn_settlepayment_Click);
            // 
            // btn_cancelsales
            // 
            this.btn_cancelsales.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_cancelsales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancelsales.Enabled = false;
            this.btn_cancelsales.FlatAppearance.BorderSize = 0;
            this.btn_cancelsales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cancelsales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancelsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelsales.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancelsales.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelsales.Image")));
            this.btn_cancelsales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelsales.Location = new System.Drawing.Point(3, 251);
            this.btn_cancelsales.Name = "btn_cancelsales";
            this.btn_cancelsales.Size = new System.Drawing.Size(261, 56);
            this.btn_cancelsales.TabIndex = 8;
            this.btn_cancelsales.Text = "  [ F5 ] Clear Cart";
            this.btn_cancelsales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelsales.UseVisualStyleBackColor = false;
            this.btn_cancelsales.Click += new System.EventHandler(this.btn_cancelsales_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SNo
            // 
            this.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SNo.HeaderText = "#";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 37;
            // 
            // Column_ID
            // 
            this.Column_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Width = 42;
            // 
            // col_pcode
            // 
            this.col_pcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_pcode.HeaderText = "Pcode";
            this.col_pcode.Name = "col_pcode";
            this.col_pcode.ReadOnly = true;
            this.col_pcode.Visible = false;
            this.col_pcode.Width = 65;
            // 
            // Column_BRAND
            // 
            this.Column_BRAND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_BRAND.HeaderText = "Name / Description";
            this.Column_BRAND.Name = "Column_BRAND";
            this.Column_BRAND.ReadOnly = true;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_price.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_price.HeaderText = "Price";
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            this.col_price.Width = 58;
            // 
            // col_qty
            // 
            this.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_qty.HeaderText = "Quantity";
            this.col_qty.Name = "col_qty";
            this.col_qty.ReadOnly = true;
            this.col_qty.Width = 74;
            // 
            // col_discount
            // 
            this.col_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_discount.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_discount.HeaderText = "Discount";
            this.col_discount.Name = "col_discount";
            this.col_discount.ReadOnly = true;
            this.col_discount.Width = 78;
            // 
            // col_total
            // 
            this.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_total.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_total.HeaderText = "Total";
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            this.col_total.Width = 57;
            // 
            // col_cost
            // 
            this.col_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_cost.HeaderText = "Cost";
            this.col_cost.Name = "col_cost";
            this.col_cost.ReadOnly = true;
            this.col_cost.Visible = false;
            this.col_cost.Width = 54;
            // 
            // col_add
            // 
            this.col_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_add.HeaderText = "";
            this.col_add.Image = ((System.Drawing.Image)(resources.GetObject("col_add.Image")));
            this.col_add.Name = "col_add";
            this.col_add.ReadOnly = true;
            this.col_add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_add.Width = 5;
            // 
            // col_remove
            // 
            this.col_remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_remove.HeaderText = "";
            this.col_remove.Image = ((System.Drawing.Image)(resources.GetObject("col_remove.Image")));
            this.col_remove.Name = "col_remove";
            this.col_remove.ReadOnly = true;
            this.col_remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_remove.Width = 5;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DELETE.HeaderText = "";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            this.DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DELETE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DELETE.Width = 17;
            // 
            // Form_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1198, 749);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_POS_KeyDown);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_ldate;
        private System.Windows.Forms.Label lbl_tno;
        private System.Windows.Forms.Label lbl_displaytotal;
        private System.Windows.Forms.Label lbl_bcode;
        public MetroFramework.Controls.MetroTextBox tft_searchbcode;
        public System.Windows.Forms.Label lbl_trcode;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_salestotal;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lbl_vat;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lbl_vatable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_sysdate;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label lbl_username;
        public System.Windows.Forms.Label lbl_name;
        public MetroFramework.Controls.MetroTextBox tft_qty;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_searchproduct;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Button btn_settlepayment;
        private System.Windows.Forms.Button btn_cancelsales;
        private System.Windows.Forms.Button btn_dailysales;
        private System.Windows.Forms.Button btn_changepass;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        public System.Windows.Forms.Button btn_eprt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BRAND;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cost;
        private System.Windows.Forms.DataGridViewImageColumn col_add;
        private System.Windows.Forms.DataGridViewImageColumn col_remove;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
    }
}