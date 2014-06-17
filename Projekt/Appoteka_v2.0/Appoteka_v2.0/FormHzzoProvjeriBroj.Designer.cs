namespace Appoteka_v2._0
{
    partial class FormHzzoProvjeriBroj
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
            this.hzzoKlijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hzzoDBDataSet = new Appoteka_v2._0.HzzoDBDataSet();
            this.hzzoKlijentTableAdapter = new Appoteka_v2._0.HzzoDBDataSetTableAdapters.hzzoKlijentTableAdapter();
            this.textKlijentIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textKlijentPrezime = new System.Windows.Forms.TextBox();
            this.textKlijentOib = new System.Windows.Forms.TextBox();
            this.textKlijentZdrastvena = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idReceptaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIstekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPodizanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serijskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hzzoReceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hzzoReceptTableAdapter = new Appoteka_v2._0.HzzoDBDataSetTableAdapters.hzzoReceptTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hzzoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hzzoLijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hzzoLijekoviTableAdapter = new Appoteka_v2._0.HzzoDBDataSetTableAdapters.hzzoLijekoviTableAdapter();
            this.serijskiBrojDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokTrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKupovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaProdajnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoKlijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoReceptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoLijekoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hzzoKlijentBindingSource
            // 
            this.hzzoKlijentBindingSource.DataMember = "hzzoKlijent";
            this.hzzoKlijentBindingSource.DataSource = this.hzzoDBDataSet;
            // 
            // hzzoDBDataSet
            // 
            this.hzzoDBDataSet.DataSetName = "HzzoDBDataSet";
            this.hzzoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hzzoKlijentTableAdapter
            // 
            this.hzzoKlijentTableAdapter.ClearBeforeFill = true;
            // 
            // textKlijentIme
            // 
            this.textKlijentIme.Location = new System.Drawing.Point(129, 30);
            this.textKlijentIme.Name = "textKlijentIme";
            this.textKlijentIme.ReadOnly = true;
            this.textKlijentIme.Size = new System.Drawing.Size(129, 20);
            this.textKlijentIme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "OIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zdrastvena";
            // 
            // textKlijentPrezime
            // 
            this.textKlijentPrezime.Location = new System.Drawing.Point(129, 61);
            this.textKlijentPrezime.Name = "textKlijentPrezime";
            this.textKlijentPrezime.ReadOnly = true;
            this.textKlijentPrezime.Size = new System.Drawing.Size(129, 20);
            this.textKlijentPrezime.TabIndex = 6;
            // 
            // textKlijentOib
            // 
            this.textKlijentOib.Location = new System.Drawing.Point(129, 91);
            this.textKlijentOib.Name = "textKlijentOib";
            this.textKlijentOib.ReadOnly = true;
            this.textKlijentOib.Size = new System.Drawing.Size(129, 20);
            this.textKlijentOib.TabIndex = 7;
            // 
            // textKlijentZdrastvena
            // 
            this.textKlijentZdrastvena.Location = new System.Drawing.Point(129, 123);
            this.textKlijentZdrastvena.Name = "textKlijentZdrastvena";
            this.textKlijentZdrastvena.ReadOnly = true;
            this.textKlijentZdrastvena.Size = new System.Drawing.Size(129, 20);
            this.textKlijentZdrastvena.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReceptaDataGridViewTextBoxColumn,
            this.datumIzdavanjaDataGridViewTextBoxColumn,
            this.datumPocetkaDataGridViewTextBoxColumn,
            this.datumIstekaDataGridViewTextBoxColumn,
            this.datumPodizanjaDataGridViewTextBoxColumn,
            this.serijskiBrojDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.hzzoReceptBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 180);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(753, 124);
            this.dataGridView2.TabIndex = 9;
            // 
            // idReceptaDataGridViewTextBoxColumn
            // 
            this.idReceptaDataGridViewTextBoxColumn.DataPropertyName = "idRecepta";
            this.idReceptaDataGridViewTextBoxColumn.HeaderText = "idRecepta";
            this.idReceptaDataGridViewTextBoxColumn.Name = "idReceptaDataGridViewTextBoxColumn";
            this.idReceptaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumIzdavanjaDataGridViewTextBoxColumn
            // 
            this.datumIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "datumIzdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.HeaderText = "datumIzdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.Name = "datumIzdavanjaDataGridViewTextBoxColumn";
            // 
            // datumPocetkaDataGridViewTextBoxColumn
            // 
            this.datumPocetkaDataGridViewTextBoxColumn.DataPropertyName = "datumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.HeaderText = "datumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.Name = "datumPocetkaDataGridViewTextBoxColumn";
            // 
            // datumIstekaDataGridViewTextBoxColumn
            // 
            this.datumIstekaDataGridViewTextBoxColumn.DataPropertyName = "datumIsteka";
            this.datumIstekaDataGridViewTextBoxColumn.HeaderText = "datumIsteka";
            this.datumIstekaDataGridViewTextBoxColumn.Name = "datumIstekaDataGridViewTextBoxColumn";
            // 
            // datumPodizanjaDataGridViewTextBoxColumn
            // 
            this.datumPodizanjaDataGridViewTextBoxColumn.DataPropertyName = "datumPodizanja";
            this.datumPodizanjaDataGridViewTextBoxColumn.HeaderText = "datumPodizanja";
            this.datumPodizanjaDataGridViewTextBoxColumn.Name = "datumPodizanjaDataGridViewTextBoxColumn";
            // 
            // serijskiBrojDataGridViewTextBoxColumn
            // 
            this.serijskiBrojDataGridViewTextBoxColumn.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn.HeaderText = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn.Name = "serijskiBrojDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn1
            // 
            this.oIBDataGridViewTextBoxColumn1.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn1.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn1.Name = "oIBDataGridViewTextBoxColumn1";
            // 
            // hzzoReceptBindingSource
            // 
            this.hzzoReceptBindingSource.DataMember = "hzzoRecept";
            this.hzzoReceptBindingSource.DataSource = this.hzzoDBDataSet;
            // 
            // hzzoReceptTableAdapter
            // 
            this.hzzoReceptTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serijskiBrojDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn,
            this.proizvodacDataGridViewTextBoxColumn,
            this.rokTrajanjaDataGridViewTextBoxColumn,
            this.cijenaKupovnaDataGridViewTextBoxColumn,
            this.cijenaProdajnaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hzzoLijekoviBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // hzzoDBDataSetBindingSource
            // 
            this.hzzoDBDataSetBindingSource.DataSource = this.hzzoDBDataSet;
            this.hzzoDBDataSetBindingSource.Position = 0;
            // 
            // hzzoLijekoviBindingSource
            // 
            this.hzzoLijekoviBindingSource.DataMember = "hzzoLijekovi";
            this.hzzoLijekoviBindingSource.DataSource = this.hzzoDBDataSetBindingSource;
            // 
            // hzzoLijekoviTableAdapter
            // 
            this.hzzoLijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // serijskiBrojDataGridViewTextBoxColumn1
            // 
            this.serijskiBrojDataGridViewTextBoxColumn1.DataPropertyName = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn1.HeaderText = "serijskiBroj";
            this.serijskiBrojDataGridViewTextBoxColumn1.Name = "serijskiBrojDataGridViewTextBoxColumn1";
            this.serijskiBrojDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // FormHzzoProvjeriBroj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textKlijentZdrastvena);
            this.Controls.Add(this.textKlijentOib);
            this.Controls.Add(this.textKlijentPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKlijentIme);
            this.Name = "FormHzzoProvjeriBroj";
            this.Text = "FormHzzoProvjeriBroj";
            this.Load += new System.EventHandler(this.FormHzzoProvjeriBroj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hzzoKlijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoReceptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoLijekoviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HzzoDBDataSet hzzoDBDataSet;
        private System.Windows.Forms.BindingSource hzzoKlijentBindingSource;
        private HzzoDBDataSetTableAdapters.hzzoKlijentTableAdapter hzzoKlijentTableAdapter;
        private System.Windows.Forms.TextBox textKlijentIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textKlijentPrezime;
        private System.Windows.Forms.TextBox textKlijentOib;
        private System.Windows.Forms.TextBox textKlijentZdrastvena;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource hzzoReceptBindingSource;
        private HzzoDBDataSetTableAdapters.hzzoReceptTableAdapter hzzoReceptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReceptaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIstekaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPodizanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hzzoDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource hzzoLijekoviBindingSource;
        private HzzoDBDataSetTableAdapters.hzzoLijekoviTableAdapter hzzoLijekoviTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serijskiBrojDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokTrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaKupovnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaProdajnaDataGridViewTextBoxColumn;
    }
}