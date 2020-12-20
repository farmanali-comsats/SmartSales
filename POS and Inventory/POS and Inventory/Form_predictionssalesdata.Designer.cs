namespace POS_and_Inventory
{
    partial class Form_predictionssalesdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_predictionssalesdata));
            this.panel_top = new System.Windows.Forms.Panel();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.lbl_showprofit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Azure;
            this.panel_top.Controls.Add(this.pictureBox_cancel);
            this.panel_top.Controls.Add(this.lbl_title);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(537, 48);
            this.panel_top.TabIndex = 6;
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cancel.Image")));
            this.pictureBox_cancel.Location = new System.Drawing.Point(508, 4);
            this.pictureBox_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(26, 27);
            this.pictureBox_cancel.TabIndex = 4;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Click += new System.EventHandler(this.pictureBox_cancel_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(3, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(219, 40);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Total Profit Predicted";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.lbl_showprofit);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 48);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(537, 170);
            this.panel_main.TabIndex = 7;
            // 
            // lbl_showprofit
            // 
            this.lbl_showprofit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showprofit.ForeColor = System.Drawing.Color.Green;
            this.lbl_showprofit.Location = new System.Drawing.Point(12, 67);
            this.lbl_showprofit.Name = "lbl_showprofit";
            this.lbl_showprofit.Size = new System.Drawing.Size(513, 49);
            this.lbl_showprofit.TabIndex = 0;
            this.lbl_showprofit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is total profit. Calculated by Subtracting total Cost from Total Price.";
            // 
            // Form_predictionssalesdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(537, 218);
            this.ControlBox = false;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_predictionssalesdata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_predictionssalesdata_KeyDown);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_showprofit;
    }
}