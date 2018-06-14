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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboxIzbor = new System.Windows.Forms.ComboBox();
            this.projektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "DataSetProjekt";
            reportDataSource1.Value = this.projektBindingSource;
            reportDataSource2.Name = "DataSetFaza";
            reportDataSource2.Value = this.fazaBindingSource;
            reportDataSource3.Name = "DataSetMaterijal";
            reportDataSource3.Value = this.materijalBindingSource;
            reportDataSource4.Name = "DataSetKorisnici";
            reportDataSource4.Value = this.korisnikBindingSource;
            reportDataSource5.Name = "DataSetPrimka";
            reportDataSource5.Value = this.primkaBindingSource;
            reportDataSource6.Name = "DataSetNarudzbenica";
            reportDataSource6.Value = this.narudzbenicaBindingSource;
            reportDataSource7.Name = "DataSetPartner";
            reportDataSource7.Value = this.partnerBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "PrikazStatistike.ReportProjekti.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 31);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(799, 419);
            this.reportViewer.TabIndex = 0;
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
            // projektBindingSource
            // 
            this.projektBindingSource.DataSource = typeof(PrikazStatistike.Projekt);
            // 
            // fazaBindingSource
            // 
            this.fazaBindingSource.DataSource = typeof(PrikazStatistike.Faza);
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(PrikazStatistike.Materijal);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(PrikazStatistike.Korisnik);
            // 
            // primkaBindingSource
            // 
            this.primkaBindingSource.DataSource = typeof(PrikazStatistike.Primka);
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataSource = typeof(PrikazStatistike.Narudzbenica);
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(PrikazStatistike.Partner);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxIzbor);
            this.Controls.Add(this.reportViewer);
            this.Name = "ReportForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.ComboBox cboxIzbor;
        private System.Windows.Forms.BindingSource projektBindingSource;
        private System.Windows.Forms.BindingSource fazaBindingSource;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource primkaBindingSource;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private System.Windows.Forms.BindingSource partnerBindingSource;
    }
}

