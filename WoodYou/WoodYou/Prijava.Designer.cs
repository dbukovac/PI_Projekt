namespace WoodYou
{
    partial class FormaPrijava
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
            this.textboxKorime = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.LabelKorime = new System.Windows.Forms.Label();
            this.LabelaLozinka = new System.Windows.Forms.Label();
            this.buttonPrijaviSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxKorime
            // 
            this.textboxKorime.Location = new System.Drawing.Point(70, 63);
            this.textboxKorime.Name = "textboxKorime";
            this.textboxKorime.Size = new System.Drawing.Size(125, 20);
            this.textboxKorime.TabIndex = 0;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(70, 133);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(125, 20);
            this.textBoxLozinka.TabIndex = 1;
            // 
            // LabelKorime
            // 
            this.LabelKorime.AutoSize = true;
            this.LabelKorime.Location = new System.Drawing.Point(67, 47);
            this.LabelKorime.Name = "LabelKorime";
            this.LabelKorime.Size = new System.Drawing.Size(75, 13);
            this.LabelKorime.TabIndex = 2;
            this.LabelKorime.Text = "Korisničko ime";
            // 
            // LabelaLozinka
            // 
            this.LabelaLozinka.AutoSize = true;
            this.LabelaLozinka.Location = new System.Drawing.Point(67, 117);
            this.LabelaLozinka.Name = "LabelaLozinka";
            this.LabelaLozinka.Size = new System.Drawing.Size(44, 13);
            this.LabelaLozinka.TabIndex = 3;
            this.LabelaLozinka.Text = "Lozinka";
            // 
            // buttonPrijaviSe
            // 
            this.buttonPrijaviSe.Location = new System.Drawing.Point(90, 173);
            this.buttonPrijaviSe.Name = "buttonPrijaviSe";
            this.buttonPrijaviSe.Size = new System.Drawing.Size(75, 23);
            this.buttonPrijaviSe.TabIndex = 4;
            this.buttonPrijaviSe.Text = "Prijavi se";
            this.buttonPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // FormaPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonPrijaviSe);
            this.Controls.Add(this.LabelaLozinka);
            this.Controls.Add(this.LabelKorime);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textboxKorime);
            this.Name = "FormaPrijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxKorime;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Label LabelKorime;
        private System.Windows.Forms.Label LabelaLozinka;
        private System.Windows.Forms.Button buttonPrijaviSe;
    }
}

