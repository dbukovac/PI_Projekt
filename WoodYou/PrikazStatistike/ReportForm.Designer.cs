namespace PrikazStatistike
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.projektBindingSource = new System.Windows.Forms.BindingSource();
            this.fazaBindingSource = new System.Windows.Forms.BindingSource();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource();
            this.primkaBindingSource = new System.Windows.Forms.BindingSource();
            this.stavkaprimkeBindingSource = new System.Windows.Forms.BindingSource();
            this.stavkanarudzbeniceBindingSource = new System.Windows.Forms.BindingSource();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource();
            this.tipkorisnikaBindingSource = new System.Windows.Forms.BindingSource();
            this.tippartneraBindingSource = new System.Windows.Forms.BindingSource();
            this.cboxIzbor = new System.Windows.Forms.ComboBox();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtProjekti2 = new System.Windows.Forms.DateTimePicker();
            this.dtProjekti1 = new System.Windows.Forms.DateTimePicker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaprimkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkanarudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippartneraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projektBindingSource
            // 
            this.projektBindingSource.DataSource = typeof(PrikazStatistike.Projekt);
            // 
            // fazaBindingSource
            // 
            this.fazaBindingSource.DataSource = typeof(PrikazStatistike.Faza);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(PrikazStatistike.Korisnik);
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(PrikazStatistike.Partner);
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(PrikazStatistike.Materijal);
            // 
            // primkaBindingSource
            // 
            this.primkaBindingSource.DataSource = typeof(PrikazStatistike.Primka);
            // 
            // stavkaprimkeBindingSource
            // 
            this.stavkaprimkeBindingSource.DataSource = typeof(PrikazStatistike.Stavka_primke);
            // 
            // stavkanarudzbeniceBindingSource
            // 
            this.stavkanarudzbeniceBindingSource.DataSource = typeof(PrikazStatistike.Stavka_narudzbenice);
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataSource = typeof(PrikazStatistike.Narudzbenica);
            // 
            // tipkorisnikaBindingSource
            // 
            this.tipkorisnikaBindingSource.DataSource = typeof(PrikazStatistike.Tip_korisnika);
            // 
            // tippartneraBindingSource
            // 
            this.tippartneraBindingSource.DataSource = typeof(PrikazStatistike.Tip_partnera);
            // 
            // cboxIzbor
            // 
            this.cboxIzbor.FormattingEnabled = true;
            this.cboxIzbor.Items.AddRange(new object[] {
            "Projekti",
            "Faze",
            "Materijal",
            "Primke",
            "Narudzbenice",
            "Korisnici",
            "Poslovni partneri"});
            this.cboxIzbor.Location = new System.Drawing.Point(836, 22);
            this.cboxIzbor.Name = "cboxIzbor";
            this.cboxIzbor.Size = new System.Drawing.Size(121, 21);
            this.cboxIzbor.TabIndex = 1;
            this.cboxIzbor.SelectedIndexChanged += new System.EventHandler(this.cboxIzbor_SelectedIndexChanged);
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "DataSetProjekt";
            reportDataSource1.Value = this.projektBindingSource;
            reportDataSource2.Name = "DataSetFaze";
            reportDataSource2.Value = this.fazaBindingSource;
            reportDataSource3.Name = "DataSetKorisnici";
            reportDataSource3.Value = this.korisnikBindingSource;
            reportDataSource4.Name = "DataSetPartner";
            reportDataSource4.Value = this.partnerBindingSource;
            reportDataSource5.Name = "DataSetMaterijal";
            reportDataSource5.Value = this.materijalBindingSource;
            reportDataSource6.Name = "DataSetPrimka";
            reportDataSource6.Value = this.primkaBindingSource;
            reportDataSource7.Name = "DataSetStavkaPrimke";
            reportDataSource7.Value = this.stavkaprimkeBindingSource;
            reportDataSource8.Name = "DataSetStavkaNarudzbenice";
            reportDataSource8.Value = this.stavkanarudzbeniceBindingSource;
            reportDataSource9.Name = "DataSetNarudzbenica";
            reportDataSource9.Value = this.narudzbenicaBindingSource;
            reportDataSource10.Name = "DataSetTipKorisnika";
            reportDataSource10.Value = this.tipkorisnikaBindingSource;
            reportDataSource11.Name = "DataSetTipPartnera";
            reportDataSource11.Value = this.tippartneraBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "PrikazStatistike.ReportPrazni.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(12, 51);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(945, 246);
            this.reportViewer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odabir kategorije:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pretraživanje po datumu:";
            // 
            // dtProjekti2
            // 
            this.dtProjekti2.Location = new System.Drawing.Point(522, 25);
            this.dtProjekti2.Name = "dtProjekti2";
            this.dtProjekti2.Size = new System.Drawing.Size(134, 20);
            this.dtProjekti2.TabIndex = 24;
            // 
            // dtProjekti1
            // 
            this.dtProjekti1.Location = new System.Drawing.Point(382, 25);
            this.dtProjekti1.Name = "dtProjekti1";
            this.dtProjekti1.Size = new System.Drawing.Size(134, 20);
            this.dtProjekti1.TabIndex = 23;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 318);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtProjekti2);
            this.Controls.Add(this.dtProjekti1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.cboxIzbor);
            this.helpProvider1.SetHelpKeyword(this, "ReportForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "ReportForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaprimkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkanarudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippartneraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxIzbor;
        private System.Windows.Forms.BindingSource projektBindingSource;
        private System.Windows.Forms.BindingSource fazaBindingSource;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource primkaBindingSource;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource stavkaprimkeBindingSource;
        private System.Windows.Forms.BindingSource stavkanarudzbeniceBindingSource;
        private System.Windows.Forms.BindingSource tipkorisnikaBindingSource;
        private System.Windows.Forms.BindingSource tippartneraBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtProjekti2;
        private System.Windows.Forms.DateTimePicker dtProjekti1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

