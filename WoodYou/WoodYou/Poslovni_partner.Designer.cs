namespace WoodYou
{
    partial class Poslovni_partner
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
            this.listBoxListaPoslovnihpartnera = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipkorisnika = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxListaPoslovnihpartnera
            // 
            this.listBoxListaPoslovnihpartnera.FormattingEnabled = true;
            this.listBoxListaPoslovnihpartnera.Location = new System.Drawing.Point(231, 22);
            this.listBoxListaPoslovnihpartnera.Name = "listBoxListaPoslovnihpartnera";
            this.listBoxListaPoslovnihpartnera.Size = new System.Drawing.Size(120, 173);
            this.listBoxListaPoslovnihpartnera.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Obriši poslovnog partnera";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Potvrdi izmjene";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kreiraj novog";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(49, 22);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(124, 20);
            this.textBoxIme.TabIndex = 4;
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Location = new System.Drawing.Point(49, 67);
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(124, 20);
            this.textBoxOIB.TabIndex = 5;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(49, 117);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(124, 20);
            this.textBoxAdresa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "OIB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tip klijenta";
            // 
            // comboBoxTipkorisnika
            // 
            this.comboBoxTipkorisnika.FormattingEnabled = true;
            this.comboBoxTipkorisnika.Location = new System.Drawing.Point(49, 163);
            this.comboBoxTipkorisnika.Name = "comboBoxTipkorisnika";
            this.comboBoxTipkorisnika.Size = new System.Drawing.Size(124, 21);
            this.comboBoxTipkorisnika.TabIndex = 13;
            // 
            // Poslovni_partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.comboBoxTipkorisnika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxOIB);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxListaPoslovnihpartnera);
            this.Name = "Poslovni_partner";
            this.Text = "Poslovni_partner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListaPoslovnihpartnera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipkorisnika;
    }
}