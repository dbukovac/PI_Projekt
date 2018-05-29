namespace UpravljanjeProjektima
{
    partial class NovaFazaForm
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
            this.fazeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fazeDataGridView = new System.Windows.Forms.DataGridView();
            this.projektiLabel = new System.Windows.Forms.Label();
            this.brisiProjektButton = new System.Windows.Forms.Button();
            this.noviProjektButton = new System.Windows.Forms.Button();
            this.projektiDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fazeLabel
            // 
            this.fazeLabel.AutoSize = true;
            this.fazeLabel.Location = new System.Drawing.Point(7, 18);
            this.fazeLabel.Name = "fazeLabel";
            this.fazeLabel.Size = new System.Drawing.Size(33, 13);
            this.fazeLabel.TabIndex = 10;
            this.fazeLabel.Text = "Faze:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Briši fazu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Dodaj fazu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fazeDataGridView
            // 
            this.fazeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fazeDataGridView.Location = new System.Drawing.Point(10, 34);
            this.fazeDataGridView.Name = "fazeDataGridView";
            this.fazeDataGridView.Size = new System.Drawing.Size(776, 150);
            this.fazeDataGridView.TabIndex = 7;
            // 
            // projektiLabel
            // 
            this.projektiLabel.AutoSize = true;
            this.projektiLabel.Location = new System.Drawing.Point(12, 212);
            this.projektiLabel.Name = "projektiLabel";
            this.projektiLabel.Size = new System.Drawing.Size(49, 13);
            this.projektiLabel.TabIndex = 14;
            this.projektiLabel.Text = "Materijal:";
            // 
            // brisiProjektButton
            // 
            this.brisiProjektButton.Location = new System.Drawing.Point(702, 367);
            this.brisiProjektButton.Name = "brisiProjektButton";
            this.brisiProjektButton.Size = new System.Drawing.Size(86, 23);
            this.brisiProjektButton.TabIndex = 13;
            this.brisiProjektButton.Text = "Briši materijal";
            this.brisiProjektButton.UseVisualStyleBackColor = true;
            // 
            // noviProjektButton
            // 
            this.noviProjektButton.Location = new System.Drawing.Point(608, 367);
            this.noviProjektButton.Name = "noviProjektButton";
            this.noviProjektButton.Size = new System.Drawing.Size(88, 23);
            this.noviProjektButton.TabIndex = 12;
            this.noviProjektButton.Text = "Dodaj materijal";
            this.noviProjektButton.UseVisualStyleBackColor = true;
            // 
            // projektiDataGridView
            // 
            this.projektiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projektiDataGridView.Location = new System.Drawing.Point(12, 228);
            this.projektiDataGridView.Name = "projektiDataGridView";
            this.projektiDataGridView.Size = new System.Drawing.Size(774, 133);
            this.projektiDataGridView.TabIndex = 11;
            // 
            // NovaFazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projektiLabel);
            this.Controls.Add(this.brisiProjektButton);
            this.Controls.Add(this.noviProjektButton);
            this.Controls.Add(this.projektiDataGridView);
            this.Controls.Add(this.fazeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fazeDataGridView);
            this.Name = "NovaFazaForm";
            this.Text = "NovaFazaForm";
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fazeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView fazeDataGridView;
        private System.Windows.Forms.Label projektiLabel;
        private System.Windows.Forms.Button brisiProjektButton;
        private System.Windows.Forms.Button noviProjektButton;
        private System.Windows.Forms.DataGridView projektiDataGridView;
    }
}