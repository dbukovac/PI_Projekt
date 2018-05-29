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
            this.narudzbeDataGridView = new System.Windows.Forms.DataGridView();
            this.narudzbenicaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkanarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbeLabel = new System.Windows.Forms.Label();
            this.stavkeLabel = new System.Windows.Forms.Label();
            this.novaNarudzbaButton = new System.Windows.Forms.Button();
            this.urediNarudzbuButton = new System.Windows.Forms.Button();
            this.obrisiNarudzbuButton = new System.Windows.Forms.Button();
            this.obrisiStavkuButton = new System.Windows.Forms.Button();
            this.urediStavkuButton = new System.Windows.Forms.Button();
            this.novaStavkaButton = new System.Windows.Forms.Button();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkanarudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavka_narudzbeniceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkanarudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_narudzbeniceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // narudzbeDataGridView
            // 
            this.narudzbeDataGridView.AutoGenerateColumns = false;
            this.narudzbeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.narudzbeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.narudzbenicaIdDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.korisnikIdDataGridViewTextBoxColumn,
            this.partnerIdDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.stavkanarudzbeniceDataGridViewTextBoxColumn});
            this.narudzbeDataGridView.DataSource = this.narudzbenicaBindingSource;
            this.narudzbeDataGridView.Location = new System.Drawing.Point(12, 25);
            this.narudzbeDataGridView.Name = "narudzbeDataGridView";
            this.narudzbeDataGridView.Size = new System.Drawing.Size(776, 246);
            this.narudzbeDataGridView.TabIndex = 0;
            this.narudzbeDataGridView.SelectionChanged += new System.EventHandler(this.NarudzbeDataGridView_SelectionChanged);
            // 
            // narudzbenicaIdDataGridViewTextBoxColumn
            // 
            this.narudzbenicaIdDataGridViewTextBoxColumn.DataPropertyName = "narudzbenicaId";
            this.narudzbenicaIdDataGridViewTextBoxColumn.HeaderText = "narudzbenicaId";
            this.narudzbenicaIdDataGridViewTextBoxColumn.Name = "narudzbenicaIdDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // korisnikIdDataGridViewTextBoxColumn
            // 
            this.korisnikIdDataGridViewTextBoxColumn.DataPropertyName = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.HeaderText = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.Name = "korisnikIdDataGridViewTextBoxColumn";
            // 
            // partnerIdDataGridViewTextBoxColumn
            // 
            this.partnerIdDataGridViewTextBoxColumn.DataPropertyName = "partnerId";
            this.partnerIdDataGridViewTextBoxColumn.HeaderText = "partnerId";
            this.partnerIdDataGridViewTextBoxColumn.Name = "partnerIdDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkanarudzbeniceDataGridViewTextBoxColumn
            // 
            this.stavkanarudzbeniceDataGridViewTextBoxColumn.DataPropertyName = "Stavka_narudzbenice";
            this.stavkanarudzbeniceDataGridViewTextBoxColumn.HeaderText = "Stavka_narudzbenice";
            this.stavkanarudzbeniceDataGridViewTextBoxColumn.Name = "stavkanarudzbeniceDataGridViewTextBoxColumn";
            this.stavkanarudzbeniceDataGridViewTextBoxColumn.Visible = false;
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Narudzbenica);
            // 
            // narudzbeLabel
            // 
            this.narudzbeLabel.AutoSize = true;
            this.narudzbeLabel.Location = new System.Drawing.Point(9, 9);
            this.narudzbeLabel.Name = "narudzbeLabel";
            this.narudzbeLabel.Size = new System.Drawing.Size(53, 13);
            this.narudzbeLabel.TabIndex = 1;
            this.narudzbeLabel.Text = "Narudžbe";
            // 
            // stavkeLabel
            // 
            this.stavkeLabel.AutoSize = true;
            this.stavkeLabel.Location = new System.Drawing.Point(9, 312);
            this.stavkeLabel.Name = "stavkeLabel";
            this.stavkeLabel.Size = new System.Drawing.Size(88, 13);
            this.stavkeLabel.TabIndex = 3;
            this.stavkeLabel.Text = "Stavke narudžbe";
            // 
            // novaNarudzbaButton
            // 
            this.novaNarudzbaButton.Location = new System.Drawing.Point(467, 277);
            this.novaNarudzbaButton.Name = "novaNarudzbaButton";
            this.novaNarudzbaButton.Size = new System.Drawing.Size(103, 23);
            this.novaNarudzbaButton.TabIndex = 4;
            this.novaNarudzbaButton.Text = "Nova narudžba";
            this.novaNarudzbaButton.UseVisualStyleBackColor = true;
            // 
            // urediNarudzbuButton
            // 
            this.urediNarudzbuButton.Location = new System.Drawing.Point(576, 277);
            this.urediNarudzbuButton.Name = "urediNarudzbuButton";
            this.urediNarudzbuButton.Size = new System.Drawing.Size(103, 23);
            this.urediNarudzbuButton.TabIndex = 5;
            this.urediNarudzbuButton.Text = "Uredi narudžbu";
            this.urediNarudzbuButton.UseVisualStyleBackColor = true;
            // 
            // obrisiNarudzbuButton
            // 
            this.obrisiNarudzbuButton.Location = new System.Drawing.Point(685, 277);
            this.obrisiNarudzbuButton.Name = "obrisiNarudzbuButton";
            this.obrisiNarudzbuButton.Size = new System.Drawing.Size(103, 23);
            this.obrisiNarudzbuButton.TabIndex = 6;
            this.obrisiNarudzbuButton.Text = "Obriši narudžbu";
            this.obrisiNarudzbuButton.UseVisualStyleBackColor = true;
            // 
            // obrisiStavkuButton
            // 
            this.obrisiStavkuButton.Location = new System.Drawing.Point(685, 580);
            this.obrisiStavkuButton.Name = "obrisiStavkuButton";
            this.obrisiStavkuButton.Size = new System.Drawing.Size(103, 23);
            this.obrisiStavkuButton.TabIndex = 9;
            this.obrisiStavkuButton.Text = "Obriši stavku";
            this.obrisiStavkuButton.UseVisualStyleBackColor = true;
            // 
            // urediStavkuButton
            // 
            this.urediStavkuButton.Location = new System.Drawing.Point(576, 580);
            this.urediStavkuButton.Name = "urediStavkuButton";
            this.urediStavkuButton.Size = new System.Drawing.Size(103, 23);
            this.urediStavkuButton.TabIndex = 8;
            this.urediStavkuButton.Text = "Uredi stavku";
            this.urediStavkuButton.UseVisualStyleBackColor = true;
            // 
            // novaStavkaButton
            // 
            this.novaStavkaButton.Location = new System.Drawing.Point(467, 580);
            this.novaStavkaButton.Name = "novaStavkaButton";
            this.novaStavkaButton.Size = new System.Drawing.Size(103, 23);
            this.novaStavkaButton.TabIndex = 7;
            this.novaStavkaButton.Text = "Nova stavka";
            this.novaStavkaButton.UseVisualStyleBackColor = true;
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Materijal);
            // 
            // stavkanarudzbeniceBindingSource
            // 
            this.stavkanarudzbeniceBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Stavka_narudzbenice);
            // 
            // stavka_narudzbeniceDataGridView
            // 
            this.stavka_narudzbeniceDataGridView.AutoGenerateColumns = false;
            this.stavka_narudzbeniceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavka_narudzbeniceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.stavka_narudzbeniceDataGridView.DataSource = this.stavkanarudzbeniceBindingSource;
            this.stavka_narudzbeniceDataGridView.Location = new System.Drawing.Point(12, 328);
            this.stavka_narudzbeniceDataGridView.Name = "stavka_narudzbeniceDataGridView";
            this.stavka_narudzbeniceDataGridView.Size = new System.Drawing.Size(776, 220);
            this.stavka_narudzbeniceDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "narudzbenicaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "narudzbenicaId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "materijalId";
            this.dataGridViewTextBoxColumn2.HeaderText = "materijalId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn3.HeaderText = "kolicina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Materijal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Materijal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Narudzbenica";
            this.dataGridViewTextBoxColumn5.HeaderText = "Narudzbenica";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // NarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 612);
            this.Controls.Add(this.stavka_narudzbeniceDataGridView);
            this.Controls.Add(this.obrisiStavkuButton);
            this.Controls.Add(this.urediStavkuButton);
            this.Controls.Add(this.novaStavkaButton);
            this.Controls.Add(this.obrisiNarudzbuButton);
            this.Controls.Add(this.urediNarudzbuButton);
            this.Controls.Add(this.novaNarudzbaButton);
            this.Controls.Add(this.stavkeLabel);
            this.Controls.Add(this.narudzbeLabel);
            this.Controls.Add(this.narudzbeDataGridView);
            this.Name = "NarudzbeForm";
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.NarudzbeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkanarudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_narudzbeniceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView narudzbeDataGridView;
        private System.Windows.Forms.Label narudzbeLabel;
        private System.Windows.Forms.Label stavkeLabel;
        private System.Windows.Forms.Button novaNarudzbaButton;
        private System.Windows.Forms.Button urediNarudzbuButton;
        private System.Windows.Forms.Button obrisiNarudzbuButton;
        private System.Windows.Forms.Button obrisiStavkuButton;
        private System.Windows.Forms.Button urediStavkuButton;
        private System.Windows.Forms.Button novaStavkaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn narudzbenicaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkanarudzbeniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.BindingSource stavkanarudzbeniceBindingSource;
        private System.Windows.Forms.DataGridView stavka_narudzbeniceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

