namespace BTKT57132300
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cẬPNHẬPXEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cẬPNHẬPCHUYẾNXEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cẬPNHẬPXEToolStripMenuItem,
            this.cẬPNHẬPCHUYẾNXEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cẬPNHẬPXEToolStripMenuItem
            // 
            this.cẬPNHẬPXEToolStripMenuItem.Name = "cẬPNHẬPXEToolStripMenuItem";
            this.cẬPNHẬPXEToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.cẬPNHẬPXEToolStripMenuItem.Text = "CẬP NHẬP XE";
            this.cẬPNHẬPXEToolStripMenuItem.Click += new System.EventHandler(this.cẬPNHẬPXEToolStripMenuItem_Click);
            // 
            // cẬPNHẬPCHUYẾNXEToolStripMenuItem
            // 
            this.cẬPNHẬPCHUYẾNXEToolStripMenuItem.Name = "cẬPNHẬPCHUYẾNXEToolStripMenuItem";
            this.cẬPNHẬPCHUYẾNXEToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.cẬPNHẬPCHUYẾNXEToolStripMenuItem.Text = "CẬP NHẬP CHUYẾN XE";
            this.cẬPNHẬPCHUYẾNXEToolStripMenuItem.Click += new System.EventHandler(this.cẬPNHẬPCHUYẾNXEToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 326);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cẬPNHẬPXEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cẬPNHẬPCHUYẾNXEToolStripMenuItem;
    }
}

