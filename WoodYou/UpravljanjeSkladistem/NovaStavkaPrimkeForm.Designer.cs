namespace UpravljanjeSkladistem
{
    partial class NovaStavkaPrimkeForm
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
            this.ureduButton = new System.Windows.Forms.Button();
            this.kolicinaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.brisiMaterijalButton = new System.Windows.Forms.Button();
            this.dodajMaterijalPrimka = new System.Windows.Forms.Button();
            this.dodaniMaterijalDataGridView = new System.Windows.Forms.DataGridView();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaprimkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodaniMaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalDataGridView = new System.Windows.Forms.DataGridView();
            this.materijalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaprimkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalLabel = new System.Windows.Forms.Label();
            this.dodaniMaterijalLabel = new System.Windows.Forms.Label();
            this.primkaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaprimkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ureduButton
            // 
            this.ureduButton.Location = new System.Drawing.Point(615, 286);
            this.ureduButton.Name = "ureduButton";
            this.ureduButton.Size = new System.Drawing.Size(75, 23);
            this.ureduButton.TabIndex = 18;
            this.ureduButton.Text = "U redu";
            this.ureduButton.UseVisualStyleBackColor = true;
            this.ureduButton.Click += new System.EventHandler(this.UreduButton_Click);
            // 
            // kolicinaNumericUpDown
            // 
            this.kolicinaNumericUpDown.Location = new System.Drawing.Point(157, 252);
            this.kolicinaNumericUpDown.Name = "kolicinaNumericUpDown";
            this.kolicinaNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.kolicinaNumericUpDown.TabIndex = 17;
            // 
            // brisiMaterijalButton
            // 
            this.brisiMaterijalButton.Location = new System.Drawing.Point(599, 251);
            this.brisiMaterijalButton.Name = "brisiMaterijalButton";
            this.brisiMaterijalButton.Size = new System.Drawing.Size(90, 23);
            this.brisiMaterijalButton.TabIndex = 16;
            this.brisiMaterijalButton.Text = "Briši iz primke";
            this.brisiMaterijalButton.UseVisualStyleBackColor = true;
            this.brisiMaterijalButton.Click += new System.EventHandler(this.BrisiMaterijalButton_Click);
            // 
            // dodajMaterijalPrimka
            // 
            this.dodajMaterijalPrimka.Location = new System.Drawing.Point(219, 251);
            this.dodajMaterijalPrimka.Name = "dodajMaterijalPrimka";
            this.dodajMaterijalPrimka.Size = new System.Drawing.Size(90, 23);
            this.dodajMaterijalPrimka.TabIndex = 15;
            this.dodajMaterijalPrimka.Text = "Dodaj u primku";
            this.dodajMaterijalPrimka.UseVisualStyleBackColor = true;
            this.dodajMaterijalPrimka.Click += new System.EventHandler(this.DodajMaterijalButton_Click);
            // 
            // dodaniMaterijalDataGridView
            // 
            this.dodaniMaterijalDataGridView.AllowUserToAddRows = false;
            this.dodaniMaterijalDataGridView.AllowUserToDeleteRows = false;
            this.dodaniMaterijalDataGridView.AutoGenerateColumns = false;
            this.dodaniMaterijalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dodaniMaterijalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.primkaIdDataGridViewTextBoxColumn,
            this.materijalIdDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.materijalDataGridViewTextBoxColumn,
            this.primkaDataGridViewTextBoxColumn});
            this.dodaniMaterijalDataGridView.DataSource = this.stavkaprimkeBindingSource;
            this.dodaniMaterijalDataGridView.Location = new System.Drawing.Point(395, 25);
            this.dodaniMaterijalDataGridView.Name = "dodaniMaterijalDataGridView";
            this.dodaniMaterijalDataGridView.ReadOnly = true;
            this.dodaniMaterijalDataGridView.Size = new System.Drawing.Size(294, 220);
            this.dodaniMaterijalDataGridView.TabIndex = 14;
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeSkladistem.Materijal);
            // 
            // stavkaprimkeBindingSource
            // 
            this.stavkaprimkeBindingSource.DataSource = typeof(UpravljanjeSkladistem.Stavka_primke);
            // 
            // dodaniMaterijalBindingSource
            // 
            this.dodaniMaterijalBindingSource.DataSource = typeof(UpravljanjeSkladistem.Materijal);
            // 
            // materijalDataGridView
            // 
            this.materijalDataGridView.AllowUserToAddRows = false;
            this.materijalDataGridView.AllowUserToDeleteRows = false;
            this.materijalDataGridView.AutoGenerateColumns = false;
            this.materijalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materijalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materijalIdDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.stavkaprimkeDataGridViewTextBoxColumn});
            this.materijalDataGridView.DataSource = this.materijalBindingSource;
            this.materijalDataGridView.Location = new System.Drawing.Point(15, 25);
            this.materijalDataGridView.Name = "materijalDataGridView";
            this.materijalDataGridView.ReadOnly = true;
            this.materijalDataGridView.Size = new System.Drawing.Size(294, 220);
            this.materijalDataGridView.TabIndex = 13;
            // 
            // materijalIdDataGridViewTextBoxColumn
            // 
            this.materijalIdDataGridViewTextBoxColumn.DataPropertyName = "materijalId";
            this.materijalIdDataGridViewTextBoxColumn.HeaderText = "materijalId";
            this.materijalIdDataGridViewTextBoxColumn.Name = "materijalIdDataGridViewTextBoxColumn";
            this.materijalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 150;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stavkaprimkeDataGridViewTextBoxColumn
            // 
            this.stavkaprimkeDataGridViewTextBoxColumn.DataPropertyName = "Stavka_primke";
            this.stavkaprimkeDataGridViewTextBoxColumn.HeaderText = "Stavka_primke";
            this.stavkaprimkeDataGridViewTextBoxColumn.Name = "stavkaprimkeDataGridViewTextBoxColumn";
            this.stavkaprimkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkaprimkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // materijalLabel
            // 
            this.materijalLabel.AutoSize = true;
            this.materijalLabel.Location = new System.Drawing.Point(12, 9);
            this.materijalLabel.Name = "materijalLabel";
            this.materijalLabel.Size = new System.Drawing.Size(46, 13);
            this.materijalLabel.TabIndex = 19;
            this.materijalLabel.Text = "Materijal";
            // 
            // dodaniMaterijalLabel
            // 
            this.dodaniMaterijalLabel.AutoSize = true;
            this.dodaniMaterijalLabel.Location = new System.Drawing.Point(392, 9);
            this.dodaniMaterijalLabel.Name = "dodaniMaterijalLabel";
            this.dodaniMaterijalLabel.Size = new System.Drawing.Size(82, 13);
            this.dodaniMaterijalLabel.TabIndex = 20;
            this.dodaniMaterijalLabel.Text = "Dodani materijal";
            // 
            // primkaIdDataGridViewTextBoxColumn
            // 
            this.primkaIdDataGridViewTextBoxColumn.DataPropertyName = "primkaId";
            this.primkaIdDataGridViewTextBoxColumn.HeaderText = "primkaId";
            this.primkaIdDataGridViewTextBoxColumn.Name = "primkaIdDataGridViewTextBoxColumn";
            this.primkaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.primkaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // materijalIdDataGridViewTextBoxColumn1
            // 
            this.materijalIdDataGridViewTextBoxColumn1.DataPropertyName = "materijalId";
            this.materijalIdDataGridViewTextBoxColumn1.DataSource = this.materijalBindingSource;
            this.materijalIdDataGridViewTextBoxColumn1.DisplayMember = "naziv";
            this.materijalIdDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materijalIdDataGridViewTextBoxColumn1.HeaderText = "Materijal";
            this.materijalIdDataGridViewTextBoxColumn1.Name = "materijalIdDataGridViewTextBoxColumn1";
            this.materijalIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.materijalIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materijalIdDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materijalIdDataGridViewTextBoxColumn1.ValueMember = "materijalId";
            this.materijalIdDataGridViewTextBoxColumn1.Width = 150;
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            this.kolicinaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "Materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            this.materijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // primkaDataGridViewTextBoxColumn
            // 
            this.primkaDataGridViewTextBoxColumn.DataPropertyName = "Primka";
            this.primkaDataGridViewTextBoxColumn.HeaderText = "Primka";
            this.primkaDataGridViewTextBoxColumn.Name = "primkaDataGridViewTextBoxColumn";
            this.primkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.primkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // NovaStavkaPrimkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 319);
            this.Controls.Add(this.dodaniMaterijalLabel);
            this.Controls.Add(this.materijalLabel);
            this.Controls.Add(this.ureduButton);
            this.Controls.Add(this.kolicinaNumericUpDown);
            this.Controls.Add(this.brisiMaterijalButton);
            this.Controls.Add(this.dodajMaterijalPrimka);
            this.Controls.Add(this.dodaniMaterijalDataGridView);
            this.Controls.Add(this.materijalDataGridView);
            this.Name = "NovaStavkaPrimkeForm";
            this.Text = "Nova stavka primke";
            this.Load += new System.EventHandler(this.NovaStavkaPrimkeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaprimkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ureduButton;
        private System.Windows.Forms.NumericUpDown kolicinaNumericUpDown;
        private System.Windows.Forms.Button brisiMaterijalButton;
        private System.Windows.Forms.Button dodajMaterijalPrimka;
        private System.Windows.Forms.DataGridView dodaniMaterijalDataGridView;
        private System.Windows.Forms.DataGridView materijalDataGridView;
        private System.Windows.Forms.BindingSource dodaniMaterijalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaprimkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.Label materijalLabel;
        private System.Windows.Forms.Label dodaniMaterijalLabel;
        private System.Windows.Forms.BindingSource stavkaprimkeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn primkaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materijalIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primkaDataGridViewTextBoxColumn;
    }
}