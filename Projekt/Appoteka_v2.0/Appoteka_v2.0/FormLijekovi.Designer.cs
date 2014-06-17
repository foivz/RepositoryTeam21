namespace Appoteka_v2._0
{
    partial class FormLijekovi
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
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet = new Appoteka_v2._0.appotekaDBDataSet();
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSetTableAdapters.lijekoviTableAdapter();
            this.btnLijekoviNovi = new System.Windows.Forms.Button();
            this.btnLijekoviNatrag = new System.Windows.Forms.Button();
            this.btnLijekoviIzmjeni = new System.Windows.Forms.Button();
            this.btnLijekIzbrisi = new System.Windows.Forms.Button();
            this.appotekaDBDataSet1 = new Appoteka_v2._0.appotekaDBDataSet1();
            this.kategorijeLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeLijekovaTableAdapter = new Appoteka_v2._0.appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serijskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokTrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKupovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaProdajnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopunskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaLijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.lijekovihaskategorijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekovi_has_kategorijeTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekovi_has_kategorijeTableAdapter();
            this.idKategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serijskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekovihaskategorijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.serijskiBrojDataGridViewTextBoxColumn,
            this.proizvodacDataGridViewTextBoxColumn,
            this.rokTrajanjaDataGridViewTextBoxColumn,
            this.cijenaKupovnaDataGridViewTextBoxColumn,
            this.cijenaProdajnaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.dopunskoDataGridViewTextBoxColumn,
            this.kategorijaLijeka});
            this.dataGridView1.DataSource = this.lijekoviBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 150);
            this.dataGridView1.TabIndex = 0;
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
            // btnLijekoviNovi
            // 
            this.btnLijekoviNovi.Location = new System.Drawing.Point(153, 207);
            this.btnLijekoviNovi.Name = "btnLijekoviNovi";
            this.btnLijekoviNovi.Size = new System.Drawing.Size(75, 23);
            this.btnLijekoviNovi.TabIndex = 1;
            this.btnLijekoviNovi.Text = "Novi";
            this.btnLijekoviNovi.UseVisualStyleBackColor = true;
            this.btnLijekoviNovi.Click += new System.EventHandler(this.btnLijekoviNovi_Click);
            // 
            // btnLijekoviNatrag
            // 
            this.btnLijekoviNatrag.Location = new System.Drawing.Point(12, 207);
            this.btnLijekoviNatrag.Name = "btnLijekoviNatrag";
            this.btnLijekoviNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnLijekoviNatrag.TabIndex = 2;
            this.btnLijekoviNatrag.Text = "Natrag";
            this.btnLijekoviNatrag.UseVisualStyleBackColor = true;
            this.btnLijekoviNatrag.Click += new System.EventHandler(this.btnLijekoviNatrag_Click);
            // 
            // btnLijekoviIzmjeni
            // 
            this.btnLijekoviIzmjeni.Location = new System.Drawing.Point(258, 207);
            this.btnLijekoviIzmjeni.Name = "btnLijekoviIzmjeni";
            this.btnLijekoviIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnLijekoviIzmjeni.TabIndex = 3;
            this.btnLijekoviIzmjeni.Text = "Izmjeni";
            this.btnLijekoviIzmjeni.UseVisualStyleBackColor = true;
            this.btnLijekoviIzmjeni.Click += new System.EventHandler(this.btnLijekoviIzmjeni_Click);
            // 
            // btnLijekIzbrisi
            // 
            this.btnLijekIzbrisi.Location = new System.Drawing.Point(362, 207);
            this.btnLijekIzbrisi.Name = "btnLijekIzbrisi";
            this.btnLijekIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnLijekIzbrisi.TabIndex = 4;
            this.btnLijekIzbrisi.Text = "Izbriši";
            this.btnLijekIzbrisi.UseVisualStyleBackColor = true;
            this.btnLijekIzbrisi.Click += new System.EventHandler(this.btnLijekIzbrisi_Click);
            // 
            // appotekaDBDataSet1
            // 
            this.appotekaDBDataSet1.DataSetName = "appotekaDBDataSet1";
            this.appotekaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijeLijekovaBindingSource
            // 
            this.kategorijeLijekovaBindingSource.DataMember = "kategorijeLijekova";
            this.kategorijeLijekovaBindingSource.DataSource = this.appotekaDBDataSet1;
            // 
            // kategorijeLijekovaTableAdapter
            // 
            this.kategorijeLijekovaTableAdapter.ClearBeforeFill = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // serijskiBrojDataGridViewTextBoxColumn
            // 
            this.serijskiBrojDataGridViewTextBoxColumn.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn.HeaderText = "Serijski broj";
            this.serijskiBrojDataGridViewTextBoxColumn.Name = "serijskiBrojDataGridViewTextBoxColumn";
            // 
            // proizvodacDataGridViewTextBoxColumn
            // 
            this.proizvodacDataGridViewTextBoxColumn.DataPropertyName = "proizvodac";
            this.proizvodacDataGridViewTextBoxColumn.HeaderText = "proizvodac";
            this.proizvodacDataGridViewTextBoxColumn.Name = "proizvodacDataGridViewTextBoxColumn";
            // 
            // rokTrajanjaDataGridViewTextBoxColumn
            // 
            this.rokTrajanjaDataGridViewTextBoxColumn.DataPropertyName = "rokTrajanja";
            this.rokTrajanjaDataGridViewTextBoxColumn.HeaderText = "rokTrajanja";
            this.rokTrajanjaDataGridViewTextBoxColumn.Name = "rokTrajanjaDataGridViewTextBoxColumn";
            // 
            // cijenaKupovnaDataGridViewTextBoxColumn
            // 
            this.cijenaKupovnaDataGridViewTextBoxColumn.DataPropertyName = "cijenaKupovna";
            this.cijenaKupovnaDataGridViewTextBoxColumn.HeaderText = "cijenaKupovna";
            this.cijenaKupovnaDataGridViewTextBoxColumn.Name = "cijenaKupovnaDataGridViewTextBoxColumn";
            // 
            // cijenaProdajnaDataGridViewTextBoxColumn
            // 
            this.cijenaProdajnaDataGridViewTextBoxColumn.DataPropertyName = "cijenaProdajna";
            this.cijenaProdajnaDataGridViewTextBoxColumn.HeaderText = "cijenaProdajna";
            this.cijenaProdajnaDataGridViewTextBoxColumn.Name = "cijenaProdajnaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // dopunskoDataGridViewTextBoxColumn
            // 
            this.dopunskoDataGridViewTextBoxColumn.DataPropertyName = "dopunsko";
            this.dopunskoDataGridViewTextBoxColumn.HeaderText = "dopunsko";
            this.dopunskoDataGridViewTextBoxColumn.Name = "dopunskoDataGridViewTextBoxColumn";
            // 
            // kategorijaLijeka
            // 
            this.kategorijaLijeka.HeaderText = "Kategorija";
            this.kategorijaLijeka.Name = "kategorijaLijeka";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKategorijeDataGridViewTextBoxColumn,
            this.serijskiBroj});
            this.dataGridView2.DataSource = this.lijekovihaskategorijeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(529, 190);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(309, 59);
            this.dataGridView2.TabIndex = 5;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lijekovihaskategorijeBindingSource
            // 
            this.lijekovihaskategorijeBindingSource.DataMember = "lijekovi_has_kategorije";
            this.lijekovihaskategorijeBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // lijekovi_has_kategorijeTableAdapter
            // 
            this.lijekovi_has_kategorijeTableAdapter.ClearBeforeFill = true;
            // 
            // idKategorijeDataGridViewTextBoxColumn
            // 
            this.idKategorijeDataGridViewTextBoxColumn.DataPropertyName = "IdKategorije";
            this.idKategorijeDataGridViewTextBoxColumn.HeaderText = "IdKategorije";
            this.idKategorijeDataGridViewTextBoxColumn.Name = "idKategorijeDataGridViewTextBoxColumn";
            this.idKategorijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serijskiBroj
            // 
            this.serijskiBroj.DataPropertyName = "serijskiBroj";
            this.serijskiBroj.HeaderText = "serijskiBroj";
            this.serijskiBroj.Name = "serijskiBroj";
            // 
            // FormLijekovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 293);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnLijekIzbrisi);
            this.Controls.Add(this.btnLijekoviIzmjeni);
            this.Controls.Add(this.btnLijekoviNatrag);
            this.Controls.Add(this.btnLijekoviNovi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLijekovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lijekovi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekovihaskategorijeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet appotekaDBDataSet;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSetTableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.Button btnLijekoviNovi;
        private System.Windows.Forms.Button btnLijekoviNatrag;
        private System.Windows.Forms.Button btnLijekoviIzmjeni;
        private System.Windows.Forms.Button btnLijekIzbrisi;
        private appotekaDBDataSet1 appotekaDBDataSet1;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource;
        private appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter kategorijeLijekovaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokTrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaKupovnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaProdajnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopunskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaLijeka;
        private System.Windows.Forms.DataGridView dataGridView2;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource lijekovihaskategorijeBindingSource;
        private appotekaDBDataSet2TableAdapters.lijekovi_has_kategorijeTableAdapter lijekovi_has_kategorijeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBroj;
    }
}

