namespace UpravljanjeSkladistem
{
    partial class NovaPrimkaForm
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
            System.Windows.Forms.Label datumPrimitkaLabel;
            System.Windows.Forms.Label korisnikIdLabel;
            System.Windows.Forms.Label partnerIdLabel;
            this.datumPrimitkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.primkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerComboBox = new System.Windows.Forms.ComboBox();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTextBox = new System.Windows.Forms.TextBox();
            this.dodaniMaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ureduButton = new System.Windows.Forms.Button();
            datumPrimitkaLabel = new System.Windows.Forms.Label();
            korisnikIdLabel = new System.Windows.Forms.Label();
            partnerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datumPrimitkaLabel
            // 
            datumPrimitkaLabel.AutoSize = true;
            datumPrimitkaLabel.Location = new System.Drawing.Point(12, 21);
            datumPrimitkaLabel.Name = "datumPrimitkaLabel";
            datumPrimitkaLabel.Size = new System.Drawing.Size(80, 13);
            datumPrimitkaLabel.TabIndex = 1;
            datumPrimitkaLabel.Text = "Datum primitka:";
            // 
            // korisnikIdLabel
            // 
            korisnikIdLabel.AutoSize = true;
            korisnikIdLabel.Location = new System.Drawing.Point(12, 47);
            korisnikIdLabel.Name = "korisnikIdLabel";
            korisnikIdLabel.Size = new System.Drawing.Size(47, 13);
            korisnikIdLabel.TabIndex = 3;
            korisnikIdLabel.Text = "Korisnik:";
            // 
            // partnerIdLabel
            // 
            partnerIdLabel.AutoSize = true;
            partnerIdLabel.Location = new System.Drawing.Point(12, 73);
            partnerIdLabel.Name = "partnerIdLabel";
            partnerIdLabel.Size = new System.Drawing.Size(44, 13);
            partnerIdLabel.TabIndex = 5;
            partnerIdLabel.Text = "Partner:";
            // 
            // datumPrimitkaDateTimePicker
            // 
            this.datumPrimitkaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.primkaBindingSource, "datumPrimitka", true));
            this.datumPrimitkaDateTimePicker.Enabled = false;
            this.datumPrimitkaDateTimePicker.Location = new System.Drawing.Point(97, 17);
            this.datumPrimitkaDateTimePicker.Name = "datumPrimitkaDateTimePicker";
            this.datumPrimitkaDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.datumPrimitkaDateTimePicker.TabIndex = 2;
            // 
            // primkaBindingSource
            // 
            this.primkaBindingSource.DataSource = typeof(UpravljanjeSkladistem.Primka);
            // 
            // partnerComboBox
            // 
            this.partnerComboBox.DataSource = this.partnerBindingSource;
            this.partnerComboBox.DisplayMember = "ime";
            this.partnerComboBox.FormattingEnabled = true;
            this.partnerComboBox.Location = new System.Drawing.Point(97, 69);
            this.partnerComboBox.Name = "partnerComboBox";
            this.partnerComboBox.Size = new System.Drawing.Size(133, 21);
            this.partnerComboBox.TabIndex = 7;
            this.partnerComboBox.ValueMember = "partnerId";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(UpravljanjeSkladistem.Partner);
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeSkladistem.Materijal);
            // 
            // korisnikTextBox
            // 
            this.korisnikTextBox.Location = new System.Drawing.Point(97, 43);
            this.korisnikTextBox.Name = "korisnikTextBox";
            this.korisnikTextBox.ReadOnly = true;
            this.korisnikTextBox.Size = new System.Drawing.Size(133, 20);
            this.korisnikTextBox.TabIndex = 8;
            // 
            // dodaniMaterijalBindingSource
            // 
            this.dodaniMaterijalBindingSource.DataSource = typeof(UpravljanjeSkladistem.Materijal);
            // 
            // ureduButton
            // 
            this.ureduButton.Location = new System.Drawing.Point(172, 97);
            this.ureduButton.Name = "ureduButton";
            this.ureduButton.Size = new System.Drawing.Size(75, 23);
            this.ureduButton.TabIndex = 12;
            this.ureduButton.Text = "U redu";
            this.ureduButton.UseVisualStyleBackColor = true;
            this.ureduButton.Click += new System.EventHandler(this.UreduButton_Click);
            // 
            // NovaPrimkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 132);
            this.Controls.Add(this.ureduButton);
            this.Controls.Add(this.korisnikTextBox);
            this.Controls.Add(this.partnerComboBox);
            this.Controls.Add(datumPrimitkaLabel);
            this.Controls.Add(this.datumPrimitkaDateTimePicker);
            this.Controls.Add(korisnikIdLabel);
            this.Controls.Add(partnerIdLabel);
            this.Name = "NovaPrimkaForm";
            this.Text = "NovaPrimkaForm";
            this.Load += new System.EventHandler(this.NovaPrimkaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodaniMaterijalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource primkaBindingSource;
        private System.Windows.Forms.DateTimePicker datumPrimitkaDateTimePicker;
        private System.Windows.Forms.ComboBox partnerComboBox;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.TextBox korisnikTextBox;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.BindingSource dodaniMaterijalBindingSource;
        private System.Windows.Forms.Button ureduButton;
    }
}