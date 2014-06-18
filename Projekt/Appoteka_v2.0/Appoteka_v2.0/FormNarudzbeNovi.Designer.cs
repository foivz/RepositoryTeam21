namespace Appoteka_v2._0
{
    partial class FormNarudzbeNovi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNaruzbeDatum = new System.Windows.Forms.DateTimePicker();
            this.btnNarudzbeNoviSpremi = new System.Windows.Forms.Button();
            this.btnNarudzbeNoviIzlaz = new System.Windows.Forms.Button();
            this.comboBoxDobavljac = new System.Windows.Forms.ComboBox();
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appotekaDBDataSet2 = new Appoteka_v2._0.appotekaDBDataSet2();
            this.comboBoxZaposlenik = new System.Windows.Forms.ComboBox();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljaciTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter();
            this.zaposleniciTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.zaposleniciTableAdapter();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new Appoteka_v2._0.appotekaDBDataSet2TableAdapters.lijekoviTableAdapter();
            this.lijekoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.textNarudzbeIznos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dobavljač";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zaposlenik";
            // 
            // dateTimeNaruzbeDatum
            // 
            this.dateTimeNaruzbeDatum.Location = new System.Drawing.Point(112, 35);
            this.dateTimeNaruzbeDatum.Name = "dateTimeNaruzbeDatum";
            this.dateTimeNaruzbeDatum.Size = new System.Drawing.Size(139, 20);
            this.dateTimeNaruzbeDatum.TabIndex = 5;
            // 
            // btnNarudzbeNoviSpremi
            // 
            this.btnNarudzbeNoviSpremi.Location = new System.Drawing.Point(31, 225);
            this.btnNarudzbeNoviSpremi.Name = "btnNarudzbeNoviSpremi";
            this.btnNarudzbeNoviSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnNarudzbeNoviSpremi.TabIndex = 6;
            this.btnNarudzbeNoviSpremi.Text = "Spremi";
            this.btnNarudzbeNoviSpremi.UseVisualStyleBackColor = true;
            this.btnNarudzbeNoviSpremi.Click += new System.EventHandler(this.btnNarudzbeNoviSpremi_Click);
            // 
            // btnNarudzbeNoviIzlaz
            // 
            this.btnNarudzbeNoviIzlaz.Location = new System.Drawing.Point(176, 225);
            this.btnNarudzbeNoviIzlaz.Name = "btnNarudzbeNoviIzlaz";
            this.btnNarudzbeNoviIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnNarudzbeNoviIzlaz.TabIndex = 7;
            this.btnNarudzbeNoviIzlaz.Text = "Izlaz";
            this.btnNarudzbeNoviIzlaz.UseVisualStyleBackColor = true;
            this.btnNarudzbeNoviIzlaz.Click += new System.EventHandler(this.btnNarudzbeNoviIzlaz_Click);
            // 
            // comboBoxDobavljac
            // 
            this.comboBoxDobavljac.DataSource = this.dobavljaciBindingSource;
            this.comboBoxDobavljac.DisplayMember = "naziv";
            this.comboBoxDobavljac.FormattingEnabled = true;
            this.comboBoxDobavljac.Location = new System.Drawing.Point(113, 94);
            this.comboBoxDobavljac.Name = "comboBoxDobavljac";
            this.comboBoxDobavljac.Size = new System.Drawing.Size(138, 21);
            this.comboBoxDobavljac.TabIndex = 9;
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
            // comboBoxZaposlenik
            // 
            this.comboBoxZaposlenik.DataSource = this.zaposleniciBindingSource;
            this.comboBoxZaposlenik.DisplayMember = "prezime";
            this.comboBoxZaposlenik.FormattingEnabled = true;
            this.comboBoxZaposlenik.Location = new System.Drawing.Point(113, 144);
            this.comboBoxZaposlenik.Name = "comboBoxZaposlenik";
            this.comboBoxZaposlenik.Size = new System.Drawing.Size(138, 21);
            this.comboBoxZaposlenik.TabIndex = 10;
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // dobavljaciTableAdapter
            // 
            this.dobavljaciTableAdapter.ClearBeforeFill = true;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "lijekovi";
            this.lijekoviBindingSource.DataSource = this.appotekaDBDataSet2;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // lijekoviBindingSource1
            // 
            this.lijekoviBindingSource1.DataMember = "lijekovi";
            this.lijekoviBindingSource1.DataSource = this.appotekaDBDataSet2;
            // 
            // lijekoviBindingSource2
            // 
            this.lijekoviBindingSource2.DataMember = "lijekovi";
            this.lijekoviBindingSource2.DataSource = this.appotekaDBDataSet2;
            // 
            // lijekoviBindingSource3
            // 
            this.lijekoviBindingSource3.DataMember = "lijekovi";
            this.lijekoviBindingSource3.DataSource = this.appotekaDBDataSet2;
            // 
            // textNarudzbeIznos
            // 
            this.textNarudzbeIznos.Location = new System.Drawing.Point(112, 187);
            this.textNarudzbeIznos.Name = "textNarudzbeIznos";
            this.textNarudzbeIznos.Size = new System.Drawing.Size(139, 20);
            this.textNarudzbeIznos.TabIndex = 11;
            // 
            // FormNarudzbeNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 274);
            this.Controls.Add(this.textNarudzbeIznos);
            this.Controls.Add(this.comboBoxZaposlenik);
            this.Controls.Add(this.comboBoxDobavljac);
            this.Controls.Add(this.btnNarudzbeNoviIzlaz);
            this.Controls.Add(this.btnNarudzbeNoviSpremi);
            this.Controls.Add(this.dateTimeNaruzbeDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormNarudzbeNovi";
            this.Text = "Nova narudžba";
            this.Load += new System.EventHandler(this.FormNarudzbeNovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeNaruzbeDatum;
        private System.Windows.Forms.Button btnNarudzbeNoviSpremi;
        private System.Windows.Forms.Button btnNarudzbeNoviIzlaz;
        private System.Windows.Forms.ComboBox comboBoxDobavljac;
        private System.Windows.Forms.ComboBox comboBoxZaposlenik;
        private appotekaDBDataSet2 appotekaDBDataSet2;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private appotekaDBDataSet2TableAdapters.dobavljaciTableAdapter dobavljaciTableAdapter;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private appotekaDBDataSet2TableAdapters.zaposleniciTableAdapter zaposleniciTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private appotekaDBDataSet2TableAdapters.lijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource1;
        private System.Windows.Forms.BindingSource lijekoviBindingSource2;
        private System.Windows.Forms.BindingSource lijekoviBindingSource3;
        private System.Windows.Forms.TextBox textNarudzbeIznos;
    }
}