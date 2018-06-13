namespace UpravljanjeProjektima
{
    partial class PopisMaterijalaForm
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
            this.dodajMaterijalButton = new System.Windows.Forms.Button();
            this.fazeLabel = new System.Windows.Forms.Label();
            this.materijalDataGridView = new System.Windows.Forms.DataGridView();
            this.materijalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaimamaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tboxKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.tboxPretrazi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajMaterijalButton
            // 
            this.dodajMaterijalButton.Location = new System.Drawing.Point(289, 126);
            this.dodajMaterijalButton.Name = "dodajMaterijalButton";
            this.dodajMaterijalButton.Size = new System.Drawing.Size(107, 23);
            this.dodajMaterijalButton.TabIndex = 9;
            this.dodajMaterijalButton.Text = "Dodaj materijal";
            this.dodajMaterijalButton.UseVisualStyleBackColor = true;
            this.dodajMaterijalButton.Click += new System.EventHandler(this.dodajMaterijalButton_Click);
            // 
            // fazeLabel
            // 
            this.fazeLabel.AutoSize = true;
            this.fazeLabel.Location = new System.Drawing.Point(9, 6);
            this.fazeLabel.Name = "fazeLabel";
            this.fazeLabel.Size = new System.Drawing.Size(49, 13);
            this.fazeLabel.TabIndex = 7;
            this.fazeLabel.Text = "Materijal:";
            // 
            // materijalDataGridView
            // 
            this.materijalDataGridView.AutoGenerateColumns = false;
            this.materijalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materijalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materijalIdDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.fazaimamaterijalDataGridViewTextBoxColumn});
            this.materijalDataGridView.DataSource = this.materijalBindingSource;
            this.materijalDataGridView.Location = new System.Drawing.Point(12, 22);
            this.materijalDataGridView.MultiSelect = false;
            this.materijalDataGridView.Name = "materijalDataGridView";
            this.materijalDataGridView.ReadOnly = true;
            this.materijalDataGridView.Size = new System.Drawing.Size(256, 186);
            this.materijalDataGridView.TabIndex = 6;
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
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina na skladištu";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fazaimamaterijalDataGridViewTextBoxColumn
            // 
            this.fazaimamaterijalDataGridViewTextBoxColumn.DataPropertyName = "Faza_ima_materijal";
            this.fazaimamaterijalDataGridViewTextBoxColumn.HeaderText = "Faza_ima_materijal";
            this.fazaimamaterijalDataGridViewTextBoxColumn.Name = "fazaimamaterijalDataGridViewTextBoxColumn";
            this.fazaimamaterijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.fazaimamaterijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeProjektima.Materijal);
            // 
            // tboxKolicina
            // 
            this.tboxKolicina.Location = new System.Drawing.Point(289, 100);
            this.tboxKolicina.Name = "tboxKolicina";
            this.tboxKolicina.Size = new System.Drawing.Size(107, 20);
            this.tboxKolicina.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Količina za projekt:";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(289, 185);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(107, 23);
            this.odustaniButton.TabIndex = 12;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // tboxPretrazi
            // 
            this.tboxPretrazi.Location = new System.Drawing.Point(289, 36);
            this.tboxPretrazi.Name = "tboxPretrazi";
            this.tboxPretrazi.Size = new System.Drawing.Size(117, 20);
            this.tboxPretrazi.TabIndex = 20;
            this.tboxPretrazi.TextChanged += new System.EventHandler(this.tboxPretrazi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pretraživanje po nazivu:";
            // 
            // PopisMaterijalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 220);
            this.Controls.Add(this.tboxPretrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxKolicina);
            this.Controls.Add(this.dodajMaterijalButton);
            this.Controls.Add(this.fazeLabel);
            this.Controls.Add(this.materijalDataGridView);
            this.Name = "PopisMaterijalaForm";
            this.Text = "PopisMaterijalaFOrm";
            this.Load += new System.EventHandler(this.PopisMaterijalaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajMaterijalButton;
        private System.Windows.Forms.Label fazeLabel;
        private System.Windows.Forms.DataGridView materijalDataGridView;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazaimamaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tboxKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.TextBox tboxPretrazi;
        private System.Windows.Forms.Label label2;
    }
}