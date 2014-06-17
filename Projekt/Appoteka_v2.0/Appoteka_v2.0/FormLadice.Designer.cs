namespace Appoteka_v2._0
{
    partial class FormLadice
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
            this.appotekaDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladiceTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.ladiceTableAdapter();
            this.idLadiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLadiceNatrag = new System.Windows.Forms.Button();
            this.btnLadiceNovi = new System.Windows.Forms.Button();
            this.btnLadiceIzmijeni = new System.Windows.Forms.Button();
            this.btnLadiceIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLadiceDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ladiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appotekaDBDataSet2BindingSource
            // 
            this.appotekaDBDataSet2BindingSource.DataSource = this.appotekaDBDataSet2;
            this.appotekaDBDataSet2BindingSource.Position = 0;
            // 
            // ladiceBindingSource
            // 
            this.ladiceBindingSource.DataMember = "ladice";
            this.ladiceBindingSource.DataSource = this.appotekaDBDataSet2BindingSource;
            // 
            // ladiceTableAdapter
            // 
            this.ladiceTableAdapter.ClearBeforeFill = true;
            // 
            // idLadiceDataGridViewTextBoxColumn
            // 
            this.idLadiceDataGridViewTextBoxColumn.DataPropertyName = "IdLadice";
            this.idLadiceDataGridViewTextBoxColumn.HeaderText = "IdLadice";
            this.idLadiceDataGridViewTextBoxColumn.Name = "idLadiceDataGridViewTextBoxColumn";
            this.idLadiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kapacitetDataGridViewTextBoxColumn
            // 
            this.kapacitetDataGridViewTextBoxColumn.DataPropertyName = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.HeaderText = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.Name = "kapacitetDataGridViewTextBoxColumn";
            // 
            // btnLadiceNatrag
            // 
            this.btnLadiceNatrag.Location = new System.Drawing.Point(21, 212);
            this.btnLadiceNatrag.Name = "btnLadiceNatrag";
            this.btnLadiceNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnLadiceNatrag.TabIndex = 1;
            this.btnLadiceNatrag.Text = "Natrag";
            this.btnLadiceNatrag.UseVisualStyleBackColor = true;
            this.btnLadiceNatrag.Click += new System.EventHandler(this.btnLadiceNatrag_Click);
            // 
            // btnLadiceNovi
            // 
            this.btnLadiceNovi.Location = new System.Drawing.Point(121, 212);
            this.btnLadiceNovi.Name = "btnLadiceNovi";
            this.btnLadiceNovi.Size = new System.Drawing.Size(75, 23);
            this.btnLadiceNovi.TabIndex = 2;
            this.btnLadiceNovi.Text = "Novi";
            this.btnLadiceNovi.UseVisualStyleBackColor = true;
            this.btnLadiceNovi.Click += new System.EventHandler(this.btnLadiceNovi_Click);
            // 
            // btnLadiceIzmijeni
            // 
            this.btnLadiceIzmijeni.Location = new System.Drawing.Point(230, 212);
            this.btnLadiceIzmijeni.Name = "btnLadiceIzmijeni";
            this.btnLadiceIzmijeni.Size = new System.Drawing.Size(75, 23);
            this.btnLadiceIzmijeni.TabIndex = 3;
            this.btnLadiceIzmijeni.Text = "Izmijeni";
            this.btnLadiceIzmijeni.UseVisualStyleBackColor = true;
            this.btnLadiceIzmijeni.Click += new System.EventHandler(this.btnLadiceIzmijeni_Click);
            // 
            // btnLadiceIzbrisi
            // 
            this.btnLadiceIzbrisi.Location = new System.Drawing.Point(338, 212);
            this.btnLadiceIzbrisi.Name = "btnLadiceIzbrisi";
            this.btnLadiceIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnLadiceIzbrisi.TabIndex = 4;
            this.btnLadiceIzbrisi.Text = "Izbriši";
            this.btnLadiceIzbrisi.UseVisualStyleBackColor = true;
            this.btnLadiceIzbrisi.Click += new System.EventHandler(this.btnLadiceIzbrisi_Click);
            // 
            // FormLadice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 271);
            this.Controls.Add(this.btnLadiceIzbrisi);
            this.Controls.Add(this.btnLadiceIzmijeni);
            this.Controls.Add(this.btnLadiceNovi);
            this.Controls.Add(this.btnLadiceNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLadice";
            this.Text = "Ladice";
            this.Load += new System.EventHandler(this.FormLadice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource appotekaDBDataSet2BindingSource;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource ladiceBindingSource;
        private appotekaDBDataSet2TableAdapters.ladiceTableAdapter ladiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLadiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLadiceNatrag;
        private System.Windows.Forms.Button btnLadiceNovi;
        private System.Windows.Forms.Button btnLadiceIzmijeni;
        private System.Windows.Forms.Button btnLadiceIzbrisi;
    }
}