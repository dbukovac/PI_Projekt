namespace UpravljanjeSkladistem
{
    partial class SkladisteForm
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
            this.brisiMaterijalButton = new System.Windows.Forms.Button();
            this.primkeButton = new System.Windows.Forms.Button();
            this.materijalLabel = new System.Windows.Forms.Label();
            this.smanjiKolicinuButton = new System.Windows.Forms.Button();
            this.kolicinaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNumericUpDown)).BeginInit();
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
            this.materijalDataGridView.Location = new System.Drawing.Point(15, 25);
            this.materijalDataGridView.Name = "materijalDataGridView";
            this.materijalDataGridView.ReadOnly = true;
            this.materijalDataGridView.Size = new System.Drawing.Size(295, 394);
            this.materijalDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Stavka_primke";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stavka_primke";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeSkladistem.Materijal);
            // 
            // brisiMaterijalButton
            // 
            this.brisiMaterijalButton.Location = new System.Drawing.Point(93, 425);
            this.brisiMaterijalButton.Name = "brisiMaterijalButton";
            this.brisiMaterijalButton.Size = new System.Drawing.Size(75, 23);
            this.brisiMaterijalButton.TabIndex = 1;
            this.brisiMaterijalButton.Text = "Briši materijal";
            this.brisiMaterijalButton.UseVisualStyleBackColor = true;
            this.brisiMaterijalButton.Click += new System.EventHandler(this.BrisiMaterijalButton_Click);
            // 
            // primkeButton
            // 
            this.primkeButton.Location = new System.Drawing.Point(12, 425);
            this.primkeButton.Name = "primkeButton";
            this.primkeButton.Size = new System.Drawing.Size(75, 23);
            this.primkeButton.TabIndex = 2;
            this.primkeButton.Text = "Primke";
            this.primkeButton.UseVisualStyleBackColor = true;
            this.primkeButton.Click += new System.EventHandler(this.PrimkeButton_Click);
            // 
            // materijalLabel
            // 
            this.materijalLabel.AutoSize = true;
            this.materijalLabel.Location = new System.Drawing.Point(12, 9);
            this.materijalLabel.Name = "materijalLabel";
            this.materijalLabel.Size = new System.Drawing.Size(46, 13);
            this.materijalLabel.TabIndex = 3;
            this.materijalLabel.Text = "Materijal";
            // 
            // smanjiKolicinuButton
            // 
            this.smanjiKolicinuButton.Location = new System.Drawing.Point(224, 425);
            this.smanjiKolicinuButton.Name = "smanjiKolicinuButton";
            this.smanjiKolicinuButton.Size = new System.Drawing.Size(75, 23);
            this.smanjiKolicinuButton.TabIndex = 4;
            this.smanjiKolicinuButton.Text = "Oduzmi";
            this.smanjiKolicinuButton.UseVisualStyleBackColor = true;
            this.smanjiKolicinuButton.Click += new System.EventHandler(this.SmanjiKolicinuButton_Click);
            // 
            // kolicinaNumericUpDown
            // 
            this.kolicinaNumericUpDown.Location = new System.Drawing.Point(174, 426);
            this.kolicinaNumericUpDown.Name = "kolicinaNumericUpDown";
            this.kolicinaNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.kolicinaNumericUpDown.TabIndex = 5;
            // 
            // SkladisteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 456);
            this.Controls.Add(this.kolicinaNumericUpDown);
            this.Controls.Add(this.smanjiKolicinuButton);
            this.Controls.Add(this.materijalLabel);
            this.Controls.Add(this.primkeButton);
            this.Controls.Add(this.brisiMaterijalButton);
            this.Controls.Add(this.materijalDataGridView);
            this.Name = "SkladisteForm";
            this.Text = "Stanje na skladištu";
            this.Load += new System.EventHandler(this.SkladisteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Button brisiMaterijalButton;
        private System.Windows.Forms.Button primkeButton;
        private System.Windows.Forms.Label materijalLabel;
        private System.Windows.Forms.Button smanjiKolicinuButton;
        private System.Windows.Forms.NumericUpDown kolicinaNumericUpDown;
    }
}

