﻿namespace Appoteka_v2._0
{
    partial class FormRacunPrikazi
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textIznosRacun = new System.Windows.Forms.TextBox();
            this.textIzdaoRacun = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textDatum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Natrag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Izdao";
            // 
            // textIznosRacun
            // 
            this.textIznosRacun.Location = new System.Drawing.Point(108, 68);
            this.textIznosRacun.Name = "textIznosRacun";
            this.textIznosRacun.ReadOnly = true;
            this.textIznosRacun.Size = new System.Drawing.Size(164, 20);
            this.textIznosRacun.TabIndex = 5;
            // 
            // textIzdaoRacun
            // 
            this.textIzdaoRacun.Location = new System.Drawing.Point(108, 109);
            this.textIzdaoRacun.Name = "textIzdaoRacun";
            this.textIzdaoRacun.ReadOnly = true;
            this.textIzdaoRacun.Size = new System.Drawing.Size(164, 20);
            this.textIzdaoRacun.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 128);
            this.dataGridView1.TabIndex = 7;
            // 
            // textDatum
            // 
            this.textDatum.Location = new System.Drawing.Point(108, 33);
            this.textDatum.Name = "textDatum";
            this.textDatum.ReadOnly = true;
            this.textDatum.Size = new System.Drawing.Size(164, 20);
            this.textDatum.TabIndex = 8;
            // 
            // FormRacunPrikazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 440);
            this.Controls.Add(this.textDatum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textIzdaoRacun);
            this.Controls.Add(this.textIznosRacun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormRacunPrikazi";
            this.Text = "FormRacunPrikazi";
            this.Load += new System.EventHandler(this.FormRacunPrikazi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIznosRacun;
        private System.Windows.Forms.TextBox textIzdaoRacun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textDatum;
    }
}