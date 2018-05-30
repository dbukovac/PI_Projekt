namespace UpravljanjeProjektima
{
    partial class PopisProjektiForm
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
            this.projektiDataGridView = new System.Windows.Forms.DataGridView();
            this.fazeDataGridView = new System.Windows.Forms.DataGridView();
            this.noviProjektButton = new System.Windows.Forms.Button();
            this.brisiProjektButton = new System.Windows.Forms.Button();
            this.brisiFazuButton = new System.Windows.Forms.Button();
            this.dodajFazuButton = new System.Windows.Forms.Button();
            this.fazeLabel = new System.Windows.Forms.Label();
            this.projektiLabel = new System.Windows.Forms.Label();
            this.pokreniProjektButton = new System.Windows.Forms.Button();
            this.izmjeniProjektButton = new System.Windows.Forms.Button();
            this.fazaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazeprojektaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.partnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gotovoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazeprojektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.projektiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projektiDataGridView
            // 
            this.projektiDataGridView.AutoGenerateColumns = false;
            this.projektiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projektiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.fazeprojektaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.partnerDataGridViewTextBoxColumn});
            this.projektiDataGridView.DataSource = this.projektBindingSource;
            this.projektiDataGridView.Location = new System.Drawing.Point(12, 22);
            this.projektiDataGridView.Name = "projektiDataGridView";
            this.projektiDataGridView.Size = new System.Drawing.Size(1251, 322);
            this.projektiDataGridView.TabIndex = 0;
            this.projektiDataGridView.SelectionChanged += new System.EventHandler(this.projektiDataGridView_SelectionChanged);
            // 
            // fazeDataGridView
            // 
            this.fazeDataGridView.AutoGenerateColumns = false;
            this.fazeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fazeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fazaIdDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn,
            this.fazeprojektaDataGridViewTextBoxColumn1});
            this.fazeDataGridView.DataSource = this.fazaBindingSource;
            this.fazeDataGridView.Location = new System.Drawing.Point(12, 405);
            this.fazeDataGridView.Name = "fazeDataGridView";
            this.fazeDataGridView.Size = new System.Drawing.Size(455, 150);
            this.fazeDataGridView.TabIndex = 1;
            // 
            // noviProjektButton
            // 
            this.noviProjektButton.Location = new System.Drawing.Point(884, 350);
            this.noviProjektButton.Name = "noviProjektButton";
            this.noviProjektButton.Size = new System.Drawing.Size(75, 23);
            this.noviProjektButton.TabIndex = 2;
            this.noviProjektButton.Text = "Novi projekt";
            this.noviProjektButton.UseVisualStyleBackColor = true;
            this.noviProjektButton.Click += new System.EventHandler(this.noviProjektButton_Click);
            // 
            // brisiProjektButton
            // 
            this.brisiProjektButton.Location = new System.Drawing.Point(1188, 350);
            this.brisiProjektButton.Name = "brisiProjektButton";
            this.brisiProjektButton.Size = new System.Drawing.Size(75, 23);
            this.brisiProjektButton.TabIndex = 3;
            this.brisiProjektButton.Text = "Briši projekt";
            this.brisiProjektButton.UseVisualStyleBackColor = true;
            this.brisiProjektButton.Click += new System.EventHandler(this.brisiProjektButton_Click);
            // 
            // brisiFazuButton
            // 
            this.brisiFazuButton.Location = new System.Drawing.Point(392, 561);
            this.brisiFazuButton.Name = "brisiFazuButton";
            this.brisiFazuButton.Size = new System.Drawing.Size(75, 23);
            this.brisiFazuButton.TabIndex = 5;
            this.brisiFazuButton.Text = "Briši fazu";
            this.brisiFazuButton.UseVisualStyleBackColor = true;
            this.brisiFazuButton.Click += new System.EventHandler(this.brisiFazuButton_Click);
            // 
            // dodajFazuButton
            // 
            this.dodajFazuButton.Location = new System.Drawing.Point(311, 561);
            this.dodajFazuButton.Name = "dodajFazuButton";
            this.dodajFazuButton.Size = new System.Drawing.Size(75, 23);
            this.dodajFazuButton.TabIndex = 4;
            this.dodajFazuButton.Text = "Dodaj fazu";
            this.dodajFazuButton.UseVisualStyleBackColor = true;
            this.dodajFazuButton.Click += new System.EventHandler(this.dodajFazuButton_Click);
            // 
            // fazeLabel
            // 
            this.fazeLabel.AutoSize = true;
            this.fazeLabel.Location = new System.Drawing.Point(9, 389);
            this.fazeLabel.Name = "fazeLabel";
            this.fazeLabel.Size = new System.Drawing.Size(33, 13);
            this.fazeLabel.TabIndex = 6;
            this.fazeLabel.Text = "Faze:";
            // 
            // projektiLabel
            // 
            this.projektiLabel.AutoSize = true;
            this.projektiLabel.Location = new System.Drawing.Point(9, 6);
            this.projektiLabel.Name = "projektiLabel";
            this.projektiLabel.Size = new System.Drawing.Size(45, 13);
            this.projektiLabel.TabIndex = 7;
            this.projektiLabel.Text = "Projekti:";
            // 
            // pokreniProjektButton
            // 
            this.pokreniProjektButton.Location = new System.Drawing.Point(1073, 350);
            this.pokreniProjektButton.Name = "pokreniProjektButton";
            this.pokreniProjektButton.Size = new System.Drawing.Size(109, 23);
            this.pokreniProjektButton.TabIndex = 9;
            this.pokreniProjektButton.Text = "Pokreni projekt";
            this.pokreniProjektButton.UseVisualStyleBackColor = true;
            this.pokreniProjektButton.Click += new System.EventHandler(this.pokreniProjektButton_Click);
            // 
            // izmjeniProjektButton
            // 
            this.izmjeniProjektButton.Location = new System.Drawing.Point(965, 350);
            this.izmjeniProjektButton.Name = "izmjeniProjektButton";
            this.izmjeniProjektButton.Size = new System.Drawing.Size(98, 23);
            this.izmjeniProjektButton.TabIndex = 10;
            this.izmjeniProjektButton.Text = "Izmjeni projekt";
            this.izmjeniProjektButton.UseVisualStyleBackColor = true;
            this.izmjeniProjektButton.Click += new System.EventHandler(this.izmjeniProjektButton_Click);
            // 
            // fazaIdDataGridViewTextBoxColumn
            // 
            this.fazaIdDataGridViewTextBoxColumn.DataPropertyName = "fazaId";
            this.fazaIdDataGridViewTextBoxColumn.HeaderText = "fazaId";
            this.fazaIdDataGridViewTextBoxColumn.Name = "fazaIdDataGridViewTextBoxColumn";
            this.fazaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            // 
            // fazeprojektaDataGridViewTextBoxColumn1
            // 
            this.fazeprojektaDataGridViewTextBoxColumn1.DataPropertyName = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn1.HeaderText = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn1.Name = "fazeprojektaDataGridViewTextBoxColumn1";
            this.fazeprojektaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fazaBindingSource
            // 
            this.fazaBindingSource.DataSource = typeof(UpravljanjeProjektima.Faza);
            // 
            // projektIdDataGridViewTextBoxColumn
            // 
            this.projektIdDataGridViewTextBoxColumn.DataPropertyName = "projektId";
            this.projektIdDataGridViewTextBoxColumn.HeaderText = "projektId";
            this.projektIdDataGridViewTextBoxColumn.Name = "projektIdDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // datumpocetkaDataGridViewTextBoxColumn
            // 
            this.datumpocetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_pocetka";
            this.datumpocetkaDataGridViewTextBoxColumn.HeaderText = "datum_pocetka";
            this.datumpocetkaDataGridViewTextBoxColumn.Name = "datumpocetkaDataGridViewTextBoxColumn";
            // 
            // potrebnovrijemeDataGridViewTextBoxColumn
            // 
            this.potrebnovrijemeDataGridViewTextBoxColumn.DataPropertyName = "potrebno_vrijeme";
            this.potrebnovrijemeDataGridViewTextBoxColumn.HeaderText = "potrebno_vrijeme";
            this.potrebnovrijemeDataGridViewTextBoxColumn.Name = "potrebnovrijemeDataGridViewTextBoxColumn";
            // 
            // datumzavrsetkaDataGridViewTextBoxColumn
            // 
            this.datumzavrsetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_zavrsetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.HeaderText = "datum_zavrsetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.Name = "datumzavrsetkaDataGridViewTextBoxColumn";
            // 
            // ukupnacijenaDataGridViewTextBoxColumn
            // 
            this.ukupnacijenaDataGridViewTextBoxColumn.DataPropertyName = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.HeaderText = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.Name = "ukupnacijenaDataGridViewTextBoxColumn";
            // 
            // cijenabezpdvDataGridViewTextBoxColumn
            // 
            this.cijenabezpdvDataGridViewTextBoxColumn.DataPropertyName = "cijena_bez_pdv";
            this.cijenabezpdvDataGridViewTextBoxColumn.HeaderText = "cijena_bez_pdv";
            this.cijenabezpdvDataGridViewTextBoxColumn.Name = "cijenabezpdvDataGridViewTextBoxColumn";
            // 
            // iznospdvDataGridViewTextBoxColumn
            // 
            this.iznospdvDataGridViewTextBoxColumn.DataPropertyName = "iznos_pdv";
            this.iznospdvDataGridViewTextBoxColumn.HeaderText = "iznos_pdv";
            this.iznospdvDataGridViewTextBoxColumn.Name = "iznospdvDataGridViewTextBoxColumn";
            // 
            // korisnikIdDataGridViewTextBoxColumn
            // 
            this.korisnikIdDataGridViewTextBoxColumn.DataPropertyName = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.DataSource = this.korisnikBindingSource;
            this.korisnikIdDataGridViewTextBoxColumn.DisplayMember = "korisnicko_ime";
            this.korisnikIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.korisnikIdDataGridViewTextBoxColumn.HeaderText = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.Name = "korisnikIdDataGridViewTextBoxColumn";
            this.korisnikIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.korisnikIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.korisnikIdDataGridViewTextBoxColumn.ValueMember = "korisnikId";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(UpravljanjeProjektima.Korisnik);
            // 
            // partnerIdDataGridViewTextBoxColumn
            // 
            this.partnerIdDataGridViewTextBoxColumn.DataPropertyName = "partnerId";
            this.partnerIdDataGridViewTextBoxColumn.HeaderText = "partnerId";
            this.partnerIdDataGridViewTextBoxColumn.Name = "partnerIdDataGridViewTextBoxColumn";
            // 
            // gotovoDataGridViewTextBoxColumn
            // 
            this.gotovoDataGridViewTextBoxColumn.DataPropertyName = "gotovo";
            this.gotovoDataGridViewTextBoxColumn.HeaderText = "gotovo";
            this.gotovoDataGridViewTextBoxColumn.Name = "gotovoDataGridViewTextBoxColumn";
            // 
            // aktivanDataGridViewTextBoxColumn
            // 
            this.aktivanDataGridViewTextBoxColumn.DataPropertyName = "aktivan";
            this.aktivanDataGridViewTextBoxColumn.HeaderText = "aktivan";
            this.aktivanDataGridViewTextBoxColumn.Name = "aktivanDataGridViewTextBoxColumn";
            // 
            // fazeprojektaDataGridViewTextBoxColumn
            // 
            this.fazeprojektaDataGridViewTextBoxColumn.DataPropertyName = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn.HeaderText = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn.Name = "fazeprojektaDataGridViewTextBoxColumn";
            this.fazeprojektaDataGridViewTextBoxColumn.Visible = false;
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
            this.projektBindingSource.DataSource = typeof(UpravljanjeProjektima.Projekt);
            // 
            // PopisProjektiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 593);
            this.Controls.Add(this.izmjeniProjektButton);
            this.Controls.Add(this.pokreniProjektButton);
            this.Controls.Add(this.projektiLabel);
            this.Controls.Add(this.fazeLabel);
            this.Controls.Add(this.brisiFazuButton);
            this.Controls.Add(this.dodajFazuButton);
            this.Controls.Add(this.brisiProjektButton);
            this.Controls.Add(this.noviProjektButton);
            this.Controls.Add(this.fazeDataGridView);
            this.Controls.Add(this.projektiDataGridView);
            this.Name = "PopisProjektiForm";
            this.Text = "Pregled projekata";
            this.Load += new System.EventHandler(this.PopisProjektiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView projektiDataGridView;
        private System.Windows.Forms.DataGridView fazeDataGridView;
        private System.Windows.Forms.Button noviProjektButton;
        private System.Windows.Forms.Button brisiProjektButton;
        private System.Windows.Forms.Button brisiFazuButton;
        private System.Windows.Forms.Button dodajFazuButton;
        private System.Windows.Forms.Label fazeLabel;
        private System.Windows.Forms.Label projektiLabel;
        private System.Windows.Forms.Button pokreniProjektButton;
        private System.Windows.Forms.BindingSource projektBindingSource;
        private System.Windows.Forms.BindingSource fazaBindingSource;
        private System.Windows.Forms.Button izmjeniProjektButton;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn projektIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potrebnovrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumzavrsetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenabezpdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznospdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gotovoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazeprojektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazeprojektaDataGridViewTextBoxColumn1;
    }
}

