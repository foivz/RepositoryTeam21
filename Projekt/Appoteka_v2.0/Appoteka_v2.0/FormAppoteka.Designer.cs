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
            this.miBrowseLijekovi = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrowseNarudzbe = new System.Windows.Forms.ToolStripMenuItem();
            this.miBrowseRacuni = new System.Windows.Forms.ToolStripMenuItem();
            this.managmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miManagementZaposlenici = new System.Windows.Forms.ToolStripMenuItem();
            this.miManagementDobavljaci = new System.Windows.Forms.ToolStripMenuItem();
            this.miManagementKategorije = new System.Windows.Forms.ToolStripMenuItem();
            this.miManagementLadice = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHzzoProvjeri = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputeZaKoristenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.managmentToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1356, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(152, 24);
            this.miFileExit.Text = "Exit";
            this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBrowseLijekovi,
            this.miBrowseNarudzbe,
            this.miBrowseRacuni});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.managementToolStripMenuItem.Text = "Browse";
            // 
            // miBrowseLijekovi
            // 
            this.miBrowseLijekovi.Name = "miBrowseLijekovi";
            this.miBrowseLijekovi.Size = new System.Drawing.Size(143, 24);
            this.miBrowseLijekovi.Text = "Lijekovi";
            this.miBrowseLijekovi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miBrowseLijekovi_MouseUp);
            // 
            // miBrowseNarudzbe
            // 
            this.miBrowseNarudzbe.Name = "miBrowseNarudzbe";
            this.miBrowseNarudzbe.Size = new System.Drawing.Size(143, 24);
            this.miBrowseNarudzbe.Text = "Narudžbe";
            this.miBrowseNarudzbe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miBrowseNarudzbe_MouseUp);
            // 
            // miBrowseRacuni
            // 
            this.miBrowseRacuni.Name = "miBrowseRacuni";
            this.miBrowseRacuni.Size = new System.Drawing.Size(143, 24);
            this.miBrowseRacuni.Text = "Računi";
            this.miBrowseRacuni.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miBrowseRacuni_MouseUp);
            // 
            // managmentToolStripMenuItem
            // 
            this.managmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miManagementZaposlenici,
            this.miManagementDobavljaci,
            this.miManagementKategorije,
            this.miManagementLadice});
            this.managmentToolStripMenuItem.Name = "managmentToolStripMenuItem";
            this.managmentToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.managmentToolStripMenuItem.Text = "Managment";
            this.managmentToolStripMenuItem.Click += new System.EventHandler(this.managmentToolStripMenuItem_Click);
            // 
            // miManagementZaposlenici
            // 
            this.miManagementZaposlenici.Name = "miManagementZaposlenici";
            this.miManagementZaposlenici.Size = new System.Drawing.Size(202, 24);
            this.miManagementZaposlenici.Text = "Zaposlenici";
            this.miManagementZaposlenici.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miManagementZaposlenici_MouseUp);
            // 
            // miManagementDobavljaci
            // 
            this.miManagementDobavljaci.Name = "miManagementDobavljaci";
            this.miManagementDobavljaci.Size = new System.Drawing.Size(202, 24);
            this.miManagementDobavljaci.Text = "Dobavljači";
            this.miManagementDobavljaci.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miManagementDobavljaci_MouseUp);
            // 
            // miManagementKategorije
            // 
            this.miManagementKategorije.Name = "miManagementKategorije";
            this.miManagementKategorije.Size = new System.Drawing.Size(202, 24);
            this.miManagementKategorije.Text = "Kategorije lijekova";
            this.miManagementKategorije.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miManagementKategorije_MouseUp);
            // 
            // miManagementLadice
            // 
            this.miManagementLadice.Name = "miManagementLadice";
            this.miManagementLadice.Size = new System.Drawing.Size(202, 24);
            this.miManagementLadice.Text = "Ladice";
            this.miManagementLadice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miManagementLadice_MouseUp);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHzzoProvjeri});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.clientsToolStripMenuItem.Text = "HZZO";
            // 
            // miHzzoProvjeri
            // 
            this.miHzzoProvjeri.Name = "miHzzoProvjeri";
            this.miHzzoProvjeri.Size = new System.Drawing.Size(128, 24);
            this.miHzzoProvjeri.Text = "Provjeri";
            this.miHzzoProvjeri.Click += new System.EventHandler(this.miHzzoProvjeri_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijekoviToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.dobavljačiToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportToolStripMenuItem.Text = "Reports";
            // 
            // lijekoviToolStripMenuItem
            // 
            this.lijekoviToolStripMenuItem.Name = "lijekoviToolStripMenuItem";
            this.lijekoviToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.lijekoviToolStripMenuItem.Text = "Lijekovi";
            this.lijekoviToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lijekoviToolStripMenuItem_MouseUp);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            this.kategorijeToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kategorijeToolStripMenuItem_MouseUp);
            // 
            // dobavljačiToolStripMenuItem
            // 
            this.dobavljačiToolStripMenuItem.Name = "dobavljačiToolStripMenuItem";
            this.dobavljačiToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.dobavljačiToolStripMenuItem.Text = "Dobavljači";
            this.dobavljačiToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dobavljačiToolStripMenuItem_MouseUp);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uputeZaKoristenjeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShowShortcutKeys = false;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // uputeZaKoristenjeToolStripMenuItem
            // 
            this.uputeZaKoristenjeToolStripMenuItem.Name = "uputeZaKoristenjeToolStripMenuItem";
            this.uputeZaKoristenjeToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.uputeZaKoristenjeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.uputeZaKoristenjeToolStripMenuItem.ShowShortcutKeys = false;
            this.uputeZaKoristenjeToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.uputeZaKoristenjeToolStripMenuItem.Text = "Upute za koristenje";
            this.uputeZaKoristenjeToolStripMenuItem.Click += new System.EventHandler(this.uputeZaKoristenjeToolStripMenuItem_Click);
            // 
            // FormAppoteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1356, 511);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAppoteka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appoteka";
            this.Load += new System.EventHandler(this.miHzzoProvjeri_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAppoteka_KeyDown);
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
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHzzoProvjeri;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uputeZaKoristenjeToolStripMenuItem;
    }
}