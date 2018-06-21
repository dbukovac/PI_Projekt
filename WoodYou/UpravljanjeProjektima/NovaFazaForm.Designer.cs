namespace UpravljanjeProjektima
{
    partial class NovaFazaForm
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
            this.odustaniButton = new System.Windows.Forms.Button();
            this.dodajFazuButton = new System.Windows.Forms.Button();
            this.tboxNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datumPocetkaLabel = new System.Windows.Forms.Label();
            this.nazivLabel = new System.Windows.Forms.Label();
            this.numTrajanje = new System.Windows.Forms.NumericUpDown();
            this.numCijena = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(182, 146);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 9;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // dodajFazuButton
            // 
            this.dodajFazuButton.Location = new System.Drawing.Point(101, 146);
            this.dodajFazuButton.Name = "dodajFazuButton";
            this.dodajFazuButton.Size = new System.Drawing.Size(75, 23);
            this.dodajFazuButton.TabIndex = 8;
            this.dodajFazuButton.Text = "Dodaj fazu";
            this.dodajFazuButton.UseVisualStyleBackColor = true;
            this.dodajFazuButton.Click += new System.EventHandler(this.dodajFazuButton_Click);
            // 
            // tboxNaziv
            // 
            this.tboxNaziv.Location = new System.Drawing.Point(101, 41);
            this.tboxNaziv.Name = "tboxNaziv";
            this.tboxNaziv.Size = new System.Drawing.Size(135, 20);
            this.tboxNaziv.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Trajanje:";
            // 
            // datumPocetkaLabel
            // 
            this.datumPocetkaLabel.AutoSize = true;
            this.datumPocetkaLabel.Location = new System.Drawing.Point(14, 67);
            this.datumPocetkaLabel.Name = "datumPocetkaLabel";
            this.datumPocetkaLabel.Size = new System.Drawing.Size(39, 13);
            this.datumPocetkaLabel.TabIndex = 14;
            this.datumPocetkaLabel.Text = "Cijena:";
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Location = new System.Drawing.Point(14, 41);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(37, 13);
            this.nazivLabel.TabIndex = 13;
            this.nazivLabel.Text = "Naziv:";
            // 
            // numTrajanje
            // 
            this.numTrajanje.Location = new System.Drawing.Point(101, 91);
            this.numTrajanje.Name = "numTrajanje";
            this.numTrajanje.Size = new System.Drawing.Size(135, 20);
            this.numTrajanje.TabIndex = 16;
            // 
            // numCijena
            // 
            this.numCijena.Location = new System.Drawing.Point(101, 65);
            this.numCijena.Name = "numCijena";
            this.numCijena.Size = new System.Drawing.Size(135, 20);
            this.numCijena.TabIndex = 17;
            // 
            // NovaFazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 191);
            this.Controls.Add(this.numCijena);
            this.Controls.Add(this.numTrajanje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datumPocetkaLabel);
            this.Controls.Add(this.nazivLabel);
            this.Controls.Add(this.tboxNaziv);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajFazuButton);
            this.Name = "NovaFazaForm";
            this.Text = "NovaFazaForm";
            this.Load += new System.EventHandler(this.NovaFazaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button dodajFazuButton;
        private System.Windows.Forms.TextBox tboxNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label datumPocetkaLabel;
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.NumericUpDown numTrajanje;
        private System.Windows.Forms.NumericUpDown numCijena;
    }
}