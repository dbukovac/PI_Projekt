namespace WoodYou
{
    partial class Skladiste
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
            this.listBoxListamaterijala = new System.Windows.Forms.ListBox();
            this.textBoxTrazilica = new System.Windows.Forms.TextBox();
            this.textBoxNazivmaterijala = new System.Windows.Forms.TextBox();
            this.textBoxKolicinamaterijala = new System.Windows.Forms.TextBox();
            this.buttonUnesimaterijal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTraži = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxListamaterijala
            // 
            this.listBoxListamaterijala.FormattingEnabled = true;
            this.listBoxListamaterijala.Location = new System.Drawing.Point(194, 45);
            this.listBoxListamaterijala.Name = "listBoxListamaterijala";
            this.listBoxListamaterijala.Size = new System.Drawing.Size(166, 147);
            this.listBoxListamaterijala.TabIndex = 0;
            // 
            // textBoxTrazilica
            // 
            this.textBoxTrazilica.Location = new System.Drawing.Point(194, 19);
            this.textBoxTrazilica.Name = "textBoxTrazilica";
            this.textBoxTrazilica.Size = new System.Drawing.Size(83, 20);
            this.textBoxTrazilica.TabIndex = 1;
            // 
            // textBoxNazivmaterijala
            // 
            this.textBoxNazivmaterijala.Location = new System.Drawing.Point(52, 67);
            this.textBoxNazivmaterijala.Name = "textBoxNazivmaterijala";
            this.textBoxNazivmaterijala.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazivmaterijala.TabIndex = 2;
            // 
            // textBoxKolicinamaterijala
            // 
            this.textBoxKolicinamaterijala.Location = new System.Drawing.Point(52, 124);
            this.textBoxKolicinamaterijala.Name = "textBoxKolicinamaterijala";
            this.textBoxKolicinamaterijala.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolicinamaterijala.TabIndex = 3;
            // 
            // buttonUnesimaterijal
            // 
            this.buttonUnesimaterijal.Location = new System.Drawing.Point(52, 171);
            this.buttonUnesimaterijal.Name = "buttonUnesimaterijal";
            this.buttonUnesimaterijal.Size = new System.Drawing.Size(100, 23);
            this.buttonUnesimaterijal.TabIndex = 4;
            this.buttonUnesimaterijal.Text = "Unesi materijal";
            this.buttonUnesimaterijal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv materijala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unesena količina";
            // 
            // buttonTraži
            // 
            this.buttonTraži.Location = new System.Drawing.Point(283, 16);
            this.buttonTraži.Name = "buttonTraži";
            this.buttonTraži.Size = new System.Drawing.Size(77, 23);
            this.buttonTraži.TabIndex = 7;
            this.buttonTraži.Text = "Traži";
            this.buttonTraži.UseVisualStyleBackColor = true;
            // 
            // Skladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 218);
            this.Controls.Add(this.buttonTraži);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUnesimaterijal);
            this.Controls.Add(this.textBoxKolicinamaterijala);
            this.Controls.Add(this.textBoxNazivmaterijala);
            this.Controls.Add(this.textBoxTrazilica);
            this.Controls.Add(this.listBoxListamaterijala);
            this.Name = "Skladiste";
            this.Text = "Skladiste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListamaterijala;
        private System.Windows.Forms.TextBox textBoxTrazilica;
        private System.Windows.Forms.TextBox textBoxNazivmaterijala;
        private System.Windows.Forms.TextBox textBoxKolicinamaterijala;
        private System.Windows.Forms.Button buttonUnesimaterijal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTraži;
    }
}