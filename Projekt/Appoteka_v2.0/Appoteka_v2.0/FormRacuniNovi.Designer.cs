namespace Appoteka_v2._0
{
    partial class FormRacuniNovi
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
            this.textRacuniIznos = new System.Windows.Forms.TextBox();
            this.dateTimeRacuniDatum = new System.Windows.Forms.DateTimePicker();
            this.btnRacuniNoviSpremi = new System.Windows.Forms.Button();
            this.btnRacuniNoviIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zaposlenik";
            // 
            // textRacuniIznos
            // 
            this.textRacuniIznos.Location = new System.Drawing.Point(155, 90);
            this.textRacuniIznos.Name = "textRacuniIznos";
            this.textRacuniIznos.Size = new System.Drawing.Size(200, 20);
            this.textRacuniIznos.TabIndex = 3;
            // 
            // dateTimeRacuniDatum
            // 
            this.dateTimeRacuniDatum.Location = new System.Drawing.Point(155, 39);
            this.dateTimeRacuniDatum.Name = "dateTimeRacuniDatum";
            this.dateTimeRacuniDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimeRacuniDatum.TabIndex = 4;
            // 
            // btnRacuniNoviSpremi
            // 
            this.btnRacuniNoviSpremi.Location = new System.Drawing.Point(40, 193);
            this.btnRacuniNoviSpremi.Name = "btnRacuniNoviSpremi";
            this.btnRacuniNoviSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnRacuniNoviSpremi.TabIndex = 5;
            this.btnRacuniNoviSpremi.Text = "Spremi";
            this.btnRacuniNoviSpremi.UseVisualStyleBackColor = true;
            this.btnRacuniNoviSpremi.Click += new System.EventHandler(this.btnRacuniNoviSpremi_Click);
            // 
            // btnRacuniNoviIzlaz
            // 
            this.btnRacuniNoviIzlaz.Location = new System.Drawing.Point(279, 193);
            this.btnRacuniNoviIzlaz.Name = "btnRacuniNoviIzlaz";
            this.btnRacuniNoviIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnRacuniNoviIzlaz.TabIndex = 6;
            this.btnRacuniNoviIzlaz.Text = "Izlaz";
            this.btnRacuniNoviIzlaz.UseVisualStyleBackColor = true;
            this.btnRacuniNoviIzlaz.Click += new System.EventHandler(this.btnRacuniNoviIzlaz_Click);
            // 
            // FormRacuniNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 262);
            this.Controls.Add(this.btnRacuniNoviIzlaz);
            this.Controls.Add(this.btnRacuniNoviSpremi);
            this.Controls.Add(this.dateTimeRacuniDatum);
            this.Controls.Add(this.textRacuniIznos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRacuniNovi";
            this.Text = "Novi račun";
            this.Load += new System.EventHandler(this.FormRacuniNovi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRacuniIznos;
        private System.Windows.Forms.DateTimePicker dateTimeRacuniDatum;
        private System.Windows.Forms.Button btnRacuniNoviSpremi;
        private System.Windows.Forms.Button btnRacuniNoviIzlaz;
    }
}