
namespace Olimpijada
{
    partial class Pregled
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
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takmicariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drzaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rasporedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportoviUcesnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem,
            this.terminiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takmicariToolStripMenuItem,
            this.drzaveToolStripMenuItem,
            this.sportoviToolStripMenuItem});
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // takmicariToolStripMenuItem
            // 
            this.takmicariToolStripMenuItem.Name = "takmicariToolStripMenuItem";
            this.takmicariToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.takmicariToolStripMenuItem.Text = "Takmicari";
            this.takmicariToolStripMenuItem.Click += new System.EventHandler(this.takmicariToolStripMenuItem_Click);
            // 
            // drzaveToolStripMenuItem
            // 
            this.drzaveToolStripMenuItem.Name = "drzaveToolStripMenuItem";
            this.drzaveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drzaveToolStripMenuItem.Text = "Drzave";
            this.drzaveToolStripMenuItem.Click += new System.EventHandler(this.drzaveToolStripMenuItem_Click);
            // 
            // sportoviToolStripMenuItem
            // 
            this.sportoviToolStripMenuItem.Name = "sportoviToolStripMenuItem";
            this.sportoviToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sportoviToolStripMenuItem.Text = "Sportovi";
            this.sportoviToolStripMenuItem.Click += new System.EventHandler(this.sportoviToolStripMenuItem_Click);
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rasporedToolStripMenuItem,
            this.sportoviUcesnikaToolStripMenuItem});
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.terminiToolStripMenuItem.Text = "Opcije";
            // 
            // rasporedToolStripMenuItem
            // 
            this.rasporedToolStripMenuItem.Name = "rasporedToolStripMenuItem";
            this.rasporedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rasporedToolStripMenuItem.Text = "Termini";
            // 
            // sportoviUcesnikaToolStripMenuItem
            // 
            this.sportoviUcesnikaToolStripMenuItem.Name = "sportoviUcesnikaToolStripMenuItem";
            this.sportoviUcesnikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sportoviUcesnikaToolStripMenuItem.Text = "Sportovi ucesnika";
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pregled_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takmicariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drzaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rasporedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportoviUcesnikaToolStripMenuItem;
    }
}