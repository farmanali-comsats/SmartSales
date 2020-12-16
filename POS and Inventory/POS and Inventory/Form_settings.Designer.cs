namespace POS_and_Inventory
{
    partial class Form_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_categoryitle = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tft_address = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tft_storename = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sessionalpredict = new System.Windows.Forms.Button();
            this.btn_salepredict = new System.Windows.Forms.Button();
            this.btn_productpredict = new System.Windows.Forms.Button();
            this.btn_profitpredict = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_savenoti = new MetroFramework.Controls.MetroLabel();
            this.tft_restoredb = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_restoredb = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openbackupfile = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.btn_opendb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pictureBox_cancel);
            this.panel1.Controls.Add(this.lbl_categoryitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 48);
            this.panel1.TabIndex = 5;
            // 
            // lbl_categoryitle
            // 
            this.lbl_categoryitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryitle.Location = new System.Drawing.Point(3, 4);
            this.lbl_categoryitle.Name = "lbl_categoryitle";
            this.lbl_categoryitle.Size = new System.Drawing.Size(219, 40);
            this.lbl_categoryitle.TabIndex = 0;
            this.lbl_categoryitle.Text = "Advanced Settings";
            this.lbl_categoryitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(121, 138);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(695, 422);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(687, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Store Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 380);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tft_address);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.btn_cancel);
            this.panel4.Controls.Add(this.tft_storename);
            this.panel4.Controls.Add(this.btn_save);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 380);
            this.panel4.TabIndex = 42;
            // 
            // tft_address
            // 
            this.tft_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tft_address.Location = new System.Drawing.Point(155, 132);
            this.tft_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tft_address.Name = "tft_address";
            this.tft_address.Size = new System.Drawing.Size(451, 25);
            this.tft_address.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(681, 40);
            this.label16.TabIndex = 18;
            this.label16.Text = "Store Information";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(331, 174);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(158, 56);
            this.btn_cancel.TabIndex = 39;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // tft_storename
            // 
            this.tft_storename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tft_storename.Location = new System.Drawing.Point(155, 78);
            this.tft_storename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tft_storename.Name = "tft_storename";
            this.tft_storename.Size = new System.Drawing.Size(451, 25);
            this.tft_storename.TabIndex = 34;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(155, 174);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(158, 56);
            this.btn_save.TabIndex = 38;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Store Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Address";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(687, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Forecasting";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 380);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_sessionalpredict, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_salepredict, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_productpredict, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_profitpredict, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 380);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // btn_sessionalpredict
            // 
            this.btn_sessionalpredict.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_sessionalpredict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sessionalpredict.FlatAppearance.BorderSize = 2;
            this.btn_sessionalpredict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sessionalpredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sessionalpredict.ForeColor = System.Drawing.Color.White;
            this.btn_sessionalpredict.Location = new System.Drawing.Point(3, 3);
            this.btn_sessionalpredict.Name = "btn_sessionalpredict";
            this.btn_sessionalpredict.Size = new System.Drawing.Size(337, 184);
            this.btn_sessionalpredict.TabIndex = 38;
            this.btn_sessionalpredict.Text = "Sessional Forecast";
            this.btn_sessionalpredict.UseVisualStyleBackColor = false;
            this.btn_sessionalpredict.Click += new System.EventHandler(this.btn_sessionalpredict_Click);
            // 
            // btn_salepredict
            // 
            this.btn_salepredict.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_salepredict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_salepredict.FlatAppearance.BorderSize = 2;
            this.btn_salepredict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_salepredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salepredict.ForeColor = System.Drawing.Color.White;
            this.btn_salepredict.Location = new System.Drawing.Point(346, 193);
            this.btn_salepredict.Name = "btn_salepredict";
            this.btn_salepredict.Size = new System.Drawing.Size(338, 184);
            this.btn_salepredict.TabIndex = 41;
            this.btn_salepredict.Text = "Sale Forecast";
            this.btn_salepredict.UseVisualStyleBackColor = false;
            this.btn_salepredict.Click += new System.EventHandler(this.btn_salepredict_Click);
            // 
            // btn_productpredict
            // 
            this.btn_productpredict.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_productpredict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_productpredict.FlatAppearance.BorderSize = 2;
            this.btn_productpredict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_productpredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productpredict.ForeColor = System.Drawing.Color.White;
            this.btn_productpredict.Location = new System.Drawing.Point(346, 3);
            this.btn_productpredict.Name = "btn_productpredict";
            this.btn_productpredict.Size = new System.Drawing.Size(338, 184);
            this.btn_productpredict.TabIndex = 39;
            this.btn_productpredict.Text = "Product Forecast";
            this.btn_productpredict.UseVisualStyleBackColor = false;
            this.btn_productpredict.Click += new System.EventHandler(this.btn_productpredict_Click);
            // 
            // btn_profitpredict
            // 
            this.btn_profitpredict.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_profitpredict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_profitpredict.FlatAppearance.BorderSize = 2;
            this.btn_profitpredict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_profitpredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profitpredict.ForeColor = System.Drawing.Color.White;
            this.btn_profitpredict.Location = new System.Drawing.Point(3, 193);
            this.btn_profitpredict.Name = "btn_profitpredict";
            this.btn_profitpredict.Size = new System.Drawing.Size(337, 184);
            this.btn_profitpredict.TabIndex = 40;
            this.btn_profitpredict.Text = "Profit Forecast";
            this.btn_profitpredict.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(687, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BackUp Data";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.Controls.Add(this.lbl_savenoti);
            this.panel5.Controls.Add(this.btn_opendb);
            this.panel5.Controls.Add(this.tft_restoredb);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btn_restoredb);
            this.panel5.Controls.Add(this.btn_backup);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(687, 380);
            this.panel5.TabIndex = 43;
            // 
            // lbl_savenoti
            // 
            this.lbl_savenoti.AutoSize = true;
            this.lbl_savenoti.Location = new System.Drawing.Point(310, 272);
            this.lbl_savenoti.Name = "lbl_savenoti";
            this.lbl_savenoti.Size = new System.Drawing.Size(0, 0);
            this.lbl_savenoti.TabIndex = 42;
            this.lbl_savenoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tft_restoredb
            // 
            // 
            // 
            // 
            this.tft_restoredb.CustomButton.Image = null;
            this.tft_restoredb.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.tft_restoredb.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tft_restoredb.CustomButton.Name = "";
            this.tft_restoredb.CustomButton.Size = new System.Drawing.Size(20, 18);
            this.tft_restoredb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_restoredb.CustomButton.TabIndex = 1;
            this.tft_restoredb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_restoredb.CustomButton.UseSelectable = true;
            this.tft_restoredb.CustomButton.Visible = false;
            this.tft_restoredb.Lines = new string[0];
            this.tft_restoredb.Location = new System.Drawing.Point(120, 133);
            this.tft_restoredb.MaxLength = 32767;
            this.tft_restoredb.Name = "tft_restoredb";
            this.tft_restoredb.PasswordChar = '\0';
            this.tft_restoredb.PromptText = "Select Backup file to restore";
            this.tft_restoredb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_restoredb.SelectedText = "";
            this.tft_restoredb.SelectionLength = 0;
            this.tft_restoredb.SelectionStart = 0;
            this.tft_restoredb.ShortcutsEnabled = true;
            this.tft_restoredb.Size = new System.Drawing.Size(426, 25);
            this.tft_restoredb.TabIndex = 40;
            this.tft_restoredb.UseSelectable = true;
            this.tft_restoredb.WaterMark = "Select Backup file to restore";
            this.tft_restoredb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_restoredb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "BackUp && Restore Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_restoredb
            // 
            this.btn_restoredb.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_restoredb.FlatAppearance.BorderSize = 0;
            this.btn_restoredb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_restoredb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restoredb.ForeColor = System.Drawing.Color.White;
            this.btn_restoredb.Location = new System.Drawing.Point(328, 174);
            this.btn_restoredb.Name = "btn_restoredb";
            this.btn_restoredb.Size = new System.Drawing.Size(158, 56);
            this.btn_restoredb.TabIndex = 39;
            this.btn_restoredb.Text = "Restore";
            this.btn_restoredb.UseVisualStyleBackColor = false;
            this.btn_restoredb.Click += new System.EventHandler(this.btn_restoredb_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_backup.FlatAppearance.BorderSize = 0;
            this.btn_backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.Location = new System.Drawing.Point(120, 174);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(158, 56);
            this.btn_backup.TabIndex = 38;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Database";
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cancel.Image")));
            this.pictureBox_cancel.Location = new System.Drawing.Point(906, 4);
            this.pictureBox_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(26, 27);
            this.pictureBox_cancel.TabIndex = 4;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Visible = false;
            // 
            // btn_opendb
            // 
            this.btn_opendb.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_opendb.FlatAppearance.BorderSize = 0;
            this.btn_opendb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_opendb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opendb.ForeColor = System.Drawing.Color.White;
            this.btn_opendb.Image = ((System.Drawing.Image)(resources.GetObject("btn_opendb.Image")));
            this.btn_opendb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_opendb.Location = new System.Drawing.Point(552, 133);
            this.btn_opendb.Name = "btn_opendb";
            this.btn_opendb.Size = new System.Drawing.Size(114, 23);
            this.btn_opendb.TabIndex = 41;
            this.btn_opendb.Text = "   Open .Bak";
            this.btn_opendb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_opendb.UseVisualStyleBackColor = false;
            this.btn_opendb.Click += new System.EventHandler(this.btn_opendb_Click);
            // 
            // Form_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(935, 648);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_settings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_settings_KeyDown);
            this.Resize += new System.EventHandler(this.Form_settings_Resize);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_categoryitle;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox tft_address;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox tft_storename;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button btn_sessionalpredict;
        public System.Windows.Forms.Button btn_salepredict;
        public System.Windows.Forms.Button btn_productpredict;
        public System.Windows.Forms.Button btn_profitpredict;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_restoredb;
        public System.Windows.Forms.Button btn_backup;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_opendb;
        private MetroFramework.Controls.MetroTextBox tft_restoredb;
        private System.Windows.Forms.OpenFileDialog openbackupfile;
        private MetroFramework.Controls.MetroLabel lbl_savenoti;
    }
}