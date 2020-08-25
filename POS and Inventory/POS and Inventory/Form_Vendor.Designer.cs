namespace POS_and_Inventory
{
    partial class Form_Vendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vendor));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_cancel = new System.Windows.Forms.PictureBox();
            this.tft_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.tft_address = new System.Windows.Forms.TextBox();
            this.tft_contactperson = new System.Windows.Forms.TextBox();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tft_contactno = new System.Windows.Forms.TextBox();
            this.lbl_contactno = new System.Windows.Forms.Label();
            this.tft_vendor = new System.Windows.Forms.TextBox();
            this.lbl_contperson = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.pb_vendor = new System.Windows.Forms.PictureBox();
            this.pb_conp = new System.Windows.Forms.PictureBox();
            this.pb_contact = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_conp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_contact)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.picbox_cancel);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(584, 29);
            this.panel_top.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendor Details";
            // 
            // picbox_cancel
            // 
            this.picbox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cancel.Image")));
            this.picbox_cancel.Location = new System.Drawing.Point(557, 3);
            this.picbox_cancel.Name = "picbox_cancel";
            this.picbox_cancel.Size = new System.Drawing.Size(24, 23);
            this.picbox_cancel.TabIndex = 0;
            this.picbox_cancel.TabStop = false;
            this.picbox_cancel.Click += new System.EventHandler(this.picbox_cancel_Click);
            // 
            // tft_email
            // 
            this.tft_email.Location = new System.Drawing.Point(135, 220);
            this.tft_email.Name = "tft_email";
            this.tft_email.Size = new System.Drawing.Size(419, 23);
            this.tft_email.TabIndex = 33;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(16, 223);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 15);
            this.lbl_email.TabIndex = 47;
            this.lbl_email.Text = "Email";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(15, 94);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(51, 15);
            this.lbl_address.TabIndex = 45;
            this.lbl_address.Text = "Address";
            // 
            // tft_address
            // 
            this.tft_address.Location = new System.Drawing.Point(135, 91);
            this.tft_address.Name = "tft_address";
            this.tft_address.Size = new System.Drawing.Size(419, 23);
            this.tft_address.TabIndex = 30;
            // 
            // tft_contactperson
            // 
            this.tft_contactperson.Location = new System.Drawing.Point(135, 131);
            this.tft_contactperson.Name = "tft_contactperson";
            this.tft_contactperson.Size = new System.Drawing.Size(419, 23);
            this.tft_contactperson.TabIndex = 31;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.AutoSize = true;
            this.lbl_vendor.Location = new System.Drawing.Point(15, 53);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(45, 15);
            this.lbl_vendor.TabIndex = 44;
            this.lbl_vendor.Text = "Vendor";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(451, 263);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 34);
            this.btn_cancel.TabIndex = 43;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(342, 263);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(103, 34);
            this.btn_update.TabIndex = 42;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(233, 263);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 34);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tft_contactno
            // 
            this.tft_contactno.Location = new System.Drawing.Point(135, 175);
            this.tft_contactno.Name = "tft_contactno";
            this.tft_contactno.Size = new System.Drawing.Size(419, 23);
            this.tft_contactno.TabIndex = 32;
            // 
            // lbl_contactno
            // 
            this.lbl_contactno.AutoSize = true;
            this.lbl_contactno.Location = new System.Drawing.Point(15, 178);
            this.lbl_contactno.Name = "lbl_contactno";
            this.lbl_contactno.Size = new System.Drawing.Size(67, 15);
            this.lbl_contactno.TabIndex = 37;
            this.lbl_contactno.Text = "Contact No";
            // 
            // tft_vendor
            // 
            this.tft_vendor.Location = new System.Drawing.Point(135, 50);
            this.tft_vendor.Name = "tft_vendor";
            this.tft_vendor.Size = new System.Drawing.Size(419, 23);
            this.tft_vendor.TabIndex = 29;
            // 
            // lbl_contperson
            // 
            this.lbl_contperson.AutoSize = true;
            this.lbl_contperson.Location = new System.Drawing.Point(15, 134);
            this.lbl_contperson.Name = "lbl_contperson";
            this.lbl_contperson.Size = new System.Drawing.Size(90, 15);
            this.lbl_contperson.TabIndex = 36;
            this.lbl_contperson.Text = "Contact Person";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(16, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 15);
            this.lbl_id.TabIndex = 48;
            this.lbl_id.Visible = false;
            // 
            // pb_vendor
            // 
            this.pb_vendor.Location = new System.Drawing.Point(557, 50);
            this.pb_vendor.Name = "pb_vendor";
            this.pb_vendor.Size = new System.Drawing.Size(24, 23);
            this.pb_vendor.TabIndex = 49;
            this.pb_vendor.TabStop = false;
            // 
            // pb_conp
            // 
            this.pb_conp.Location = new System.Drawing.Point(557, 131);
            this.pb_conp.Name = "pb_conp";
            this.pb_conp.Size = new System.Drawing.Size(24, 23);
            this.pb_conp.TabIndex = 50;
            this.pb_conp.TabStop = false;
            // 
            // pb_contact
            // 
            this.pb_contact.Location = new System.Drawing.Point(557, 175);
            this.pb_contact.Name = "pb_contact";
            this.pb_contact.Size = new System.Drawing.Size(24, 23);
            this.pb_contact.TabIndex = 51;
            this.pb_contact.TabStop = false;
            // 
            // Form_Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(584, 322);
            this.ControlBox = false;
            this.Controls.Add(this.pb_contact);
            this.Controls.Add(this.pb_conp);
            this.Controls.Add(this.pb_vendor);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.tft_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.tft_address);
            this.Controls.Add(this.tft_contactperson);
            this.Controls.Add(this.lbl_vendor);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tft_contactno);
            this.Controls.Add(this.lbl_contactno);
            this.Controls.Add(this.tft_vendor);
            this.Controls.Add(this.lbl_contperson);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Vendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Vendor_KeyDown);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_conp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_contact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_cancel;
        public System.Windows.Forms.TextBox tft_email;
        public System.Windows.Forms.Label lbl_email;
        public System.Windows.Forms.Label lbl_address;
        public System.Windows.Forms.TextBox tft_address;
        public System.Windows.Forms.TextBox tft_contactperson;
        public System.Windows.Forms.Label lbl_vendor;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox tft_contactno;
        public System.Windows.Forms.Label lbl_contactno;
        public System.Windows.Forms.TextBox tft_vendor;
        public System.Windows.Forms.Label lbl_contperson;
        public System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.PictureBox pb_vendor;
        private System.Windows.Forms.PictureBox pb_conp;
        private System.Windows.Forms.PictureBox pb_contact;
    }
}