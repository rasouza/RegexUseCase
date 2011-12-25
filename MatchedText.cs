using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexUseCase
{
    public partial class Matched : Form
    {
        public Regex RE { get; set; }
        public string TextToMatch { get; set; }
        
        public Matched()
        {
            InitializeComponent();
        }

        private void MatchedText_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void MatchRegex(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Match result = RE.Match(TextToMatch);
                lbRegex.Text = RE.ToString();
                lbMatchedText.Text = TextToMatch;

                if (RE.IsMatch(TextToMatch))
                {
                    lbStatus.ForeColor = System.Drawing.Color.DarkGreen;
                    lbStatus.Text = "Match";
                    lbMatchedText.Text = result.Value;
                }
                else
                {
                    lbStatus.ForeColor = System.Drawing.Color.Red;
                    lbStatus.Text = "Didn't match";
                }
            }
        }

        private void MatchRegex()
        {

        }
        
    }
}
