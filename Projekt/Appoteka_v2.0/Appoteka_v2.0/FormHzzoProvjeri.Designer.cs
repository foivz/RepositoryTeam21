namespace Appoteka_v2._0
{
    partial class FormHzzoProvjeri
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
            this.textZdrastvena = new System.Windows.Forms.TextBox();
            this.btnFormHzzoProvjeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zdrastvena iskaznica";
            // 
            // textZdrastvena
            // 
            this.textZdrastvena.Location = new System.Drawing.Point(206, 37);
            this.textZdrastvena.Name = "textZdrastvena";
            this.textZdrastvena.Size = new System.Drawing.Size(152, 20);
            this.textZdrastvena.TabIndex = 1;
            this.textZdrastvena.TextChanged += new System.EventHandler(this.textSerijskiBroj_TextChanged);
            // 
            // btnFormHzzoProvjeri
            // 
            this.btnFormHzzoProvjeri.Location = new System.Drawing.Point(222, 85);
            this.btnFormHzzoProvjeri.Name = "btnFormHzzoProvjeri";
            this.btnFormHzzoProvjeri.Size = new System.Drawing.Size(109, 23);
            this.btnFormHzzoProvjeri.TabIndex = 2;
            this.btnFormHzzoProvjeri.Text = "Provjeri";
            this.btnFormHzzoProvjeri.UseVisualStyleBackColor = true;
            this.btnFormHzzoProvjeri.Click += new System.EventHandler(this.btnFormHzzoProvjeri_Click);
            // 
            // FormHzzoProvjeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 285);
            this.Controls.Add(this.btnFormHzzoProvjeri);
            this.Controls.Add(this.textZdrastvena);
            this.Controls.Add(this.label1);
            this.Name = "FormHzzoProvjeri";
            this.Text = "FormHzzoProvjeri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textZdrastvena;
        private System.Windows.Forms.Button btnFormHzzoProvjeri;
    }
}