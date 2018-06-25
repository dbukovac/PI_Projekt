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
            this.projektIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fazeprojektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazeDataGridView = new System.Windows.Forms.DataGridView();
            this.fazaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazeprojektaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noviProjektButton = new System.Windows.Forms.Button();
            this.brisiProjektButton = new System.Windows.Forms.Button();
            this.brisiFazuButton = new System.Windows.Forms.Button();
            this.dodajFazuButton = new System.Windows.Forms.Button();
            this.fazeLabel = new System.Windows.Forms.Label();
            this.projektiLabel = new System.Windows.Forms.Label();
            this.pokreniProjektButton = new System.Windows.Forms.Button();
            this.izmjeniProjektButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.materijalDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazeprojektaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaimamaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brisiMaterijalButton = new System.Windows.Forms.Button();
            this.dodajMaterijalButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxPretrazi = new System.Windows.Forms.TextBox();
            this.dtProjekti1 = new System.Windows.Forms.DateTimePicker();
            this.dtProjekti2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.korisnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.projektiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaimamaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // projektiDataGridView
            // 
            this.projektiDataGridView.AllowUserToAddRows = false;
            this.projektiDataGridView.AllowUserToDeleteRows = false;
            this.projektiDataGridView.AutoGenerateColumns = false;
            this.projektiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projektiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projektIdDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.kod,
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
            this.projektiDataGridView.Location = new System.Drawing.Point(12, 49);
            this.projektiDataGridView.MultiSelect = false;
            this.projektiDataGridView.Name = "projektiDataGridView";
            this.projektiDataGridView.ReadOnly = true;
            this.projektiDataGridView.Size = new System.Drawing.Size(1148, 322);
            this.projektiDataGridView.TabIndex = 0;
            this.projektiDataGridView.SelectionChanged += new System.EventHandler(this.projektiDataGridView_SelectionChanged);
            // 
            // projektIdDataGridViewTextBoxColumn
            // 
            this.projektIdDataGridViewTextBoxColumn.DataPropertyName = "projektId";
            this.projektIdDataGridViewTextBoxColumn.HeaderText = "projektId";
            this.projektIdDataGridViewTextBoxColumn.Name = "projektIdDataGridViewTextBoxColumn";
            this.projektIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kod
            // 
            this.kod.DataPropertyName = "kod";
            this.kod.HeaderText = "kod";
            this.kod.Name = "kod";
            this.kod.ReadOnly = true;
            // 
            // datumpocetkaDataGridViewTextBoxColumn
            // 
            this.datumpocetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_pocetka";
            this.datumpocetkaDataGridViewTextBoxColumn.HeaderText = "datum pocetka";
            this.datumpocetkaDataGridViewTextBoxColumn.Name = "datumpocetkaDataGridViewTextBoxColumn";
            this.datumpocetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // potrebnovrijemeDataGridViewTextBoxColumn
            // 
            this.potrebnovrijemeDataGridViewTextBoxColumn.DataPropertyName = "potrebno_vrijeme";
            this.potrebnovrijemeDataGridViewTextBoxColumn.HeaderText = "potrebno vrijeme";
            this.potrebnovrijemeDataGridViewTextBoxColumn.Name = "potrebnovrijemeDataGridViewTextBoxColumn";
            this.potrebnovrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumzavrsetkaDataGridViewTextBoxColumn
            // 
            this.datumzavrsetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_zavrsetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.HeaderText = "datum zavrsetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.Name = "datumzavrsetkaDataGridViewTextBoxColumn";
            this.datumzavrsetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ukupnacijenaDataGridViewTextBoxColumn
            // 
            this.ukupnacijenaDataGridViewTextBoxColumn.DataPropertyName = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.HeaderText = "ukupna cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.Name = "ukupnacijenaDataGridViewTextBoxColumn";
            this.ukupnacijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenabezpdvDataGridViewTextBoxColumn
            // 
            this.cijenabezpdvDataGridViewTextBoxColumn.DataPropertyName = "cijena_bez_pdv";
            this.cijenabezpdvDataGridViewTextBoxColumn.HeaderText = "cijena bez pdv";
            this.cijenabezpdvDataGridViewTextBoxColumn.Name = "cijenabezpdvDataGridViewTextBoxColumn";
            this.cijenabezpdvDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenabezpdvDataGridViewTextBoxColumn.Visible = false;
            // 
            // iznospdvDataGridViewTextBoxColumn
            // 
            this.iznospdvDataGridViewTextBoxColumn.DataPropertyName = "iznos_pdv";
            this.iznospdvDataGridViewTextBoxColumn.HeaderText = "iznos pdv";
            this.iznospdvDataGridViewTextBoxColumn.Name = "iznospdvDataGridViewTextBoxColumn";
            this.iznospdvDataGridViewTextBoxColumn.ReadOnly = true;
            this.iznospdvDataGridViewTextBoxColumn.Visible = false;
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
            this.korisnikBindingSource.DataSource = typeof(UpravljanjeProjektima.Korisnik);
            // 
            // partnerIdDataGridViewTextBoxColumn
            // 
            this.partnerIdDataGridViewTextBoxColumn.DataPropertyName = "partnerId";
            this.partnerIdDataGridViewTextBoxColumn.DataSource = this.partnerBindingSource;
            this.partnerIdDataGridViewTextBoxColumn.DisplayMember = "ime";
            this.partnerIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.partnerIdDataGridViewTextBoxColumn.HeaderText = "partner";
            this.partnerIdDataGridViewTextBoxColumn.Name = "partnerIdDataGridViewTextBoxColumn";
            this.partnerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partnerIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partnerIdDataGridViewTextBoxColumn.ValueMember = "partnerId";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(UpravljanjeProjektima.Partner);
            // 
            // gotovoDataGridViewTextBoxColumn
            // 
            this.gotovoDataGridViewTextBoxColumn.DataPropertyName = "gotovo";
            this.gotovoDataGridViewTextBoxColumn.HeaderText = "Izdan račun";
            this.gotovoDataGridViewTextBoxColumn.Name = "gotovoDataGridViewTextBoxColumn";
            this.gotovoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktivanDataGridViewTextBoxColumn
            // 
            this.aktivanDataGridViewTextBoxColumn.DataPropertyName = "aktivan";
            this.aktivanDataGridViewTextBoxColumn.HeaderText = "Pokrenut";
            this.aktivanDataGridViewTextBoxColumn.Name = "aktivanDataGridViewTextBoxColumn";
            this.aktivanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fazeprojektaDataGridViewTextBoxColumn
            // 
            this.fazeprojektaDataGridViewTextBoxColumn.DataPropertyName = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn.HeaderText = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn.Name = "fazeprojektaDataGridViewTextBoxColumn";
            this.fazeprojektaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fazeprojektaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // partnerDataGridViewTextBoxColumn
            // 
            this.partnerDataGridViewTextBoxColumn.DataPropertyName = "Partner";
            this.partnerDataGridViewTextBoxColumn.HeaderText = "Partner";
            this.partnerDataGridViewTextBoxColumn.Name = "partnerDataGridViewTextBoxColumn";
            this.partnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerDataGridViewTextBoxColumn.Visible = false;
            // 
            // projektBindingSource
            // 
            this.projektBindingSource.DataSource = typeof(UpravljanjeProjektima.Projekt);
            // 
            // fazeDataGridView
            // 
            this.fazeDataGridView.AllowUserToAddRows = false;
            this.fazeDataGridView.AllowUserToDeleteRows = false;
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
            this.fazeDataGridView.MultiSelect = false;
            this.fazeDataGridView.Name = "fazeDataGridView";
            this.fazeDataGridView.ReadOnly = true;
            this.fazeDataGridView.Size = new System.Drawing.Size(354, 150);
            this.fazeDataGridView.TabIndex = 1;
            this.fazeDataGridView.SelectionChanged += new System.EventHandler(this.fazeDataGridView_SelectionChanged);
            // 
            // fazaIdDataGridViewTextBoxColumn
            // 
            this.fazaIdDataGridViewTextBoxColumn.DataPropertyName = "fazaId";
            this.fazaIdDataGridViewTextBoxColumn.HeaderText = "fazaId";
            this.fazaIdDataGridViewTextBoxColumn.Name = "fazaIdDataGridViewTextBoxColumn";
            this.fazaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fazaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            this.trajanjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fazeprojektaDataGridViewTextBoxColumn1
            // 
            this.fazeprojektaDataGridViewTextBoxColumn1.DataPropertyName = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn1.HeaderText = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn1.Name = "fazeprojektaDataGridViewTextBoxColumn1";
            this.fazeprojektaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fazeprojektaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fazaBindingSource
            // 
            this.fazaBindingSource.DataSource = typeof(UpravljanjeProjektima.Faza);
            // 
            // noviProjektButton
            // 
            this.noviProjektButton.Location = new System.Drawing.Point(781, 377);
            this.noviProjektButton.Name = "noviProjektButton";
            this.noviProjektButton.Size = new System.Drawing.Size(75, 23);
            this.noviProjektButton.TabIndex = 2;
            this.noviProjektButton.Text = "Novi projekt";
            this.noviProjektButton.UseVisualStyleBackColor = true;
            this.noviProjektButton.Click += new System.EventHandler(this.noviProjektButton_Click);
            // 
            // brisiProjektButton
            // 
            this.brisiProjektButton.Location = new System.Drawing.Point(1085, 377);
            this.brisiProjektButton.Name = "brisiProjektButton";
            this.brisiProjektButton.Size = new System.Drawing.Size(75, 23);
            this.brisiProjektButton.TabIndex = 3;
            this.brisiProjektButton.Text = "Briši projekt";
            this.brisiProjektButton.UseVisualStyleBackColor = true;
            this.brisiProjektButton.Visible = false;
            this.brisiProjektButton.Click += new System.EventHandler(this.brisiProjektButton_Click);
            // 
            // brisiFazuButton
            // 
            this.brisiFazuButton.Location = new System.Drawing.Point(291, 561);
            this.brisiFazuButton.Name = "brisiFazuButton";
            this.brisiFazuButton.Size = new System.Drawing.Size(75, 23);
            this.brisiFazuButton.TabIndex = 5;
            this.brisiFazuButton.Text = "Briši fazu";
            this.brisiFazuButton.UseVisualStyleBackColor = true;
            this.brisiFazuButton.Click += new System.EventHandler(this.brisiFazuButton_Click);
            // 
            // dodajFazuButton
            // 
            this.dodajFazuButton.Location = new System.Drawing.Point(210, 561);
            this.dodajFazuButton.Name = "dodajFazuButton";
            this.dodajFazuButton.Size = new System.Drawing.Size(75, 23);
            this.dodajFazuButton.TabIndex = 4;
            this.dodajFazuButton.Text = "Izbornik faza";
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
            this.projektiLabel.Location = new System.Drawing.Point(9, 33);
            this.projektiLabel.Name = "projektiLabel";
            this.projektiLabel.Size = new System.Drawing.Size(45, 13);
            this.projektiLabel.TabIndex = 7;
            this.projektiLabel.Text = "Projekti:";
            // 
            // pokreniProjektButton
            // 
            this.pokreniProjektButton.Location = new System.Drawing.Point(970, 377);
            this.pokreniProjektButton.Name = "pokreniProjektButton";
            this.pokreniProjektButton.Size = new System.Drawing.Size(109, 23);
            this.pokreniProjektButton.TabIndex = 9;
            this.pokreniProjektButton.Text = "Pokreni projekt";
            this.pokreniProjektButton.UseVisualStyleBackColor = true;
            this.pokreniProjektButton.Click += new System.EventHandler(this.pokreniProjektButton_Click);
            // 
            // izmjeniProjektButton
            // 
            this.izmjeniProjektButton.Location = new System.Drawing.Point(862, 377);
            this.izmjeniProjektButton.Name = "izmjeniProjektButton";
            this.izmjeniProjektButton.Size = new System.Drawing.Size(98, 23);
            this.izmjeniProjektButton.TabIndex = 10;
            this.izmjeniProjektButton.Text = "Izmjeni projekt";
            this.izmjeniProjektButton.UseVisualStyleBackColor = true;
            this.izmjeniProjektButton.Click += new System.EventHandler(this.izmjeniProjektButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Materijal:";
            // 
            // materijalDataGridView
            // 
            this.materijalDataGridView.AllowUserToAddRows = false;
            this.materijalDataGridView.AllowUserToDeleteRows = false;
            this.materijalDataGridView.AutoGenerateColumns = false;
            this.materijalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materijalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.materijalIdDataGridViewTextBoxColumn,
            this.cijena,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijena_stavke,
            this.fazeprojektaDataGridViewTextBoxColumn2,
            this.materijalDataGridViewTextBoxColumn});
            this.materijalDataGridView.DataSource = this.fazaimamaterijalBindingSource;
            this.materijalDataGridView.Location = new System.Drawing.Point(462, 405);
            this.materijalDataGridView.MultiSelect = false;
            this.materijalDataGridView.Name = "materijalDataGridView";
            this.materijalDataGridView.ReadOnly = true;
            this.materijalDataGridView.Size = new System.Drawing.Size(447, 150);
            this.materijalDataGridView.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // materijalIdDataGridViewTextBoxColumn
            // 
            this.materijalIdDataGridViewTextBoxColumn.DataPropertyName = "materijalId";
            this.materijalIdDataGridViewTextBoxColumn.DataSource = this.materijalBindingSource;
            this.materijalIdDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.materijalIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materijalIdDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.materijalIdDataGridViewTextBoxColumn.Name = "materijalIdDataGridViewTextBoxColumn";
            this.materijalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materijalIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materijalIdDataGridViewTextBoxColumn.ValueMember = "materijalId";
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeProjektima.Materijal);
            // 
            // cijena
            // 
            this.cijena.DataPropertyName = "materijalId";
            this.cijena.DataSource = this.materijalBindingSource;
            this.cijena.DisplayMember = "cijena";
            this.cijena.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cijena.HeaderText = "Cijena";
            this.cijena.Name = "cijena";
            this.cijena.ReadOnly = true;
            this.cijena.ValueMember = "materijalId";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijena_stavke
            // 
            this.cijena_stavke.DataPropertyName = "cijena_stavke";
            this.cijena_stavke.HeaderText = "cijena_stavke";
            this.cijena_stavke.Name = "cijena_stavke";
            this.cijena_stavke.ReadOnly = true;
            // 
            // fazeprojektaDataGridViewTextBoxColumn2
            // 
            this.fazeprojektaDataGridViewTextBoxColumn2.DataPropertyName = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn2.HeaderText = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn2.Name = "fazeprojektaDataGridViewTextBoxColumn2";
            this.fazeprojektaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.fazeprojektaDataGridViewTextBoxColumn2.Visible = false;
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "Materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            this.materijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // fazaimamaterijalBindingSource
            // 
            this.fazaimamaterijalBindingSource.DataSource = typeof(UpravljanjeProjektima.Faza_ima_materijal);
            // 
            // brisiMaterijalButton
            // 
            this.brisiMaterijalButton.Location = new System.Drawing.Point(819, 561);
            this.brisiMaterijalButton.Name = "brisiMaterijalButton";
            this.brisiMaterijalButton.Size = new System.Drawing.Size(90, 23);
            this.brisiMaterijalButton.TabIndex = 14;
            this.brisiMaterijalButton.Text = "Briši materijal";
            this.brisiMaterijalButton.UseVisualStyleBackColor = true;
            this.brisiMaterijalButton.Click += new System.EventHandler(this.brisiMaterijalButton_Click);
            // 
            // dodajMaterijalButton
            // 
            this.dodajMaterijalButton.Location = new System.Drawing.Point(719, 561);
            this.dodajMaterijalButton.Name = "dodajMaterijalButton";
            this.dodajMaterijalButton.Size = new System.Drawing.Size(94, 23);
            this.dodajMaterijalButton.TabIndex = 13;
            this.dodajMaterijalButton.Text = "Dodaj materijal";
            this.dodajMaterijalButton.UseVisualStyleBackColor = true;
            this.dodajMaterijalButton.Click += new System.EventHandler(this.dodajMaterijalButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pretraživanje po nazivu:";
            // 
            // tboxPretrazi
            // 
            this.tboxPretrazi.Location = new System.Drawing.Point(505, 17);
            this.tboxPretrazi.Name = "tboxPretrazi";
            this.tboxPretrazi.Size = new System.Drawing.Size(144, 20);
            this.tboxPretrazi.TabIndex = 16;
            this.tboxPretrazi.TextChanged += new System.EventHandler(this.tboxPretrazi_TextChanged);
            // 
            // dtProjekti1
            // 
            this.dtProjekti1.Location = new System.Drawing.Point(830, 17);
            this.dtProjekti1.Name = "dtProjekti1";
            this.dtProjekti1.Size = new System.Drawing.Size(134, 20);
            this.dtProjekti1.TabIndex = 17;
            this.dtProjekti1.ValueChanged += new System.EventHandler(this.dtProjekti1_ValueChanged);
            // 
            // dtProjekti2
            // 
            this.dtProjekti2.Location = new System.Drawing.Point(970, 17);
            this.dtProjekti2.Name = "dtProjekti2";
            this.dtProjekti2.Size = new System.Drawing.Size(134, 20);
            this.dtProjekti2.TabIndex = 18;
            this.dtProjekti2.ValueChanged += new System.EventHandler(this.dtProjekti2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pretraživanje po datumu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(832, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(967, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Do:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1110, 15);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(50, 23);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // korisnikBindingSource1
            // 
            this.korisnikBindingSource1.DataSource = typeof(UpravljanjeProjektima.Korisnik);
            // 
            // PopisProjektiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 593);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtProjekti2);
            this.Controls.Add(this.dtProjekti1);
            this.Controls.Add(this.tboxPretrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brisiMaterijalButton);
            this.Controls.Add(this.dodajMaterijalButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materijalDataGridView);
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
            this.helpProvider1.SetHelpKeyword(this, "PopisProjektiForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "PopisProjektiForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Pregled projekata";
            this.Load += new System.EventHandler(this.PopisProjektiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaimamaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn fazaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazeprojektaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView materijalDataGridView;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.BindingSource fazaimamaterijalBindingSource;
        private System.Windows.Forms.Button brisiMaterijalButton;
        private System.Windows.Forms.Button dodajMaterijalButton;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn projektIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn fazeprojektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtProjekti1;
        private System.Windows.Forms.DateTimePicker dtProjekti2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materijalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena_stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazeprojektaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

