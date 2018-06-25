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
            this.components = new System.ComponentModel.Container();
            this.nazivLabel = new System.Windows.Forms.Label();
            this.datumPocetkaLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxNaziv = new System.Windows.Forms.TextBox();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.spremiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.cboxPartner = new System.Windows.Forms.ComboBox();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
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
            // tboxNaziv
            // 
            this.tboxNaziv.Location = new System.Drawing.Point(135, 18);
            this.tboxNaziv.Name = "tboxNaziv";
            this.tboxNaziv.Size = new System.Drawing.Size(100, 20);
            this.tboxNaziv.TabIndex = 7;
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(135, 44);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(136, 20);
            this.dtDatum.TabIndex = 10;
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(148, 106);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 13;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(229, 106);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 14;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // cboxPartner
            // 
            this.cboxPartner.DataSource = this.partnerBindingSource;
            this.cboxPartner.DisplayMember = "ime";
            this.cboxPartner.FormattingEnabled = true;
            this.cboxPartner.Location = new System.Drawing.Point(135, 70);
            this.cboxPartner.Name = "cboxPartner";
            this.cboxPartner.Size = new System.Drawing.Size(136, 21);
            this.cboxPartner.TabIndex = 15;
            this.cboxPartner.ValueMember = "partnerId";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(UpravljanjeProjektima.Partner);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // NoviProjektForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 153);
            this.Controls.Add(this.cboxPartner);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.tboxNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datumPocetkaLabel);
            this.Controls.Add(this.nazivLabel);
            this.helpProvider1.SetHelpKeyword(this, "NoviProjektForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "NoviProjektForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Unos novog projekta";
            this.Load += new System.EventHandler(this.NoviProjektForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.Label datumPocetkaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxNaziv;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.ComboBox cboxPartner;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}