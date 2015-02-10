namespace Appoteka_v2._0
{
    partial class FormDobavljaci
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
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.dobavljaciTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter();
            this.btnDobavljaciNatrag = new System.Windows.Forms.Button();
            this.btnDobavljaciNovi = new System.Windows.Forms.Button();
            this.btnDobavljaciIzmijeni = new System.Windows.Forms.Button();
            this.btnDobavljaciIzbrisi = new System.Windows.Forms.Button();
            this.idDobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDobavljacDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.iBANDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dobavljaciBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(29, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataMember = "dobavljaci";
            this.dobavljaciBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dobavljaciTableAdapter
            // 
            this.dobavljaciTableAdapter.ClearBeforeFill = true;
            // 
            // btnDobavljaciNatrag
            // 
            this.btnDobavljaciNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDobavljaciNatrag.Location = new System.Drawing.Point(29, 266);
            this.btnDobavljaciNatrag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDobavljaciNatrag.Name = "btnDobavljaciNatrag";
            this.btnDobavljaciNatrag.Size = new System.Drawing.Size(113, 41);
            this.btnDobavljaciNatrag.TabIndex = 1;
            this.btnDobavljaciNatrag.Text = "Natrag";
            this.btnDobavljaciNatrag.UseVisualStyleBackColor = true;
            this.btnDobavljaciNatrag.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDobavljaciNovi
            // 
            this.btnDobavljaciNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDobavljaciNovi.Location = new System.Drawing.Point(316, 266);
            this.btnDobavljaciNovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDobavljaciNovi.Name = "btnDobavljaciNovi";
            this.btnDobavljaciNovi.Size = new System.Drawing.Size(113, 41);
            this.btnDobavljaciNovi.TabIndex = 2;
            this.btnDobavljaciNovi.Text = "Novi";
            this.btnDobavljaciNovi.UseVisualStyleBackColor = true;
            this.btnDobavljaciNovi.Click += new System.EventHandler(this.btnDobavljaciNovi_Click);
            // 
            // btnDobavljaciIzmijeni
            // 
            this.btnDobavljaciIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDobavljaciIzmijeni.Location = new System.Drawing.Point(479, 266);
            this.btnDobavljaciIzmijeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDobavljaciIzmijeni.Name = "btnDobavljaciIzmijeni";
            this.btnDobavljaciIzmijeni.Size = new System.Drawing.Size(113, 41);
            this.btnDobavljaciIzmijeni.TabIndex = 3;
            this.btnDobavljaciIzmijeni.Text = "Izmijeni";
            this.btnDobavljaciIzmijeni.UseVisualStyleBackColor = true;
            this.btnDobavljaciIzmijeni.Click += new System.EventHandler(this.btnDobavljaciIzmijeni_Click);
            // 
            // btnDobavljaciIzbrisi
            // 
            this.btnDobavljaciIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDobavljaciIzbrisi.Location = new System.Drawing.Point(644, 266);
            this.btnDobavljaciIzbrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDobavljaciIzbrisi.Name = "btnDobavljaciIzbrisi";
            this.btnDobavljaciIzbrisi.Size = new System.Drawing.Size(113, 41);
            this.btnDobavljaciIzbrisi.TabIndex = 4;
            this.btnDobavljaciIzbrisi.Text = "Izbriši";
            this.btnDobavljaciIzbrisi.UseVisualStyleBackColor = true;
            this.btnDobavljaciIzbrisi.Click += new System.EventHandler(this.btnDobavljaciIzbrisi_Click);
            // 
            // idDobavljacDataGridViewTextBoxColumn
            // 
            this.idDobavljacDataGridViewTextBoxColumn.DataPropertyName = "IdDobavljac";
            this.idDobavljacDataGridViewTextBoxColumn.HeaderText = "ID dobavljač";
            this.idDobavljacDataGridViewTextBoxColumn.Name = "idDobavljacDataGridViewTextBoxColumn";
            this.idDobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // iBANDataGridViewTextBoxColumn
            // 
            this.iBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN";
            this.iBANDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.iBANDataGridViewTextBoxColumn.Name = "iBANDataGridViewTextBoxColumn";
            this.iBANDataGridViewTextBoxColumn.Width = 200;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // FormDobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 353);
            this.Controls.Add(this.btnDobavljaciIzbrisi);
            this.Controls.Add(this.btnDobavljaciIzmijeni);
            this.Controls.Add(this.btnDobavljaciNovi);
            this.Controls.Add(this.btnDobavljaciNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDobavljaci";
            this.Text = "Dobavljači";
            this.Load += new System.EventHandler(this.FormDobavljaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter dobavljaciTableAdapter;
        private System.Windows.Forms.Button btnDobavljaciNatrag;
        private System.Windows.Forms.Button btnDobavljaciNovi;
        private System.Windows.Forms.Button btnDobavljaciIzmijeni;
        private System.Windows.Forms.Button btnDobavljaciIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
    }
}