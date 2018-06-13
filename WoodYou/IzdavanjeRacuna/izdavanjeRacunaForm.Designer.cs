namespace IzdavanjeRacuna
{
    partial class IzdavanjeRacunaForm
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
            this.ProjektidataGridView = new System.Windows.Forms.DataGridView();
            this.projektIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potrebnovrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumzavrsetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenabezpdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznospdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gotovoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.izdajRacunButton = new System.Windows.Forms.Button();
            this.pregledRačunaButton = new System.Windows.Forms.Button();
            this.tboxPretrazi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProjektidataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjektidataGridView
            // 
            this.ProjektidataGridView.AutoGenerateColumns = false;
            this.ProjektidataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjektidataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projektIdDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.datumpocetkaDataGridViewTextBoxColumn,
            this.potrebnovrijemeDataGridViewTextBoxColumn,
            this.datumzavrsetkaDataGridViewTextBoxColumn,
            this.ukupnacijenaDataGridViewTextBoxColumn,
            this.cijenabezpdvDataGridViewTextBoxColumn,
            this.iznospdvDataGridViewTextBoxColumn,
            this.korisnikIdDataGridViewTextBoxColumn,
            this.partnerIdDataGridViewTextBoxColumn,
            this.gotovoDataGridViewTextBoxColumn,
            this.aktivanDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.partnerDataGridViewTextBoxColumn});
            this.ProjektidataGridView.DataSource = this.projektBindingSource;
            this.ProjektidataGridView.Location = new System.Drawing.Point(12, 50);
            this.ProjektidataGridView.MultiSelect = false;
            this.ProjektidataGridView.Name = "ProjektidataGridView";
            this.ProjektidataGridView.ReadOnly = true;
            this.ProjektidataGridView.Size = new System.Drawing.Size(653, 235);
            this.ProjektidataGridView.TabIndex = 0;
            // 
            // projektIdDataGridViewTextBoxColumn
            // 
            this.projektIdDataGridViewTextBoxColumn.DataPropertyName = "projektId";
            this.projektIdDataGridViewTextBoxColumn.HeaderText = "projektId";
            this.projektIdDataGridViewTextBoxColumn.Name = "projektIdDataGridViewTextBoxColumn";
            this.projektIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.projektIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumpocetkaDataGridViewTextBoxColumn
            // 
            this.datumpocetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_pocetka";
            this.datumpocetkaDataGridViewTextBoxColumn.HeaderText = "datum_pocetka";
            this.datumpocetkaDataGridViewTextBoxColumn.Name = "datumpocetkaDataGridViewTextBoxColumn";
            this.datumpocetkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumpocetkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // potrebnovrijemeDataGridViewTextBoxColumn
            // 
            this.potrebnovrijemeDataGridViewTextBoxColumn.DataPropertyName = "potrebno_vrijeme";
            this.potrebnovrijemeDataGridViewTextBoxColumn.HeaderText = "potrebno_vrijeme";
            this.potrebnovrijemeDataGridViewTextBoxColumn.Name = "potrebnovrijemeDataGridViewTextBoxColumn";
            this.potrebnovrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            this.potrebnovrijemeDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumzavrsetkaDataGridViewTextBoxColumn
            // 
            this.datumzavrsetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_zavrsetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.HeaderText = "datum_zavrsetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.Name = "datumzavrsetkaDataGridViewTextBoxColumn";
            this.datumzavrsetkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumzavrsetkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ukupnacijenaDataGridViewTextBoxColumn
            // 
            this.ukupnacijenaDataGridViewTextBoxColumn.DataPropertyName = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.HeaderText = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.Name = "ukupnacijenaDataGridViewTextBoxColumn";
            this.ukupnacijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenabezpdvDataGridViewTextBoxColumn
            // 
            this.cijenabezpdvDataGridViewTextBoxColumn.DataPropertyName = "cijena_bez_pdv";
            this.cijenabezpdvDataGridViewTextBoxColumn.HeaderText = "cijena_bez_pdv";
            this.cijenabezpdvDataGridViewTextBoxColumn.Name = "cijenabezpdvDataGridViewTextBoxColumn";
            this.cijenabezpdvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznospdvDataGridViewTextBoxColumn
            // 
            this.iznospdvDataGridViewTextBoxColumn.DataPropertyName = "iznos_pdv";
            this.iznospdvDataGridViewTextBoxColumn.HeaderText = "iznos_pdv";
            this.iznospdvDataGridViewTextBoxColumn.Name = "iznospdvDataGridViewTextBoxColumn";
            this.iznospdvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikIdDataGridViewTextBoxColumn
            // 
            this.korisnikIdDataGridViewTextBoxColumn.DataPropertyName = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.DataSource = this.korisnikBindingSource;
            this.korisnikIdDataGridViewTextBoxColumn.DisplayMember = "korisnicko_ime";
            this.korisnikIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.korisnikIdDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikIdDataGridViewTextBoxColumn.Name = "korisnikIdDataGridViewTextBoxColumn";
            this.korisnikIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.korisnikIdDataGridViewTextBoxColumn.ValueMember = "korisnikId";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(IzdavanjeRacuna.Korisnik);
            // 
            // partnerIdDataGridViewTextBoxColumn
            // 
            this.partnerIdDataGridViewTextBoxColumn.DataPropertyName = "partnerId";
            this.partnerIdDataGridViewTextBoxColumn.DataSource = this.partnerBindingSource;
            this.partnerIdDataGridViewTextBoxColumn.DisplayMember = "ime";
            this.partnerIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.partnerIdDataGridViewTextBoxColumn.HeaderText = "partner";
            this.partnerIdDataGridViewTextBoxColumn.Name = "partnerIdDataGridViewTextBoxColumn";
            this.partnerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partnerIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partnerIdDataGridViewTextBoxColumn.ValueMember = "partnerId";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(IzdavanjeRacuna.Partner);
            // 
            // gotovoDataGridViewTextBoxColumn
            // 
            this.gotovoDataGridViewTextBoxColumn.DataPropertyName = "gotovo";
            this.gotovoDataGridViewTextBoxColumn.HeaderText = "gotovo";
            this.gotovoDataGridViewTextBoxColumn.Name = "gotovoDataGridViewTextBoxColumn";
            this.gotovoDataGridViewTextBoxColumn.ReadOnly = true;
            this.gotovoDataGridViewTextBoxColumn.Visible = false;
            // 
            // aktivanDataGridViewTextBoxColumn
            // 
            this.aktivanDataGridViewTextBoxColumn.DataPropertyName = "aktivan";
            this.aktivanDataGridViewTextBoxColumn.HeaderText = "aktivan";
            this.aktivanDataGridViewTextBoxColumn.Name = "aktivanDataGridViewTextBoxColumn";
            this.aktivanDataGridViewTextBoxColumn.ReadOnly = true;
            this.aktivanDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // partnerDataGridViewTextBoxColumn
            // 
            this.partnerDataGridViewTextBoxColumn.DataPropertyName = "Partner";
            this.partnerDataGridViewTextBoxColumn.HeaderText = "Partner";
            this.partnerDataGridViewTextBoxColumn.Name = "partnerDataGridViewTextBoxColumn";
            this.partnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerDataGridViewTextBoxColumn.Visible = false;
            // 
            // projektBindingSource
            // 
            this.projektBindingSource.DataSource = typeof(IzdavanjeRacuna.Projekt);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projekti:";
            // 
            // izdajRacunButton
            // 
            this.izdajRacunButton.Location = new System.Drawing.Point(457, 291);
            this.izdajRacunButton.Name = "izdajRacunButton";
            this.izdajRacunButton.Size = new System.Drawing.Size(75, 23);
            this.izdajRacunButton.TabIndex = 2;
            this.izdajRacunButton.Text = "Izdaj račun";
            this.izdajRacunButton.UseVisualStyleBackColor = true;
            this.izdajRacunButton.Click += new System.EventHandler(this.izdajRacunButton_Click);
            // 
            // pregledRačunaButton
            // 
            this.pregledRačunaButton.Location = new System.Drawing.Point(538, 291);
            this.pregledRačunaButton.Name = "pregledRačunaButton";
            this.pregledRačunaButton.Size = new System.Drawing.Size(127, 23);
            this.pregledRačunaButton.TabIndex = 3;
            this.pregledRačunaButton.Text = "Pregled izdanih računa";
            this.pregledRačunaButton.UseVisualStyleBackColor = true;
            this.pregledRačunaButton.Click += new System.EventHandler(this.pregledRačunaButton_Click);
            // 
            // tboxPretrazi
            // 
            this.tboxPretrazi.Location = new System.Drawing.Point(538, 12);
            this.tboxPretrazi.Name = "tboxPretrazi";
            this.tboxPretrazi.Size = new System.Drawing.Size(127, 20);
            this.tboxPretrazi.TabIndex = 4;
            this.tboxPretrazi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pretraživanje po nazivu:";
            // 
            // IzdavanjeRacunaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxPretrazi);
            this.Controls.Add(this.pregledRačunaButton);
            this.Controls.Add(this.izdajRacunButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjektidataGridView);
            this.Name = "IzdavanjeRacunaForm";
            this.Text = "Izdavanje Računa";
            this.Load += new System.EventHandler(this.izdavanjeRacunaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjektidataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProjektidataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projektIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potrebnovrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumzavrsetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenabezpdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznospdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn partnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gotovoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projektBindingSource;
        private System.Windows.Forms.Button izdajRacunButton;
        private System.Windows.Forms.Button pregledRačunaButton;
        private System.Windows.Forms.TextBox tboxPretrazi;
        private System.Windows.Forms.Label label2;
    }
}

