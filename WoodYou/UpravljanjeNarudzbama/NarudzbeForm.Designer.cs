namespace UpravljanjeNarudzbama
{
    partial class NarudzbeForm
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
            this.novaNarudzbaButton = new System.Windows.Forms.Button();
            this.urediNarudzbuButton = new System.Windows.Forms.Button();
            this.obrisiNarudzbuButton = new System.Windows.Forms.Button();
            this.obrisiStavkuButton = new System.Windows.Forms.Button();
            this.novaStavkaButton = new System.Windows.Forms.Button();
            this.narudzbenicaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavka_narudzbeniceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkanarudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaLabel = new System.Windows.Forms.Label();
            this.stavkeNarudzbeniceLabel = new System.Windows.Forms.Label();
            this.ispisNarudzbeniceButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_narudzbeniceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkanarudzbeniceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // novaNarudzbaButton
            // 
            this.novaNarudzbaButton.Location = new System.Drawing.Point(12, 426);
            this.novaNarudzbaButton.Name = "novaNarudzbaButton";
            this.novaNarudzbaButton.Size = new System.Drawing.Size(103, 23);
            this.novaNarudzbaButton.TabIndex = 4;
            this.novaNarudzbaButton.Text = "Nova narudžba";
            this.novaNarudzbaButton.UseVisualStyleBackColor = true;
            this.novaNarudzbaButton.Click += new System.EventHandler(this.NovaNarudzbaButton_Click);
            // 
            // urediNarudzbuButton
            // 
            this.urediNarudzbuButton.Location = new System.Drawing.Point(121, 426);
            this.urediNarudzbuButton.Name = "urediNarudzbuButton";
            this.urediNarudzbuButton.Size = new System.Drawing.Size(103, 23);
            this.urediNarudzbuButton.TabIndex = 5;
            this.urediNarudzbuButton.Text = "Uredi narudžbu";
            this.urediNarudzbuButton.UseVisualStyleBackColor = true;
            this.urediNarudzbuButton.Click += new System.EventHandler(this.UrediNarudzbuButton_Click);
            // 
            // obrisiNarudzbuButton
            // 
            this.obrisiNarudzbuButton.Enabled = false;
            this.obrisiNarudzbuButton.Location = new System.Drawing.Point(311, 426);
            this.obrisiNarudzbuButton.Name = "obrisiNarudzbuButton";
            this.obrisiNarudzbuButton.Size = new System.Drawing.Size(103, 23);
            this.obrisiNarudzbuButton.TabIndex = 6;
            this.obrisiNarudzbuButton.Text = "Obriši narudžbu";
            this.obrisiNarudzbuButton.UseVisualStyleBackColor = true;
            this.obrisiNarudzbuButton.Visible = false;
            this.obrisiNarudzbuButton.Click += new System.EventHandler(this.ObrisiNarudzbuButton_Click);
            // 
            // obrisiStavkuButton
            // 
            this.obrisiStavkuButton.Location = new System.Drawing.Point(677, 426);
            this.obrisiStavkuButton.Name = "obrisiStavkuButton";
            this.obrisiStavkuButton.Size = new System.Drawing.Size(103, 23);
            this.obrisiStavkuButton.TabIndex = 9;
            this.obrisiStavkuButton.Text = "Obriši stavku";
            this.obrisiStavkuButton.UseVisualStyleBackColor = true;
            this.obrisiStavkuButton.Click += new System.EventHandler(this.ObrisiStavkuButton_Click);
            // 
            // novaStavkaButton
            // 
            this.novaStavkaButton.Location = new System.Drawing.Point(568, 426);
            this.novaStavkaButton.Name = "novaStavkaButton";
            this.novaStavkaButton.Size = new System.Drawing.Size(103, 23);
            this.novaStavkaButton.TabIndex = 7;
            this.novaStavkaButton.Text = "Nova stavka";
            this.novaStavkaButton.UseVisualStyleBackColor = true;
            this.novaStavkaButton.Click += new System.EventHandler(this.NovaStavkaButton_Click);
            // 
            // narudzbenicaDataGridView
            // 
            this.narudzbenicaDataGridView.AllowUserToAddRows = false;
            this.narudzbenicaDataGridView.AllowUserToDeleteRows = false;
            this.narudzbenicaDataGridView.AllowUserToOrderColumns = true;
            this.narudzbenicaDataGridView.AllowUserToResizeColumns = false;
            this.narudzbenicaDataGridView.AllowUserToResizeRows = false;
            this.narudzbenicaDataGridView.AutoGenerateColumns = false;
            this.narudzbenicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.narudzbenicaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.narudzbenicaDataGridView.DataSource = this.narudzbenicaBindingSource;
            this.narudzbenicaDataGridView.Location = new System.Drawing.Point(12, 28);
            this.narudzbenicaDataGridView.Name = "narudzbenicaDataGridView";
            this.narudzbenicaDataGridView.ReadOnly = true;
            this.narudzbenicaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.narudzbenicaDataGridView.Size = new System.Drawing.Size(402, 392);
            this.narudzbenicaDataGridView.TabIndex = 10;
            this.narudzbenicaDataGridView.SelectionChanged += new System.EventHandler(this.NarudzbeDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "narudzbenicaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "narudzbenicaId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "datum_slanja";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datum slanja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "korisnikId";
            this.dataGridViewTextBoxColumn3.DataSource = this.korisnikBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "korisnicko_ime";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Izdao korisnik";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "korisnikId";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Korisnik);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "partnerId";
            this.dataGridViewTextBoxColumn4.DataSource = this.partnerBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "ime";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Dobavljač";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "partnerId";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Partner);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Korisnik";
            this.dataGridViewTextBoxColumn7.HeaderText = "Korisnik";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Stavka_narudzbenice";
            this.dataGridViewTextBoxColumn8.HeaderText = "Stavka_narudzbenice";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Narudzbenica);
            // 
            // stavka_narudzbeniceDataGridView
            // 
            this.stavka_narudzbeniceDataGridView.AllowUserToAddRows = false;
            this.stavka_narudzbeniceDataGridView.AllowUserToDeleteRows = false;
            this.stavka_narudzbeniceDataGridView.AutoGenerateColumns = false;
            this.stavka_narudzbeniceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavka_narudzbeniceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.stavka_narudzbeniceDataGridView.DataSource = this.stavkanarudzbeniceBindingSource;
            this.stavka_narudzbeniceDataGridView.Location = new System.Drawing.Point(424, 28);
            this.stavka_narudzbeniceDataGridView.Name = "stavka_narudzbeniceDataGridView";
            this.stavka_narudzbeniceDataGridView.ReadOnly = true;
            this.stavka_narudzbeniceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavka_narudzbeniceDataGridView.Size = new System.Drawing.Size(356, 392);
            this.stavka_narudzbeniceDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "narudzbenicaId";
            this.dataGridViewTextBoxColumn9.HeaderText = "narudzbenicaId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "materijalId";
            this.dataGridViewTextBoxColumn10.DataSource = this.materijalBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn10.HeaderText = "Materijal";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "materijalId";
            this.dataGridViewTextBoxColumn10.Width = 130;
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Materijal);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn11.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Materijal";
            this.dataGridViewTextBoxColumn12.HeaderText = "Materijal";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Narudzbenica";
            this.dataGridViewTextBoxColumn13.HeaderText = "Narudzbenica";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // stavkanarudzbeniceBindingSource
            // 
            this.stavkanarudzbeniceBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Stavka_narudzbenice);
            // 
            // narudzbenicaLabel
            // 
            this.narudzbenicaLabel.AutoSize = true;
            this.narudzbenicaLabel.Location = new System.Drawing.Point(9, 12);
            this.narudzbenicaLabel.Name = "narudzbenicaLabel";
            this.narudzbenicaLabel.Size = new System.Drawing.Size(73, 13);
            this.narudzbenicaLabel.TabIndex = 11;
            this.narudzbenicaLabel.Text = "Narudžbenica";
            // 
            // stavkeNarudzbeniceLabel
            // 
            this.stavkeNarudzbeniceLabel.AutoSize = true;
            this.stavkeNarudzbeniceLabel.Location = new System.Drawing.Point(421, 12);
            this.stavkeNarudzbeniceLabel.Name = "stavkeNarudzbeniceLabel";
            this.stavkeNarudzbeniceLabel.Size = new System.Drawing.Size(108, 13);
            this.stavkeNarudzbeniceLabel.TabIndex = 12;
            this.stavkeNarudzbeniceLabel.Text = "Stavke narudžbenice";
            // 
            // ispisNarudzbeniceButton
            // 
            this.ispisNarudzbeniceButton.Location = new System.Drawing.Point(230, 426);
            this.ispisNarudzbeniceButton.Name = "ispisNarudzbeniceButton";
            this.ispisNarudzbeniceButton.Size = new System.Drawing.Size(75, 23);
            this.ispisNarudzbeniceButton.TabIndex = 13;
            this.ispisNarudzbeniceButton.Text = "Ispiši";
            this.ispisNarudzbeniceButton.UseVisualStyleBackColor = true;
            this.ispisNarudzbeniceButton.Click += new System.EventHandler(this.IspisNarudzbeniceButton_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // NarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 457);
            this.Controls.Add(this.ispisNarudzbeniceButton);
            this.Controls.Add(this.stavkeNarudzbeniceLabel);
            this.Controls.Add(this.narudzbenicaLabel);
            this.Controls.Add(this.stavka_narudzbeniceDataGridView);
            this.Controls.Add(this.narudzbenicaDataGridView);
            this.Controls.Add(this.obrisiStavkuButton);
            this.Controls.Add(this.novaStavkaButton);
            this.Controls.Add(this.obrisiNarudzbuButton);
            this.Controls.Add(this.urediNarudzbuButton);
            this.Controls.Add(this.novaNarudzbaButton);
            this.helpProvider1.SetHelpKeyword(this, "Narudzbe");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "NarudzbeForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.NarudzbeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_narudzbeniceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkanarudzbeniceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button novaNarudzbaButton;
        private System.Windows.Forms.Button urediNarudzbuButton;
        private System.Windows.Forms.Button obrisiNarudzbuButton;
        private System.Windows.Forms.Button obrisiStavkuButton;
        private System.Windows.Forms.Button novaStavkaButton;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private System.Windows.Forms.DataGridView narudzbenicaDataGridView;
        private System.Windows.Forms.BindingSource stavkanarudzbeniceBindingSource;
        private System.Windows.Forms.DataGridView stavka_narudzbeniceDataGridView;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label narudzbenicaLabel;
        private System.Windows.Forms.Label stavkeNarudzbeniceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button ispisNarudzbeniceButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

