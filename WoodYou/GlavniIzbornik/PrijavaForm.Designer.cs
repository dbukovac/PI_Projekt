namespace GlavniIzbornik
{
    partial class PrijavaForm
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
            this.buttonPrijaviSe = new System.Windows.Forms.Button();
            this.LabelaLozinka = new System.Windows.Forms.Label();
            this.LabelKorime = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textboxKorime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPrijaviSe
            // 
            this.buttonPrijaviSe.Location = new System.Drawing.Point(98, 178);
            this.buttonPrijaviSe.Name = "buttonPrijaviSe";
            this.buttonPrijaviSe.Size = new System.Drawing.Size(75, 23);
            this.buttonPrijaviSe.TabIndex = 9;
            this.buttonPrijaviSe.Text = "Prijavi se";
            this.buttonPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // LabelaLozinka
            // 
            this.LabelaLozinka.AutoSize = true;
            this.LabelaLozinka.Location = new System.Drawing.Point(75, 122);
            this.LabelaLozinka.Name = "LabelaLozinka";
            this.LabelaLozinka.Size = new System.Drawing.Size(44, 13);
            this.LabelaLozinka.TabIndex = 8;
            this.LabelaLozinka.Text = "Lozinka";
            // 
            // LabelKorime
            // 
            this.LabelKorime.AutoSize = true;
            this.LabelKorime.Location = new System.Drawing.Point(75, 52);
            this.LabelKorime.Name = "LabelKorime";
            this.LabelKorime.Size = new System.Drawing.Size(75, 13);
            this.LabelKorime.TabIndex = 7;
            this.LabelKorime.Text = "Korisničko ime";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(78, 138);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(125, 20);
            this.textBoxLozinka.TabIndex = 6;
            // 
            // textboxKorime
            // 
            this.textboxKorime.Location = new System.Drawing.Point(78, 68);
            this.textboxKorime.Name = "textboxKorime";
            this.textboxKorime.Size = new System.Drawing.Size(125, 20);
            this.textboxKorime.TabIndex = 5;
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonPrijaviSe);
            this.Controls.Add(this.LabelaLozinka);
            this.Controls.Add(this.LabelKorime);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textboxKorime);
            this.Name = "PrijavaForm";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrijaviSe;
        private System.Windows.Forms.Label LabelaLozinka;
        private System.Windows.Forms.Label LabelKorime;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textboxKorime;
    }
}

