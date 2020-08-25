namespace POS_and_Inventory
{
    partial class Form_addbrand
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_addbrand = new System.Windows.Forms.Label();
            this.lbl_brandname = new System.Windows.Forms.Label();
            this.tft_brandname = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_top.Controls.Add(this.lbl_addbrand);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(665, 40);
            this.panel_top.TabIndex = 1;
            // 
            // lbl_addbrand
            // 
            this.lbl_addbrand.AutoSize = true;
            this.lbl_addbrand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addbrand.ForeColor = System.Drawing.Color.White;
            this.lbl_addbrand.Location = new System.Drawing.Point(3, 9);
            this.lbl_addbrand.Name = "lbl_addbrand";
            this.lbl_addbrand.Size = new System.Drawing.Size(133, 25);
            this.lbl_addbrand.TabIndex = 0;
            this.lbl_addbrand.Text = "Adding Brand ";
            // 
            // lbl_brandname
            // 
            this.lbl_brandname.AutoSize = true;
            this.lbl_brandname.Location = new System.Drawing.Point(24, 94);
            this.lbl_brandname.Name = "lbl_brandname";
            this.lbl_brandname.Size = new System.Drawing.Size(81, 17);
            this.lbl_brandname.TabIndex = 2;
            this.lbl_brandname.Text = "Brand Name";
            // 
            // tft_brandname
            // 
            this.tft_brandname.Location = new System.Drawing.Point(147, 91);
            this.tft_brandname.Name = "tft_brandname";
            this.tft_brandname.Size = new System.Drawing.Size(457, 25);
            this.tft_brandname.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(147, 149);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 34);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_update.Enabled = false;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(256, 149);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(103, 34);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(365, 149);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 34);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(474, 149);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(130, 37);
            this.lblid.TabIndex = 7;
            this.lblid.Visible = false;
            // 
            // Form_addbrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(665, 217);
            this.ControlBox = false;
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tft_brandname);
            this.Controls.Add(this.lbl_brandname);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_addbrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_addbrand";
            this.Load += new System.EventHandler(this.Form_addbrand_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_addbrand_KeyDown);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_addbrand;
        private System.Windows.Forms.Label lbl_brandname;
        public System.Windows.Forms.TextBox tft_brandname;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_cancel;
    }
}