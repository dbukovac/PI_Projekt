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
            this.fazaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazeprojektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazeLabel = new System.Windows.Forms.Label();
            this.novaFazaButton = new System.Windows.Forms.Button();
            this.dodajFazuButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.izmjeniFazuButton = new System.Windows.Forms.Button();
            this.obrisiFazuButton = new System.Windows.Forms.Button();
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
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(395, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.fazaBindingSource.DataSource = typeof(UpravljanjeProjektima.Faza);
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
            this.novaFazaButton.Location = new System.Drawing.Point(12, 181);
            this.novaFazaButton.Name = "novaFazaButton";
            this.novaFazaButton.Size = new System.Drawing.Size(75, 23);
            this.novaFazaButton.TabIndex = 2;
            this.novaFazaButton.Text = "Kreiraj fazu";
            this.novaFazaButton.UseVisualStyleBackColor = true;
            this.novaFazaButton.Click += new System.EventHandler(this.novaFazaButton_Click);
            // 
            // dodajFazuButton
            // 
            this.dodajFazuButton.Location = new System.Drawing.Point(255, 181);
            this.dodajFazuButton.Name = "dodajFazuButton";
            this.dodajFazuButton.Size = new System.Drawing.Size(75, 23);
            this.dodajFazuButton.TabIndex = 5;
            this.dodajFazuButton.Text = "Dodaj fazu";
            this.dodajFazuButton.UseVisualStyleBackColor = true;
            this.dodajFazuButton.Click += new System.EventHandler(this.dodajFazuButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(335, 181);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 6;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // izmjeniFazuButton
            // 
            this.izmjeniFazuButton.Location = new System.Drawing.Point(93, 181);
            this.izmjeniFazuButton.Name = "izmjeniFazuButton";
            this.izmjeniFazuButton.Size = new System.Drawing.Size(75, 23);
            this.izmjeniFazuButton.TabIndex = 7;
            this.izmjeniFazuButton.Text = "Izmjeni fazu";
            this.izmjeniFazuButton.UseVisualStyleBackColor = true;
            this.izmjeniFazuButton.Click += new System.EventHandler(this.izmjeniFazuButton_Click);
            // 
            // obrisiFazuButton
            // 
            this.obrisiFazuButton.Location = new System.Drawing.Point(174, 181);
            this.obrisiFazuButton.Name = "obrisiFazuButton";
            this.obrisiFazuButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiFazuButton.TabIndex = 8;
            this.obrisiFazuButton.Text = "Obriši fazu";
            this.obrisiFazuButton.UseVisualStyleBackColor = true;
            this.obrisiFazuButton.Click += new System.EventHandler(this.obrisiFazuButton_Click);
            // 
            // PopisFazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 212);
            this.Controls.Add(this.obrisiFazuButton);
            this.Controls.Add(this.izmjeniFazuButton);
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
        private System.Windows.Forms.Button izmjeniFazuButton;
        private System.Windows.Forms.Button obrisiFazuButton;
    }
}