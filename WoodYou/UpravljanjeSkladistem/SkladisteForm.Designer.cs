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
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalLabel = new System.Windows.Forms.Label();
            this.noviMaterijalButton = new System.Windows.Forms.Button();
            this.urediMaterijalButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
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
            this.cijena,
            this.dataGridViewTextBoxColumn4});
            this.materijalDataGridView.DataSource = this.materijalBindingSource;
            this.materijalDataGridView.Location = new System.Drawing.Point(15, 25);
            this.materijalDataGridView.Name = "materijalDataGridView";
            this.materijalDataGridView.ReadOnly = true;
            this.materijalDataGridView.Size = new System.Drawing.Size(519, 394);
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
            // cijena
            // 
            this.cijena.DataPropertyName = "cijena";
            this.cijena.HeaderText = "Cijena";
            this.cijena.Name = "cijena";
            this.cijena.ReadOnly = true;
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
            // materijalLabel
            // 
            this.materijalLabel.AutoSize = true;
            this.materijalLabel.Location = new System.Drawing.Point(12, 9);
            this.materijalLabel.Name = "materijalLabel";
            this.materijalLabel.Size = new System.Drawing.Size(46, 13);
            this.materijalLabel.TabIndex = 3;
            this.materijalLabel.Text = "Materijal";
            // 
            // noviMaterijalButton
            // 
            this.noviMaterijalButton.Location = new System.Drawing.Point(452, 425);
            this.noviMaterijalButton.Name = "noviMaterijalButton";
            this.noviMaterijalButton.Size = new System.Drawing.Size(82, 23);
            this.noviMaterijalButton.TabIndex = 6;
            this.noviMaterijalButton.Text = "Novi materijal";
            this.noviMaterijalButton.UseVisualStyleBackColor = true;
            this.noviMaterijalButton.Click += new System.EventHandler(this.NoviMaterijalButton_Click);
            // 
            // urediMaterijalButton
            // 
            this.urediMaterijalButton.Enabled = false;
            this.urediMaterijalButton.Location = new System.Drawing.Point(361, 425);
            this.urediMaterijalButton.Name = "urediMaterijalButton";
            this.urediMaterijalButton.Size = new System.Drawing.Size(85, 23);
            this.urediMaterijalButton.TabIndex = 7;
            this.urediMaterijalButton.Text = "Uredi materijal";
            this.urediMaterijalButton.UseVisualStyleBackColor = true;
            this.urediMaterijalButton.Visible = false;
            this.urediMaterijalButton.Click += new System.EventHandler(this.UrediMaterijalButton_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help.chm";
            // 
            // SkladisteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 456);
            this.Controls.Add(this.urediMaterijalButton);
            this.Controls.Add(this.noviMaterijalButton);
            this.Controls.Add(this.materijalLabel);
            this.Controls.Add(this.materijalDataGridView);
            this.helpProvider1.SetHelpKeyword(this, "SkladišteForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "SkladisteForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Stanje na skladištu";
            this.Load += new System.EventHandler(this.SkladisteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materijalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.DataGridView materijalDataGridView;
        private System.Windows.Forms.Label materijalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button noviMaterijalButton;
        private System.Windows.Forms.Button urediMaterijalButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

