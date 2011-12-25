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
        Matched oMatchedText = new Matched();

        public Principal()
        {
            InitializeComponent();
        }

        private void btMatch_Click(object sender, EventArgs e)
        {
            oMatchedText.RE = new Regex(@txtRegex.Text);
            oMatchedText.TextToMatch = txtMatchText.Text;
            oMatchedText.Show();
        }

        /**
         * MENU METHODS
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
