using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_and_Inventory
{
    public partial class Form_predictionssalesdata : Form
    {
        public Form_predictionssalesdata()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }        

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_predictionssalesdata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pictureBox_cancel_Click(sender,e);
            }
        }
    }
}
