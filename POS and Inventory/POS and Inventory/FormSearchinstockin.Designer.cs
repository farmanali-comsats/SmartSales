namespace POS_and_Inventory
{
    partial class FormSearchinstockin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchinstockin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chb_bcode = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tft_bcode = new MetroFramework.Controls.MetroTextBox();
            this.tft_search = new MetroFramework.Controls.MetroTextBox();
            this.picbox_cancel = new System.Windows.Forms.PictureBox();
            this.lbl_stokintitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.chb_bcode);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picbox_cancel);
            this.panel1.Controls.Add(this.lbl_stokintitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 40);
            this.panel1.TabIndex = 30;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // chb_bcode
            // 
            this.chb_bcode.AutoSize = true;
            this.chb_bcode.Location = new System.Drawing.Point(602, 10);
            this.chb_bcode.Name = "chb_bcode";
            this.chb_bcode.Size = new System.Drawing.Size(75, 21);
            this.chb_bcode.TabIndex = 3;
            this.chb_bcode.Text = "Barcode";
            this.chb_bcode.UseVisualStyleBackColor = true;
            this.chb_bcode.CheckedChanged += new System.EventHandler(this.chb_bcode_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tft_bcode);
            this.panel2.Controls.Add(this.tft_search);
            this.panel2.Location = new System.Drawing.Point(683, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 32);
            this.panel2.TabIndex = 70;
            // 
            // tft_bcode
            // 
            // 
            // 
            // 
            this.tft_bcode.CustomButton.Image = null;
            this.tft_bcode.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.tft_bcode.CustomButton.Name = "";
            this.tft_bcode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_bcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_bcode.CustomButton.TabIndex = 1;
            this.tft_bcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_bcode.CustomButton.UseSelectable = true;
            this.tft_bcode.CustomButton.Visible = false;
            this.tft_bcode.DisplayIcon = true;
            this.tft_bcode.Enabled = false;
            this.tft_bcode.Icon = ((System.Drawing.Image)(resources.GetObject("tft_bcode.Icon")));
            this.tft_bcode.Lines = new string[0];
            this.tft_bcode.Location = new System.Drawing.Point(3, 3);
            this.tft_bcode.MaxLength = 32767;
            this.tft_bcode.Name = "tft_bcode";
            this.tft_bcode.PasswordChar = '\0';
            this.tft_bcode.PromptText = "Search By Barcode Here";
            this.tft_bcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_bcode.SelectedText = "";
            this.tft_bcode.SelectionLength = 0;
            this.tft_bcode.SelectionStart = 0;
            this.tft_bcode.ShortcutsEnabled = true;
            this.tft_bcode.Size = new System.Drawing.Size(353, 25);
            this.tft_bcode.TabIndex = 5;
            this.tft_bcode.UseSelectable = true;
            this.tft_bcode.Visible = false;
            this.tft_bcode.WaterMark = "Search By Barcode Here";
            this.tft_bcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_bcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tft_bcode.TextChanged += new System.EventHandler(this.tft_bcode_TextChanged);
            this.tft_bcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tft_bcode_KeyDown);
            // 
            // tft_search
            // 
            // 
            // 
            // 
            this.tft_search.CustomButton.Image = null;
            this.tft_search.CustomButton.Location = new System.Drawing.Point(329, 1);
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
            this.tft_search.Location = new System.Drawing.Point(3, 4);
            this.tft_search.MaxLength = 32767;
            this.tft_search.Name = "tft_search";
            this.tft_search.PasswordChar = '\0';
            this.tft_search.PromptText = "Search By Name Here";
            this.tft_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_search.SelectedText = "";
            this.tft_search.SelectionLength = 0;
            this.tft_search.SelectionStart = 0;
            this.tft_search.ShortcutsEnabled = true;
            this.tft_search.Size = new System.Drawing.Size(353, 25);
            this.tft_search.TabIndex = 1;
            this.tft_search.UseSelectable = true;
            this.tft_search.WaterMark = "Search By Name Here";
            this.tft_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tft_search.TextChanged += new System.EventHandler(this.tft_search_TextChanged);
            // 
            // picbox_cancel
            // 
            this.picbox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cancel.Image")));
            this.picbox_cancel.Location = new System.Drawing.Point(1048, 3);
            this.picbox_cancel.Name = "picbox_cancel";
            this.picbox_cancel.Size = new System.Drawing.Size(25, 28);
            this.picbox_cancel.TabIndex = 2;
            this.picbox_cancel.TabStop = false;
            this.picbox_cancel.Click += new System.EventHandler(this.picbox_cancel_Click);
            // 
            // lbl_stokintitle
            // 
            this.lbl_stokintitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stokintitle.Location = new System.Drawing.Point(3, 3);
            this.lbl_stokintitle.Name = "lbl_stokintitle";
            this.lbl_stokintitle.Size = new System.Drawing.Size(121, 31);
            this.lbl_stokintitle.TabIndex = 101;
            this.lbl_stokintitle.Text = "Product List";
            this.lbl_stokintitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.p_code,
            this.Column_name,
            this.Column_description,
            this.Category,
            this.Column_qty,
            this.Vendor,
            this.Select});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 645);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // SNo
            // 
            this.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SNo.HeaderText = "#";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 39;
            // 
            // p_code
            // 
            this.p_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_code.HeaderText = "PCode";
            this.p_code.Name = "p_code";
            this.p_code.ReadOnly = true;
            this.p_code.Width = 69;
            // 
            // Column_name
            // 
            this.Column_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_name.HeaderText = "Name";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            this.Column_name.Width = 66;
            // 
            // Column_description
            // 
            this.Column_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_description.HeaderText = "Description";
            this.Column_description.Name = "Column_description";
            this.Column_description.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Category.DefaultCellStyle = dataGridViewCellStyle2;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 84;
            // 
            // Column_qty
            // 
            this.Column_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_qty.HeaderText = "Quantity";
            this.Column_qty.Name = "Column_qty";
            this.Column_qty.ReadOnly = true;
            this.Column_qty.Width = 79;
            // 
            // Vendor
            // 
            this.Vendor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Vendor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Vendor.HeaderText = "Vendor";
            this.Vendor.Name = "Vendor";
            this.Vendor.ReadOnly = true;
            this.Vendor.Width = 73;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 17;
            // 
            // FormSearchinstockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1079, 685);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSearchinstockin";
            this.Load += new System.EventHandler(this.FormSearchinstockin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSearchinstockin_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picbox_cancel;
        private System.Windows.Forms.Label lbl_stokintitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chb_bcode;
        private MetroFramework.Controls.MetroTextBox tft_bcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        public MetroFramework.Controls.MetroTextBox tft_search;
    }
}