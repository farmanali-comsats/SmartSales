namespace POS_and_Inventory
{
    partial class Form_vendortotal
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
            this.tft_total = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tft_credit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tft_debit = new System.Windows.Forms.TextBox();
            this.lblbal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tft_vid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_paynow = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tft_cbill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tft_total
            // 
            this.tft_total.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_total.Location = new System.Drawing.Point(141, 124);
            this.tft_total.Name = "tft_total";
            this.tft_total.Size = new System.Drawing.Size(182, 25);
            this.tft_total.TabIndex = 4;
            this.tft_total.Text = "0.00";
            this.tft_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbltotal
            // 
            this.lbltotal.Location = new System.Drawing.Point(18, 127);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(114, 25);
            this.lbltotal.TabIndex = 90;
            this.lbltotal.Text = "Total";
            // 
            // tft_credit
            // 
            this.tft_credit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_credit.Location = new System.Drawing.Point(141, 155);
            this.tft_credit.Name = "tft_credit";
            this.tft_credit.Size = new System.Drawing.Size(182, 25);
            this.tft_credit.TabIndex = 5;
            this.tft_credit.Text = "0.00";
            this.tft_credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tft_credit.TextChanged += new System.EventHandler(this.tft_credit_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(18, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 87;
            this.label7.Text = "Credit";
            // 
            // tft_debit
            // 
            this.tft_debit.Enabled = false;
            this.tft_debit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_debit.Location = new System.Drawing.Point(141, 186);
            this.tft_debit.Name = "tft_debit";
            this.tft_debit.Size = new System.Drawing.Size(182, 25);
            this.tft_debit.TabIndex = 6;
            this.tft_debit.Text = "0.00";
            this.tft_debit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblbal
            // 
            this.lblbal.Location = new System.Drawing.Point(18, 189);
            this.lblbal.Name = "lblbal";
            this.lblbal.Size = new System.Drawing.Size(114, 25);
            this.lblbal.TabIndex = 88;
            this.lblbal.Text = "Debit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 40);
            this.label3.TabIndex = 85;
            this.label3.Text = "Vendor Purchases";
            // 
            // tft_vid
            // 
            this.tft_vid.Enabled = false;
            this.tft_vid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_vid.Location = new System.Drawing.Point(141, 62);
            this.tft_vid.Name = "tft_vid";
            this.tft_vid.Size = new System.Drawing.Size(182, 25);
            this.tft_vid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "Vendor Name";
            // 
            // btn_paynow
            // 
            this.btn_paynow.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_paynow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_paynow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paynow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paynow.ForeColor = System.Drawing.Color.White;
            this.btn_paynow.Location = new System.Drawing.Point(141, 217);
            this.btn_paynow.Name = "btn_paynow";
            this.btn_paynow.Size = new System.Drawing.Size(182, 44);
            this.btn_paynow.TabIndex = 7;
            this.btn_paynow.Text = "Enter";
            this.btn_paynow.UseVisualStyleBackColor = false;
            this.btn_paynow.Click += new System.EventHandler(this.btn_paynow_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(141, 267);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(182, 44);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Cancel";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tft_cbill
            // 
            this.tft_cbill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tft_cbill.Location = new System.Drawing.Point(141, 93);
            this.tft_cbill.Name = "tft_cbill";
            this.tft_cbill.Size = new System.Drawing.Size(182, 25);
            this.tft_cbill.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 94;
            this.label2.Text = "Company Bill #";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(329, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_vendortotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(355, 325);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tft_cbill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_paynow);
            this.Controls.Add(this.tft_total);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.tft_credit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tft_debit);
            this.Controls.Add(this.lblbal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tft_vid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_vendortotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_vendortotal_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tft_total;
        private System.Windows.Forms.Label lbltotal;
        public System.Windows.Forms.TextBox tft_credit;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tft_debit;
        private System.Windows.Forms.Label lblbal;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tft_vid;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_paynow;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.TextBox tft_cbill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}