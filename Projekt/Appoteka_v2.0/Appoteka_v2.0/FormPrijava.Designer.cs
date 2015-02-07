namespace Appoteka_v2._0
{
    partial class FormPrijava
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
            this.textPrijavaKorime = new System.Windows.Forms.TextBox();
            this.textPrijavaLozinka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(119, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "PRIJAVA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka";
            // 
            // textPrijavaKorime
            // 
            this.textPrijavaKorime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textPrijavaKorime.Location = new System.Drawing.Point(31, 70);
            this.textPrijavaKorime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPrijavaKorime.Name = "textPrijavaKorime";
            this.textPrijavaKorime.Size = new System.Drawing.Size(271, 30);
            this.textPrijavaKorime.TabIndex = 0;
            this.textPrijavaKorime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPrijavaKorime_KeyDown);
            // 
            // textPrijavaLozinka
            // 
            this.textPrijavaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textPrijavaLozinka.Location = new System.Drawing.Point(31, 142);
            this.textPrijavaLozinka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPrijavaLozinka.Name = "textPrijavaLozinka";
            this.textPrijavaLozinka.Size = new System.Drawing.Size(271, 30);
            this.textPrijavaLozinka.TabIndex = 1;
            this.textPrijavaLozinka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPrijavaLozinka_KeyDown);
            // 
            // FormPrijava
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.textPrijavaLozinka);
            this.Controls.Add(this.textPrijavaKorime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.FormPrijava_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrijava_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrijavaKorime;
        private System.Windows.Forms.TextBox textPrijavaLozinka;
    }
}