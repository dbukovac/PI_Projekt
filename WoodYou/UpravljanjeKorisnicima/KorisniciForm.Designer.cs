﻿namespace UpravljanjeKorisnicima
{
    partial class KorisniciForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.korisnikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipkorisnikaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipkorisnikaBindingSource = new System.Windows.Forms.BindingSource();
            this.tipkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource();
            this.label1 = new System.Windows.Forms.Label();
            this.noviButton = new System.Windows.Forms.Button();
            this.izmjeniButton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.tboxPretrazi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikIdDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.tipkorisnikaIdDataGridViewTextBoxColumn,
            this.tipkorisnikaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.korisnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // korisnikIdDataGridViewTextBoxColumn
            // 
            this.korisnikIdDataGridViewTextBoxColumn.DataPropertyName = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.HeaderText = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.Name = "korisnikIdDataGridViewTextBoxColumn";
            this.korisnikIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "korisnicko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lozinkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipkorisnikaIdDataGridViewTextBoxColumn
            // 
            this.tipkorisnikaIdDataGridViewTextBoxColumn.DataPropertyName = "tip_korisnikaId";
            this.tipkorisnikaIdDataGridViewTextBoxColumn.DataSource = this.tipkorisnikaBindingSource;
            this.tipkorisnikaIdDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.tipkorisnikaIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tipkorisnikaIdDataGridViewTextBoxColumn.HeaderText = "tip korisnika";
            this.tipkorisnikaIdDataGridViewTextBoxColumn.Name = "tipkorisnikaIdDataGridViewTextBoxColumn";
            this.tipkorisnikaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipkorisnikaIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipkorisnikaIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipkorisnikaIdDataGridViewTextBoxColumn.ValueMember = "tip_korisnikaId";
            // 
            // tipkorisnikaBindingSource
            // 
            this.tipkorisnikaBindingSource.DataSource = typeof(UpravljanjeKorisnicima.Tip_korisnika);
            // 
            // tipkorisnikaDataGridViewTextBoxColumn
            // 
            this.tipkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "Tip_korisnika";
            this.tipkorisnikaDataGridViewTextBoxColumn.HeaderText = "Tip_korisnika";
            this.tipkorisnikaDataGridViewTextBoxColumn.Name = "tipkorisnikaDataGridViewTextBoxColumn";
            this.tipkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipkorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(UpravljanjeKorisnicima.Korisnik);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisnici:";
            // 
            // noviButton
            // 
            this.noviButton.Location = new System.Drawing.Point(231, 260);
            this.noviButton.Name = "noviButton";
            this.noviButton.Size = new System.Drawing.Size(69, 23);
            this.noviButton.TabIndex = 2;
            this.noviButton.Text = "Novi";
            this.noviButton.UseVisualStyleBackColor = true;
            this.noviButton.Click += new System.EventHandler(this.noviButton_Click);
            // 
            // izmjeniButton
            // 
            this.izmjeniButton.Location = new System.Drawing.Point(306, 260);
            this.izmjeniButton.Name = "izmjeniButton";
            this.izmjeniButton.Size = new System.Drawing.Size(75, 23);
            this.izmjeniButton.TabIndex = 3;
            this.izmjeniButton.Text = "Izmjeni";
            this.izmjeniButton.UseVisualStyleBackColor = true;
            this.izmjeniButton.Click += new System.EventHandler(this.izmjeniButton_Click);
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(387, 260);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiButton.TabIndex = 4;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // tboxPretrazi
            // 
            this.tboxPretrazi.Location = new System.Drawing.Point(336, 12);
            this.tboxPretrazi.Name = "tboxPretrazi";
            this.tboxPretrazi.Size = new System.Drawing.Size(126, 20);
            this.tboxPretrazi.TabIndex = 8;
            this.tboxPretrazi.TextChanged += new System.EventHandler(this.tboxPretrazi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pretraživanje po nazivu:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // KorisniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 290);
            this.Controls.Add(this.tboxPretrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.izmjeniButton);
            this.Controls.Add(this.noviButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.helpProvider1.SetHelpKeyword(this, "KorisniciForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "KorisniciForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.KorisniciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button noviButton;
        private System.Windows.Forms.Button izmjeniButton;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.BindingSource tipkorisnikaBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipkorisnikaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tboxPretrazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

