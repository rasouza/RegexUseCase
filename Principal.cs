using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexUseCase
{
    public partial class Principal : Form
    {
        //Options
        public RegexOptions IgnoreCase
        {
            get
            {
                if (IgnoreCaseItem.Checked)
                {
                    return RegexOptions.IgnoreCase;
                }
                else
                {
                    return RegexOptions.None;
                }
            }
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void btMatch_Click(object sender, EventArgs e)
        {
            Matched oMatched = new Matched();
            oMatched.RE = new Regex(@txtRegex.Text, IgnoreCase);
            oMatched.TextToMatch = txtMatchText.Text;
            oMatched.ShowDialog(this);
        }

        /**
         * Menu Methods
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IgnoreCaseItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.About oAbout = new Help.About();
            oAbout.ShowDialog();
        }

    }
}