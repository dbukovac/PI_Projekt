namespace UpravljanjeNarudzbama
{
    partial class NovaNarudzbenicaForm
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
            System.Windows.Forms.Label datumSlanjaLabel;
            System.Windows.Forms.Label partnerIdLabel;
            this.datumSlanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spremiNarudzbuButton = new System.Windows.Forms.Button();
            this.partnerComboBox = new System.Windows.Forms.ComboBox();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            datumSlanjaLabel = new System.Windows.Forms.Label();
            partnerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datumSlanjaLabel
            // 
            datumSlanjaLabel.AutoSize = true;
            datumSlanjaLabel.Location = new System.Drawing.Point(12, 9);
            datumSlanjaLabel.Name = "datumSlanjaLabel";
            datumSlanjaLabel.Size = new System.Drawing.Size(71, 13);
            datumSlanjaLabel.TabIndex = 1;
            datumSlanjaLabel.Text = "Datum slanja:";
            // 
            // partnerIdLabel
            // 
            partnerIdLabel.AutoSize = true;
            partnerIdLabel.Location = new System.Drawing.Point(12, 34);
            partnerIdLabel.Name = "partnerIdLabel";
            partnerIdLabel.Size = new System.Drawing.Size(44, 13);
            partnerIdLabel.TabIndex = 9;
            partnerIdLabel.Text = "Partner:";
            // 
            // datumSlanjaDateTimePicker
            // 
            this.datumSlanjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.narudzbenicaBindingSource, "datum_slanja", true));
            this.datumSlanjaDateTimePicker.Location = new System.Drawing.Point(110, 5);
            this.datumSlanjaDateTimePicker.Name = "datumSlanjaDateTimePicker";
            this.datumSlanjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumSlanjaDateTimePicker.TabIndex = 2;
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Narudzbenica);
            // 
            // spremiNarudzbuButton
            // 
            this.spremiNarudzbuButton.Location = new System.Drawing.Point(230, 58);
            this.spremiNarudzbuButton.Name = "spremiNarudzbuButton";
            this.spremiNarudzbuButton.Size = new System.Drawing.Size(75, 23);
            this.spremiNarudzbuButton.TabIndex = 13;
            this.spremiNarudzbuButton.Text = "Spremi";
            this.spremiNarudzbuButton.UseVisualStyleBackColor = true;
            this.spremiNarudzbuButton.Click += new System.EventHandler(this.SpremiNarudzbuButton_Click);
            // 
            // partnerComboBox
            // 
            this.partnerComboBox.DataSource = this.partnerBindingSource;
            this.partnerComboBox.DisplayMember = "ime";
            this.partnerComboBox.FormattingEnabled = true;
            this.partnerComboBox.Location = new System.Drawing.Point(110, 31);
            this.partnerComboBox.Name = "partnerComboBox";
            this.partnerComboBox.Size = new System.Drawing.Size(200, 21);
            this.partnerComboBox.TabIndex = 15;
            this.partnerComboBox.ValueMember = "partnerId";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Partner);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\..\\..\\packages\\HTML help\\help.chm";
            // 
            // NovaNarudzbenicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 90);
            this.Controls.Add(this.partnerComboBox);
            this.Controls.Add(this.spremiNarudzbuButton);
            this.Controls.Add(datumSlanjaLabel);
            this.Controls.Add(this.datumSlanjaDateTimePicker);
            this.Controls.Add(partnerIdLabel);
            this.helpProvider1.SetHelpKeyword(this, "NovaNarudzbenicaForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "NovaNarudzbenicaForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Nova narudžbenica";
            this.Load += new System.EventHandler(this.NovaNarudzbenicaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private System.Windows.Forms.DateTimePicker datumSlanjaDateTimePicker;
        private System.Windows.Forms.Button spremiNarudzbuButton;
        private System.Windows.Forms.ComboBox partnerComboBox;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}