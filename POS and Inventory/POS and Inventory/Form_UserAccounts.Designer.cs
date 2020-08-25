namespace POS_and_Inventory
{
    partial class Form_UserAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UserAccounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_categoryitle = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tft_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tft_repass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tft_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tft_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkbox_username = new MetroFramework.Controls.MetroCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_changepass = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_validate = new System.Windows.Forms.Button();
            this.checkbox_duser = new MetroFramework.Controls.MetroCheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_dcancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox_check = new System.Windows.Forms.PictureBox();
            this.tft_cusername = new MetroFramework.Controls.MetroTextBox();
            this.tft_cnewpassretype = new MetroFramework.Controls.MetroTextBox();
            this.tft_cnewpass = new MetroFramework.Controls.MetroTextBox();
            this.tft_coldpass = new MetroFramework.Controls.MetroTextBox();
            this.tft_dname = new MetroFramework.Controls.MetroTextBox();
            this.tft_dpassword = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox_duser = new System.Windows.Forms.PictureBox();
            this.tft_dusername = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_duser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pictureBox_cancel);
            this.panel1.Controls.Add(this.lbl_categoryitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 48);
            this.panel1.TabIndex = 3;
            // 
            // lbl_categoryitle
            // 
            this.lbl_categoryitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryitle.Location = new System.Drawing.Point(3, 4);
            this.lbl_categoryitle.Name = "lbl_categoryitle";
            this.lbl_categoryitle.Size = new System.Drawing.Size(173, 40);
            this.lbl_categoryitle.TabIndex = 0;
            this.lbl_categoryitle.Text = "User Accounts";
            this.lbl_categoryitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(116, 137);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(695, 422);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(687, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Account";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.tft_name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cb_role);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tft_repass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tft_pass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tft_username);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 380);
            this.panel2.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(154, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(363, 40);
            this.label16.TabIndex = 18;
            this.label16.Text = "Create New Account";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(474, 312);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(116, 42);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Clear";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(352, 312);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(116, 42);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tft_name
            // 
            this.tft_name.Location = new System.Drawing.Point(189, 281);
            this.tft_name.Name = "tft_name";
            this.tft_name.Size = new System.Drawing.Size(401, 25);
            this.tft_name.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(34, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.cb_role.Location = new System.Drawing.Point(189, 231);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(401, 25);
            this.cb_role.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(34, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role";
            // 
            // tft_repass
            // 
            this.tft_repass.Location = new System.Drawing.Point(189, 182);
            this.tft_repass.Name = "tft_repass";
            this.tft_repass.PasswordChar = '*';
            this.tft_repass.Size = new System.Drawing.Size(401, 25);
            this.tft_repass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(34, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-type Password";
            // 
            // tft_pass
            // 
            this.tft_pass.Location = new System.Drawing.Point(189, 129);
            this.tft_pass.Name = "tft_pass";
            this.tft_pass.PasswordChar = '*';
            this.tft_pass.Size = new System.Drawing.Size(401, 25);
            this.tft_pass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tft_username
            // 
            this.tft_username.Location = new System.Drawing.Point(189, 77);
            this.tft_username.Name = "tft_username";
            this.tft_username.Size = new System.Drawing.Size(401, 25);
            this.tft_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(687, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Password";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.pictureBox_check);
            this.panel3.Controls.Add(this.checkbox_username);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tft_cusername);
            this.panel3.Controls.Add(this.tft_cnewpassretype);
            this.panel3.Controls.Add(this.tft_cnewpass);
            this.panel3.Controls.Add(this.tft_coldpass);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_changepass);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 380);
            this.panel3.TabIndex = 1;
            // 
            // checkbox_username
            // 
            this.checkbox_username.Location = new System.Drawing.Point(619, 98);
            this.checkbox_username.Name = "checkbox_username";
            this.checkbox_username.Size = new System.Drawing.Size(14, 23);
            this.checkbox_username.TabIndex = 11;
            this.checkbox_username.UseSelectable = true;
            this.checkbox_username.CheckedChanged += new System.EventHandler(this.checkbox_username_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(137, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 40);
            this.label6.TabIndex = 17;
            this.label6.Text = "Change Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(523, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_changepass
            // 
            this.btn_changepass.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_changepass.FlatAppearance.BorderSize = 0;
            this.btn_changepass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_changepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changepass.ForeColor = System.Drawing.Color.White;
            this.btn_changepass.Location = new System.Drawing.Point(354, 317);
            this.btn_changepass.Name = "btn_changepass";
            this.btn_changepass.Size = new System.Drawing.Size(146, 42);
            this.btn_changepass.TabIndex = 16;
            this.btn_changepass.Text = "Change Password";
            this.btn_changepass.UseVisualStyleBackColor = false;
            this.btn_changepass.Click += new System.EventHandler(this.btn_changepass_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(34, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Re-type Password";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(34, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "New Password";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(34, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Old Password";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(34, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Username";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(687, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Account";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.btn_validate);
            this.panel4.Controls.Add(this.checkbox_duser);
            this.panel4.Controls.Add(this.tft_dname);
            this.panel4.Controls.Add(this.tft_dpassword);
            this.panel4.Controls.Add(this.pictureBox_duser);
            this.panel4.Controls.Add(this.tft_dusername);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.btn_dcancel);
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 380);
            this.panel4.TabIndex = 1;
            // 
            // btn_validate
            // 
            this.btn_validate.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_validate.FlatAppearance.BorderSize = 0;
            this.btn_validate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_validate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_validate.ForeColor = System.Drawing.Color.White;
            this.btn_validate.Location = new System.Drawing.Point(473, 112);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(179, 30);
            this.btn_validate.TabIndex = 22;
            this.btn_validate.Text = "Validate Account";
            this.btn_validate.UseVisualStyleBackColor = false;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // checkbox_duser
            // 
            this.checkbox_duser.Location = new System.Drawing.Point(632, 84);
            this.checkbox_duser.Name = "checkbox_duser";
            this.checkbox_duser.Size = new System.Drawing.Size(14, 22);
            this.checkbox_duser.TabIndex = 21;
            this.checkbox_duser.UseSelectable = true;
            this.checkbox_duser.CheckedChanged += new System.EventHandler(this.checkbox_duser_CheckedChanged);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(147, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(363, 40);
            this.label17.TabIndex = 18;
            this.label17.Text = "Delete Account";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dcancel
            // 
            this.btn_dcancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_dcancel.FlatAppearance.BorderSize = 0;
            this.btn_dcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_dcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dcancel.ForeColor = System.Drawing.Color.White;
            this.btn_dcancel.Location = new System.Drawing.Point(522, 272);
            this.btn_dcancel.Name = "btn_dcancel";
            this.btn_dcancel.Size = new System.Drawing.Size(130, 42);
            this.btn_dcancel.TabIndex = 26;
            this.btn_dcancel.Text = "Clear";
            this.btn_dcancel.UseVisualStyleBackColor = false;
            this.btn_dcancel.Click += new System.EventHandler(this.btn_dcancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_delete.Enabled = false;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(363, 272);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 42);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(47, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Name";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(47, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "Password";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(47, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Username";
            // 
            // pictureBox_check
            // 
            this.pictureBox_check.Location = new System.Drawing.Point(639, 98);
            this.pictureBox_check.Name = "pictureBox_check";
            this.pictureBox_check.Size = new System.Drawing.Size(26, 23);
            this.pictureBox_check.TabIndex = 19;
            this.pictureBox_check.TabStop = false;
            // 
            // tft_cusername
            // 
            // 
            // 
            // 
            this.tft_cusername.CustomButton.Image = null;
            this.tft_cusername.CustomButton.Location = new System.Drawing.Point(424, 2);
            this.tft_cusername.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tft_cusername.CustomButton.Name = "";
            this.tft_cusername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_cusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_cusername.CustomButton.TabIndex = 1;
            this.tft_cusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_cusername.CustomButton.UseSelectable = true;
            this.tft_cusername.CustomButton.Visible = false;
            this.tft_cusername.DisplayIcon = true;
            this.tft_cusername.Enabled = false;
            this.tft_cusername.Icon = ((System.Drawing.Image)(resources.GetObject("tft_cusername.Icon")));
            this.tft_cusername.Lines = new string[0];
            this.tft_cusername.Location = new System.Drawing.Point(189, 95);
            this.tft_cusername.MaxLength = 32767;
            this.tft_cusername.Name = "tft_cusername";
            this.tft_cusername.PasswordChar = '\0';
            this.tft_cusername.PromptText = "Username";
            this.tft_cusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_cusername.SelectedText = "";
            this.tft_cusername.SelectionLength = 0;
            this.tft_cusername.SelectionStart = 0;
            this.tft_cusername.ShortcutsEnabled = true;
            this.tft_cusername.Size = new System.Drawing.Size(450, 28);
            this.tft_cusername.TabIndex = 10;
            this.tft_cusername.UseSelectable = true;
            this.tft_cusername.WaterMark = "Username";
            this.tft_cusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_cusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tft_cnewpassretype
            // 
            // 
            // 
            // 
            this.tft_cnewpassretype.CustomButton.Image = null;
            this.tft_cnewpassretype.CustomButton.Location = new System.Drawing.Point(424, 2);
            this.tft_cnewpassretype.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tft_cnewpassretype.CustomButton.Name = "";
            this.tft_cnewpassretype.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_cnewpassretype.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_cnewpassretype.CustomButton.TabIndex = 1;
            this.tft_cnewpassretype.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_cnewpassretype.CustomButton.UseSelectable = true;
            this.tft_cnewpassretype.CustomButton.Visible = false;
            this.tft_cnewpassretype.DisplayIcon = true;
            this.tft_cnewpassretype.Icon = ((System.Drawing.Image)(resources.GetObject("tft_cnewpassretype.Icon")));
            this.tft_cnewpassretype.Lines = new string[0];
            this.tft_cnewpassretype.Location = new System.Drawing.Point(189, 249);
            this.tft_cnewpassretype.MaxLength = 32767;
            this.tft_cnewpassretype.Name = "tft_cnewpassretype";
            this.tft_cnewpassretype.PasswordChar = '●';
            this.tft_cnewpassretype.PromptText = "Confirm New Password";
            this.tft_cnewpassretype.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_cnewpassretype.SelectedText = "";
            this.tft_cnewpassretype.SelectionLength = 0;
            this.tft_cnewpassretype.SelectionStart = 0;
            this.tft_cnewpassretype.ShortcutsEnabled = true;
            this.tft_cnewpassretype.Size = new System.Drawing.Size(450, 28);
            this.tft_cnewpassretype.TabIndex = 15;
            this.tft_cnewpassretype.UseSelectable = true;
            this.tft_cnewpassretype.UseSystemPasswordChar = true;
            this.tft_cnewpassretype.WaterMark = "Confirm New Password";
            this.tft_cnewpassretype.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_cnewpassretype.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tft_cnewpass
            // 
            // 
            // 
            // 
            this.tft_cnewpass.CustomButton.Image = null;
            this.tft_cnewpass.CustomButton.Location = new System.Drawing.Point(424, 2);
            this.tft_cnewpass.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tft_cnewpass.CustomButton.Name = "";
            this.tft_cnewpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_cnewpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_cnewpass.CustomButton.TabIndex = 1;
            this.tft_cnewpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_cnewpass.CustomButton.UseSelectable = true;
            this.tft_cnewpass.CustomButton.Visible = false;
            this.tft_cnewpass.DisplayIcon = true;
            this.tft_cnewpass.Icon = ((System.Drawing.Image)(resources.GetObject("tft_cnewpass.Icon")));
            this.tft_cnewpass.Lines = new string[0];
            this.tft_cnewpass.Location = new System.Drawing.Point(189, 200);
            this.tft_cnewpass.MaxLength = 32767;
            this.tft_cnewpass.Name = "tft_cnewpass";
            this.tft_cnewpass.PasswordChar = '●';
            this.tft_cnewpass.PromptText = "New Password";
            this.tft_cnewpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_cnewpass.SelectedText = "";
            this.tft_cnewpass.SelectionLength = 0;
            this.tft_cnewpass.SelectionStart = 0;
            this.tft_cnewpass.ShortcutsEnabled = true;
            this.tft_cnewpass.Size = new System.Drawing.Size(450, 28);
            this.tft_cnewpass.TabIndex = 14;
            this.tft_cnewpass.UseSelectable = true;
            this.tft_cnewpass.UseSystemPasswordChar = true;
            this.tft_cnewpass.WaterMark = "New Password";
            this.tft_cnewpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_cnewpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tft_coldpass
            // 
            // 
            // 
            // 
            this.tft_coldpass.CustomButton.Image = null;
            this.tft_coldpass.CustomButton.Location = new System.Drawing.Point(424, 2);
            this.tft_coldpass.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tft_coldpass.CustomButton.Name = "";
            this.tft_coldpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_coldpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_coldpass.CustomButton.TabIndex = 1;
            this.tft_coldpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_coldpass.CustomButton.UseSelectable = true;
            this.tft_coldpass.CustomButton.Visible = false;
            this.tft_coldpass.DisplayIcon = true;
            this.tft_coldpass.Icon = ((System.Drawing.Image)(resources.GetObject("tft_coldpass.Icon")));
            this.tft_coldpass.Lines = new string[0];
            this.tft_coldpass.Location = new System.Drawing.Point(189, 147);
            this.tft_coldpass.MaxLength = 32767;
            this.tft_coldpass.Name = "tft_coldpass";
            this.tft_coldpass.PasswordChar = '●';
            this.tft_coldpass.PromptText = "Old Password";
            this.tft_coldpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_coldpass.SelectedText = "";
            this.tft_coldpass.SelectionLength = 0;
            this.tft_coldpass.SelectionStart = 0;
            this.tft_coldpass.ShortcutsEnabled = true;
            this.tft_coldpass.Size = new System.Drawing.Size(450, 28);
            this.tft_coldpass.TabIndex = 12;
            this.tft_coldpass.UseSelectable = true;
            this.tft_coldpass.UseSystemPasswordChar = true;
            this.tft_coldpass.WaterMark = "Old Password";
            this.tft_coldpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_coldpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tft_dname
            // 
            // 
            // 
            // 
            this.tft_dname.CustomButton.Image = null;
            this.tft_dname.CustomButton.Location = new System.Drawing.Point(424, 2);
            this.tft_dname.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tft_dname.CustomButton.Name = "";
            this.tft_dname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_dname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_dname.CustomButton.TabIndex = 1;
            this.tft_dname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_dname.CustomButton.UseSelectable = true;
            this.tft_dname.CustomButton.Visible = false;
            this.tft_dname.DisplayIcon = true;
            this.tft_dname.Enabled = false;
            this.tft_dname.Icon = ((System.Drawing.Image)(resources.GetObject("tft_dname.Icon")));
            this.tft_dname.Lines = new string[0];
            this.tft_dname.Location = new System.Drawing.Point(202, 214);
            this.tft_dname.MaxLength = 32767;
            this.tft_dname.Name = "tft_dname";
            this.tft_dname.PasswordChar = '\0';
            this.tft_dname.PromptText = "Name Here";
            this.tft_dname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_dname.SelectedText = "";
            this.tft_dname.SelectionLength = 0;
            this.tft_dname.SelectionStart = 0;
            this.tft_dname.ShortcutsEnabled = true;
            this.tft_dname.Size = new System.Drawing.Size(450, 28);
            this.tft_dname.TabIndex = 24;
            this.tft_dname.UseSelectable = true;
            this.tft_dname.WaterMark = "Name Here";
            this.tft_dname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_dname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tft_dpassword
            // 
            // 
            // 
            // 
            this.tft_dpassword.CustomButton.Image = null;
            this.tft_dpassword.CustomButton.Location = new System.Drawing.Point(424, 2);
            this.tft_dpassword.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tft_dpassword.CustomButton.Name = "";
            this.tft_dpassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_dpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_dpassword.CustomButton.TabIndex = 1;
            this.tft_dpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_dpassword.CustomButton.UseSelectable = true;
            this.tft_dpassword.CustomButton.Visible = false;
            this.tft_dpassword.DisplayIcon = true;
            this.tft_dpassword.Enabled = false;
            this.tft_dpassword.Icon = ((System.Drawing.Image)(resources.GetObject("tft_dpassword.Icon")));
            this.tft_dpassword.Lines = new string[0];
            this.tft_dpassword.Location = new System.Drawing.Point(202, 158);
            this.tft_dpassword.MaxLength = 32767;
            this.tft_dpassword.Name = "tft_dpassword";
            this.tft_dpassword.PasswordChar = '●';
            this.tft_dpassword.PromptText = "Password";
            this.tft_dpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_dpassword.SelectedText = "";
            this.tft_dpassword.SelectionLength = 0;
            this.tft_dpassword.SelectionStart = 0;
            this.tft_dpassword.ShortcutsEnabled = true;
            this.tft_dpassword.Size = new System.Drawing.Size(450, 28);
            this.tft_dpassword.TabIndex = 23;
            this.tft_dpassword.UseSelectable = true;
            this.tft_dpassword.UseSystemPasswordChar = true;
            this.tft_dpassword.WaterMark = "Password";
            this.tft_dpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_dpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox_duser
            // 
            this.pictureBox_duser.Location = new System.Drawing.Point(652, 83);
            this.pictureBox_duser.Name = "pictureBox_duser";
            this.pictureBox_duser.Size = new System.Drawing.Size(26, 23);
            this.pictureBox_duser.TabIndex = 21;
            this.pictureBox_duser.TabStop = false;
            // 
            // tft_dusername
            // 
            // 
            // 
            // 
            this.tft_dusername.CustomButton.Image = null;
            this.tft_dusername.CustomButton.Location = new System.Drawing.Point(424, 2);
            this.tft_dusername.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tft_dusername.CustomButton.Name = "";
            this.tft_dusername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tft_dusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tft_dusername.CustomButton.TabIndex = 1;
            this.tft_dusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tft_dusername.CustomButton.UseSelectable = true;
            this.tft_dusername.CustomButton.Visible = false;
            this.tft_dusername.DisplayIcon = true;
            this.tft_dusername.Enabled = false;
            this.tft_dusername.Icon = ((System.Drawing.Image)(resources.GetObject("tft_dusername.Icon")));
            this.tft_dusername.Lines = new string[0];
            this.tft_dusername.Location = new System.Drawing.Point(202, 81);
            this.tft_dusername.MaxLength = 32767;
            this.tft_dusername.Name = "tft_dusername";
            this.tft_dusername.PasswordChar = '\0';
            this.tft_dusername.PromptText = "Username";
            this.tft_dusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tft_dusername.SelectedText = "";
            this.tft_dusername.SelectionLength = 0;
            this.tft_dusername.SelectionStart = 0;
            this.tft_dusername.ShortcutsEnabled = true;
            this.tft_dusername.Size = new System.Drawing.Size(450, 28);
            this.tft_dusername.TabIndex = 20;
            this.tft_dusername.UseSelectable = true;
            this.tft_dusername.WaterMark = "Username";
            this.tft_dusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tft_dusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cancel.Image")));
            this.pictureBox_cancel.Location = new System.Drawing.Point(906, 4);
            this.pictureBox_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(26, 27);
            this.pictureBox_cancel.TabIndex = 4;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Visible = false;
            this.pictureBox_cancel.Click += new System.EventHandler(this.pictureBox_cancel_Click);
            // 
            // Form_UserAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(935, 648);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_UserAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_UserAccounts_Load);
            this.Resize += new System.EventHandler(this.Form_UserAccounts_Resize);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_duser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_categoryitle;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tft_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tft_repass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tft_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tft_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_changepass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_dcancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox tft_cusername;
        private MetroFramework.Controls.MetroTextBox tft_cnewpassretype;
        private MetroFramework.Controls.MetroTextBox tft_cnewpass;
        private MetroFramework.Controls.MetroTextBox tft_coldpass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private MetroFramework.Controls.MetroCheckBox checkbox_username;
        private System.Windows.Forms.PictureBox pictureBox_check;
        private System.Windows.Forms.Button btn_validate;
        private MetroFramework.Controls.MetroCheckBox checkbox_duser;
        private MetroFramework.Controls.MetroTextBox tft_dname;
        private MetroFramework.Controls.MetroTextBox tft_dpassword;
        private System.Windows.Forms.PictureBox pictureBox_duser;
        private MetroFramework.Controls.MetroTextBox tft_dusername;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
    }
}