namespace Appoteka_v2._0
{
    partial class FormLijekoviNovi
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
            this.btnLijekoviNoviSpremi = new System.Windows.Forms.Button();
            this.btnLijekoviNoviIzlaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textSerijskiBroj = new System.Windows.Forms.TextBox();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.textProizvodac = new System.Windows.Forms.TextBox();
            this.textCijenaKupovna = new System.Windows.Forms.TextBox();
            this.textCijenaProdajna = new System.Windows.Forms.TextBox();
            this.textLadice = new System.Windows.Forms.TextBox();
            this.textDopunsko = new System.Windows.Forms.TextBox();
            this.textKolicina = new System.Windows.Forms.TextBox();
            this.dateRokTrajanja = new System.Windows.Forms.DateTimePicker();
            this.appotekaDBDataSet1 = new Appoteka_v2._0.appotekaDBDataSet1();
            this.kategorijeLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeLijekovaTableAdapter = new Appoteka_v2._0.appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLijekoviNoviSpremi
            // 
            this.btnLijekoviNoviSpremi.Location = new System.Drawing.Point(198, 266);
            this.btnLijekoviNoviSpremi.Name = "btnLijekoviNoviSpremi";
            this.btnLijekoviNoviSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnLijekoviNoviSpremi.TabIndex = 0;
            this.btnLijekoviNoviSpremi.Text = "Spremi";
            this.btnLijekoviNoviSpremi.UseVisualStyleBackColor = true;
            this.btnLijekoviNoviSpremi.Click += new System.EventHandler(this.btnLijekoviNoviSpremi_Click);
            // 
            // btnLijekoviNoviIzlaz
            // 
            this.btnLijekoviNoviIzlaz.Location = new System.Drawing.Point(297, 266);
            this.btnLijekoviNoviIzlaz.Name = "btnLijekoviNoviIzlaz";
            this.btnLijekoviNoviIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnLijekoviNoviIzlaz.TabIndex = 1;
            this.btnLijekoviNoviIzlaz.Text = "Izlaz";
            this.btnLijekoviNoviIzlaz.UseVisualStyleBackColor = true;
            this.btnLijekoviNoviIzlaz.Click += new System.EventHandler(this.btnLijekoviNoviIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serijski broj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proizvođač";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cijena kupovna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cijena prodajna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rok trajanja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Količina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dopunsko (%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ladice";
            // 
            // textSerijskiBroj
            // 
            this.textSerijskiBroj.Location = new System.Drawing.Point(133, 26);
            this.textSerijskiBroj.Name = "textSerijskiBroj";
            this.textSerijskiBroj.Size = new System.Drawing.Size(126, 20);
            this.textSerijskiBroj.TabIndex = 12;
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(133, 58);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(126, 20);
            this.textNaziv.TabIndex = 13;
            // 
            // textProizvodac
            // 
            this.textProizvodac.Location = new System.Drawing.Point(133, 94);
            this.textProizvodac.Name = "textProizvodac";
            this.textProizvodac.Size = new System.Drawing.Size(126, 20);
            this.textProizvodac.TabIndex = 14;
            // 
            // textCijenaKupovna
            // 
            this.textCijenaKupovna.Location = new System.Drawing.Point(133, 133);
            this.textCijenaKupovna.Name = "textCijenaKupovna";
            this.textCijenaKupovna.Size = new System.Drawing.Size(126, 20);
            this.textCijenaKupovna.TabIndex = 15;
            // 
            // textCijenaProdajna
            // 
            this.textCijenaProdajna.Location = new System.Drawing.Point(133, 167);
            this.textCijenaProdajna.Name = "textCijenaProdajna";
            this.textCijenaProdajna.Size = new System.Drawing.Size(126, 20);
            this.textCijenaProdajna.TabIndex = 16;
            // 
            // textLadice
            // 
            this.textLadice.Location = new System.Drawing.Point(373, 120);
            this.textLadice.Name = "textLadice";
            this.textLadice.Size = new System.Drawing.Size(126, 20);
            this.textLadice.TabIndex = 20;
            // 
            // textDopunsko
            // 
            this.textDopunsko.Location = new System.Drawing.Point(373, 94);
            this.textDopunsko.Name = "textDopunsko";
            this.textDopunsko.Size = new System.Drawing.Size(126, 20);
            this.textDopunsko.TabIndex = 18;
            // 
            // textKolicina
            // 
            this.textKolicina.Location = new System.Drawing.Point(373, 58);
            this.textKolicina.Name = "textKolicina";
            this.textKolicina.Size = new System.Drawing.Size(126, 20);
            this.textKolicina.TabIndex = 17;
            // 
            // dateRokTrajanja
            // 
            this.dateRokTrajanja.Location = new System.Drawing.Point(373, 26);
            this.dateRokTrajanja.Name = "dateRokTrajanja";
            this.dateRokTrajanja.Size = new System.Drawing.Size(126, 20);
            this.dateRokTrajanja.TabIndex = 21;
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
            // FormLijekoviNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 316);
            this.Controls.Add(this.dateRokTrajanja);
            this.Controls.Add(this.textLadice);
            this.Controls.Add(this.textDopunsko);
            this.Controls.Add(this.textKolicina);
            this.Controls.Add(this.textCijenaProdajna);
            this.Controls.Add(this.textCijenaKupovna);
            this.Controls.Add(this.textProizvodac);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.textSerijskiBroj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLijekoviNoviIzlaz);
            this.Controls.Add(this.btnLijekoviNoviSpremi);
            this.Name = "FormLijekoviNovi";
            this.Text = "Novi lijek";
            this.Load += new System.EventHandler(this.FormLijekoviNovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appotekaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeLijekovaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLijekoviNoviSpremi;
        private System.Windows.Forms.Button btnLijekoviNoviIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSerijskiBroj;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.TextBox textProizvodac;
        private System.Windows.Forms.TextBox textCijenaKupovna;
        private System.Windows.Forms.TextBox textCijenaProdajna;
        private System.Windows.Forms.TextBox textLadice;
        private System.Windows.Forms.TextBox textDopunsko;
        private System.Windows.Forms.TextBox textKolicina;
        private System.Windows.Forms.DateTimePicker dateRokTrajanja;
        private appotekaDBDataSet1 appotekaDBDataSet1;
        private System.Windows.Forms.BindingSource kategorijeLijekovaBindingSource;
        private appotekaDBDataSet1TableAdapters.kategorijeLijekovaTableAdapter kategorijeLijekovaTableAdapter;
    }
}