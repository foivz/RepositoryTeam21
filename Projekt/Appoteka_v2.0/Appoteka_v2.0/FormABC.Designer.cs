namespace Appoteka_v2._0
{
    partial class FormABC
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
            this.txtKlasificiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKlasificiraj
            // 
            this.txtKlasificiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKlasificiraj.Location = new System.Drawing.Point(466, 153);
            this.txtKlasificiraj.Name = "txtKlasificiraj";
            this.txtKlasificiraj.Size = new System.Drawing.Size(92, 38);
            this.txtKlasificiraj.TabIndex = 0;
            this.txtKlasificiraj.Text = "Klasificiraj";
            this.txtKlasificiraj.UseVisualStyleBackColor = true;
            this.txtKlasificiraj.MouseHover += new System.EventHandler(this.txtKlasificiraj_MouseHover);
            // 
            // FormABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 261);
            this.Controls.Add(this.txtKlasificiraj);
            this.Name = "FormABC";
            this.Text = "FormABC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtKlasificiraj;
    }
}