namespace IzdavanjeRacuna
{
    partial class PregledRacunForm
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
            this.pregledRačunaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjektidataGridView = new System.Windows.Forms.DataGridView();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.projektIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potrebnovrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumzavrsetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenabezpdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznospdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gotovoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumizdavanjaracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProjektidataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pregledRačunaButton
            // 
            this.pregledRačunaButton.Location = new System.Drawing.Point(659, 265);
            this.pregledRačunaButton.Name = "pregledRačunaButton";
            this.pregledRačunaButton.Size = new System.Drawing.Size(101, 23);
            this.pregledRačunaButton.TabIndex = 7;
            this.pregledRačunaButton.Text = "Pregled računa";
            this.pregledRačunaButton.UseVisualStyleBackColor = true;
            this.pregledRačunaButton.Click += new System.EventHandler(this.pregledRačunaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Računi:";
            // 
            // ProjektidataGridView
            // 
            this.ProjektidataGridView.AutoGenerateColumns = false;
            this.ProjektidataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjektidataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projektIdDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.datumpocetkaDataGridViewTextBoxColumn,
            this.potrebnovrijemeDataGridViewTextBoxColumn,
            this.datumzavrsetkaDataGridViewTextBoxColumn,
            this.ukupnacijenaDataGridViewTextBoxColumn,
            this.cijenabezpdvDataGridViewTextBoxColumn,
            this.iznospdvDataGridViewTextBoxColumn,
            this.korisnikIdDataGridViewTextBoxColumn,
            this.partnerIdDataGridViewTextBoxColumn,
            this.gotovoDataGridViewTextBoxColumn,
            this.aktivanDataGridViewTextBoxColumn,
            this.datumizdavanjaracunaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.partnerDataGridViewTextBoxColumn});
            this.ProjektidataGridView.DataSource = this.projektBindingSource;
            this.ProjektidataGridView.Location = new System.Drawing.Point(12, 24);
            this.ProjektidataGridView.Name = "ProjektidataGridView";
            this.ProjektidataGridView.Size = new System.Drawing.Size(855, 235);
            this.ProjektidataGridView.TabIndex = 4;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(766, 265);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(101, 23);
            this.odustaniButton.TabIndex = 8;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // projektIdDataGridViewTextBoxColumn
            // 
            this.projektIdDataGridViewTextBoxColumn.DataPropertyName = "projektId";
            this.projektIdDataGridViewTextBoxColumn.HeaderText = "broj računa";
            this.projektIdDataGridViewTextBoxColumn.Name = "projektIdDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime projekta";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // datumpocetkaDataGridViewTextBoxColumn
            // 
            this.datumpocetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_pocetka";
            this.datumpocetkaDataGridViewTextBoxColumn.HeaderText = "datum_pocetka";
            this.datumpocetkaDataGridViewTextBoxColumn.Name = "datumpocetkaDataGridViewTextBoxColumn";
            this.datumpocetkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // potrebnovrijemeDataGridViewTextBoxColumn
            // 
            this.potrebnovrijemeDataGridViewTextBoxColumn.DataPropertyName = "potrebno_vrijeme";
            this.potrebnovrijemeDataGridViewTextBoxColumn.HeaderText = "potrebno_vrijeme";
            this.potrebnovrijemeDataGridViewTextBoxColumn.Name = "potrebnovrijemeDataGridViewTextBoxColumn";
            this.potrebnovrijemeDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumzavrsetkaDataGridViewTextBoxColumn
            // 
            this.datumzavrsetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_zavrsetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.HeaderText = "datum_zavrsetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.Name = "datumzavrsetkaDataGridViewTextBoxColumn";
            this.datumzavrsetkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ukupnacijenaDataGridViewTextBoxColumn
            // 
            this.ukupnacijenaDataGridViewTextBoxColumn.DataPropertyName = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.HeaderText = "ukupna cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.Name = "ukupnacijenaDataGridViewTextBoxColumn";
            // 
            // cijenabezpdvDataGridViewTextBoxColumn
            // 
            this.cijenabezpdvDataGridViewTextBoxColumn.DataPropertyName = "cijena_bez_pdv";
            this.cijenabezpdvDataGridViewTextBoxColumn.HeaderText = "cijena bez pdv";
            this.cijenabezpdvDataGridViewTextBoxColumn.Name = "cijenabezpdvDataGridViewTextBoxColumn";
            // 
            // iznospdvDataGridViewTextBoxColumn
            // 
            this.iznospdvDataGridViewTextBoxColumn.DataPropertyName = "iznos_pdv";
            this.iznospdvDataGridViewTextBoxColumn.HeaderText = "iznos pdv";
            this.iznospdvDataGridViewTextBoxColumn.Name = "iznospdvDataGridViewTextBoxColumn";
            // 
            // korisnikIdDataGridViewTextBoxColumn
            // 
            this.korisnikIdDataGridViewTextBoxColumn.DataPropertyName = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.DataSource = this.korisnikBindingSource;
            this.korisnikIdDataGridViewTextBoxColumn.DisplayMember = "korisnicko_ime";
            this.korisnikIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.korisnikIdDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikIdDataGridViewTextBoxColumn.Name = "korisnikIdDataGridViewTextBoxColumn";
            this.korisnikIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.korisnikIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.korisnikIdDataGridViewTextBoxColumn.ValueMember = "korisnikId";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(IzdavanjeRacuna.Korisnik);
            // 
            // partnerIdDataGridViewTextBoxColumn
            // 
            this.partnerIdDataGridViewTextBoxColumn.DataPropertyName = "partnerId";
            this.partnerIdDataGridViewTextBoxColumn.DataSource = this.partnerBindingSource;
            this.partnerIdDataGridViewTextBoxColumn.DisplayMember = "ime";
            this.partnerIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.partnerIdDataGridViewTextBoxColumn.HeaderText = "partner";
            this.partnerIdDataGridViewTextBoxColumn.Name = "partnerIdDataGridViewTextBoxColumn";
            this.partnerIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partnerIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partnerIdDataGridViewTextBoxColumn.ValueMember = "partnerId";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(IzdavanjeRacuna.Partner);
            // 
            // gotovoDataGridViewTextBoxColumn
            // 
            this.gotovoDataGridViewTextBoxColumn.DataPropertyName = "gotovo";
            this.gotovoDataGridViewTextBoxColumn.HeaderText = "gotovo";
            this.gotovoDataGridViewTextBoxColumn.Name = "gotovoDataGridViewTextBoxColumn";
            this.gotovoDataGridViewTextBoxColumn.Visible = false;
            // 
            // aktivanDataGridViewTextBoxColumn
            // 
            this.aktivanDataGridViewTextBoxColumn.DataPropertyName = "aktivan";
            this.aktivanDataGridViewTextBoxColumn.HeaderText = "aktivan";
            this.aktivanDataGridViewTextBoxColumn.Name = "aktivanDataGridViewTextBoxColumn";
            this.aktivanDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumizdavanjaracunaDataGridViewTextBoxColumn
            // 
            this.datumizdavanjaracunaDataGridViewTextBoxColumn.DataPropertyName = "datum_izdavanja_racuna";
            this.datumizdavanjaracunaDataGridViewTextBoxColumn.HeaderText = "datum izdavanja racuna";
            this.datumizdavanjaracunaDataGridViewTextBoxColumn.Name = "datumizdavanjaracunaDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // partnerDataGridViewTextBoxColumn
            // 
            this.partnerDataGridViewTextBoxColumn.DataPropertyName = "Partner";
            this.partnerDataGridViewTextBoxColumn.HeaderText = "Partner";
            this.partnerDataGridViewTextBoxColumn.Name = "partnerDataGridViewTextBoxColumn";
            this.partnerDataGridViewTextBoxColumn.Visible = false;
            // 
            // projektBindingSource
            // 
            this.projektBindingSource.DataSource = typeof(IzdavanjeRacuna.Projekt);
            // 
            // PregledRacunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 293);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.pregledRačunaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjektidataGridView);
            this.Name = "PregledRacunForm";
            this.Text = "Pregled računa";
            this.Load += new System.EventHandler(this.PregledRacunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjektidataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pregledRačunaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProjektidataGridView;
        private System.Windows.Forms.BindingSource projektBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn projektIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potrebnovrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumzavrsetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenabezpdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznospdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn partnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gotovoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumizdavanjaracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerDataGridViewTextBoxColumn;
    }
}