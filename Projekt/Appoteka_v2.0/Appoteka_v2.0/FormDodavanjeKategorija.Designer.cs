﻿namespace Appoteka_v2._0
{
    partial class FormDodavanjeKategorija
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
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.kategorijeLijekovaTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.kategorijeLijekovaTableAdapter();
            this.btnDodajKategorije = new System.Windows.Forms.Button();
            this.btnZavrsiKategorije = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kategorijeLijekovaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnNatragKategorije = new System.Windows.Forms.Button();
            this.kategorijeLijekovaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idKategorijeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource2)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 94);
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
            this.kategorijeLijekovaBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // appotekaDBDataSet2
            // 
            this.appotekaDBDataSet2.DataSetName = "appotekaDBDataSet2";
            this.appotekaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijeLijekovaTableAdapter
            // 
            this.kategorijeLijekovaTableAdapter.ClearBeforeFill = true;
            // 
            // btnDodajKategorije
            // 
            this.btnDodajKategorije.Location = new System.Drawing.Point(451, 35);
            this.btnDodajKategorije.Name = "btnDodajKategorije";
            this.btnDodajKategorije.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKategorije.TabIndex = 1;
            this.btnDodajKategorije.Text = "Dodaj";
            this.btnDodajKategorije.UseVisualStyleBackColor = true;
            this.btnDodajKategorije.Click += new System.EventHandler(this.btnDodajKategorije_Click);
            // 
            // btnZavrsiKategorije
            // 
            this.btnZavrsiKategorije.Location = new System.Drawing.Point(451, 106);
            this.btnZavrsiKategorije.Name = "btnZavrsiKategorije";
            this.btnZavrsiKategorije.Size = new System.Drawing.Size(75, 23);
            this.btnZavrsiKategorije.TabIndex = 3;
            this.btnZavrsiKategorije.Text = "Završi";
            this.btnZavrsiKategorije.UseVisualStyleBackColor = true;
            this.btnZavrsiKategorije.Click += new System.EventHandler(this.btnZavrsiKategorije_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKategorijeDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.opisDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.kategorijeLijekovaBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(30, 200);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(386, 107);
            this.dataGridView2.TabIndex = 4;
            // 
            // kategorijeLijekovaBindingSource1
            // 
            this.kategorijeLijekovaBindingSource1.DataMember = "kategorijeLijekova";
            this.kategorijeLijekovaBindingSource1.DataSource = this.appotekaDBDataSet2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dodane kategorije";
            // 
            // btnNatragKategorije
            // 
            this.btnNatragKategorije.Location = new System.Drawing.Point(30, 349);
            this.btnNatragKategorije.Name = "btnNatragKategorije";
            this.btnNatragKategorije.Size = new System.Drawing.Size(75, 23);
            this.btnNatragKategorije.TabIndex = 6;
            this.btnNatragKategorije.Text = "Natrag";
            this.btnNatragKategorije.UseVisualStyleBackColor = true;
            this.btnNatragKategorije.Click += new System.EventHandler(this.btnNatragKategorije_Click);
            // 
            // kategorijeLijekovaBindingSource2
            // 
            this.kategorijeLijekovaBindingSource2.DataMember = "kategorijeLijekova";
            this.kategorijeLijekovaBindingSource2.DataSource = this.appotekaDBDataSet2;
            // 
            // idKategorijeDataGridViewTextBoxColumn1
            // 
            this.idKategorijeDataGridViewTextBoxColumn1.DataPropertyName = "IdKategorije";
            this.idKategorijeDataGridViewTextBoxColumn1.HeaderText = "IdKategorije";
            this.idKategorijeDataGridViewTextBoxColumn1.Name = "idKategorijeDataGridViewTextBoxColumn1";
            this.idKategorijeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // opisDataGridViewTextBoxColumn1
            // 
            this.opisDataGridViewTextBoxColumn1.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn1.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn1.Name = "opisDataGridViewTextBoxColumn1";
            // 
            // FormDodavanjeKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 399);
            this.Controls.Add(this.btnNatragKategorije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnZavrsiKategorije);
            this.Controls.Add(this.btnDodajKategorije);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDodavanjeKategorija";
            this.Text = "Dodavanje kategorija";
            this.Load += new System.EventHandler(this.FormDodavanjeKategorija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource;
        private appotekaDBDataSet2TableAdapters.kategorijeLijekovaTableAdapter kategorijeLijekovaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajKategorije;
        private System.Windows.Forms.Button btnZavrsiKategorije;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNatragKategorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKategorijeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource2;
    }
}