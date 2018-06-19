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
            this.components = new System.ComponentModel.Container();
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
            this.cboxIzbor = new System.Windows.Forms.ComboBox();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.projektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaprimkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkanarudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipkorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tippartneraBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.cboxIzbor.Location = new System.Drawing.Point(488, 4);
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
            this.reportViewer.Location = new System.Drawing.Point(12, 41);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(776, 246);
            this.reportViewer.TabIndex = 2;
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
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.cboxIzbor);
            this.Name = "ReportForm";
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
    }
}

