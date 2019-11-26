using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + txtName.Text);
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void radWhite_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                grpColour.Visible = true;
            }
            else
            {
                grpColour.Visible = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrClock.Enabled = true;
        }
        
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrClock.Enabled = false;
        }
    }
}
