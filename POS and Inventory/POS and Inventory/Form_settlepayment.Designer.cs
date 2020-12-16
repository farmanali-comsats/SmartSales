namespace POS_and_Inventory
{
    partial class Form_settlepayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_settlepayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_stokintitle = new System.Windows.Forms.Label();
            this.tft_sale = new System.Windows.Forms.TextBox();
            this.tft_cash = new System.Windows.Forms.TextBox();
            this.tft_change = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.tft_customer = new System.Windows.Forms.TextBox();
            this.checkbox_customer = new System.Windows.Forms.CheckBox();
            this.lbl_cid = new System.Windows.Forms.Label();
            this.btn_paylater = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(283, 34);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_stokintitle
            // 
            this.lbl_stokintitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stokintitle.Location = new System.Drawing.Point(4, 5);
            this.lbl_stokintitle.Name = "lbl_stokintitle";
            this.lbl_stokintitle.Size = new System.Drawing.Size(158, 25);
            this.lbl_stokintitle.TabIndex = 0;
            this.lbl_stokintitle.Text = "Settle Payment";
            // 
            // tft_sale
            // 
            this.tft_sale.BackColor = System.Drawing.Color.White;
            this.tft_sale.Enabled = false;
            this.tft_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_sale.Location = new System.Drawing.Point(9, 98);
            this.tft_sale.Name = "tft_sale";
            this.tft_sale.Size = new System.Drawing.Size(266, 38);
            this.tft_sale.TabIndex = 7;
            this.tft_sale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tft_cash
            // 
            this.tft_cash.BackColor = System.Drawing.Color.White;
            this.tft_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_cash.Location = new System.Drawing.Point(9, 153);
            this.tft_cash.Name = "tft_cash";
            this.tft_cash.Size = new System.Drawing.Size(266, 38);
            this.tft_cash.TabIndex = 6;
            this.tft_cash.Text = "0.00";
            this.tft_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tft_cash.TextChanged += new System.EventHandler(this.tft_cash_TextChanged);
            this.tft_cash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tft_cash_KeyDown);
            // 
            // tft_change
            // 
            this.tft_change.BackColor = System.Drawing.Color.White;
            this.tft_change.Enabled = false;
            this.tft_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_change.Location = new System.Drawing.Point(9, 210);
            this.tft_change.Name = "tft_change";
            this.tft_change.Size = new System.Drawing.Size(266, 38);
            this.tft_change.TabIndex = 8;
            this.tft_change.Text = "0.00";
            this.tft_change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.White;
            this.btn_enter.Location = new System.Drawing.Point(9, 459);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(266, 50);
            this.btn_enter.TabIndex = 59;
            this.btn_enter.Text = "PAY NOW";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_00
            // 
            this.btn_00.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_00.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_00.ForeColor = System.Drawing.Color.White;
            this.btn_00.Location = new System.Drawing.Point(213, 391);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(62, 62);
            this.btn_00.TabIndex = 58;
            this.btn_00.Text = "00";
            this.btn_00.UseVisualStyleBackColor = false;
            this.btn_00.Click += new System.EventHandler(this.btn_00_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(145, 391);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(62, 62);
            this.btn_3.TabIndex = 57;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(77, 391);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(62, 62);
            this.btn_2.TabIndex = 56;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(9, 391);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(62, 62);
            this.btn_1.TabIndex = 55;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(213, 323);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(62, 62);
            this.btn_0.TabIndex = 54;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(145, 323);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(62, 62);
            this.btn_6.TabIndex = 53;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(77, 323);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(62, 62);
            this.btn_5.TabIndex = 52;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(9, 323);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(62, 62);
            this.btn_4.TabIndex = 51;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.ForeColor = System.Drawing.Color.White;
            this.btn_c.Location = new System.Drawing.Point(213, 254);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(62, 62);
            this.btn_c.TabIndex = 50;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(145, 254);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(62, 62);
            this.btn_9.TabIndex = 49;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(77, 254);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(62, 62);
            this.btn_8.TabIndex = 48;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(9, 254);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(62, 62);
            this.btn_7.TabIndex = 47;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // tft_customer
            // 
            this.tft_customer.BackColor = System.Drawing.Color.White;
            this.tft_customer.Enabled = false;
            this.tft_customer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_customer.Location = new System.Drawing.Point(9, 49);
            this.tft_customer.Name = "tft_customer";
            this.tft_customer.ReadOnly = true;
            this.tft_customer.Size = new System.Drawing.Size(266, 33);
            this.tft_customer.TabIndex = 60;
            this.tft_customer.Text = "Default";
            // 
            // checkbox_customer
            // 
            this.checkbox_customer.AutoSize = true;
            this.checkbox_customer.Location = new System.Drawing.Point(254, 58);
            this.checkbox_customer.Name = "checkbox_customer";
            this.checkbox_customer.Size = new System.Drawing.Size(15, 14);
            this.checkbox_customer.TabIndex = 62;
            this.checkbox_customer.UseVisualStyleBackColor = true;
            this.checkbox_customer.CheckedChanged += new System.EventHandler(this.checkbox_customer_CheckedChanged);
            this.checkbox_customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkbox_customer_KeyDown);
            // 
            // lbl_cid
            // 
            this.lbl_cid.AutoSize = true;
            this.lbl_cid.Enabled = false;
            this.lbl_cid.Location = new System.Drawing.Point(6, 37);
            this.lbl_cid.Name = "lbl_cid";
            this.lbl_cid.Size = new System.Drawing.Size(0, 13);
            this.lbl_cid.TabIndex = 63;
            this.lbl_cid.Visible = false;
            // 
            // btn_paylater
            // 
            this.btn_paylater.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_paylater.Enabled = false;
            this.btn_paylater.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_paylater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paylater.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paylater.ForeColor = System.Drawing.Color.White;
            this.btn_paylater.Location = new System.Drawing.Point(9, 515);
            this.btn_paylater.Name = "btn_paylater";
            this.btn_paylater.Size = new System.Drawing.Size(266, 50);
            this.btn_paylater.TabIndex = 64;
            this.btn_paylater.Text = "Pay Later";
            this.btn_paylater.UseVisualStyleBackColor = false;
            this.btn_paylater.Click += new System.EventHandler(this.btn_paylater_Click);
            // 
            // Form_settlepayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(283, 574);
            this.ControlBox = false;
            this.Controls.Add(this.btn_paylater);
            this.Controls.Add(this.lbl_cid);
            this.Controls.Add(this.checkbox_customer);
            this.Controls.Add(this.tft_customer);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_00);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.tft_change);
            this.Controls.Add(this.tft_cash);
            this.Controls.Add(this.tft_sale);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_settlepayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_settlepayment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_settlepayment_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_stokintitle;
        public System.Windows.Forms.Button btn_enter;
        public System.Windows.Forms.Button btn_00;
        public System.Windows.Forms.Button btn_3;
        public System.Windows.Forms.Button btn_2;
        public System.Windows.Forms.Button btn_1;
        public System.Windows.Forms.Button btn_0;
        public System.Windows.Forms.Button btn_6;
        public System.Windows.Forms.Button btn_5;
        public System.Windows.Forms.Button btn_4;
        public System.Windows.Forms.Button btn_c;
        public System.Windows.Forms.Button btn_9;
        public System.Windows.Forms.Button btn_8;
        public System.Windows.Forms.Button btn_7;
        public System.Windows.Forms.TextBox tft_sale;
        public System.Windows.Forms.TextBox tft_cash;
        public System.Windows.Forms.TextBox tft_change;
        public System.Windows.Forms.TextBox tft_customer;
        private System.Windows.Forms.CheckBox checkbox_customer;
        public System.Windows.Forms.Label lbl_cid;
        public System.Windows.Forms.Button btn_paylater;
    }
}