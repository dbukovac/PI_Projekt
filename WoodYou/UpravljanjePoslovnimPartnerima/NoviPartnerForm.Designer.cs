namespace UpravljanjePoslovnimPartnerima
{
    partial class NoviPartnerForm
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
            this.tboxIme = new System.Windows.Forms.TextBox();
            this.cboxTip = new System.Windows.Forms.ComboBox();
            this.tippartneraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spremiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxOIB = new System.Windows.Forms.TextBox();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.tippartneraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxIme
            // 
            this.tboxIme.Location = new System.Drawing.Point(109, 12);
            this.tboxIme.Name = "tboxIme";
            this.tboxIme.Size = new System.Drawing.Size(121, 20);
            this.tboxIme.TabIndex = 0;
            // 
            // cboxTip
            // 
            this.cboxTip.DataSource = this.tippartneraBindingSource;
            this.cboxTip.DisplayMember = "naziv";
            this.cboxTip.FormattingEnabled = true;
            this.cboxTip.Location = new System.Drawing.Point(109, 95);
            this.cboxTip.Name = "cboxTip";
            this.cboxTip.Size = new System.Drawing.Size(121, 21);
            this.cboxTip.TabIndex = 1;
            this.cboxTip.ValueMember = "kljuc";
            // 
            // tippartneraBindingSource
            // 
            this.tippartneraBindingSource.DataSource = typeof(UpravljanjePoslovnimPartnerima.Tip_partnera);
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(109, 132);
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
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresa:";
            // 
            // tboxAdresa
            // 
            this.tboxAdresa.Location = new System.Drawing.Point(109, 64);
            this.tboxAdresa.Name = "tboxAdresa";
            this.tboxAdresa.Size = new System.Drawing.Size(121, 20);
            this.tboxAdresa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "OIB:";
            // 
            // tboxOIB
            // 
            this.tboxOIB.Location = new System.Drawing.Point(109, 38);
            this.tboxOIB.Name = "tboxOIB";
            this.tboxOIB.Size = new System.Drawing.Size(121, 20);
            this.tboxOIB.TabIndex = 7;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(199, 132);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 9;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // NoviPartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 178);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxOIB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.cboxTip);
            this.Controls.Add(this.tboxIme);
            this.helpProvider1.SetHelpKeyword(this, "NoviPartnerForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "NoviPartnerForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "NoviPartnerForm";
            this.Load += new System.EventHandler(this.NoviPartnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tippartneraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxIme;
        private System.Windows.Forms.ComboBox cboxTip;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxOIB;
        private System.Windows.Forms.BindingSource tippartneraBindingSource;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}