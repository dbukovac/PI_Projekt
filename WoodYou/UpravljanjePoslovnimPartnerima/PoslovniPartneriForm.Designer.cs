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
            this.poslPartneriLabel = new System.Windows.Forms.Label();
            this.noviPartnerbutton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.urediButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poslPartneriDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // poslPartneriDataGrid
            // 
            this.poslPartneriDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poslPartneriDataGrid.Location = new System.Drawing.Point(15, 25);
            this.poslPartneriDataGrid.Name = "poslPartneriDataGrid";
            this.poslPartneriDataGrid.Size = new System.Drawing.Size(577, 150);
            this.poslPartneriDataGrid.TabIndex = 0;
            // 
            // poslPartneriLabel
            // 
            this.poslPartneriLabel.AutoSize = true;
            this.poslPartneriLabel.Location = new System.Drawing.Point(12, 9);
            this.poslPartneriLabel.Name = "poslPartneriLabel";
            this.poslPartneriLabel.Size = new System.Drawing.Size(88, 13);
            this.poslPartneriLabel.TabIndex = 1;
            this.poslPartneriLabel.Text = "Poslovni partneri:";
            // 
            // noviPartnerbutton
            // 
            this.noviPartnerbutton.Location = new System.Drawing.Point(355, 181);
            this.noviPartnerbutton.Name = "noviPartnerbutton";
            this.noviPartnerbutton.Size = new System.Drawing.Size(75, 23);
            this.noviPartnerbutton.TabIndex = 2;
            this.noviPartnerbutton.Text = "Novi";
            this.noviPartnerbutton.UseVisualStyleBackColor = true;
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(517, 181);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiButton.TabIndex = 3;
            this.obrisiButton.Text = "Obrisi";
            this.obrisiButton.UseVisualStyleBackColor = true;
            // 
            // urediButton
            // 
            this.urediButton.Location = new System.Drawing.Point(436, 181);
            this.urediButton.Name = "urediButton";
            this.urediButton.Size = new System.Drawing.Size(75, 23);
            this.urediButton.TabIndex = 4;
            this.urediButton.Text = "Uredi";
            this.urediButton.UseVisualStyleBackColor = true;
            // 
            // PoslovniPartneriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 218);
            this.Controls.Add(this.urediButton);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.noviPartnerbutton);
            this.Controls.Add(this.poslPartneriLabel);
            this.Controls.Add(this.poslPartneriDataGrid);
            this.Name = "PoslovniPartneriForm";
            this.Text = "Poslovni partneri";
            ((System.ComponentModel.ISupportInitialize)(this.poslPartneriDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView poslPartneriDataGrid;
        private System.Windows.Forms.Label poslPartneriLabel;
        private System.Windows.Forms.Button noviPartnerbutton;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.Button urediButton;
    }
}

