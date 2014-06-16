namespace Appoteka_v2._0
{
    partial class FormKategorije
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
            this.idKategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijeLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet1 = new Appoteka_v2._0.appotekaDBDataSet1();
            this.kategorijeLijekovaTableAdapter = new Appoteka_v2._0.appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter();
            this.btnKategorijeNatrag = new System.Windows.Forms.Button();
            this.btnKategorijeNovi = new System.Windows.Forms.Button();
            this.btnKategorijeIzmjeni = new System.Windows.Forms.Button();
            this.btnKategorijeIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKategorijeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kategorijeLijekovaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idKategorijeDataGridViewTextBoxColumn
            // 
            this.idKategorijeDataGridViewTextBoxColumn.DataPropertyName = "IdKategorije";
            this.idKategorijeDataGridViewTextBoxColumn.HeaderText = "IdKategorije";
            this.idKategorijeDataGridViewTextBoxColumn.Name = "idKategorijeDataGridViewTextBoxColumn";
            this.idKategorijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // kategorijeLijekovaBindingSource
            // 
            this.kategorijeLijekovaBindingSource.DataMember = "kategorijeLijekova";
            this.kategorijeLijekovaBindingSource.DataSource = this.appotekaDBDataSet1;
            // 
            // appotekaDBDataSet1
            // 
            this.appotekaDBDataSet1.DataSetName = "appotekaDBDataSet1";
            this.appotekaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijeLijekovaTableAdapter
            // 
            this.kategorijeLijekovaTableAdapter.ClearBeforeFill = true;
            // 
            // btnKategorijeNatrag
            // 
            this.btnKategorijeNatrag.Location = new System.Drawing.Point(36, 206);
            this.btnKategorijeNatrag.Name = "btnKategorijeNatrag";
            this.btnKategorijeNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnKategorijeNatrag.TabIndex = 1;
            this.btnKategorijeNatrag.Text = "Natrag";
            this.btnKategorijeNatrag.UseVisualStyleBackColor = true;
            this.btnKategorijeNatrag.Click += new System.EventHandler(this.btnKategorijeNatrag_Click);
            // 
            // btnKategorijeNovi
            // 
            this.btnKategorijeNovi.Location = new System.Drawing.Point(145, 206);
            this.btnKategorijeNovi.Name = "btnKategorijeNovi";
            this.btnKategorijeNovi.Size = new System.Drawing.Size(75, 23);
            this.btnKategorijeNovi.TabIndex = 2;
            this.btnKategorijeNovi.Text = "Novi";
            this.btnKategorijeNovi.UseVisualStyleBackColor = true;
            this.btnKategorijeNovi.Click += new System.EventHandler(this.btnKategorijeNovi_Click);
            // 
            // btnKategorijeIzmjeni
            // 
            this.btnKategorijeIzmjeni.Location = new System.Drawing.Point(241, 206);
            this.btnKategorijeIzmjeni.Name = "btnKategorijeIzmjeni";
            this.btnKategorijeIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnKategorijeIzmjeni.TabIndex = 3;
            this.btnKategorijeIzmjeni.Text = "Izmjeni";
            this.btnKategorijeIzmjeni.UseVisualStyleBackColor = true;
            this.btnKategorijeIzmjeni.Click += new System.EventHandler(this.btnKategorijeIzmjeni_Click);
            // 
            // btnKategorijeIzbrisi
            // 
            this.btnKategorijeIzbrisi.Location = new System.Drawing.Point(338, 206);
            this.btnKategorijeIzbrisi.Name = "btnKategorijeIzbrisi";
            this.btnKategorijeIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnKategorijeIzbrisi.TabIndex = 4;
            this.btnKategorijeIzbrisi.Text = "Izbriši";
            this.btnKategorijeIzbrisi.UseVisualStyleBackColor = true;
            this.btnKategorijeIzbrisi.Click += new System.EventHandler(this.btnKategorijeIzbrisi_Click);
            // 
            // FormKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 314);
            this.Controls.Add(this.btnKategorijeIzbrisi);
            this.Controls.Add(this.btnKategorijeIzmjeni);
            this.Controls.Add(this.btnKategorijeNovi);
            this.Controls.Add(this.btnKategorijeNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKategorije";
            this.Text = "Kategorije lijekova";
            this.Load += new System.EventHandler(this.FormKategorije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet1 appotekaDBDataSet1;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource;
        private appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter kategorijeLijekovaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKategorijeNatrag;
        private System.Windows.Forms.Button btnKategorijeNovi;
        private System.Windows.Forms.Button btnKategorijeIzmjeni;
        private System.Windows.Forms.Button btnKategorijeIzbrisi;
    }
}