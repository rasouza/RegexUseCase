namespace RegexUseCase
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lbRegex = new System.Windows.Forms.Label();
            this.lbMatchText = new System.Windows.Forms.Label();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.txtMatchText = new System.Windows.Forms.TextBox();
            this.btMatch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IgnoreCaseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRegex
            // 
            this.lbRegex.AutoSize = true;
            this.lbRegex.Location = new System.Drawing.Point(12, 44);
            this.lbRegex.Name = "lbRegex";
            this.lbRegex.Size = new System.Drawing.Size(98, 13);
            this.lbRegex.TabIndex = 0;
            this.lbRegex.Text = "Regular Expression";
            // 
            // lbMatchText
            // 
            this.lbMatchText.AutoSize = true;
            this.lbMatchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatchText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbMatchText.Location = new System.Drawing.Point(97, 90);
            this.lbMatchText.Name = "lbMatchText";
            this.lbMatchText.Size = new System.Drawing.Size(103, 24);
            this.lbMatchText.TabIndex = 1;
            this.lbMatchText.Text = "Match Text";
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(118, 41);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(162, 20);
            this.txtRegex.TabIndex = 2;
            // 
            // txtMatchText
            // 
            this.txtMatchText.Location = new System.Drawing.Point(12, 117);
            this.txtMatchText.Multiline = true;
            this.txtMatchText.Name = "txtMatchText";
            this.txtMatchText.Size = new System.Drawing.Size(268, 96);
            this.txtMatchText.TabIndex = 3;
            // 
            // btMatch
            // 
            this.btMatch.Location = new System.Drawing.Point(100, 233);
            this.btMatch.Name = "btMatch";
            this.btMatch.Size = new System.Drawing.Size(100, 23);
            this.btMatch.TabIndex = 4;
            this.btMatch.Text = "Match";
            this.btMatch.UseVisualStyleBackColor = true;
            this.btMatch.Click += new System.EventHandler(this.btMatch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IgnoreCaseItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // IgnoreCaseItem
            // 
            this.IgnoreCaseItem.CheckOnClick = true;
            this.IgnoreCaseItem.Name = "IgnoreCaseItem";
            this.IgnoreCaseItem.Size = new System.Drawing.Size(141, 22);
            this.IgnoreCaseItem.Text = "&IgnoreCase";
            this.IgnoreCaseItem.CheckedChanged += new System.EventHandler(this.IgnoreCaseItem_CheckedChanged);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.btMatch);
            this.Controls.Add(this.txtMatchText);
            this.Controls.Add(this.txtRegex);
            this.Controls.Add(this.lbMatchText);
            this.Controls.Add(this.lbRegex);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Regex";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegex;
        private System.Windows.Forms.Label lbMatchText;
        private System.Windows.Forms.Button btMatch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IgnoreCaseItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        public System.Windows.Forms.TextBox txtRegex;
        public System.Windows.Forms.TextBox txtMatchText;

    }
}

