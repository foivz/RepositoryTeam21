namespace Appoteka_v2._0
{
    partial class FormNarudzbe
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
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.narudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbeTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.narudzbeTableAdapter();
            this.idNarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNarudzbeNatrag = new System.Windows.Forms.Button();
            this.btnNarudzbeNovi = new System.Windows.Forms.Button();
            this.btnNarudzbeIzmijeni = new System.Windows.Forms.Button();
            this.btnNarudzbeIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNarudzbeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.idDobavljacDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narudzbeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbeBindingSource
            // 
            this.narudzbeBindingSource.DataMember = "narudzbe";
            this.narudzbeBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // narudzbeTableAdapter
            // 
            this.narudzbeTableAdapter.ClearBeforeFill = true;
            // 
            // idNarudzbeDataGridViewTextBoxColumn
            // 
            this.idNarudzbeDataGridViewTextBoxColumn.DataPropertyName = "IdNarudzbe";
            this.idNarudzbeDataGridViewTextBoxColumn.HeaderText = "IdNarudzbe";
            this.idNarudzbeDataGridViewTextBoxColumn.Name = "idNarudzbeDataGridViewTextBoxColumn";
            this.idNarudzbeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            // 
            // idDobavljacDataGridViewTextBoxColumn
            // 
            this.idDobavljacDataGridViewTextBoxColumn.DataPropertyName = "IdDobavljac";
            this.idDobavljacDataGridViewTextBoxColumn.HeaderText = "IdDobavljac";
            this.idDobavljacDataGridViewTextBoxColumn.Name = "idDobavljacDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // btnNarudzbeNatrag
            // 
            this.btnNarudzbeNatrag.Location = new System.Drawing.Point(21, 227);
            this.btnNarudzbeNatrag.Name = "btnNarudzbeNatrag";
            this.btnNarudzbeNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNarudzbeNatrag.TabIndex = 1;
            this.btnNarudzbeNatrag.Text = "Natrag";
            this.btnNarudzbeNatrag.UseVisualStyleBackColor = true;
            this.btnNarudzbeNatrag.Click += new System.EventHandler(this.btnNarudzbeNatrag_Click);
            // 
            // btnNarudzbeNovi
            // 
            this.btnNarudzbeNovi.Location = new System.Drawing.Point(184, 227);
            this.btnNarudzbeNovi.Name = "btnNarudzbeNovi";
            this.btnNarudzbeNovi.Size = new System.Drawing.Size(75, 23);
            this.btnNarudzbeNovi.TabIndex = 2;
            this.btnNarudzbeNovi.Text = "Novi";
            this.btnNarudzbeNovi.UseVisualStyleBackColor = true;
            this.btnNarudzbeNovi.Click += new System.EventHandler(this.btnNarudzbeNovi_Click);
            // 
            // btnNarudzbeIzmijeni
            // 
            this.btnNarudzbeIzmijeni.Location = new System.Drawing.Point(404, 227);
            this.btnNarudzbeIzmijeni.Name = "btnNarudzbeIzmijeni";
            this.btnNarudzbeIzmijeni.Size = new System.Drawing.Size(75, 23);
            this.btnNarudzbeIzmijeni.TabIndex = 3;
            this.btnNarudzbeIzmijeni.Text = "Izmijeni";
            this.btnNarudzbeIzmijeni.UseVisualStyleBackColor = true;
            this.btnNarudzbeIzmijeni.Click += new System.EventHandler(this.btnNarudzbeIzmijeni_Click);
            // 
            // btnNarudzbeIzbrisi
            // 
            this.btnNarudzbeIzbrisi.Location = new System.Drawing.Point(567, 226);
            this.btnNarudzbeIzbrisi.Name = "btnNarudzbeIzbrisi";
            this.btnNarudzbeIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnNarudzbeIzbrisi.TabIndex = 4;
            this.btnNarudzbeIzbrisi.Text = "Izbriši";
            this.btnNarudzbeIzbrisi.UseVisualStyleBackColor = true;
            this.btnNarudzbeIzbrisi.Click += new System.EventHandler(this.btnNarudzbeIzbrisi_Click);
            // 
            // FormNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 275);
            this.Controls.Add(this.btnNarudzbeIzbrisi);
            this.Controls.Add(this.btnNarudzbeIzmijeni);
            this.Controls.Add(this.btnNarudzbeNovi);
            this.Controls.Add(this.btnNarudzbeNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNarudzbe";
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.FormNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource narudzbeBindingSource;
        private appotekaDBDataSet2TableAdapters.narudzbeTableAdapter narudzbeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNarudzbeNatrag;
        private System.Windows.Forms.Button btnNarudzbeNovi;
        private System.Windows.Forms.Button btnNarudzbeIzmijeni;
        private System.Windows.Forms.Button btnNarudzbeIzbrisi;
    }
}