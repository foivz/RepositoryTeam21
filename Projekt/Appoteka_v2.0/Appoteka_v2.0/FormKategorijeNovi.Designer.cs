namespace Appoteka_v2._0
{
    partial class FormKategorijeNovi
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
            this.textKategorijaNaziv = new System.Windows.Forms.TextBox();
            this.textKategorijaOpis = new System.Windows.Forms.TextBox();
            this.btnKategorijeNoviSpremi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis";
            // 
            // textKategorijaNaziv
            // 
            this.textKategorijaNaziv.Location = new System.Drawing.Point(134, 74);
            this.textKategorijaNaziv.Name = "textKategorijaNaziv";
            this.textKategorijaNaziv.Size = new System.Drawing.Size(147, 20);
            this.textKategorijaNaziv.TabIndex = 3;
            // 
            // textKategorijaOpis
            // 
            this.textKategorijaOpis.Location = new System.Drawing.Point(134, 120);
            this.textKategorijaOpis.Multiline = true;
            this.textKategorijaOpis.Name = "textKategorijaOpis";
            this.textKategorijaOpis.Size = new System.Drawing.Size(147, 76);
            this.textKategorijaOpis.TabIndex = 5;
            // 
            // btnKategorijeNoviSpremi
            // 
            this.btnKategorijeNoviSpremi.Location = new System.Drawing.Point(105, 258);
            this.btnKategorijeNoviSpremi.Name = "btnKategorijeNoviSpremi";
            this.btnKategorijeNoviSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnKategorijeNoviSpremi.TabIndex = 6;
            this.btnKategorijeNoviSpremi.Text = "Spremi";
            this.btnKategorijeNoviSpremi.UseVisualStyleBackColor = true;
            this.btnKategorijeNoviSpremi.Click += new System.EventHandler(this.btnKategorijeNoviSpremi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormKategorijeNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKategorijeNoviSpremi);
            this.Controls.Add(this.textKategorijaOpis);
            this.Controls.Add(this.textKategorijaNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKategorijeNovi";
            this.Text = "Nova kategorija lijeka";
            this.Load += new System.EventHandler(this.FormKategorijeNovi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKategorijaNaziv;
        private System.Windows.Forms.TextBox textKategorijaOpis;
        private System.Windows.Forms.Button btnKategorijeNoviSpremi;
        private System.Windows.Forms.Button button2;
    }
}