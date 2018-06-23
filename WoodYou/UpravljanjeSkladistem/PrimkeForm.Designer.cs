namespace UpravljanjeSkladistem
{
    partial class PrimkeForm
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
            this.primkaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primkeLabel = new System.Windows.Forms.Label();
            this.stavka_primkeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavka_primkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalLabel = new System.Windows.Forms.Label();
            this.novaPrimkaButton = new System.Windows.Forms.Button();
            this.brisiPrimkuButton = new System.Windows.Forms.Button();
            this.urediPrimkuButton = new System.Windows.Forms.Button();
            this.brisiStavkuButton = new System.Windows.Forms.Button();
            this.novaStavkaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.primkaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_primkeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_primkeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // primkaDataGridView
            // 
            this.primkaDataGridView.AllowUserToAddRows = false;
            this.primkaDataGridView.AllowUserToDeleteRows = false;
            this.primkaDataGridView.AutoGenerateColumns = false;
            this.primkaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primkaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.primkaDataGridView.DataSource = this.primkaBindingSource;
            this.primkaDataGridView.Location = new System.Drawing.Point(15, 24);
            this.primkaDataGridView.Name = "primkaDataGridView";
            this.primkaDataGridView.ReadOnly = true;
            this.primkaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.primkaDataGridView.Size = new System.Drawing.Size(344, 290);
            this.primkaDataGridView.TabIndex = 1;
            this.primkaDataGridView.SelectionChanged += new System.EventHandler(this.PrimkaDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "primkaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "primkaId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "datumPrimitka";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datum primitka";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "korisnikId";
            this.dataGridViewTextBoxColumn3.DataSource = this.korisnikBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "korisnicko_ime";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Korisnik";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "korisnikId";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(UpravljanjeSkladistem.Korisnik);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "partnerId";
            this.dataGridViewTextBoxColumn4.DataSource = this.partnerBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "ime";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Partner";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "partnerId";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(UpravljanjeSkladistem.Partner);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Stavka_primke";
            this.dataGridViewTextBoxColumn5.HeaderText = "Stavka_primke";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Korisnik";
            this.dataGridViewTextBoxColumn6.HeaderText = "Korisnik";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Partner";
            this.dataGridViewTextBoxColumn7.HeaderText = "Partner";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // primkaBindingSource
            // 
            this.primkaBindingSource.DataSource = typeof(UpravljanjeSkladistem.Primka);
            // 
            // primkeLabel
            // 
            this.primkeLabel.AutoSize = true;
            this.primkeLabel.Location = new System.Drawing.Point(12, 9);
            this.primkeLabel.Name = "primkeLabel";
            this.primkeLabel.Size = new System.Drawing.Size(39, 13);
            this.primkeLabel.TabIndex = 2;
            this.primkeLabel.Text = "Primke";
            // 
            // stavka_primkeDataGridView
            // 
            this.stavka_primkeDataGridView.AllowUserToAddRows = false;
            this.stavka_primkeDataGridView.AllowUserToDeleteRows = false;
            this.stavka_primkeDataGridView.AutoGenerateColumns = false;
            this.stavka_primkeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavka_primkeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.stavka_primkeDataGridView.DataSource = this.stavka_primkeBindingSource;
            this.stavka_primkeDataGridView.Location = new System.Drawing.Point(416, 24);
            this.stavka_primkeDataGridView.Name = "stavka_primkeDataGridView";
            this.stavka_primkeDataGridView.ReadOnly = true;
            this.stavka_primkeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavka_primkeDataGridView.Size = new System.Drawing.Size(245, 290);
            this.stavka_primkeDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "primkaId";
            this.dataGridViewTextBoxColumn8.HeaderText = "primkaId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "materijalId";
            this.dataGridViewTextBoxColumn9.DataSource = this.materijalBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn9.HeaderText = "Materijal";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "materijalId";
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeSkladistem.Materijal);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn10.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Materijal";
            this.dataGridViewTextBoxColumn11.HeaderText = "Materijal";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Primka";
            this.dataGridViewTextBoxColumn12.HeaderText = "Primka";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // stavka_primkeBindingSource
            // 
            this.stavka_primkeBindingSource.DataSource = typeof(UpravljanjeSkladistem.Stavka_primke);
            // 
            // materijalLabel
            // 
            this.materijalLabel.AutoSize = true;
            this.materijalLabel.Location = new System.Drawing.Point(413, 9);
            this.materijalLabel.Name = "materijalLabel";
            this.materijalLabel.Size = new System.Drawing.Size(46, 13);
            this.materijalLabel.TabIndex = 3;
            this.materijalLabel.Text = "Materijal\r\n";
            // 
            // novaPrimkaButton
            // 
            this.novaPrimkaButton.Location = new System.Drawing.Point(15, 321);
            this.novaPrimkaButton.Name = "novaPrimkaButton";
            this.novaPrimkaButton.Size = new System.Drawing.Size(75, 23);
            this.novaPrimkaButton.TabIndex = 4;
            this.novaPrimkaButton.Text = "Nova primka";
            this.novaPrimkaButton.UseVisualStyleBackColor = true;
            this.novaPrimkaButton.Click += new System.EventHandler(this.NovaPrimkaButton_Click);
            // 
            // brisiPrimkuButton
            // 
            this.brisiPrimkuButton.Enabled = false;
            this.brisiPrimkuButton.Location = new System.Drawing.Point(177, 321);
            this.brisiPrimkuButton.Name = "brisiPrimkuButton";
            this.brisiPrimkuButton.Size = new System.Drawing.Size(75, 23);
            this.brisiPrimkuButton.TabIndex = 5;
            this.brisiPrimkuButton.Text = "Briši primku";
            this.brisiPrimkuButton.UseVisualStyleBackColor = true;
            this.brisiPrimkuButton.Visible = false;
            this.brisiPrimkuButton.Click += new System.EventHandler(this.BrisiPrimkuButton_Click);
            // 
            // urediPrimkuButton
            // 
            this.urediPrimkuButton.Location = new System.Drawing.Point(96, 321);
            this.urediPrimkuButton.Name = "urediPrimkuButton";
            this.urediPrimkuButton.Size = new System.Drawing.Size(75, 23);
            this.urediPrimkuButton.TabIndex = 6;
            this.urediPrimkuButton.Text = "Uredi primku";
            this.urediPrimkuButton.UseVisualStyleBackColor = true;
            this.urediPrimkuButton.Click += new System.EventHandler(this.UrediPrimkuButton_Click);
            // 
            // brisiStavkuButton
            // 
            this.brisiStavkuButton.Location = new System.Drawing.Point(551, 321);
            this.brisiStavkuButton.Name = "brisiStavkuButton";
            this.brisiStavkuButton.Size = new System.Drawing.Size(110, 23);
            this.brisiStavkuButton.TabIndex = 8;
            this.brisiStavkuButton.Text = "Briši stavke primke";
            this.brisiStavkuButton.UseVisualStyleBackColor = true;
            this.brisiStavkuButton.Click += new System.EventHandler(this.BrisiStavkuButton_Click);
            // 
            // novaStavkaButton
            // 
            this.novaStavkaButton.Location = new System.Drawing.Point(435, 321);
            this.novaStavkaButton.Name = "novaStavkaButton";
            this.novaStavkaButton.Size = new System.Drawing.Size(110, 23);
            this.novaStavkaButton.TabIndex = 7;
            this.novaStavkaButton.Text = "Nova stavka primke";
            this.novaStavkaButton.UseVisualStyleBackColor = true;
            this.novaStavkaButton.Click += new System.EventHandler(this.NovaStavkaButton_Click);
            // 
            // PrimkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(676, 353);
            this.Controls.Add(this.brisiStavkuButton);
            this.Controls.Add(this.novaStavkaButton);
            this.Controls.Add(this.urediPrimkuButton);
            this.Controls.Add(this.brisiPrimkuButton);
            this.Controls.Add(this.novaPrimkaButton);
            this.Controls.Add(this.materijalLabel);
            this.Controls.Add(this.stavka_primkeDataGridView);
            this.Controls.Add(this.primkeLabel);
            this.Controls.Add(this.primkaDataGridView);
            this.Name = "PrimkeForm";
            this.Text = "Prikaz primki";
            this.Load += new System.EventHandler(this.PrimkeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primkaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_primkeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_primkeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource primkaBindingSource;
        private System.Windows.Forms.DataGridView primkaDataGridView;
        private System.Windows.Forms.Label primkeLabel;
        private System.Windows.Forms.BindingSource stavka_primkeBindingSource;
        private System.Windows.Forms.DataGridView stavka_primkeDataGridView;
        private System.Windows.Forms.Label materijalLabel;
        private System.Windows.Forms.Button novaPrimkaButton;
        private System.Windows.Forms.Button brisiPrimkuButton;
        private System.Windows.Forms.Button urediPrimkuButton;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button brisiStavkuButton;
        private System.Windows.Forms.Button novaStavkaButton;
    }
}