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
            this.nazivLabel = new System.Windows.Forms.Label();
            this.datumPocetkaLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.spremiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Location = new System.Drawing.Point(24, 21);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(37, 13);
            this.nazivLabel.TabIndex = 1;
            this.nazivLabel.Text = "Naziv:";
            // 
            // datumPocetkaLabel
            // 
            this.datumPocetkaLabel.AutoSize = true;
            this.datumPocetkaLabel.Location = new System.Drawing.Point(24, 50);
            this.datumPocetkaLabel.Name = "datumPocetkaLabel";
            this.datumPocetkaLabel.Size = new System.Drawing.Size(83, 13);
            this.datumPocetkaLabel.TabIndex = 2;
            this.datumPocetkaLabel.Text = "Datum početka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Klijent:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(148, 106);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 13;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(229, 106);
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
            this.ClientSize = new System.Drawing.Size(316, 153);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datumPocetkaLabel);
            this.Controls.Add(this.nazivLabel);
            this.Name = "NoviProjektForm";
            this.Text = "Unos novog projekta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.Label datumPocetkaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}