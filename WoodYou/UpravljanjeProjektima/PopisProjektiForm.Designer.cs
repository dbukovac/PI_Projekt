namespace UpravljanjeProjektima
{
    partial class PopisProjektiForm
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
            this.projektiDataGridView = new System.Windows.Forms.DataGridView();
            this.fazeDataGridView = new System.Windows.Forms.DataGridView();
            this.noviProjektButton = new System.Windows.Forms.Button();
            this.brisiProjektButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fazeLabel = new System.Windows.Forms.Label();
            this.projektiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projektiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // projektiDataGridView
            // 
            this.projektiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projektiDataGridView.Location = new System.Drawing.Point(12, 22);
            this.projektiDataGridView.Name = "projektiDataGridView";
            this.projektiDataGridView.Size = new System.Drawing.Size(776, 322);
            this.projektiDataGridView.TabIndex = 0;
            // 
            // fazeDataGridView
            // 
            this.fazeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fazeDataGridView.Location = new System.Drawing.Point(12, 405);
            this.fazeDataGridView.Name = "fazeDataGridView";
            this.fazeDataGridView.Size = new System.Drawing.Size(776, 150);
            this.fazeDataGridView.TabIndex = 1;
            // 
            // noviProjektButton
            // 
            this.noviProjektButton.Location = new System.Drawing.Point(632, 350);
            this.noviProjektButton.Name = "noviProjektButton";
            this.noviProjektButton.Size = new System.Drawing.Size(75, 23);
            this.noviProjektButton.TabIndex = 2;
            this.noviProjektButton.Text = "Novi projekt";
            this.noviProjektButton.UseVisualStyleBackColor = true;
            // 
            // brisiProjektButton
            // 
            this.brisiProjektButton.Location = new System.Drawing.Point(713, 350);
            this.brisiProjektButton.Name = "brisiProjektButton";
            this.brisiProjektButton.Size = new System.Drawing.Size(75, 23);
            this.brisiProjektButton.TabIndex = 3;
            this.brisiProjektButton.Text = "Briši projekt";
            this.brisiProjektButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Briši fazu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dodaj fazu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fazeLabel
            // 
            this.fazeLabel.AutoSize = true;
            this.fazeLabel.Location = new System.Drawing.Point(9, 389);
            this.fazeLabel.Name = "fazeLabel";
            this.fazeLabel.Size = new System.Drawing.Size(33, 13);
            this.fazeLabel.TabIndex = 6;
            this.fazeLabel.Text = "Faze:";
            // 
            // projektiLabel
            // 
            this.projektiLabel.AutoSize = true;
            this.projektiLabel.Location = new System.Drawing.Point(9, 6);
            this.projektiLabel.Name = "projektiLabel";
            this.projektiLabel.Size = new System.Drawing.Size(45, 13);
            this.projektiLabel.TabIndex = 7;
            this.projektiLabel.Text = "Projekti:";
            // 
            // PopisProjektiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.projektiLabel);
            this.Controls.Add(this.fazeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.brisiProjektButton);
            this.Controls.Add(this.noviProjektButton);
            this.Controls.Add(this.fazeDataGridView);
            this.Controls.Add(this.projektiDataGridView);
            this.Name = "PopisProjektiForm";
            this.Text = "Pregled projekata";
            ((System.ComponentModel.ISupportInitialize)(this.projektiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView projektiDataGridView;
        private System.Windows.Forms.DataGridView fazeDataGridView;
        private System.Windows.Forms.Button noviProjektButton;
        private System.Windows.Forms.Button brisiProjektButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label fazeLabel;
        private System.Windows.Forms.Label projektiLabel;
    }
}

