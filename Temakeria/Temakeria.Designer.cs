namespace Temakeria
{
    partial class Temakeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temakeria));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPCOESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPCOESToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPCOESToolStripMenuItem
            // 
            this.oPCOESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFuncionarioToolStripMenuItem});
            this.oPCOESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.oPCOESToolStripMenuItem.Name = "oPCOESToolStripMenuItem";
            this.oPCOESToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.oPCOESToolStripMenuItem.Text = "Opções";
            this.oPCOESToolStripMenuItem.Click += new System.EventHandler(this.oPCOESToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // addFuncionarioToolStripMenuItem
            // 
            this.addFuncionarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addFuncionarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.addFuncionarioToolStripMenuItem.Name = "addFuncionarioToolStripMenuItem";
            this.addFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFuncionarioToolStripMenuItem.Text = "AddFuncionario";
            this.addFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.addFuncionarioToolStripMenuItem_Click);
            // 
            // Temakeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 388);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Temakeria";
            this.ShowIcon = false;
            this.Text = "Temakeria";
            this.Load += new System.EventHandler(this.Temakeria_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPCOESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

