namespace UpravljanjeProjektima
{
    partial class PopisMaterijalaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.fazeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj materijal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fazeLabel
            // 
            this.fazeLabel.AutoSize = true;
            this.fazeLabel.Location = new System.Drawing.Point(9, 6);
            this.fazeLabel.Name = "fazeLabel";
            this.fazeLabel.Size = new System.Drawing.Size(49, 13);
            this.fazeLabel.TabIndex = 7;
            this.fazeLabel.Text = "Materijal:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // PopisMaterijalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fazeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopisMaterijalaForm";
            this.Text = "PopisMaterijalaFOrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fazeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}