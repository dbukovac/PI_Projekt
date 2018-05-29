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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fazeLabel = new System.Windows.Forms.Label();
            this.novaFazaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.novaFazaButton.Location = new System.Drawing.Point(227, 181);
            this.novaFazaButton.Name = "novaFazaButton";
            this.novaFazaButton.Size = new System.Drawing.Size(75, 23);
            this.novaFazaButton.TabIndex = 2;
            this.novaFazaButton.Text = "Pregled faza";
            this.novaFazaButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj fazu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PopisFazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.novaFazaButton);
            this.Controls.Add(this.fazeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopisFazaForm";
            this.Text = "Faze";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label fazeLabel;
        private System.Windows.Forms.Button novaFazaButton;
        private System.Windows.Forms.Button button1;
    }
}