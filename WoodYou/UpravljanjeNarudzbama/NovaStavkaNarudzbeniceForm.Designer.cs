namespace UpravljanjeNarudzbama
{
    partial class NovaStavkaNarudzbeniceForm
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
            this.materijalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodajButton = new System.Windows.Forms.Button();
            this.materijaliLabel = new System.Windows.Forms.Label();
            this.kolicinaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.spremiButton = new System.Windows.Forms.Button();
            this.brisiMaterijalButton = new System.Windows.Forms.Button();
            this.dodaniMaterijalLabel = new System.Windows.Forms.Label();
            this.dodaniMaterijalDataGridView = new System.Windows.Forms.DataGridView();
            this.narudzbenicaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkanarudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodaniMaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkanarudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materijalDataGridView
            // 
            this.materijalDataGridView.AllowUserToAddRows = false;
            this.materijalDataGridView.AllowUserToDeleteRows = false;
            this.materijalDataGridView.AutoGenerateColumns = false;
            this.materijalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materijalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.materijalDataGridView.DataSource = this.materijalBindingSource;
            this.materijalDataGridView.Location = new System.Drawing.Point(12, 25);
            this.materijalDataGridView.Name = "materijalDataGridView";
            this.materijalDataGridView.ReadOnly = true;
            this.materijalDataGridView.Size = new System.Drawing.Size(293, 310);
            this.materijalDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "materijalId";
            this.dataGridViewTextBoxColumn1.HeaderText = "materijalId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Stavka_narudzbenice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stavka_narudzbenice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Materijal);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(71, 338);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // materijaliLabel
            // 
            this.materijaliLabel.AutoSize = true;
            this.materijaliLabel.Location = new System.Drawing.Point(9, 9);
            this.materijaliLabel.Name = "materijaliLabel";
            this.materijaliLabel.Size = new System.Drawing.Size(48, 13);
            this.materijaliLabel.TabIndex = 4;
            this.materijaliLabel.Text = "Materijali";
            // 
            // kolicinaNumericUpDown
            // 
            this.kolicinaNumericUpDown.Location = new System.Drawing.Point(12, 341);
            this.kolicinaNumericUpDown.Name = "kolicinaNumericUpDown";
            this.kolicinaNumericUpDown.Size = new System.Drawing.Size(53, 20);
            this.kolicinaNumericUpDown.TabIndex = 5;
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(567, 369);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 6;
            this.spremiButton.Text = " Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.SpremiButton_Click);
            // 
            // brisiMaterijalButton
            // 
            this.brisiMaterijalButton.Location = new System.Drawing.Point(351, 338);
            this.brisiMaterijalButton.Name = "brisiMaterijalButton";
            this.brisiMaterijalButton.Size = new System.Drawing.Size(75, 23);
            this.brisiMaterijalButton.TabIndex = 8;
            this.brisiMaterijalButton.Text = "Briši";
            this.brisiMaterijalButton.UseVisualStyleBackColor = true;
            this.brisiMaterijalButton.Click += new System.EventHandler(this.BrisiMaterijalButton_Click);
            // 
            // dodaniMaterijalLabel
            // 
            this.dodaniMaterijalLabel.AutoSize = true;
            this.dodaniMaterijalLabel.Location = new System.Drawing.Point(348, 9);
            this.dodaniMaterijalLabel.Name = "dodaniMaterijalLabel";
            this.dodaniMaterijalLabel.Size = new System.Drawing.Size(82, 13);
            this.dodaniMaterijalLabel.TabIndex = 9;
            this.dodaniMaterijalLabel.Text = "Dodani materijal";
            // 
            // dodaniMaterijalDataGridView
            // 
            this.dodaniMaterijalDataGridView.AllowUserToAddRows = false;
            this.dodaniMaterijalDataGridView.AllowUserToDeleteRows = false;
            this.dodaniMaterijalDataGridView.AutoGenerateColumns = false;
            this.dodaniMaterijalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dodaniMaterijalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.narudzbenicaIdDataGridViewTextBoxColumn,
            this.materijalIdDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn,
            this.narudzbenicaDataGridViewTextBoxColumn});
            this.dodaniMaterijalDataGridView.DataSource = this.stavkanarudzbeniceBindingSource;
            this.dodaniMaterijalDataGridView.Location = new System.Drawing.Point(351, 25);
            this.dodaniMaterijalDataGridView.Name = "dodaniMaterijalDataGridView";
            this.dodaniMaterijalDataGridView.ReadOnly = true;
            this.dodaniMaterijalDataGridView.Size = new System.Drawing.Size(293, 310);
            this.dodaniMaterijalDataGridView.TabIndex = 10;
            // 
            // narudzbenicaIdDataGridViewTextBoxColumn
            // 
            this.narudzbenicaIdDataGridViewTextBoxColumn.DataPropertyName = "narudzbenicaId";
            this.narudzbenicaIdDataGridViewTextBoxColumn.HeaderText = "narudzbenicaId";
            this.narudzbenicaIdDataGridViewTextBoxColumn.Name = "narudzbenicaIdDataGridViewTextBoxColumn";
            this.narudzbenicaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.narudzbenicaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // materijalIdDataGridViewTextBoxColumn
            // 
            this.materijalIdDataGridViewTextBoxColumn.DataPropertyName = "materijalId";
            this.materijalIdDataGridViewTextBoxColumn.DataSource = this.materijalBindingSource;
            this.materijalIdDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.materijalIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materijalIdDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.materijalIdDataGridViewTextBoxColumn.Name = "materijalIdDataGridViewTextBoxColumn";
            this.materijalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materijalIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materijalIdDataGridViewTextBoxColumn.ValueMember = "materijalId";
            this.materijalIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "Materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            this.materijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // narudzbenicaDataGridViewTextBoxColumn
            // 
            this.narudzbenicaDataGridViewTextBoxColumn.DataPropertyName = "Narudzbenica";
            this.narudzbenicaDataGridViewTextBoxColumn.HeaderText = "Narudzbenica";
            this.narudzbenicaDataGridViewTextBoxColumn.Name = "narudzbenicaDataGridViewTextBoxColumn";
            this.narudzbenicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.narudzbenicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkanarudzbeniceBindingSource
            // 
            this.stavkanarudzbeniceBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Stavka_narudzbenice);
            // 
            // dodaniMaterijalBindingSource
            // 
            this.dodaniMaterijalBindingSource.DataSource = typeof(UpravljanjeNarudzbama.Materijal);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\..\\..\\packages\\HTML help\\help.chm";
            // 
            // NovaStavkaNarudzbeniceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 404);
            this.Controls.Add(this.dodaniMaterijalDataGridView);
            this.Controls.Add(this.dodaniMaterijalLabel);
            this.Controls.Add(this.brisiMaterijalButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.kolicinaNumericUpDown);
            this.Controls.Add(this.materijaliLabel);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.materijalDataGridView);
            this.helpProvider1.SetHelpKeyword(this, "NovaStvakaNarudzbenica");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "NovaStavkaNarudzbeniceForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Nova stavka narudžbenice";
            this.Load += new System.EventHandler(this.NovaStavkaNarudzbenice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkanarudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.DataGridView materijalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label materijaliLabel;
        private System.Windows.Forms.NumericUpDown kolicinaNumericUpDown;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button brisiMaterijalButton;
        private System.Windows.Forms.Label dodaniMaterijalLabel;
        private System.Windows.Forms.DataGridView dodaniMaterijalDataGridView;
        private System.Windows.Forms.BindingSource dodaniMaterijalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn narudzbenicaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materijalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narudzbenicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stavkanarudzbeniceBindingSource;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}