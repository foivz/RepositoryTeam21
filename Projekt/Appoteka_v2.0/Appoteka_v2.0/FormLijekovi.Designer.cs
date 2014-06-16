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
            this.serijskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokTrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKupovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaProdajnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopunskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet = new Appoteka_v2._0.appotekaDBDataSet();
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSetTableAdapters.lijekoviTableAdapter();
            this.btnLijekoviNovi = new System.Windows.Forms.Button();
            this.btnLijekoviNatrag = new System.Windows.Forms.Button();
            this.btnLijekoviIzmjeni = new System.Windows.Forms.Button();
            this.btnLijekIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serijskiBrojDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.proizvodacDataGridViewTextBoxColumn,
            this.rokTrajanjaDataGridViewTextBoxColumn,
            this.cijenaKupovnaDataGridViewTextBoxColumn,
            this.cijenaProdajnaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.dopunskoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lijekoviBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // serijskiBrojDataGridViewTextBoxColumn
            // 
            this.serijskiBrojDataGridViewTextBoxColumn.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn.HeaderText = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn.Name = "serijskiBrojDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
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
            // FormLijekovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 293);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet appotekaDBDataSet;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSetTableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokTrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaKupovnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaProdajnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopunskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLijekoviNovi;
        private System.Windows.Forms.Button btnLijekoviNatrag;
        private System.Windows.Forms.Button btnLijekoviIzmjeni;
        private System.Windows.Forms.Button btnLijekIzbrisi;
    }
}

