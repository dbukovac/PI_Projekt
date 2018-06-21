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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource16 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource17 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource18 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource19 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource20 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource21 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource22 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cboxIzbor = new System.Windows.Forms.ComboBox();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cboxIzbor.Location = new System.Drawing.Point(836, 12);
            this.cboxIzbor.Name = "cboxIzbor";
            this.cboxIzbor.Size = new System.Drawing.Size(121, 21);
            this.cboxIzbor.TabIndex = 1;
            this.cboxIzbor.SelectedIndexChanged += new System.EventHandler(this.cboxIzbor_SelectedIndexChanged);
            // 
            // reportViewer
            // 
            reportDataSource12.Name = "DataSetProjekt";
            reportDataSource12.Value = this.projektBindingSource;
            reportDataSource13.Name = "DataSetFaze";
            reportDataSource13.Value = this.fazaBindingSource;
            reportDataSource14.Name = "DataSetKorisnici";
            reportDataSource14.Value = this.korisnikBindingSource;
            reportDataSource15.Name = "DataSetPartner";
            reportDataSource15.Value = this.partnerBindingSource;
            reportDataSource16.Name = "DataSetMaterijal";
            reportDataSource16.Value = this.materijalBindingSource;
            reportDataSource17.Name = "DataSetPrimka";
            reportDataSource17.Value = this.primkaBindingSource;
            reportDataSource18.Name = "DataSetStavkaPrimke";
            reportDataSource18.Value = this.stavkaprimkeBindingSource;
            reportDataSource19.Name = "DataSetStavkaNarudzbenice";
            reportDataSource19.Value = this.stavkanarudzbeniceBindingSource;
            reportDataSource20.Name = "DataSetNarudzbenica";
            reportDataSource20.Value = this.narudzbenicaBindingSource;
            reportDataSource21.Name = "DataSetTipKorisnika";
            reportDataSource21.Value = this.tipkorisnikaBindingSource;
            reportDataSource22.Name = "DataSetTipPartnera";
            reportDataSource22.Value = this.tippartneraBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource16);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource17);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource18);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource19);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource20);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource21);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource22);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "PrikazStatistike.ReportPrazni.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(12, 41);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(945, 246);
            this.reportViewer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odabir kategorije:";
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
            this.ClientSize = new System.Drawing.Size(969, 306);
            this.Controls.Add(this.label1);
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
    }
}

