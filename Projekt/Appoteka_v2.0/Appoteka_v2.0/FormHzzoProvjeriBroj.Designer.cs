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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hzzoDBDataSet = new Appoteka_v2._0.HzzoDBDataSet();
            this.hzzoKlijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hzzoKlijentTableAdapter = new Appoteka_v2._0.HzzoDBDataSetTableAdapters.hzzoKlijentTableAdapter();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdrastvenaIskaznicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoKlijentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.zdrastvenaIskaznicaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hzzoKlijentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // hzzoDBDataSet
            // 
            this.hzzoDBDataSet.DataSetName = "HzzoDBDataSet";
            this.hzzoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hzzoKlijentBindingSource
            // 
            this.hzzoKlijentBindingSource.DataMember = "hzzoKlijent";
            this.hzzoKlijentBindingSource.DataSource = this.hzzoDBDataSet;
            // 
            // hzzoKlijentTableAdapter
            // 
            this.hzzoKlijentTableAdapter.ClearBeforeFill = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // zdrastvenaIskaznicaDataGridViewTextBoxColumn
            // 
            this.zdrastvenaIskaznicaDataGridViewTextBoxColumn.DataPropertyName = "zdrastvenaIskaznica";
            this.zdrastvenaIskaznicaDataGridViewTextBoxColumn.HeaderText = "zdrastvenaIskaznica";
            this.zdrastvenaIskaznicaDataGridViewTextBoxColumn.Name = "zdrastvenaIskaznicaDataGridViewTextBoxColumn";
            // 
            // FormHzzoProvjeriBroj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormHzzoProvjeriBroj";
            this.Text = "FormHzzoProvjeriBroj";
            this.Load += new System.EventHandler(this.FormHzzoProvjeriBroj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hzzoKlijentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HzzoDBDataSet hzzoDBDataSet;
        private System.Windows.Forms.BindingSource hzzoKlijentBindingSource;
        private HzzoDBDataSetTableAdapters.hzzoKlijentTableAdapter hzzoKlijentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdrastvenaIskaznicaDataGridViewTextBoxColumn;
    }
}