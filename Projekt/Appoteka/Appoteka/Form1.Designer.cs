namespace Appoteka
{
    partial class Form1
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
            this.appotekaDBDataSet = new Appoteka.appotekaDBDataSet();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new Appoteka.appotekaDBDataSetTableAdapters.lijekoviTableAdapter();
            this.serijskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokTrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKupovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaProdajnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopunskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(251, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // appotekaDBDataSet
            // 
            this.appotekaDBDataSet.DataSetName = "appotekaDBDataSet";
            this.appotekaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "lijekovi";
            this.lijekoviBindingSource.DataSource = this.appotekaDBDataSet;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
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
    }
}

