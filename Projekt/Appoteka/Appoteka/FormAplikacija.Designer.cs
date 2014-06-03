namespace Appoteka
{
    partial class FormAplikacija
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.managamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataLijekovi = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataNarduzbe = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataRacuni = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.lijekoviToolStripMenuItem,
            this.managamentToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(904, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lijekoviToolStripMenuItem
            // 
            this.lijekoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDataLijekovi,
            this.miDataNarduzbe,
            this.miDataRacuni});
            this.lijekoviToolStripMenuItem.Name = "lijekoviToolStripMenuItem";
            this.lijekoviToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.lijekoviToolStripMenuItem.Text = "Data";
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(152, 22);
            this.miFileExit.Text = "Exit";
            // 
            // managamentToolStripMenuItem
            // 
            this.managamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniciToolStripMenuItem,
            this.dobavljačiToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.ladiceToolStripMenuItem});
            this.managamentToolStripMenuItem.Name = "managamentToolStripMenuItem";
            this.managamentToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managamentToolStripMenuItem.Text = "Managament";
            // 
            // miDataLijekovi
            // 
            this.miDataLijekovi.Name = "miDataLijekovi";
            this.miDataLijekovi.Size = new System.Drawing.Size(152, 22);
            this.miDataLijekovi.Text = "Lijekovi";
            this.miDataLijekovi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miDataLijekovi_MouseUp);
            // 
            // miDataNarduzbe
            // 
            this.miDataNarduzbe.Name = "miDataNarduzbe";
            this.miDataNarduzbe.Size = new System.Drawing.Size(152, 22);
            this.miDataNarduzbe.Text = "Narudžbe";
            // 
            // miDataRacuni
            // 
            this.miDataRacuni.Name = "miDataRacuni";
            this.miDataRacuni.Size = new System.Drawing.Size(152, 22);
            this.miDataRacuni.Text = "Računi";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // dobavljačiToolStripMenuItem
            // 
            this.dobavljačiToolStripMenuItem.Name = "dobavljačiToolStripMenuItem";
            this.dobavljačiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dobavljačiToolStripMenuItem.Text = "Dobavljači";
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // ladiceToolStripMenuItem
            // 
            this.ladiceToolStripMenuItem.Name = "ladiceToolStripMenuItem";
            this.ladiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ladiceToolStripMenuItem.Text = "Ladice";
            // 
            // FormAplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 312);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "FormAplikacija";
            this.Text = "FormAplikacija";
            this.Load += new System.EventHandler(this.FormAplikacija_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem miDataLijekovi;
        private System.Windows.Forms.ToolStripMenuItem miDataNarduzbe;
        private System.Windows.Forms.ToolStripMenuItem miDataRacuni;
        private System.Windows.Forms.ToolStripMenuItem managamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladiceToolStripMenuItem;
    }
}