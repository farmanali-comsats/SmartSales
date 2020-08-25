namespace POS_and_Inventory
{
    partial class Form_customerpurchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_customerpurchases));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.picbox_add = new System.Windows.Forms.PictureBox();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.lbl_TITLE = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.col_sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_transno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_payed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tbal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_paymentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tbalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.picbox_debit = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_debit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.picbox_debit);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.picbox_add);
            this.panel1.Controls.Add(this.pictureBox_cancel);
            this.panel1.Controls.Add(this.lbl_TITLE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 37);
            this.panel1.TabIndex = 7;
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
            this.picbox_add.Location = new System.Drawing.Point(976, 4);
            this.picbox_add.Name = "picbox_add";
            this.picbox_add.Size = new System.Drawing.Size(67, 28);
            this.picbox_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_add.TabIndex = 5;
            this.picbox_add.TabStop = false;
            this.picbox_add.Click += new System.EventHandler(this.picbox_add_Click);
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cancel.Image")));
            this.pictureBox_cancel.Location = new System.Drawing.Point(1049, 4);
            this.pictureBox_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(26, 27);
            this.pictureBox_cancel.TabIndex = 4;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Click += new System.EventHandler(this.pictureBox_cancel_Click);
            // 
            // lbl_TITLE
            // 
            this.lbl_TITLE.AutoSize = true;
            this.lbl_TITLE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TITLE.Location = new System.Drawing.Point(3, 4);
            this.lbl_TITLE.Name = "lbl_TITLE";
            this.lbl_TITLE.Size = new System.Drawing.Size(267, 25);
            this.lbl_TITLE.TabIndex = 0;
            this.lbl_TITLE.Text = "Customer Purchases Records";
            this.lbl_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_sno,
            this.col_cid,
            this.col_name,
            this.col_transno,
            this.col_total,
            this.col_payed,
            this.col_balance,
            this.col_change,
            this.col_tbal,
            this.col_date,
            this.col_paymentdate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1078, 650);
            this.dataGridView2.TabIndex = 8;
            // 
            // col_sno
            // 
            this.col_sno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_sno.HeaderText = "#";
            this.col_sno.Name = "col_sno";
            this.col_sno.ReadOnly = true;
            this.col_sno.Width = 39;
            // 
            // col_cid
            // 
            this.col_cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_cid.HeaderText = "Customer ID";
            this.col_cid.Name = "col_cid";
            this.col_cid.ReadOnly = true;
            this.col_cid.Width = 103;
            // 
            // col_name
            // 
            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 66;
            // 
            // col_transno
            // 
            this.col_transno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_transno.HeaderText = "Transaction #";
            this.col_transno.Name = "col_transno";
            this.col_transno.ReadOnly = true;
            this.col_transno.Width = 109;
            // 
            // col_total
            // 
            this.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_total.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_total.HeaderText = "Total";
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            this.col_total.Width = 59;
            // 
            // col_payed
            // 
            this.col_payed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_payed.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_payed.HeaderText = "Payed";
            this.col_payed.Name = "col_payed";
            this.col_payed.ReadOnly = true;
            this.col_payed.Width = 66;
            // 
            // col_balance
            // 
            this.col_balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_balance.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_balance.HeaderText = "Balance";
            this.col_balance.Name = "col_balance";
            this.col_balance.ReadOnly = true;
            this.col_balance.Width = 75;
            // 
            // col_change
            // 
            this.col_change.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_change.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_change.HeaderText = "Change";
            this.col_change.Name = "col_change";
            this.col_change.ReadOnly = true;
            this.col_change.Width = 75;
            // 
            // col_tbal
            // 
            this.col_tbal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_tbal.HeaderText = "Total Balance";
            this.col_tbal.Name = "col_tbal";
            this.col_tbal.ReadOnly = true;
            this.col_tbal.Width = 107;
            // 
            // col_date
            // 
            this.col_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_date.HeaderText = "Purchase Date";
            this.col_date.Name = "col_date";
            this.col_date.ReadOnly = true;
            this.col_date.Width = 114;
            // 
            // col_paymentdate
            // 
            this.col_paymentdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_paymentdate.HeaderText = "Payment Date";
            this.col_paymentdate.Name = "col_paymentdate";
            this.col_paymentdate.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lbl_tbalance);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbl_total);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 645);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1078, 42);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(354, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 42);
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
            this.lbl_tbalance.Location = new System.Drawing.Point(538, 0);
            this.lbl_tbalance.Name = "lbl_tbalance";
            this.lbl_tbalance.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbl_tbalance.Size = new System.Drawing.Size(178, 42);
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
            this.label1.Location = new System.Drawing.Point(716, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 42);
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
            this.lbl_total.Location = new System.Drawing.Point(894, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(184, 42);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "0.00";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picbox_debit
            // 
            this.picbox_debit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_debit.Image = ((System.Drawing.Image)(resources.GetObject("picbox_debit.Image")));
            this.picbox_debit.Location = new System.Drawing.Point(903, 4);
            this.picbox_debit.Name = "picbox_debit";
            this.picbox_debit.Size = new System.Drawing.Size(67, 28);
            this.picbox_debit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_debit.TabIndex = 7;
            this.picbox_debit.TabStop = false;
            this.picbox_debit.Click += new System.EventHandler(this.picbox_debit_Click);
            // 
            // lblname
            // 
            this.lblname.Enabled = false;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(533, 13);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(13, 10);
            this.lblname.TabIndex = 8;
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblname.Visible = false;
            // 
            // Form_customerpurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1078, 687);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_customerpurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Form_customerpurchases_Activated);
            this.Load += new System.EventHandler(this.Form_customerpurchases_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_customerpurchases_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_debit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.PictureBox picbox_add;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
        private System.Windows.Forms.Label lbl_TITLE;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tbalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_transno;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_payed;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_change;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tbal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_paymentdate;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox picbox_debit;
        public System.Windows.Forms.Label lblname;
    }
}