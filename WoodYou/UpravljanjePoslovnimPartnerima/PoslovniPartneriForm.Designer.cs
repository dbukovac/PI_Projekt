namespace UpravljanjePoslovnimPartnerima
{
    partial class PoslovniPartneriForm
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
            this.poslPartneriDataGrid = new System.Windows.Forms.DataGridView();
            this.partnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tippartneraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tippartneraBindingSource = new System.Windows.Forms.BindingSource();
            this.tippartnera1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource();
            this.poslPartneriLabel = new System.Windows.Forms.Label();
            this.noviPartnerbutton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.urediButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPretrazi = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.poslPartneriDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippartneraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // poslPartneriDataGrid
            // 
            this.poslPartneriDataGrid.AllowUserToAddRows = false;
            this.poslPartneriDataGrid.AllowUserToDeleteRows = false;
            this.poslPartneriDataGrid.AutoGenerateColumns = false;
            this.poslPartneriDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poslPartneriDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partnerIdDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.tippartneraDataGridViewTextBoxColumn,
            this.tippartnera1DataGridViewTextBoxColumn});
            this.poslPartneriDataGrid.DataSource = this.partnerBindingSource;
            this.poslPartneriDataGrid.Location = new System.Drawing.Point(12, 60);
            this.poslPartneriDataGrid.MultiSelect = false;
            this.poslPartneriDataGrid.Name = "poslPartneriDataGrid";
            this.poslPartneriDataGrid.ReadOnly = true;
            this.poslPartneriDataGrid.Size = new System.Drawing.Size(454, 150);
            this.poslPartneriDataGrid.TabIndex = 0;
            // 
            // partnerIdDataGridViewTextBoxColumn
            // 
            this.partnerIdDataGridViewTextBoxColumn.DataPropertyName = "partnerId";
            this.partnerIdDataGridViewTextBoxColumn.HeaderText = "partnerId";
            this.partnerIdDataGridViewTextBoxColumn.Name = "partnerIdDataGridViewTextBoxColumn";
            this.partnerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tippartneraDataGridViewTextBoxColumn
            // 
            this.tippartneraDataGridViewTextBoxColumn.DataPropertyName = "tip_partnera";
            this.tippartneraDataGridViewTextBoxColumn.DataSource = this.tippartneraBindingSource;
            this.tippartneraDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.tippartneraDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tippartneraDataGridViewTextBoxColumn.HeaderText = "tip_partnera";
            this.tippartneraDataGridViewTextBoxColumn.Name = "tippartneraDataGridViewTextBoxColumn";
            this.tippartneraDataGridViewTextBoxColumn.ReadOnly = true;
            this.tippartneraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tippartneraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tippartneraDataGridViewTextBoxColumn.ValueMember = "kljuc";
            // 
            // tippartneraBindingSource
            // 
            this.tippartneraBindingSource.DataSource = typeof(UpravljanjePoslovnimPartnerima.Tip_partnera);
            // 
            // tippartnera1DataGridViewTextBoxColumn
            // 
            this.tippartnera1DataGridViewTextBoxColumn.DataPropertyName = "Tip_partnera1";
            this.tippartnera1DataGridViewTextBoxColumn.HeaderText = "Tip_partnera1";
            this.tippartnera1DataGridViewTextBoxColumn.Name = "tippartnera1DataGridViewTextBoxColumn";
            this.tippartnera1DataGridViewTextBoxColumn.ReadOnly = true;
            this.tippartnera1DataGridViewTextBoxColumn.Visible = false;
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(UpravljanjePoslovnimPartnerima.Partner);
            // 
            // poslPartneriLabel
            // 
            this.poslPartneriLabel.AutoSize = true;
            this.poslPartneriLabel.Location = new System.Drawing.Point(9, 44);
            this.poslPartneriLabel.Name = "poslPartneriLabel";
            this.poslPartneriLabel.Size = new System.Drawing.Size(88, 13);
            this.poslPartneriLabel.TabIndex = 1;
            this.poslPartneriLabel.Text = "Poslovni partneri:";
            // 
            // noviPartnerbutton
            // 
            this.noviPartnerbutton.Location = new System.Drawing.Point(229, 216);
            this.noviPartnerbutton.Name = "noviPartnerbutton";
            this.noviPartnerbutton.Size = new System.Drawing.Size(75, 23);
            this.noviPartnerbutton.TabIndex = 2;
            this.noviPartnerbutton.Text = "Novi";
            this.noviPartnerbutton.UseVisualStyleBackColor = true;
            this.noviPartnerbutton.Click += new System.EventHandler(this.noviPartnerbutton_Click);
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(391, 216);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiButton.TabIndex = 3;
            this.obrisiButton.Text = "Obrisi";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Visible = false;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // urediButton
            // 
            this.urediButton.Location = new System.Drawing.Point(310, 216);
            this.urediButton.Name = "urediButton";
            this.urediButton.Size = new System.Drawing.Size(75, 23);
            this.urediButton.TabIndex = 4;
            this.urediButton.Text = "Uredi";
            this.urediButton.UseVisualStyleBackColor = true;
            this.urediButton.Click += new System.EventHandler(this.urediButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraživanje po nazivu:";
            // 
            // tboxPretrazi
            // 
            this.tboxPretrazi.Location = new System.Drawing.Point(340, 23);
            this.tboxPretrazi.Name = "tboxPretrazi";
            this.tboxPretrazi.Size = new System.Drawing.Size(126, 20);
            this.tboxPretrazi.TabIndex = 6;
            this.tboxPretrazi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // PoslovniPartneriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 246);
            this.Controls.Add(this.tboxPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urediButton);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.noviPartnerbutton);
            this.Controls.Add(this.poslPartneriLabel);
            this.Controls.Add(this.poslPartneriDataGrid);
            this.helpProvider1.SetHelpKeyword(this, "PoslovniPartneriForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "PoslovniPartneriForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Poslovni partneri";
            this.Load += new System.EventHandler(this.PoslovniPartneriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poslPartneriDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippartneraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView poslPartneriDataGrid;
        private System.Windows.Forms.Label poslPartneriLabel;
        private System.Windows.Forms.Button noviPartnerbutton;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.Button urediButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tippartneraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tippartneraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tippartnera1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPretrazi;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

