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
            this.materijalDataGridView = new System.Windows.Forms.DataGridView();
            this.materijalLabel = new System.Windows.Forms.Label();
            this.dodaniMaterijalLabel = new System.Windows.Forms.Label();
            this.materijalIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaprimkeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodaniMaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaprimkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
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
            this.materijalIdDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.stavkaprimkeDataGridViewTextBoxColumn1});
            this.dodaniMaterijalDataGridView.DataSource = this.dodaniMaterijalBindingSource;
            this.dodaniMaterijalDataGridView.Location = new System.Drawing.Point(395, 25);
            this.dodaniMaterijalDataGridView.Name = "dodaniMaterijalDataGridView";
            this.dodaniMaterijalDataGridView.ReadOnly = true;
            this.dodaniMaterijalDataGridView.Size = new System.Drawing.Size(294, 220);
            this.dodaniMaterijalDataGridView.TabIndex = 14;
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
            // materijalIdDataGridViewTextBoxColumn1
            // 
            this.materijalIdDataGridViewTextBoxColumn1.DataPropertyName = "materijalId";
            this.materijalIdDataGridViewTextBoxColumn1.HeaderText = "materijalId";
            this.materijalIdDataGridViewTextBoxColumn1.Name = "materijalIdDataGridViewTextBoxColumn1";
            this.materijalIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.materijalIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn1.Width = 150;
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            this.kolicinaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stavkaprimkeDataGridViewTextBoxColumn1
            // 
            this.stavkaprimkeDataGridViewTextBoxColumn1.DataPropertyName = "Stavka_primke";
            this.stavkaprimkeDataGridViewTextBoxColumn1.HeaderText = "Stavka_primke";
            this.stavkaprimkeDataGridViewTextBoxColumn1.Name = "stavkaprimkeDataGridViewTextBoxColumn1";
            this.stavkaprimkeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stavkaprimkeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dodaniMaterijalBindingSource
            // 
            this.dodaniMaterijalBindingSource.DataSource = typeof(UpravljanjeSkladistem.Materijal);
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
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeSkladistem.Materijal);
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
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaprimkeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource dodaniMaterijalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaprimkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.Label materijalLabel;
        private System.Windows.Forms.Label dodaniMaterijalLabel;
    }
}