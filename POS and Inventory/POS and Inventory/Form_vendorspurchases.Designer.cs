namespace POS_and_Inventory
{
    partial class Form_vendorspurchases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_vendorspurchases));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.picbox_add = new System.Windows.Forms.PictureBox();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.lbl_TITLE = new System.Windows.Forms.Label();
            this.tft_search = new MetroFramework.Controls.MetroTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tbalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Column_vendor,
            this.cbill,
            this.col_Total,
            this.col_credit,
            this.col_debit,
            this.col_tbalance,
            this.col_date,
            this.col_pay,
            this.select,
            this.delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 602);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.tft_search);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.picbox_add);
            this.panel1.Controls.Add(this.pictureBox_cancel);
            this.panel1.Controls.Add(this.lbl_TITLE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 41);
            this.panel1.TabIndex = 6;
            // 
            // lbl_id
            // 
            this.lbl_id.Enabled = false;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(306, 16);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 10);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_id.Visible = false;
            // 
            // picbox_add
            // 
            this.picbox_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_add.Image = ((System.Drawing.Image)(resources.GetObject("picbox_add.Image")));
            this.picbox_add.Location = new System.Drawing.Point(924, 4);
            this.picbox_add.Name = "picbox_add";
            this.picbox_add.Size = new System.Drawing.Size(25, 28);
            this.picbox_add.TabIndex = 5;
            this.picbox_add.TabStop = false;
            this.picbox_add.Click += new System.EventHandler(this.picbox_add_Click);
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cancel.Image")));
            this.pictureBox_cancel.Location = new System.Drawing.Point(955, 4);
            this.pictureBox_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(26, 27);
            this.pictureBox_cancel.TabIndex = 4;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Click += new System.EventHandler(this.pictureBox_cancel_Click);
            // 
            // lbl_TITLE
            // 
            this.lbl_TITLE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TITLE.Location = new System.Drawing.Point(3, 4);
            this.lbl_TITLE.Name = "lbl_TITLE";
            this.lbl_TITLE.Size = new System.Drawing.Size(164, 35);
            this.lbl_TITLE.TabIndex = 0;
            this.lbl_TITLE.Text = "Vendor History";
            this.lbl_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tft_search
            // 
            this.tft_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tft_search.Location = new System.Drawing.Point(506, 7);
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
            this.tft_search.TabIndex = 7;
            this.tft_search.UseSelectable = true;
            this.tft_search.WaterMark = "Search Here";
            this.tft_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tft_search.TextChanged += new System.EventHandler(this.tft_search_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lbl_tbalance);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbl_total);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 605);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 38);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(260, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 38);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total Balance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_tbalance
            // 
            this.lbl_tbalance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_tbalance.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_tbalance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tbalance.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_tbalance.Location = new System.Drawing.Point(444, 0);
            this.lbl_tbalance.Name = "lbl_tbalance";
            this.lbl_tbalance.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbl_tbalance.Size = new System.Drawing.Size(178, 38);
            this.lbl_tbalance.TabIndex = 26;
            this.lbl_tbalance.Text = "0.00";
            this.lbl_tbalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(622, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Purchases";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_total.Location = new System.Drawing.Point(800, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(184, 38);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "0.00";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SNo
            // 
            this.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SNo.HeaderText = "#";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 39;
            // 
            // Column_ID
            // 
            this.Column_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Width = 43;
            // 
            // Column_vendor
            // 
            this.Column_vendor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_vendor.HeaderText = "Vendor";
            this.Column_vendor.Name = "Column_vendor";
            this.Column_vendor.ReadOnly = true;
            this.Column_vendor.Width = 73;
            // 
            // cbill
            // 
            this.cbill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cbill.HeaderText = "Company Bill #";
            this.cbill.Name = "cbill";
            this.cbill.ReadOnly = true;
            this.cbill.Width = 118;
            // 
            // col_Total
            // 
            this.col_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_Total.HeaderText = "Bill Total";
            this.col_Total.Name = "col_Total";
            this.col_Total.ReadOnly = true;
            this.col_Total.Width = 79;
            // 
            // col_credit
            // 
            this.col_credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_credit.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_credit.HeaderText = "Credit";
            this.col_credit.Name = "col_credit";
            this.col_credit.ReadOnly = true;
            this.col_credit.Width = 66;
            // 
            // col_debit
            // 
            this.col_debit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_debit.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_debit.HeaderText = "Debit";
            this.col_debit.Name = "col_debit";
            this.col_debit.ReadOnly = true;
            this.col_debit.Width = 62;
            // 
            // col_tbalance
            // 
            this.col_tbalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_tbalance.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_tbalance.HeaderText = "Total Balance";
            this.col_tbalance.Name = "col_tbalance";
            this.col_tbalance.ReadOnly = true;
            this.col_tbalance.Width = 107;
            // 
            // col_date
            // 
            this.col_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_date.HeaderText = "Date";
            this.col_date.MinimumWidth = 150;
            this.col_date.Name = "col_date";
            this.col_date.ReadOnly = true;
            this.col_date.Width = 150;
            // 
            // col_pay
            // 
            this.col_pay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_pay.HeaderText = "Complete Payment";
            this.col_pay.MinimumWidth = 150;
            this.col_pay.Name = "col_pay";
            this.col_pay.ReadOnly = true;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.select.HeaderText = "";
            this.select.Image = ((System.Drawing.Image)(resources.GetObject("select.Image")));
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.select.Visible = false;
            this.select.Width = 17;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 17;
            // 
            // Form_vendorspurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(984, 643);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_vendorspurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Form_vendorspurchases_Activated);
            this.Load += new System.EventHandler(this.Form_vendorspurchases_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_vendorspurchases_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picbox_add;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
        private System.Windows.Forms.Label lbl_TITLE;
        public System.Windows.Forms.Label lbl_id;
        private MetroFramework.Controls.MetroTextBox tft_search;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tbalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tbalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pay;
        private System.Windows.Forms.DataGridViewImageColumn select;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}