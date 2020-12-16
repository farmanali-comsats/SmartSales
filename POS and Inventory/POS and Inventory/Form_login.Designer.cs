namespace POS_and_Inventory
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tft_username = new MetroFramework.Controls.MetroTextBox();
            this.tft_pass = new MetroFramework.Controls.MetroTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 245);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_reset.Enabled = false;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(0, 423);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(14, 12);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
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
            this.tft_username.Lines = new string[] {
        "admin"};
            this.tft_username.Location = new System.Drawing.Point(12, 264);
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
            this.tft_username.TabIndex = 1;
            this.tft_username.Text = "admin";
            this.tft_username.UseSelectable = true;
            this.tft_username.WaterMark = "Username";
            this.tft_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.tft_pass.Lines = new string[] {
        "frmn0900"};
            this.tft_pass.Location = new System.Drawing.Point(12, 309);
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
            this.tft_pass.TabIndex = 2;
            this.tft_pass.Text = "frmn0900";
            this.tft_pass.UseSelectable = true;
            this.tft_pass.UseSystemPasswordChar = true;
            this.tft_pass.WaterMark = "Password";
            this.tft_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(12, 383);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(304, 34);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(12, 343);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(304, 34);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(328, 434);
            this.ControlBox = false;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tft_pass);
            this.Controls.Add(this.tft_username);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_login_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox tft_username;
        private MetroFramework.Controls.MetroTextBox tft_pass;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_reset;
    }
}