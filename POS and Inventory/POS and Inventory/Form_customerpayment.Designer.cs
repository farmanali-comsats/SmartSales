namespace POS_and_Inventory
{
    partial class Form_customerpayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_customerpayment));
            this.tft_balance = new System.Windows.Forms.TextBox();
            this.lblptotal = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_paynow = new System.Windows.Forms.Button();
            this.tft_cash = new System.Windows.Forms.TextBox();
            this.lblpay = new System.Windows.Forms.Label();
            this.tft_debit = new System.Windows.Forms.TextBox();
            this.lblnbalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tft_cname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_cid = new System.Windows.Forms.Label();
            this.lblcheck = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tft_balance
            // 
            this.tft_balance.Enabled = false;
            this.tft_balance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_balance.Location = new System.Drawing.Point(158, 93);
            this.tft_balance.Name = "tft_balance";
            this.tft_balance.Size = new System.Drawing.Size(182, 25);
            this.tft_balance.TabIndex = 96;
            this.tft_balance.Text = "0.00";
            this.tft_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblptotal
            // 
            this.lblptotal.Location = new System.Drawing.Point(34, 96);
            this.lblptotal.Name = "lblptotal";
            this.lblptotal.Size = new System.Drawing.Size(116, 25);
            this.lblptotal.TabIndex = 108;
            this.lblptotal.Text = "Previous Balance";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(158, 246);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(182, 44);
            this.btn_cancel.TabIndex = 101;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_paynow
            // 
            this.btn_paynow.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_paynow.FlatAppearance.BorderSize = 0;
            this.btn_paynow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_paynow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paynow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paynow.ForeColor = System.Drawing.Color.White;
            this.btn_paynow.Location = new System.Drawing.Point(158, 196);
            this.btn_paynow.Name = "btn_paynow";
            this.btn_paynow.Size = new System.Drawing.Size(182, 44);
            this.btn_paynow.TabIndex = 100;
            this.btn_paynow.Text = "Save";
            this.btn_paynow.UseVisualStyleBackColor = false;
            this.btn_paynow.Click += new System.EventHandler(this.btn_paynow_Click);
            // 
            // tft_cash
            // 
            this.tft_cash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_cash.Location = new System.Drawing.Point(158, 124);
            this.tft_cash.Name = "tft_cash";
            this.tft_cash.Size = new System.Drawing.Size(182, 25);
            this.tft_cash.TabIndex = 97;
            this.tft_cash.Text = "0.00";
            this.tft_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tft_cash.TextChanged += new System.EventHandler(this.tft_cash_TextChanged);
            // 
            // lblpay
            // 
            this.lblpay.Location = new System.Drawing.Point(34, 127);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(116, 25);
            this.lblpay.TabIndex = 107;
            this.lblpay.Text = "Current Payment";
            // 
            // tft_debit
            // 
            this.tft_debit.Enabled = false;
            this.tft_debit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_debit.Location = new System.Drawing.Point(158, 155);
            this.tft_debit.Name = "tft_debit";
            this.tft_debit.Size = new System.Drawing.Size(182, 25);
            this.tft_debit.TabIndex = 98;
            this.tft_debit.Text = "0.00";
            this.tft_debit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblnbalance
            // 
            this.lblnbalance.Location = new System.Drawing.Point(34, 158);
            this.lblnbalance.Name = "lblnbalance";
            this.lblnbalance.Size = new System.Drawing.Size(116, 25);
            this.lblnbalance.TabIndex = 105;
            this.lblnbalance.Text = "New Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 40);
            this.label3.TabIndex = 103;
            this.label3.Text = "Customer Payment";
            // 
            // tft_cname
            // 
            this.tft_cname.Enabled = false;
            this.tft_cname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_cname.Location = new System.Drawing.Point(158, 62);
            this.tft_cname.Name = "tft_cname";
            this.tft_cname.Size = new System.Drawing.Size(182, 25);
            this.tft_cname.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 104;
            this.label1.Text = "Customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_cid
            // 
            this.lbl_cid.AutoSize = true;
            this.lbl_cid.Enabled = false;
            this.lbl_cid.Location = new System.Drawing.Point(34, 212);
            this.lbl_cid.Name = "lbl_cid";
            this.lbl_cid.Size = new System.Drawing.Size(0, 17);
            this.lbl_cid.TabIndex = 110;
            this.lbl_cid.Visible = false;
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Enabled = false;
            this.lblcheck.Location = new System.Drawing.Point(23, 27);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(0, 17);
            this.lblcheck.TabIndex = 111;
            this.lblcheck.Visible = false;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(26, 196);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(126, 25);
            this.dtp.TabIndex = 112;
            this.dtp.Visible = false;
            // 
            // Form_customerpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(371, 309);
            this.ControlBox = false;
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lblcheck);
            this.Controls.Add(this.lbl_cid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tft_balance);
            this.Controls.Add(this.lblptotal);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_paynow);
            this.Controls.Add(this.tft_cash);
            this.Controls.Add(this.lblpay);
            this.Controls.Add(this.tft_debit);
            this.Controls.Add(this.lblnbalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tft_cname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_customerpayment";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_customerpayment_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tft_balance;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_paynow;
        public System.Windows.Forms.TextBox tft_cash;
        public System.Windows.Forms.TextBox tft_debit;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tft_cname;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_cid;
        public System.Windows.Forms.Label lblptotal;
        public System.Windows.Forms.Label lblpay;
        public System.Windows.Forms.Label lblnbalance;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblcheck;
        public System.Windows.Forms.DateTimePicker dtp;
    }
}