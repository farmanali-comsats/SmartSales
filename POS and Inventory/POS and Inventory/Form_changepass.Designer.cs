namespace POS_and_Inventory
{
    partial class Form_changepass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_changepass));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_cancel = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tft_oldpass = new MetroFramework.Controls.MetroTextBox();
            this.tft_newpass = new MetroFramework.Controls.MetroTextBox();
            this.tft_newpassretype = new MetroFramework.Controls.MetroTextBox();
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
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(316, 29);
            this.panel_top.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Password";
            // 
            // picbox_cancel
            // 
            this.picbox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cancel.Image")));
            this.picbox_cancel.Location = new System.Drawing.Point(289, 3);
            this.picbox_cancel.Name = "picbox_cancel";
            this.picbox_cancel.Size = new System.Drawing.Size(24, 23);
            this.picbox_cancel.TabIndex = 0;
            this.picbox_cancel.TabStop = false;
            this.picbox_cancel.Click += new System.EventHandler(this.picbox_cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(6, 183);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(304, 34);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tft_oldpass
            // 
            // 
            // 
            // 
            this.tft_oldpass.CustomButton.Image = null;
            this.tft_oldpass.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.tft_oldpass.CustomButton.Name = "";
            this.tft_oldpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_oldpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_oldpass.CustomButton.TabIndex = 1;
            this.tft_oldpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_oldpass.CustomButton.UseSelectable = true;
            this.tft_oldpass.CustomButton.Visible = false;
            this.tft_oldpass.DisplayIcon = true;
            this.tft_oldpass.Icon = ((System.Drawing.Image)(resources.GetObject("tft_oldpass.Icon")));
            this.tft_oldpass.Lines = new string[0];
            this.tft_oldpass.Location = new System.Drawing.Point(6, 49);
            this.tft_oldpass.MaxLength = 32767;
            this.tft_oldpass.Name = "tft_oldpass";
            this.tft_oldpass.PasswordChar = '●';
            this.tft_oldpass.PromptText = "Old Password";
            this.tft_oldpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_oldpass.SelectedText = "";
            this.tft_oldpass.SelectionLength = 0;
            this.tft_oldpass.SelectionStart = 0;
            this.tft_oldpass.ShortcutsEnabled = true;
            this.tft_oldpass.Size = new System.Drawing.Size(304, 28);
            this.tft_oldpass.TabIndex = 8;
            this.tft_oldpass.UseSelectable = true;
            this.tft_oldpass.UseSystemPasswordChar = true;
            this.tft_oldpass.WaterMark = "Old Password";
            this.tft_oldpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_oldpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tft_newpass
            // 
            // 
            // 
            // 
            this.tft_newpass.CustomButton.Image = null;
            this.tft_newpass.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.tft_newpass.CustomButton.Name = "";
            this.tft_newpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_newpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_newpass.CustomButton.TabIndex = 1;
            this.tft_newpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_newpass.CustomButton.UseSelectable = true;
            this.tft_newpass.CustomButton.Visible = false;
            this.tft_newpass.DisplayIcon = true;
            this.tft_newpass.Icon = ((System.Drawing.Image)(resources.GetObject("tft_newpass.Icon")));
            this.tft_newpass.Lines = new string[0];
            this.tft_newpass.Location = new System.Drawing.Point(6, 94);
            this.tft_newpass.MaxLength = 32767;
            this.tft_newpass.Name = "tft_newpass";
            this.tft_newpass.PasswordChar = '●';
            this.tft_newpass.PromptText = "New Password";
            this.tft_newpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_newpass.SelectedText = "";
            this.tft_newpass.SelectionLength = 0;
            this.tft_newpass.SelectionStart = 0;
            this.tft_newpass.ShortcutsEnabled = true;
            this.tft_newpass.Size = new System.Drawing.Size(304, 28);
            this.tft_newpass.TabIndex = 10;
            this.tft_newpass.UseSelectable = true;
            this.tft_newpass.UseSystemPasswordChar = true;
            this.tft_newpass.WaterMark = "New Password";
            this.tft_newpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_newpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tft_newpassretype
            // 
            // 
            // 
            // 
            this.tft_newpassretype.CustomButton.Image = null;
            this.tft_newpassretype.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.tft_newpassretype.CustomButton.Name = "";
            this.tft_newpassretype.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_newpassretype.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_newpassretype.CustomButton.TabIndex = 1;
            this.tft_newpassretype.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_newpassretype.CustomButton.UseSelectable = true;
            this.tft_newpassretype.CustomButton.Visible = false;
            this.tft_newpassretype.DisplayIcon = true;
            this.tft_newpassretype.Icon = ((System.Drawing.Image)(resources.GetObject("tft_newpassretype.Icon")));
            this.tft_newpassretype.Lines = new string[0];
            this.tft_newpassretype.Location = new System.Drawing.Point(6, 139);
            this.tft_newpassretype.MaxLength = 32767;
            this.tft_newpassretype.Name = "tft_newpassretype";
            this.tft_newpassretype.PasswordChar = '●';
            this.tft_newpassretype.PromptText = "Confirm New Password";
            this.tft_newpassretype.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_newpassretype.SelectedText = "";
            this.tft_newpassretype.SelectionLength = 0;
            this.tft_newpassretype.SelectionStart = 0;
            this.tft_newpassretype.ShortcutsEnabled = true;
            this.tft_newpassretype.Size = new System.Drawing.Size(304, 28);
            this.tft_newpassretype.TabIndex = 11;
            this.tft_newpassretype.UseSelectable = true;
            this.tft_newpassretype.UseSystemPasswordChar = true;
            this.tft_newpassretype.WaterMark = "Confirm New Password";
            this.tft_newpassretype.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_newpassretype.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form_changepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(316, 228);
            this.ControlBox = false;
            this.Controls.Add(this.tft_newpassretype);
            this.Controls.Add(this.tft_newpass);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tft_oldpass);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_changepass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_changepass_KeyDown);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_cancel;
        public System.Windows.Forms.Button btn_Save;
        private MetroFramework.Controls.MetroTextBox tft_oldpass;
        private MetroFramework.Controls.MetroTextBox tft_newpass;
        private MetroFramework.Controls.MetroTextBox tft_newpassretype;
    }
}