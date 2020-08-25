namespace POS_and_Inventory
{
    partial class Form_voidby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_voidby));
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_bal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_cancel = new System.Windows.Forms.PictureBox();
            this.btn_void = new System.Windows.Forms.Button();
            this.tft_pass = new MetroFramework.Controls.MetroTextBox();
            this.tft_username = new MetroFramework.Controls.MetroTextBox();
            this.lbl_newpaid = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_top.Controls.Add(this.lbl_newpaid);
            this.panel_top.Controls.Add(this.lbl_bal);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.picbox_cancel);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(328, 40);
            this.panel_top.TabIndex = 3;
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Enabled = false;
            this.lbl_bal.Location = new System.Drawing.Point(178, 11);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(0, 13);
            this.lbl_bal.TabIndex = 2;
            this.lbl_bal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Void Cancel By";
            // 
            // picbox_cancel
            // 
            this.picbox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cancel.Image")));
            this.picbox_cancel.Location = new System.Drawing.Point(299, 3);
            this.picbox_cancel.Name = "picbox_cancel";
            this.picbox_cancel.Size = new System.Drawing.Size(26, 30);
            this.picbox_cancel.TabIndex = 0;
            this.picbox_cancel.TabStop = false;
            this.picbox_cancel.Click += new System.EventHandler(this.picbox_cancel_Click);
            // 
            // btn_void
            // 
            this.btn_void.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_void.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_void.FlatAppearance.BorderSize = 0;
            this.btn_void.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_void.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_void.ForeColor = System.Drawing.Color.White;
            this.btn_void.Location = new System.Drawing.Point(10, 114);
            this.btn_void.Name = "btn_void";
            this.btn_void.Size = new System.Drawing.Size(304, 34);
            this.btn_void.TabIndex = 9;
            this.btn_void.Text = "Void";
            this.btn_void.UseVisualStyleBackColor = false;
            this.btn_void.Click += new System.EventHandler(this.btn_void_Click);
            // 
            // tft_pass
            // 
            // 
            // 
            // 
            this.tft_pass.CustomButton.Image = null;
            this.tft_pass.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.tft_pass.CustomButton.Name = "";
            this.tft_pass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_pass.CustomButton.TabIndex = 1;
            this.tft_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_pass.CustomButton.UseSelectable = true;
            this.tft_pass.CustomButton.Visible = false;
            this.tft_pass.DisplayIcon = true;
            this.tft_pass.Icon = ((System.Drawing.Image)(resources.GetObject("tft_pass.Icon")));
            this.tft_pass.Lines = new string[0];
            this.tft_pass.Location = new System.Drawing.Point(10, 80);
            this.tft_pass.MaxLength = 32767;
            this.tft_pass.Name = "tft_pass";
            this.tft_pass.PasswordChar = '●';
            this.tft_pass.PromptText = "Password";
            this.tft_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_pass.SelectedText = "";
            this.tft_pass.SelectionLength = 0;
            this.tft_pass.SelectionStart = 0;
            this.tft_pass.ShortcutsEnabled = true;
            this.tft_pass.Size = new System.Drawing.Size(304, 28);
            this.tft_pass.TabIndex = 8;
            this.tft_pass.UseSelectable = true;
            this.tft_pass.UseSystemPasswordChar = true;
            this.tft_pass.WaterMark = "Password";
            this.tft_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tft_username
            // 
            // 
            // 
            // 
            this.tft_username.CustomButton.Image = null;
            this.tft_username.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.tft_username.CustomButton.Name = "";
            this.tft_username.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_username.CustomButton.TabIndex = 1;
            this.tft_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_username.CustomButton.UseSelectable = true;
            this.tft_username.CustomButton.Visible = false;
            this.tft_username.DisplayIcon = true;
            this.tft_username.Icon = ((System.Drawing.Image)(resources.GetObject("tft_username.Icon")));
            this.tft_username.Lines = new string[0];
            this.tft_username.Location = new System.Drawing.Point(10, 46);
            this.tft_username.MaxLength = 32767;
            this.tft_username.Name = "tft_username";
            this.tft_username.PasswordChar = '\0';
            this.tft_username.PromptText = "Username";
            this.tft_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_username.SelectedText = "";
            this.tft_username.SelectionLength = 0;
            this.tft_username.SelectionStart = 0;
            this.tft_username.ShortcutsEnabled = true;
            this.tft_username.Size = new System.Drawing.Size(304, 28);
            this.tft_username.TabIndex = 6;
            this.tft_username.UseSelectable = true;
            this.tft_username.WaterMark = "Username";
            this.tft_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_newpaid
            // 
            this.lbl_newpaid.AutoSize = true;
            this.lbl_newpaid.Enabled = false;
            this.lbl_newpaid.Location = new System.Drawing.Point(164, 14);
            this.lbl_newpaid.Name = "lbl_newpaid";
            this.lbl_newpaid.Size = new System.Drawing.Size(0, 13);
            this.lbl_newpaid.TabIndex = 3;
            this.lbl_newpaid.Visible = false;
            // 
            // Form_voidby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(328, 159);
            this.ControlBox = false;
            this.Controls.Add(this.tft_username);
            this.Controls.Add(this.btn_void);
            this.Controls.Add(this.tft_pass);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_voidby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_voidby_KeyDown);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_cancel;
        public System.Windows.Forms.Button btn_void;
        private MetroFramework.Controls.MetroTextBox tft_pass;
        private MetroFramework.Controls.MetroTextBox tft_username;
        public System.Windows.Forms.Label lbl_bal;
        public System.Windows.Forms.Label lbl_newpaid;
    }
}