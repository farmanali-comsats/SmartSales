namespace POS_and_Inventory
{
    partial class Form_CancelDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CancelDetails));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_cancel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tft_id = new System.Windows.Forms.TextBox();
            this.tft_pcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tft_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tft_transno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tft_qty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tft_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tft_voidby = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tft_total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tft_reason = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tft_cby = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_addtoinv = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tft_cqty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tft_discount = new System.Windows.Forms.TextBox();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.picbox_cancel);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(705, 40);
            this.panel_top.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cancel Order Details";
            // 
            // picbox_cancel
            // 
            this.picbox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cancel.Image")));
            this.picbox_cancel.Location = new System.Drawing.Point(677, 4);
            this.picbox_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picbox_cancel.Name = "picbox_cancel";
            this.picbox_cancel.Size = new System.Drawing.Size(25, 27);
            this.picbox_cancel.TabIndex = 0;
            this.picbox_cancel.TabStop = false;
            this.picbox_cancel.Click += new System.EventHandler(this.picbox_cancel_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // tft_id
            // 
            this.tft_id.Enabled = false;
            this.tft_id.Location = new System.Drawing.Point(128, 75);
            this.tft_id.Name = "tft_id";
            this.tft_id.Size = new System.Drawing.Size(224, 25);
            this.tft_id.TabIndex = 5;
            // 
            // tft_pcode
            // 
            this.tft_pcode.Enabled = false;
            this.tft_pcode.Location = new System.Drawing.Point(127, 106);
            this.tft_pcode.Name = "tft_pcode";
            this.tft_pcode.Size = new System.Drawing.Size(224, 25);
            this.tft_pcode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(357, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transaction No";
            // 
            // tft_desc
            // 
            this.tft_desc.Enabled = false;
            this.tft_desc.Location = new System.Drawing.Point(127, 137);
            this.tft_desc.Multiline = true;
            this.tft_desc.Name = "tft_desc";
            this.tft_desc.Size = new System.Drawing.Size(224, 65);
            this.tft_desc.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // tft_transno
            // 
            this.tft_transno.Enabled = false;
            this.tft_transno.Location = new System.Drawing.Point(475, 75);
            this.tft_transno.Name = "tft_transno";
            this.tft_transno.Size = new System.Drawing.Size(217, 25);
            this.tft_transno.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product Code";
            // 
            // tft_qty
            // 
            this.tft_qty.Enabled = false;
            this.tft_qty.Location = new System.Drawing.Point(475, 137);
            this.tft_qty.Name = "tft_qty";
            this.tft_qty.Size = new System.Drawing.Size(100, 25);
            this.tft_qty.TabIndex = 15;
            this.tft_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(357, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantity/Discount";
            // 
            // tft_price
            // 
            this.tft_price.Enabled = false;
            this.tft_price.Location = new System.Drawing.Point(475, 106);
            this.tft_price.Name = "tft_price";
            this.tft_price.Size = new System.Drawing.Size(217, 25);
            this.tft_price.TabIndex = 13;
            this.tft_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(357, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Price";
            // 
            // tft_voidby
            // 
            this.tft_voidby.Enabled = false;
            this.tft_voidby.Location = new System.Drawing.Point(127, 259);
            this.tft_voidby.Name = "tft_voidby";
            this.tft_voidby.Size = new System.Drawing.Size(224, 25);
            this.tft_voidby.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Void By";
            // 
            // tft_total
            // 
            this.tft_total.Enabled = false;
            this.tft_total.Location = new System.Drawing.Point(475, 169);
            this.tft_total.Name = "tft_total";
            this.tft_total.Size = new System.Drawing.Size(217, 25);
            this.tft_total.TabIndex = 17;
            this.tft_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(357, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total";
            // 
            // tft_reason
            // 
            this.tft_reason.Location = new System.Drawing.Point(475, 290);
            this.tft_reason.Multiline = true;
            this.tft_reason.Name = "tft_reason";
            this.tft_reason.Size = new System.Drawing.Size(217, 56);
            this.tft_reason.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Add To Inventory?";
            // 
            // tft_cby
            // 
            this.tft_cby.Enabled = false;
            this.tft_cby.Location = new System.Drawing.Point(127, 290);
            this.tft_cby.Name = "tft_cby";
            this.tft_cby.Size = new System.Drawing.Size(224, 25);
            this.tft_cby.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(8, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cancelled By";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(357, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 30);
            this.label12.TabIndex = 24;
            this.label12.Text = "Reason(s)";
            // 
            // cb_addtoinv
            // 
            this.cb_addtoinv.FormattingEnabled = true;
            this.cb_addtoinv.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_addtoinv.Location = new System.Drawing.Point(127, 321);
            this.cb_addtoinv.Name = "cb_addtoinv";
            this.cb_addtoinv.Size = new System.Drawing.Size(224, 25);
            this.cb_addtoinv.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(8, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Sold Item";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(8, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Cancel Item(s)";
            // 
            // tft_cqty
            // 
            this.tft_cqty.Location = new System.Drawing.Point(475, 259);
            this.tft_cqty.Name = "tft_cqty";
            this.tft_cqty.Size = new System.Drawing.Size(217, 25);
            this.tft_cqty.TabIndex = 23;
            this.tft_cqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(357, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Cancel Quantity";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(515, 362);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(177, 41);
            this.btn_confirm.TabIndex = 31;
            this.btn_confirm.Text = "Cancel Order";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // tft_discount
            // 
            this.tft_discount.Enabled = false;
            this.tft_discount.Location = new System.Drawing.Point(581, 137);
            this.tft_discount.Name = "tft_discount";
            this.tft_discount.Size = new System.Drawing.Size(111, 25);
            this.tft_discount.TabIndex = 31;
            this.tft_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form_CancelDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(705, 418);
            this.ControlBox = false;
            this.Controls.Add(this.tft_discount);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tft_cqty);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_addtoinv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tft_reason);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tft_cby);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tft_voidby);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tft_total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tft_qty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tft_price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tft_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tft_transno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tft_pcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tft_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_CancelDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_CancelDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_CancelDetails_KeyDown);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_confirm;
        public System.Windows.Forms.TextBox tft_id;
        public System.Windows.Forms.TextBox tft_pcode;
        public System.Windows.Forms.TextBox tft_desc;
        public System.Windows.Forms.TextBox tft_transno;
        public System.Windows.Forms.TextBox tft_qty;
        public System.Windows.Forms.TextBox tft_price;
        public System.Windows.Forms.TextBox tft_voidby;
        public System.Windows.Forms.TextBox tft_total;
        public System.Windows.Forms.TextBox tft_reason;
        public System.Windows.Forms.TextBox tft_cby;
        public System.Windows.Forms.ComboBox cb_addtoinv;
        public System.Windows.Forms.TextBox tft_cqty;
        public System.Windows.Forms.TextBox tft_discount;
    }
}