namespace UpravljanjeProjektima
{
    partial class NoviProjektForm
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
            this.projektIdLabel = new System.Windows.Forms.Label();
            this.nazivLabel = new System.Windows.Forms.Label();
            this.datumPocetkaLabel = new System.Windows.Forms.Label();
            this.vrijemeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datumZavrsetkaLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.spremiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projektIdLabel
            // 
            this.projektIdLabel.AutoSize = true;
            this.projektIdLabel.Location = new System.Drawing.Point(24, 33);
            this.projektIdLabel.Name = "projektIdLabel";
            this.projektIdLabel.Size = new System.Drawing.Size(21, 13);
            this.projektIdLabel.TabIndex = 0;
            this.projektIdLabel.Text = "ID:";
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Location = new System.Drawing.Point(24, 59);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(37, 13);
            this.nazivLabel.TabIndex = 1;
            this.nazivLabel.Text = "Naziv:";
            // 
            // datumPocetkaLabel
            // 
            this.datumPocetkaLabel.AutoSize = true;
            this.datumPocetkaLabel.Location = new System.Drawing.Point(24, 88);
            this.datumPocetkaLabel.Name = "datumPocetkaLabel";
            this.datumPocetkaLabel.Size = new System.Drawing.Size(83, 13);
            this.datumPocetkaLabel.TabIndex = 2;
            this.datumPocetkaLabel.Text = "Datum početka:";
            // 
            // vrijemeLabel
            // 
            this.vrijemeLabel.AutoSize = true;
            this.vrijemeLabel.Location = new System.Drawing.Point(24, 115);
            this.vrijemeLabel.Name = "vrijemeLabel";
            this.vrijemeLabel.Size = new System.Drawing.Size(89, 13);
            this.vrijemeLabel.TabIndex = 3;
            this.vrijemeLabel.Text = "Potrebno vrijeme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Klijent:";
            // 
            // datumZavrsetkaLabel
            // 
            this.datumZavrsetkaLabel.AutoSize = true;
            this.datumZavrsetkaLabel.Location = new System.Drawing.Point(24, 141);
            this.datumZavrsetkaLabel.Name = "datumZavrsetkaLabel";
            this.datumZavrsetkaLabel.Size = new System.Drawing.Size(90, 13);
            this.datumZavrsetkaLabel.TabIndex = 5;
            this.datumZavrsetkaLabel.Text = "Datum završteka:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(135, 109);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(135, 135);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker3.TabIndex = 12;
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(145, 211);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 13;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(226, 211);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 14;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            // 
            // NoviProjektForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 257);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datumZavrsetkaLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vrijemeLabel);
            this.Controls.Add(this.datumPocetkaLabel);
            this.Controls.Add(this.nazivLabel);
            this.Controls.Add(this.projektIdLabel);
            this.Name = "NoviProjektForm";
            this.Text = "Unos novog projekta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projektIdLabel;
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.Label datumPocetkaLabel;
        private System.Windows.Forms.Label vrijemeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label datumZavrsetkaLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}