namespace IzdavanjeRacuna
{
    partial class OdabraniRacunForm
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
            this.fazeDataGridView = new System.Windows.Forms.DataGridView();
            this.fazaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazeprojektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaBindingSource = new System.Windows.Forms.BindingSource();
            this.materijalDataGridView = new System.Windows.Forms.DataGridView();
            this.materijalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource();
            this.materijalId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaimamaterijalBindingSource = new System.Windows.Forms.BindingSource();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tboxDatumIzdavanja = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxKorisnik = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tboxPartner = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxIznosPdv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxCijenaBezPdv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxUkupnaCijena = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxDatumZavrsetka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxPotrebnoVrijeme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxDatumPocetka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxBrojRacuna = new System.Windows.Forms.TextBox();
            this.izadiButton = new System.Windows.Forms.Button();
            this.printajButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaimamaterijalBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.fazeprojektaDataGridViewTextBoxColumn});
            this.fazeDataGridView.DataSource = this.fazaBindingSource;
            this.fazeDataGridView.Location = new System.Drawing.Point(15, 190);
            this.fazeDataGridView.MultiSelect = false;
            this.fazeDataGridView.Name = "fazeDataGridView";
            this.fazeDataGridView.ReadOnly = true;
            this.fazeDataGridView.Size = new System.Drawing.Size(355, 150);
            this.fazeDataGridView.TabIndex = 0;
            this.fazeDataGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // fazeprojektaDataGridViewTextBoxColumn
            // 
            this.fazeprojektaDataGridViewTextBoxColumn.DataPropertyName = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn.HeaderText = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn.Name = "fazeprojektaDataGridViewTextBoxColumn";
            this.fazeprojektaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fazeprojektaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fazaBindingSource
            // 
            this.fazaBindingSource.DataSource = typeof(IzdavanjeRacuna.Faza);
            // 
            // materijalDataGridView
            // 
            this.materijalDataGridView.AutoGenerateColumns = false;
            this.materijalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materijalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materijalIdDataGridViewTextBoxColumn,
            this.materijalId,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijena_stavke});
            this.materijalDataGridView.DataSource = this.fazaimamaterijalBindingSource;
            this.materijalDataGridView.Location = new System.Drawing.Point(414, 190);
            this.materijalDataGridView.MultiSelect = false;
            this.materijalDataGridView.Name = "materijalDataGridView";
            this.materijalDataGridView.ReadOnly = true;
            this.materijalDataGridView.Size = new System.Drawing.Size(349, 150);
            this.materijalDataGridView.TabIndex = 1;
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
            this.materijalBindingSource.DataSource = typeof(IzdavanjeRacuna.Materijal);
            // 
            // materijalId
            // 
            this.materijalId.DataPropertyName = "materijalId";
            this.materijalId.DataSource = this.materijalBindingSource;
            this.materijalId.DisplayMember = "cijena";
            this.materijalId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materijalId.HeaderText = "Cijena";
            this.materijalId.Name = "materijalId";
            this.materijalId.ReadOnly = true;
            this.materijalId.ValueMember = "materijalId";
            this.materijalId.Width = 60;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 60;
            // 
            // cijena_stavke
            // 
            this.cijena_stavke.DataPropertyName = "cijena_stavke";
            this.cijena_stavke.HeaderText = "cijena_stavke";
            this.cijena_stavke.Name = "cijena_stavke";
            this.cijena_stavke.ReadOnly = true;
            this.cijena_stavke.Width = 80;
            // 
            // fazaimamaterijalBindingSource
            // 
            this.fazaimamaterijalBindingSource.DataSource = typeof(IzdavanjeRacuna.Faza_ima_materijal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Materijal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Faze:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tboxDatumIzdavanja);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tboxKorisnik);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tboxPartner);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tboxIznosPdv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tboxCijenaBezPdv);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tboxUkupnaCijena);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tboxDatumZavrsetka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tboxPotrebnoVrijeme);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tboxDatumPocetka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tboxNaziv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tboxBrojRacuna);
            this.groupBox1.Location = new System.Drawing.Point(53, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabrani projekt";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(203, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Datum izdavanja računa:";
            // 
            // tboxDatumIzdavanja
            // 
            this.tboxDatumIzdavanja.Location = new System.Drawing.Point(334, 106);
            this.tboxDatumIzdavanja.Name = "tboxDatumIzdavanja";
            this.tboxDatumIzdavanja.ReadOnly = true;
            this.tboxDatumIzdavanja.Size = new System.Drawing.Size(126, 20);
            this.tboxDatumIzdavanja.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Korisnik:";
            // 
            // tboxKorisnik
            // 
            this.tboxKorisnik.Location = new System.Drawing.Point(101, 80);
            this.tboxKorisnik.Name = "tboxKorisnik";
            this.tboxKorisnik.ReadOnly = true;
            this.tboxKorisnik.Size = new System.Drawing.Size(100, 20);
            this.tboxKorisnik.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Partner:";
            // 
            // tboxPartner
            // 
            this.tboxPartner.Location = new System.Drawing.Point(101, 106);
            this.tboxPartner.Name = "tboxPartner";
            this.tboxPartner.ReadOnly = true;
            this.tboxPartner.Size = new System.Drawing.Size(100, 20);
            this.tboxPartner.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Iznos pdv-a:";
            // 
            // tboxIznosPdv
            // 
            this.tboxIznosPdv.Location = new System.Drawing.Point(569, 80);
            this.tboxIznosPdv.Name = "tboxIznosPdv";
            this.tboxIznosPdv.ReadOnly = true;
            this.tboxIznosPdv.Size = new System.Drawing.Size(100, 20);
            this.tboxIznosPdv.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cijena bez pdv-a:";
            // 
            // tboxCijenaBezPdv
            // 
            this.tboxCijenaBezPdv.Location = new System.Drawing.Point(569, 54);
            this.tboxCijenaBezPdv.Name = "tboxCijenaBezPdv";
            this.tboxCijenaBezPdv.ReadOnly = true;
            this.tboxCijenaBezPdv.Size = new System.Drawing.Size(100, 20);
            this.tboxCijenaBezPdv.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ukupna cijena:";
            // 
            // tboxUkupnaCijena
            // 
            this.tboxUkupnaCijena.Location = new System.Drawing.Point(569, 28);
            this.tboxUkupnaCijena.Name = "tboxUkupnaCijena";
            this.tboxUkupnaCijena.ReadOnly = true;
            this.tboxUkupnaCijena.Size = new System.Drawing.Size(100, 20);
            this.tboxUkupnaCijena.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Datum završetka:";
            // 
            // tboxDatumZavrsetka
            // 
            this.tboxDatumZavrsetka.Location = new System.Drawing.Point(334, 80);
            this.tboxDatumZavrsetka.Name = "tboxDatumZavrsetka";
            this.tboxDatumZavrsetka.ReadOnly = true;
            this.tboxDatumZavrsetka.Size = new System.Drawing.Size(126, 20);
            this.tboxDatumZavrsetka.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Potrebno vrijeme:";
            // 
            // tboxPotrebnoVrijeme
            // 
            this.tboxPotrebnoVrijeme.Location = new System.Drawing.Point(334, 54);
            this.tboxPotrebnoVrijeme.Name = "tboxPotrebnoVrijeme";
            this.tboxPotrebnoVrijeme.ReadOnly = true;
            this.tboxPotrebnoVrijeme.Size = new System.Drawing.Size(126, 20);
            this.tboxPotrebnoVrijeme.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Datum početka:";
            // 
            // tboxDatumPocetka
            // 
            this.tboxDatumPocetka.Location = new System.Drawing.Point(334, 28);
            this.tboxDatumPocetka.Name = "tboxDatumPocetka";
            this.tboxDatumPocetka.ReadOnly = true;
            this.tboxDatumPocetka.Size = new System.Drawing.Size(126, 20);
            this.tboxDatumPocetka.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Naziv projekta:";
            // 
            // tboxNaziv
            // 
            this.tboxNaziv.Location = new System.Drawing.Point(101, 54);
            this.tboxNaziv.Name = "tboxNaziv";
            this.tboxNaziv.ReadOnly = true;
            this.tboxNaziv.Size = new System.Drawing.Size(100, 20);
            this.tboxNaziv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Broj računa:";
            // 
            // tboxBrojRacuna
            // 
            this.tboxBrojRacuna.Location = new System.Drawing.Point(101, 28);
            this.tboxBrojRacuna.Name = "tboxBrojRacuna";
            this.tboxBrojRacuna.ReadOnly = true;
            this.tboxBrojRacuna.Size = new System.Drawing.Size(100, 20);
            this.tboxBrojRacuna.TabIndex = 0;
            // 
            // izadiButton
            // 
            this.izadiButton.Location = new System.Drawing.Point(688, 364);
            this.izadiButton.Name = "izadiButton";
            this.izadiButton.Size = new System.Drawing.Size(75, 23);
            this.izadiButton.TabIndex = 5;
            this.izadiButton.Text = "Izađi";
            this.izadiButton.UseVisualStyleBackColor = true;
            this.izadiButton.Click += new System.EventHandler(this.izadiButton_Click);
            // 
            // printajButton
            // 
            this.helpProvider1.SetHelpKeyword(this.printajButton, "OdabraniRacunForm");
            this.helpProvider1.SetHelpNavigator(this.printajButton, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.printajButton.Location = new System.Drawing.Point(607, 364);
            this.printajButton.Name = "printajButton";
            this.helpProvider1.SetShowHelp(this.printajButton, true);
            this.printajButton.Size = new System.Drawing.Size(75, 23);
            this.printajButton.TabIndex = 6;
            this.printajButton.Text = "Printaj";
            this.printajButton.UseVisualStyleBackColor = true;
            this.printajButton.Click += new System.EventHandler(this.printajButton_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // OdabraniRacunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 390);
            this.Controls.Add(this.printajButton);
            this.Controls.Add(this.izadiButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materijalDataGridView);
            this.Controls.Add(this.fazeDataGridView);
            this.Name = "OdabraniRacunForm";
            this.Text = "OdabraniRacunForm";
            this.Load += new System.EventHandler(this.OdabraniRacunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaimamaterijalBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fazeDataGridView;
        private System.Windows.Forms.DataGridView materijalDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxIznosPdv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxCijenaBezPdv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxUkupnaCijena;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tboxDatumZavrsetka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxPotrebnoVrijeme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxDatumPocetka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxBrojRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazeprojektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fazaBindingSource;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.BindingSource fazaimamaterijalBindingSource;
        private System.Windows.Forms.Button izadiButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tboxDatumIzdavanja;
        private System.Windows.Forms.TextBox tboxKorisnik;
        private System.Windows.Forms.TextBox tboxPartner;
        private System.Windows.Forms.Button printajButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn materijalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materijalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena_stavke;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}