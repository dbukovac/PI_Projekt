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
            this.tboxPretrazi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fazaIdDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn,
            this.fazeprojektaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fazaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
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
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "Trajanje";
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
            this.fazeLabel.Location = new System.Drawing.Point(9, 32);
            this.fazeLabel.Name = "fazeLabel";
            this.fazeLabel.Size = new System.Drawing.Size(33, 13);
            this.fazeLabel.TabIndex = 1;
            this.fazeLabel.Text = "Faze:";
            // 
            // novaFazaButton
            // 
            this.novaFazaButton.Location = new System.Drawing.Point(9, 204);
            this.novaFazaButton.Name = "novaFazaButton";
            this.novaFazaButton.Size = new System.Drawing.Size(75, 23);
            this.novaFazaButton.TabIndex = 2;
            this.novaFazaButton.Text = "Kreiraj fazu";
            this.novaFazaButton.UseVisualStyleBackColor = true;
            this.novaFazaButton.Visible = false;
            this.novaFazaButton.Click += new System.EventHandler(this.novaFazaButton_Click);
            // 
            // dodajFazuButton
            // 
            this.dodajFazuButton.Location = new System.Drawing.Point(252, 204);
            this.dodajFazuButton.Name = "dodajFazuButton";
            this.dodajFazuButton.Size = new System.Drawing.Size(75, 23);
            this.dodajFazuButton.TabIndex = 5;
            this.dodajFazuButton.Text = "Dodaj fazu";
            this.dodajFazuButton.UseVisualStyleBackColor = true;
            this.dodajFazuButton.Click += new System.EventHandler(this.dodajFazuButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(332, 204);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 6;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // izmjeniFazuButton
            // 
            this.izmjeniFazuButton.Location = new System.Drawing.Point(90, 204);
            this.izmjeniFazuButton.Name = "izmjeniFazuButton";
            this.izmjeniFazuButton.Size = new System.Drawing.Size(75, 23);
            this.izmjeniFazuButton.TabIndex = 7;
            this.izmjeniFazuButton.Text = "Izmjeni fazu";
            this.izmjeniFazuButton.UseVisualStyleBackColor = true;
            this.izmjeniFazuButton.Visible = false;
            this.izmjeniFazuButton.Click += new System.EventHandler(this.izmjeniFazuButton_Click);
            // 
            // obrisiFazuButton
            // 
            this.obrisiFazuButton.Location = new System.Drawing.Point(171, 204);
            this.obrisiFazuButton.Name = "obrisiFazuButton";
            this.obrisiFazuButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiFazuButton.TabIndex = 8;
            this.obrisiFazuButton.Text = "Obriši fazu";
            this.obrisiFazuButton.UseVisualStyleBackColor = true;
            this.obrisiFazuButton.Visible = false;
            this.obrisiFazuButton.Click += new System.EventHandler(this.obrisiFazuButton_Click);
            // 
            // tboxPretrazi
            // 
            this.tboxPretrazi.Location = new System.Drawing.Point(263, 12);
            this.tboxPretrazi.Name = "tboxPretrazi";
            this.tboxPretrazi.Size = new System.Drawing.Size(144, 20);
            this.tboxPretrazi.TabIndex = 18;
            this.tboxPretrazi.TextChanged += new System.EventHandler(this.tboxPretrazi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pretraživanje po nazivu:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // PopisFazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 234);
            this.Controls.Add(this.tboxPretrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.obrisiFazuButton);
            this.Controls.Add(this.izmjeniFazuButton);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajFazuButton);
            this.Controls.Add(this.novaFazaButton);
            this.Controls.Add(this.fazeLabel);
            this.Controls.Add(this.dataGridView1);
            this.helpProvider1.SetHelpKeyword(this, "PopisFazaForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "PopisFazaForm";
            this.helpProvider1.SetShowHelp(this, true);
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
        private System.Windows.Forms.BindingSource fazaBindingSource;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button izmjeniFazuButton;
        private System.Windows.Forms.Button obrisiFazuButton;
        private System.Windows.Forms.TextBox tboxPretrazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazeprojektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}