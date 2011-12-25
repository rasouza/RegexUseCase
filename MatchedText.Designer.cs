namespace RegexUseCase
{
    partial class Matched
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matched));
            this.lbStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRegex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMatchedText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(11, 9);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(92, 31);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "label1";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regular Expression";
            // 
            // lbRegex
            // 
            this.lbRegex.AutoSize = true;
            this.lbRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegex.Location = new System.Drawing.Point(136, 53);
            this.lbRegex.Name = "lbRegex";
            this.lbRegex.Size = new System.Drawing.Size(43, 13);
            this.lbRegex.TabIndex = 2;
            this.lbRegex.Text = "Regex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matched Text";
            // 
            // lbMatchedText
            // 
            this.lbMatchedText.AutoSize = true;
            this.lbMatchedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatchedText.Location = new System.Drawing.Point(136, 100);
            this.lbMatchedText.Name = "lbMatchedText";
            this.lbMatchedText.Size = new System.Drawing.Size(85, 13);
            this.lbMatchedText.TabIndex = 4;
            this.lbMatchedText.Text = "Matched Text";
            // 
            // Matched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.lbMatchedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRegex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Matched";
            this.Text = "Regex";
            this.VisibleChanged += new System.EventHandler(this.MatchRegex);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatchedText_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRegex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMatchedText;

    }
}