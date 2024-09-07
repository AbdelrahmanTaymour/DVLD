using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Questions.Controls
{
    public partial class ctrlQuetion : UserControl
    {
        public ctrlQuetion()
        {
            InitializeComponent();
        }

        private void ctrlQuetion_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(rbOption1.Checked)
            {
                rbOption1.BorderColor = Color.Green;
                rbOption1.BackColor = Color.White;
            }
            else
                rbOption1.BorderColor = Color.Black;

            if (rbOption2.Checked)
                rbOption2.BorderColor = Color.Red;
            else
                rbOption2.BorderColor = Color.Black;

            if (rbOption3.Checked)
                rbOption3.BorderColor = Color.Red;
            else
                rbOption3.BorderColor = Color.Black;

            if (rbOption4.Checked)
                rbOption4.BorderColor = Color.Red;
            else
                rbOption4.BorderColor = Color.Black;

            btnCheck.Visible = false;
            btnContinue.Visible = true;
        }
        short count = 1;
        private void btnContinue_Click(object sender, EventArgs e)
        {
            count++;
            lblQuetionNo.Text = count.ToString() + " / 10";

            rbOption1.Checked = false;
            rbOption2.Checked = false;
            rbOption3.Checked = false;
            rbOption4.Checked = false;

            rbOption1.BorderColor = Color.Black;
            rbOption2.BorderColor = Color.Black;
            rbOption3.BorderColor = Color.Black;
            rbOption4.BorderColor = Color.Black;

            btnContinue.Visible = false;
            btnCheck.Visible = true;

        }
    }
}
