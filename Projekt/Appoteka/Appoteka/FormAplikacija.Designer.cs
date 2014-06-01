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
            this.components = new System.ComponentModel.Container();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet = new Appoteka.appotekaDBDataSet();
            this.lijekoviTableAdapter = new Appoteka.appotekaDBDataSetTableAdapters.lijekoviTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "lijekovi";
            this.lijekoviBindingSource.DataSource = this.appotekaDBDataSet;
            // 
            // appotekaDBDataSet
            // 
            this.appotekaDBDataSet.DataSetName = "appotekaDBDataSet";
            this.appotekaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacijaToolStripMenuItem,
            this.lijekoviToolStripMenuItem,
            this.narudžbeToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.dobavljačiToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.ladiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacijaToolStripMenuItem
            // 
            this.aplikacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.aplikacijaToolStripMenuItem.Name = "aplikacijaToolStripMenuItem";
            this.aplikacijaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aplikacijaToolStripMenuItem.Text = "File";
            this.aplikacijaToolStripMenuItem.Click += new System.EventHandler(this.aplikacijaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // lijekoviToolStripMenuItem
            // 
            this.lijekoviToolStripMenuItem.Name = "lijekoviToolStripMenuItem";
            this.lijekoviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.lijekoviToolStripMenuItem.Text = "Lijekovi";
            this.lijekoviToolStripMenuItem.Click += new System.EventHandler(this.lijekoviToolStripMenuItem_Click);
            // 
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            // 
            // dobavljačiToolStripMenuItem
            // 
            this.dobavljačiToolStripMenuItem.Name = "dobavljačiToolStripMenuItem";
            this.dobavljačiToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.dobavljačiToolStripMenuItem.Text = "Dobavljači";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // ladiceToolStripMenuItem
            // 
            this.ladiceToolStripMenuItem.Name = "ladiceToolStripMenuItem";
            this.ladiceToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ladiceToolStripMenuItem.Text = "Ladice";
            // 
            // FormAplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAplikacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appoteka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private appotekaDBDataSet appotekaDBDataSet;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSetTableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladiceToolStripMenuItem;
    }
}

