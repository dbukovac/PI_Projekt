namespace UpravljanjeSkladistem
{
    partial class NoviMaterijalForm
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
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label nazivLabel;
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spremiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.kolicinaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cijenaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            cijenaLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.Location = new System.Drawing.Point(41, 61);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 1;
            cijenaLabel.Text = "Cijena:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(41, 87);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(47, 13);
            kolicinaLabel.TabIndex = 3;
            kolicinaLabel.Text = "Količina:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(41, 35);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 7;
            nazivLabel.Text = "Naziv:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materijalBindingSource, "naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(107, 32);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 8;
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(UpravljanjeSkladistem.Materijal);
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(92, 126);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 9;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.SpremiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(173, 126);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 10;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            // 
            // kolicinaNumericUpDown
            // 
            this.kolicinaNumericUpDown.Location = new System.Drawing.Point(107, 85);
            this.kolicinaNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kolicinaNumericUpDown.Name = "kolicinaNumericUpDown";
            this.kolicinaNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.kolicinaNumericUpDown.TabIndex = 11;
            // 
            // cijenaNumericUpDown
            // 
            this.cijenaNumericUpDown.DecimalPlaces = 2;
            this.cijenaNumericUpDown.Location = new System.Drawing.Point(107, 59);
            this.cijenaNumericUpDown.Name = "cijenaNumericUpDown";
            this.cijenaNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.cijenaNumericUpDown.TabIndex = 12;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\..\\..\\packages\\HTML help\\help.chm";
            // 
            // NoviMaterijalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 161);
            this.Controls.Add(this.cijenaNumericUpDown);
            this.Controls.Add(this.kolicinaNumericUpDown);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.helpProvider1.SetHelpKeyword(this, "NoviMaterijalForm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "NoviMaterijalForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Novi materijal";
            this.Load += new System.EventHandler(this.NoviMaterijalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijenaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.NumericUpDown kolicinaNumericUpDown;
        private System.Windows.Forms.NumericUpDown cijenaNumericUpDown;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}