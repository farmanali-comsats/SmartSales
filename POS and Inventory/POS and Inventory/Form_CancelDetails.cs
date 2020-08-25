using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_and_Inventory
{
    public partial class Form_CancelDetails : Form
    {
        Form_Solditems form;
        public Form_CancelDetails(Form_Solditems frm)
        {
            InitializeComponent();
            form = frm;
            this.KeyPreview = true;
        }

        private void Form_CancelDetails_Load(object sender, EventArgs e)
        {

        }

        private void picbox_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cb_addtoinv.Text != String.Empty)&& (tft_cqty.Text != String.Empty)&& (tft_reason.Text != String.Empty))
                {
                    if (int.Parse(tft_cqty.Text)>int.Parse(tft_qty.Text))
                    {
                        MessageBox.Show("Maximum Quantity to Cancel is " + tft_qty.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Form_voidby frm = new Form_voidby(this);
                        double p = double.Parse(tft_price.Text);
                        int q = (int.Parse(tft_qty.Text))-(int.Parse(tft_cqty.Text));
                        double t  = p * q;
                        double discperunit = (double.Parse(tft_discount.Text)) / (int.Parse(tft_qty.Text));
                        double minuspaid = ((p) * (int.Parse(tft_cqty.Text))) - (discperunit*(int.Parse(tft_cqty.Text)));
                        frm.lbl_newpaid.Text = minuspaid.ToString();
                        frm.lbl_bal.Text = t.ToString();
                        frm.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Mandatory Details" , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void refreshlist()
        {
            form.loadrecords();
        }

        private void Form_CancelDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_confirm_Click(sender, e);
            }
        }
    }
}
