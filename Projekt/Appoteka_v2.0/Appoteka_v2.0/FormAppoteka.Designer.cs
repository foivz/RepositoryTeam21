﻿namespace Appoteka_v2._0
{
    partial class FormAppoteka
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrowseLijekovi = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrowseNarudzbe = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrowseRacuni = new System.Windows.Forms.ToolStripMenuItem();
            this.miManagementZaposlenici = new System.Windows.Forms.ToolStripMenuItem();
            this.miManagementDobavljaci = new System.Windows.Forms.ToolStripMenuItem();
            this.miManagementKategorije = new System.Windows.Forms.ToolStripMenuItem();
            this.miManagementLadice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.managmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(152, 22);
            this.miFileExit.Text = "Exit";
            this.miFileExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miFileExit_MouseUp);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBrowseLijekovi,
            this.miBrowseNarudzbe,
            this.miBrowseRacuni});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.managementToolStripMenuItem.Text = "Browse";
            // 
            // managmentToolStripMenuItem
            // 
            this.managmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miManagementZaposlenici,
            this.miManagementDobavljaci,
            this.miManagementKategorije,
            this.miManagementLadice});
            this.managmentToolStripMenuItem.Name = "managmentToolStripMenuItem";
            this.managmentToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.managmentToolStripMenuItem.Text = "Managment";
            // 
            // miBrowseLijekovi
            // 
            this.miBrowseLijekovi.Name = "miBrowseLijekovi";
            this.miBrowseLijekovi.Size = new System.Drawing.Size(152, 22);
            this.miBrowseLijekovi.Text = "Lijekovi";
            this.miBrowseLijekovi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miBrowseLijekovi_MouseUp);
            // 
            // miBrowseNarudzbe
            // 
            this.miBrowseNarudzbe.Name = "miBrowseNarudzbe";
            this.miBrowseNarudzbe.Size = new System.Drawing.Size(152, 22);
            this.miBrowseNarudzbe.Text = "Narudžbe";
            // 
            // miBrowseRacuni
            // 
            this.miBrowseRacuni.Name = "miBrowseRacuni";
            this.miBrowseRacuni.Size = new System.Drawing.Size(152, 22);
            this.miBrowseRacuni.Text = "Računi";
            // 
            // miManagementZaposlenici
            // 
            this.miManagementZaposlenici.Name = "miManagementZaposlenici";
            this.miManagementZaposlenici.Size = new System.Drawing.Size(170, 22);
            this.miManagementZaposlenici.Text = "Zaposlenici";
            // 
            // miManagementDobavljaci
            // 
            this.miManagementDobavljaci.Name = "miManagementDobavljaci";
            this.miManagementDobavljaci.Size = new System.Drawing.Size(170, 22);
            this.miManagementDobavljaci.Text = "Dobavljači";
            // 
            // miManagementKategorije
            // 
            this.miManagementKategorije.Name = "miManagementKategorije";
            this.miManagementKategorije.Size = new System.Drawing.Size(170, 22);
            this.miManagementKategorije.Text = "Kategorije lijekova";
            this.miManagementKategorije.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miManagementKategorije_MouseUp);
            // 
            // miManagementLadice
            // 
            this.miManagementLadice.Name = "miManagementLadice";
            this.miManagementLadice.Size = new System.Drawing.Size(170, 22);
            this.miManagementLadice.Text = "Ladice";
            // 
            // FormAppoteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 291);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAppoteka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appoteka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miBrowseLijekovi;
        private System.Windows.Forms.ToolStripMenuItem miBrowseNarudzbe;
        private System.Windows.Forms.ToolStripMenuItem miBrowseRacuni;
        private System.Windows.Forms.ToolStripMenuItem managmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miManagementZaposlenici;
        private System.Windows.Forms.ToolStripMenuItem miManagementDobavljaci;
        private System.Windows.Forms.ToolStripMenuItem miManagementKategorije;
        private System.Windows.Forms.ToolStripMenuItem miManagementLadice;
    }
}