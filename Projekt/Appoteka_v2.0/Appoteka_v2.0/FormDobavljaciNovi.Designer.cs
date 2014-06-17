namespace Appoteka_v2._0
{
    partial class FormDobavljaciNovi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDobavljaciNaziv = new System.Windows.Forms.TextBox();
            this.textDobavljaciOIB = new System.Windows.Forms.TextBox();
            this.textDobavljaciIBAN = new System.Windows.Forms.TextBox();
            this.textDobavljaciAdresa = new System.Windows.Forms.TextBox();
            this.btnDobavljaciNoviSpremi = new System.Windows.Forms.Button();
            this.btnDobavljaciNoviIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "OIB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IBAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // textDobavljaciNaziv
            // 
            this.textDobavljaciNaziv.Location = new System.Drawing.Point(153, 41);
            this.textDobavljaciNaziv.Name = "textDobavljaciNaziv";
            this.textDobavljaciNaziv.Size = new System.Drawing.Size(100, 20);
            this.textDobavljaciNaziv.TabIndex = 4;
            // 
            // textDobavljaciOIB
            // 
            this.textDobavljaciOIB.Location = new System.Drawing.Point(153, 80);
            this.textDobavljaciOIB.Name = "textDobavljaciOIB";
            this.textDobavljaciOIB.Size = new System.Drawing.Size(100, 20);
            this.textDobavljaciOIB.TabIndex = 5;
            // 
            // textDobavljaciIBAN
            // 
            this.textDobavljaciIBAN.Location = new System.Drawing.Point(153, 117);
            this.textDobavljaciIBAN.Name = "textDobavljaciIBAN";
            this.textDobavljaciIBAN.Size = new System.Drawing.Size(100, 20);
            this.textDobavljaciIBAN.TabIndex = 6;
            // 
            // textDobavljaciAdresa
            // 
            this.textDobavljaciAdresa.Location = new System.Drawing.Point(153, 151);
            this.textDobavljaciAdresa.Name = "textDobavljaciAdresa";
            this.textDobavljaciAdresa.Size = new System.Drawing.Size(100, 20);
            this.textDobavljaciAdresa.TabIndex = 7;
            // 
            // btnDobavljaciNoviSpremi
            // 
            this.btnDobavljaciNoviSpremi.Location = new System.Drawing.Point(35, 219);
            this.btnDobavljaciNoviSpremi.Name = "btnDobavljaciNoviSpremi";
            this.btnDobavljaciNoviSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnDobavljaciNoviSpremi.TabIndex = 8;
            this.btnDobavljaciNoviSpremi.Text = "Spremi";
            this.btnDobavljaciNoviSpremi.UseVisualStyleBackColor = true;
            this.btnDobavljaciNoviSpremi.Click += new System.EventHandler(this.btnDobavljaciNoviSpremi_Click);
            // 
            // btnDobavljaciNoviIzlaz
            // 
            this.btnDobavljaciNoviIzlaz.Location = new System.Drawing.Point(177, 219);
            this.btnDobavljaciNoviIzlaz.Name = "btnDobavljaciNoviIzlaz";
            this.btnDobavljaciNoviIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnDobavljaciNoviIzlaz.TabIndex = 9;
            this.btnDobavljaciNoviIzlaz.Text = "Izlaz";
            this.btnDobavljaciNoviIzlaz.UseVisualStyleBackColor = true;
            this.btnDobavljaciNoviIzlaz.Click += new System.EventHandler(this.btnDobavljaciNoviIzlaz_Click);
            // 
            // FormDobavljaciNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDobavljaciNoviIzlaz);
            this.Controls.Add(this.btnDobavljaciNoviSpremi);
            this.Controls.Add(this.textDobavljaciAdresa);
            this.Controls.Add(this.textDobavljaciIBAN);
            this.Controls.Add(this.textDobavljaciOIB);
            this.Controls.Add(this.textDobavljaciNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDobavljaciNovi";
            this.Text = "Novi dobavljač";
            this.Load += new System.EventHandler(this.FormDobavljaciNovi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDobavljaciNaziv;
        private System.Windows.Forms.TextBox textDobavljaciOIB;
        private System.Windows.Forms.TextBox textDobavljaciIBAN;
        private System.Windows.Forms.TextBox textDobavljaciAdresa;
        private System.Windows.Forms.Button btnDobavljaciNoviSpremi;
        private System.Windows.Forms.Button btnDobavljaciNoviIzlaz;
    }
}