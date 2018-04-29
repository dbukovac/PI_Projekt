namespace WoodYou
{
    partial class Korisnici
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
            this.buttonPotvrdiKorisnika = new System.Windows.Forms.Button();
            this.listBoxKorisnici = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxKorime = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonIzmjeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPotvrdiKorisnika
            // 
            this.buttonPotvrdiKorisnika.Location = new System.Drawing.Point(12, 226);
            this.buttonPotvrdiKorisnika.Name = "buttonPotvrdiKorisnika";
            this.buttonPotvrdiKorisnika.Size = new System.Drawing.Size(100, 23);
            this.buttonPotvrdiKorisnika.TabIndex = 0;
            this.buttonPotvrdiKorisnika.Text = "Potvrdi unos";
            this.buttonPotvrdiKorisnika.UseVisualStyleBackColor = true;
            // 
            // listBoxKorisnici
            // 
            this.listBoxKorisnici.FormattingEnabled = true;
            this.listBoxKorisnici.Location = new System.Drawing.Point(230, 28);
            this.listBoxKorisnici.Name = "listBoxKorisnici";
            this.listBoxKorisnici.Size = new System.Drawing.Size(120, 186);
            this.listBoxKorisnici.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Obriši korisnika";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxKorime
            // 
            this.textBoxKorime.Location = new System.Drawing.Point(67, 28);
            this.textBoxKorime.Name = "textBoxKorime";
            this.textBoxKorime.Size = new System.Drawing.Size(100, 20);
            this.textBoxKorime.TabIndex = 3;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(67, 65);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(100, 20);
            this.textBoxLozinka.TabIndex = 4;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(67, 105);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 5;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(67, 147);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Korisnicko Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prezime";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Razina prava";
            // 
            // buttonIzmjeni
            // 
            this.buttonIzmjeni.Location = new System.Drawing.Point(118, 226);
            this.buttonIzmjeni.Name = "buttonIzmjeni";
            this.buttonIzmjeni.Size = new System.Drawing.Size(100, 23);
            this.buttonIzmjeni.TabIndex = 14;
            this.buttonIzmjeni.Text = "Potvrdi izmjene";
            this.buttonIzmjeni.UseVisualStyleBackColor = true;
            // 
            // Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.buttonIzmjeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKorime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxKorisnici);
            this.Controls.Add(this.buttonPotvrdiKorisnika);
            this.Name = "Korisnici";
            this.Text = "Korisnici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPotvrdiKorisnika;
        private System.Windows.Forms.ListBox listBoxKorisnici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxKorime;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonIzmjeni;
    }
}