namespace UpravljanjeNarudzbama
{
    partial class NarudzbeReportForm
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
            this.NarudzbenicaReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stavka_narudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NarudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stavka_narudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarudzbenicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NarudzbenicaReportViewer
            // 
            this.NarudzbenicaReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MaterijalDataSet";
            reportDataSource1.Value = this.MaterijalBindingSource;
            reportDataSource2.Name = "StavkeMaterijalaDataSet";
            reportDataSource2.Value = this.Stavka_narudzbeniceBindingSource;
            reportDataSource3.Name = "NarudzbenicaDataSet";
            reportDataSource3.Value = this.NarudzbenicaBindingSource;
            this.NarudzbenicaReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.NarudzbenicaReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.NarudzbenicaReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.NarudzbenicaReportViewer.LocalReport.ReportEmbeddedResource = "UpravljanjeNarudzbama.NarudzbenicaReport.rdlc";
            this.NarudzbenicaReportViewer.Location = new System.Drawing.Point(0, 0);
            this.NarudzbenicaReportViewer.Name = "NarudzbenicaReportViewer";
            this.NarudzbenicaReportViewer.ServerReport.BearerToken = null;
            this.NarudzbenicaReportViewer.Size = new System.Drawing.Size(855, 529);
            this.NarudzbenicaReportViewer.TabIndex = 0;
            // 
            // MaterijalBindingSource
            // 
            this.MaterijalBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Materijal);
            // 
            // Stavka_narudzbeniceBindingSource
            // 
            this.Stavka_narudzbeniceBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Stavka_narudzbenice);
            // 
            // NarudzbenicaBindingSource
            // 
            this.NarudzbenicaBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Narudzbenica);
            // 
            // NarudzbeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 529);
            this.Controls.Add(this.NarudzbenicaReportViewer);
            this.Name = "NarudzbeReportForm";
            this.Text = "Narudžba";
            this.Load += new System.EventHandler(this.NarudzbeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stavka_narudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarudzbenicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer NarudzbenicaReportViewer;
        private System.Windows.Forms.BindingSource MaterijalBindingSource;
        private System.Windows.Forms.BindingSource Stavka_narudzbeniceBindingSource;
        private System.Windows.Forms.BindingSource NarudzbenicaBindingSource;
    }
}