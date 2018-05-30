namespace UpravljanjeProjektima
{
    partial class PopisFazaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fazeLabel = new System.Windows.Forms.Label();
            this.novaFazaButton = new System.Windows.Forms.Button();
            this.dodajFazuButton = new System.Windows.Forms.Button();
            this.fazaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazeprojektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odustaniButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fazaIdDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn,
            this.fazeprojektaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fazaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // fazeLabel
            // 
            this.fazeLabel.AutoSize = true;
            this.fazeLabel.Location = new System.Drawing.Point(12, 9);
            this.fazeLabel.Name = "fazeLabel";
            this.fazeLabel.Size = new System.Drawing.Size(33, 13);
            this.fazeLabel.TabIndex = 1;
            this.fazeLabel.Text = "Faze:";
            // 
            // novaFazaButton
            // 
            this.novaFazaButton.Location = new System.Drawing.Point(146, 181);
            this.novaFazaButton.Name = "novaFazaButton";
            this.novaFazaButton.Size = new System.Drawing.Size(75, 23);
            this.novaFazaButton.TabIndex = 2;
            this.novaFazaButton.Text = "Kreiraj fazu";
            this.novaFazaButton.UseVisualStyleBackColor = true;
            // 
            // dodajFazuButton
            // 
            this.dodajFazuButton.Location = new System.Drawing.Point(227, 181);
            this.dodajFazuButton.Name = "dodajFazuButton";
            this.dodajFazuButton.Size = new System.Drawing.Size(75, 23);
            this.dodajFazuButton.TabIndex = 5;
            this.dodajFazuButton.Text = "Dodaj fazu";
            this.dodajFazuButton.UseVisualStyleBackColor = true;
            this.dodajFazuButton.Click += new System.EventHandler(this.dodajFazuButton_Click);
            // 
            // fazaIdDataGridViewTextBoxColumn
            // 
            this.fazaIdDataGridViewTextBoxColumn.DataPropertyName = "fazaId";
            this.fazaIdDataGridViewTextBoxColumn.HeaderText = "fazaId";
            this.fazaIdDataGridViewTextBoxColumn.Name = "fazaIdDataGridViewTextBoxColumn";
            this.fazaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            // 
            // fazeprojektaDataGridViewTextBoxColumn
            // 
            this.fazeprojektaDataGridViewTextBoxColumn.DataPropertyName = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn.HeaderText = "Faze_projekta";
            this.fazeprojektaDataGridViewTextBoxColumn.Name = "fazeprojektaDataGridViewTextBoxColumn";
            this.fazeprojektaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fazaBindingSource
            // 
            this.fazaBindingSource.DataSource = typeof(UpravljanjeProjektima.Faza);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(308, 181);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 6;
            this.odustaniButton.Text = "Dodaj fazu";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // PopisFazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 212);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajFazuButton);
            this.Controls.Add(this.novaFazaButton);
            this.Controls.Add(this.fazeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopisFazaForm";
            this.Text = "Faze";
            this.Load += new System.EventHandler(this.PopisFazaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label fazeLabel;
        private System.Windows.Forms.Button novaFazaButton;
        private System.Windows.Forms.Button dodajFazuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazeprojektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fazaBindingSource;
        private System.Windows.Forms.Button odustaniButton;
    }
}