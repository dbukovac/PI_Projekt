namespace UpravljanjeKorisnicima
{
    partial class NoviKorisnikForm
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
            this.components = new System.ComponentModel.Container();
            this.tboxKorime = new System.Windows.Forms.TextBox();
            this.cboxTip = new System.Windows.Forms.ComboBox();
            this.spremiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxLozinka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.tipkorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxKorime
            // 
            this.tboxKorime.Location = new System.Drawing.Point(114, 35);
            this.tboxKorime.Name = "tboxKorime";
            this.tboxKorime.Size = new System.Drawing.Size(161, 20);
            this.tboxKorime.TabIndex = 0;
            // 
            // cboxTip
            // 
            this.cboxTip.DataSource = this.tipkorisnikaBindingSource;
            this.cboxTip.DisplayMember = "naziv";
            this.cboxTip.FormattingEnabled = true;
            this.cboxTip.Location = new System.Drawing.Point(114, 139);
            this.cboxTip.Name = "cboxTip";
            this.cboxTip.Size = new System.Drawing.Size(110, 21);
            this.cboxTip.TabIndex = 1;
            this.cboxTip.ValueMember = "tip_korisnikaId";
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(188, 187);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 2;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime:";
            // 
            // tboxIme
            // 
            this.tboxIme.Location = new System.Drawing.Point(114, 61);
            this.tboxIme.Name = "tboxIme";
            this.tboxIme.Size = new System.Drawing.Size(161, 20);
            this.tboxIme.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezime:";
            // 
            // tboxPrezime
            // 
            this.tboxPrezime.Location = new System.Drawing.Point(114, 87);
            this.tboxPrezime.Name = "tboxPrezime";
            this.tboxPrezime.Size = new System.Drawing.Size(161, 20);
            this.tboxPrezime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lozinka:";
            // 
            // tboxLozinka
            // 
            this.tboxLozinka.Location = new System.Drawing.Point(114, 113);
            this.tboxLozinka.Name = "tboxLozinka";
            this.tboxLozinka.Size = new System.Drawing.Size(161, 20);
            this.tboxLozinka.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tip:";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(278, 187);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 11;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // tipkorisnikaBindingSource
            // 
            this.tipkorisnikaBindingSource.DataSource = typeof(UpravljanjeKorisnicima.Tip_korisnika);
            // 
            // NoviKorisnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 222);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxLozinka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.cboxTip);
            this.Controls.Add(this.tboxKorime);
            this.Name = "NoviKorisnikForm";
            this.Text = "NoviKorisnikForm";
            this.Load += new System.EventHandler(this.NoviKorisnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxKorime;
        private System.Windows.Forms.ComboBox cboxTip;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxLozinka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.BindingSource tipkorisnikaBindingSource;
    }
}