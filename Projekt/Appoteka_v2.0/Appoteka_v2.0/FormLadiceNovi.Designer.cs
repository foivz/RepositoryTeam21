namespace Appoteka_v2._0
{
    partial class FormLadiceNovi
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
            this.btnLadiceNoviSpremi = new System.Windows.Forms.Button();
            this.btnLadiceNoviIzlaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textLadiceNoviKapacitet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLadiceNoviSpremi
            // 
            this.btnLadiceNoviSpremi.Location = new System.Drawing.Point(37, 186);
            this.btnLadiceNoviSpremi.Name = "btnLadiceNoviSpremi";
            this.btnLadiceNoviSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnLadiceNoviSpremi.TabIndex = 0;
            this.btnLadiceNoviSpremi.Text = "Spremi";
            this.btnLadiceNoviSpremi.UseVisualStyleBackColor = true;
            this.btnLadiceNoviSpremi.Click += new System.EventHandler(this.btnLadiceNoviSpremi_Click);
            // 
            // btnLadiceNoviIzlaz
            // 
            this.btnLadiceNoviIzlaz.Location = new System.Drawing.Point(183, 186);
            this.btnLadiceNoviIzlaz.Name = "btnLadiceNoviIzlaz";
            this.btnLadiceNoviIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnLadiceNoviIzlaz.TabIndex = 1;
            this.btnLadiceNoviIzlaz.Text = "Izlaz";
            this.btnLadiceNoviIzlaz.UseVisualStyleBackColor = true;
            this.btnLadiceNoviIzlaz.Click += new System.EventHandler(this.btnLadiceNoviIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kapacitet";
            // 
            // textLadiceNoviKapacitet
            // 
            this.textLadiceNoviKapacitet.Location = new System.Drawing.Point(158, 84);
            this.textLadiceNoviKapacitet.Name = "textLadiceNoviKapacitet";
            this.textLadiceNoviKapacitet.Size = new System.Drawing.Size(100, 20);
            this.textLadiceNoviKapacitet.TabIndex = 3;
            // 
            // FormLadiceNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textLadiceNoviKapacitet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLadiceNoviIzlaz);
            this.Controls.Add(this.btnLadiceNoviSpremi);
            this.Name = "FormLadiceNovi";
            this.Text = "FormLadiceNovi";
            this.Load += new System.EventHandler(this.FormLadiceNovi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLadiceNoviSpremi;
        private System.Windows.Forms.Button btnLadiceNoviIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLadiceNoviKapacitet;
    }
}