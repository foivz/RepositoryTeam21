namespace Appoteka_v2._0
{
    partial class FormRacuni
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.racunTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.racunTableAdapter();
            this.btnRacuniNatrag = new System.Windows.Forms.Button();
            this.btnRacuniNovi = new System.Windows.Forms.Button();
            this.btnRacuniIzmijeni = new System.Windows.Forms.Button();
            this.btnRacunIzbrisi = new System.Windows.Forms.Button();
            this.idrRacunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrRacunaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.racunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // btnRacuniNatrag
            // 
            this.btnRacuniNatrag.Location = new System.Drawing.Point(22, 226);
            this.btnRacuniNatrag.Name = "btnRacuniNatrag";
            this.btnRacuniNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnRacuniNatrag.TabIndex = 1;
            this.btnRacuniNatrag.Text = "Natrag";
            this.btnRacuniNatrag.UseVisualStyleBackColor = true;
            this.btnRacuniNatrag.Click += new System.EventHandler(this.btnRacuniNatrag_Click);
            // 
            // btnRacuniNovi
            // 
            this.btnRacuniNovi.Location = new System.Drawing.Point(155, 225);
            this.btnRacuniNovi.Name = "btnRacuniNovi";
            this.btnRacuniNovi.Size = new System.Drawing.Size(75, 23);
            this.btnRacuniNovi.TabIndex = 2;
            this.btnRacuniNovi.Text = "Novi";
            this.btnRacuniNovi.UseVisualStyleBackColor = true;
            this.btnRacuniNovi.Click += new System.EventHandler(this.btnRacuniNovi_Click);
            // 
            // btnRacuniIzmijeni
            // 
            this.btnRacuniIzmijeni.Location = new System.Drawing.Point(306, 226);
            this.btnRacuniIzmijeni.Name = "btnRacuniIzmijeni";
            this.btnRacuniIzmijeni.Size = new System.Drawing.Size(75, 23);
            this.btnRacuniIzmijeni.TabIndex = 3;
            this.btnRacuniIzmijeni.Text = "Provjeri";
            this.btnRacuniIzmijeni.UseVisualStyleBackColor = true;
            this.btnRacuniIzmijeni.Click += new System.EventHandler(this.btnRacuniIzmijeni_Click);
            // 
            // btnRacunIzbrisi
            // 
            this.btnRacunIzbrisi.Location = new System.Drawing.Point(436, 225);
            this.btnRacunIzbrisi.Name = "btnRacunIzbrisi";
            this.btnRacunIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnRacunIzbrisi.TabIndex = 4;
            this.btnRacunIzbrisi.Text = "Izbriši";
            this.btnRacunIzbrisi.UseVisualStyleBackColor = true;
            this.btnRacunIzbrisi.Click += new System.EventHandler(this.btnRacunIzbrisi_Click);
            // 
            // idrRacunaDataGridViewTextBoxColumn
            // 
            this.idrRacunaDataGridViewTextBoxColumn.DataPropertyName = "IdrRacuna";
            this.idrRacunaDataGridViewTextBoxColumn.HeaderText = "ID računa";
            this.idrRacunaDataGridViewTextBoxColumn.Name = "idrRacunaDataGridViewTextBoxColumn";
            this.idrRacunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // FormRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 282);
            this.Controls.Add(this.btnRacunIzbrisi);
            this.Controls.Add(this.btnRacuniIzmijeni);
            this.Controls.Add(this.btnRacuniNovi);
            this.Controls.Add(this.btnRacuniNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRacuni";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.FormRacuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private appotekaDBDataSet2TableAdapters.racunTableAdapter racunTableAdapter;
        private System.Windows.Forms.Button btnRacuniNatrag;
        private System.Windows.Forms.Button btnRacuniNovi;
        private System.Windows.Forms.Button btnRacuniIzmijeni;
        private System.Windows.Forms.Button btnRacunIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrRacunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
    }
}