﻿namespace Appoteka_v2._0
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNarudzbeIznos = new System.Windows.Forms.TextBox();
            this.dateTimeNaruzbeDatum = new System.Windows.Forms.DateTimePicker();
            this.btnNarudzbeNoviSpremi = new System.Windows.Forms.Button();
            this.btnNarudzbeNoviIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dobavljač";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zaposlenik";
            // 
            // textNarudzbeIznos
            // 
            this.textNarudzbeIznos.Location = new System.Drawing.Point(147, 74);
            this.textNarudzbeIznos.Name = "textNarudzbeIznos";
            this.textNarudzbeIznos.Size = new System.Drawing.Size(139, 20);
            this.textNarudzbeIznos.TabIndex = 4;
            // 
            // dateTimeNaruzbeDatum
            // 
            this.dateTimeNaruzbeDatum.Location = new System.Drawing.Point(147, 34);
            this.dateTimeNaruzbeDatum.Name = "dateTimeNaruzbeDatum";
            this.dateTimeNaruzbeDatum.Size = new System.Drawing.Size(139, 20);
            this.dateTimeNaruzbeDatum.TabIndex = 5;
            // 
            // btnNarudzbeNoviSpremi
            // 
            this.btnNarudzbeNoviSpremi.Location = new System.Drawing.Point(42, 212);
            this.btnNarudzbeNoviSpremi.Name = "btnNarudzbeNoviSpremi";
            this.btnNarudzbeNoviSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnNarudzbeNoviSpremi.TabIndex = 6;
            this.btnNarudzbeNoviSpremi.Text = "Spremi";
            this.btnNarudzbeNoviSpremi.UseVisualStyleBackColor = true;
            this.btnNarudzbeNoviSpremi.Click += new System.EventHandler(this.btnNarudzbeNoviSpremi_Click);
            // 
            // btnNarudzbeNoviIzlaz
            // 
            this.btnNarudzbeNoviIzlaz.Location = new System.Drawing.Point(210, 211);
            this.btnNarudzbeNoviIzlaz.Name = "btnNarudzbeNoviIzlaz";
            this.btnNarudzbeNoviIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnNarudzbeNoviIzlaz.TabIndex = 7;
            this.btnNarudzbeNoviIzlaz.Text = "Izlaz";
            this.btnNarudzbeNoviIzlaz.UseVisualStyleBackColor = true;
            this.btnNarudzbeNoviIzlaz.Click += new System.EventHandler(this.btnNarudzbeNoviIzlaz_Click);
            // 
            // FormNarudzbeNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 262);
            this.Controls.Add(this.btnNarudzbeNoviIzlaz);
            this.Controls.Add(this.btnNarudzbeNoviSpremi);
            this.Controls.Add(this.dateTimeNaruzbeDatum);
            this.Controls.Add(this.textNarudzbeIznos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNarudzbeNovi";
            this.Text = "Nova narudžba";
            this.Load += new System.EventHandler(this.FormNarudzbeNovi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNarudzbeIznos;
        private System.Windows.Forms.DateTimePicker dateTimeNaruzbeDatum;
        private System.Windows.Forms.Button btnNarudzbeNoviSpremi;
        private System.Windows.Forms.Button btnNarudzbeNoviIzlaz;
    }
}