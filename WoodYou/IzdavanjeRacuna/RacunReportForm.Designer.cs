namespace IzdavanjeRacuna
{
    partial class RacunReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Faza_ima_materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazeprojektaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProjektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Faza_ima_materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazeprojektaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProjekt";
            reportDataSource1.Value = this.ProjektBindingSource;
            reportDataSource2.Name = "DataSetFaza";
            reportDataSource2.Value = this.FazaBindingSource;
            reportDataSource3.Name = "DataSetFazaMaterijal";
            reportDataSource3.Value = this.Faza_ima_materijalBindingSource;
            reportDataSource4.Name = "DataSetMaterijal";
            reportDataSource4.Value = this.materijalBindingSource;
            reportDataSource5.Name = "DataSetFazeProjekta";
            reportDataSource5.Value = this.fazeprojektaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IzdavanjeRacuna.RacunReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProjektBindingSource
            // 
            this.ProjektBindingSource.DataSource = typeof(IzdavanjeRacuna.Projekt);
            // 
            // FazaBindingSource
            // 
            this.FazaBindingSource.DataSource = typeof(IzdavanjeRacuna.Faza);
            // 
            // Faza_ima_materijalBindingSource
            // 
            this.Faza_ima_materijalBindingSource.DataSource = typeof(IzdavanjeRacuna.Faza_ima_materijal);
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(IzdavanjeRacuna.Materijal);
            // 
            // fazeprojektaBindingSource
            // 
            this.fazeprojektaBindingSource.DataSource = typeof(IzdavanjeRacuna.Faze_projekta);
            // 
            // RacunReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RacunReportForm";
            this.Text = "RacunReportForm";
            this.Load += new System.EventHandler(this.RacunReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Faza_ima_materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazeprojektaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ProjektBindingSource;
        private System.Windows.Forms.BindingSource FazaBindingSource;
        private System.Windows.Forms.BindingSource Faza_ima_materijalBindingSource;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource fazeprojektaBindingSource;
    }
}