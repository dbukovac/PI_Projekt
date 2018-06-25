namespace GlavniIzbornik
{
    partial class GlavnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledProjekataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledNarudžbiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledSkladistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izdavanjeRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poslovniPartneriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentiToolStripMenuItem,
            this.narudžbeToolStripMenuItem,
            this.skladisteToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.poslovniPartneriToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledProjekataToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.klijentiToolStripMenuItem.Text = "Projekti";
            // 
            // pregledProjekataToolStripMenuItem
            // 
            this.pregledProjekataToolStripMenuItem.Name = "pregledProjekataToolStripMenuItem";
            this.pregledProjekataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.pregledProjekataToolStripMenuItem.Text = "Pregled projekata";
            this.pregledProjekataToolStripMenuItem.Click += new System.EventHandler(this.PregledProjekataToolStripMenuItem_Click);
            // 
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledNarudžbiToolStripMenuItem});
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            // 
            // pregledNarudžbiToolStripMenuItem
            // 
            this.pregledNarudžbiToolStripMenuItem.Name = "pregledNarudžbiToolStripMenuItem";
            this.pregledNarudžbiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pregledNarudžbiToolStripMenuItem.Text = "Pregled narudžbi";
            this.pregledNarudžbiToolStripMenuItem.Click += new System.EventHandler(this.PregledNarudžbiToolStripMenuItem_Click);
            // 
            // skladisteToolStripMenuItem
            // 
            this.skladisteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledSkladistaToolStripMenuItem,
            this.primkeToolStripMenuItem});
            this.skladisteToolStripMenuItem.Name = "skladisteToolStripMenuItem";
            this.skladisteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.skladisteToolStripMenuItem.Text = "Skladište";
            // 
            // pregledSkladistaToolStripMenuItem
            // 
            this.pregledSkladistaToolStripMenuItem.Name = "pregledSkladistaToolStripMenuItem";
            this.pregledSkladistaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pregledSkladistaToolStripMenuItem.Text = "Pregled skladišta";
            this.pregledSkladistaToolStripMenuItem.Click += new System.EventHandler(this.PregledSkladistaToolStripMenuItem_Click);
            // 
            // primkeToolStripMenuItem
            // 
            this.primkeToolStripMenuItem.Name = "primkeToolStripMenuItem";
            this.primkeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.primkeToolStripMenuItem.Text = "Pregled primki";
            this.primkeToolStripMenuItem.Click += new System.EventHandler(this.PrimkeToolStripMenuItem_Click);
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledRacunaToolStripMenuItem,
            this.izdavanjeRacunaToolStripMenuItem});
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            // 
            // pregledRacunaToolStripMenuItem
            // 
            this.pregledRacunaToolStripMenuItem.Name = "pregledRacunaToolStripMenuItem";
            this.pregledRacunaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pregledRacunaToolStripMenuItem.Text = "Pregled računa";
            this.pregledRacunaToolStripMenuItem.Click += new System.EventHandler(this.PregledRacunaToolStripMenuItem_Click);
            // 
            // izdavanjeRacunaToolStripMenuItem
            // 
            this.izdavanjeRacunaToolStripMenuItem.Name = "izdavanjeRacunaToolStripMenuItem";
            this.izdavanjeRacunaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.izdavanjeRacunaToolStripMenuItem.Text = "Izdavanje računa";
            this.izdavanjeRacunaToolStripMenuItem.Click += new System.EventHandler(this.IzdavanjeRacunaToolStripMenuItem_Click);
            // 
            // poslovniPartneriToolStripMenuItem
            // 
            this.poslovniPartneriToolStripMenuItem.Name = "poslovniPartneriToolStripMenuItem";
            this.poslovniPartneriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.poslovniPartneriToolStripMenuItem.Text = "Poslovni partneri";
            this.poslovniPartneriToolStripMenuItem.Click += new System.EventHandler(this.PoslovniPartneriToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.StatistikaToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Visible = false;
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.KorisniciToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.OdjavaToolStripMenuItem_Click);
            // 
            // GlavnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForm";
            this.Text = "WoodYou";
            this.Load += new System.EventHandler(this.GlavnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skladisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poslovniPartneriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledProjekataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledNarudžbiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledSkladistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izdavanjeRacunaToolStripMenuItem;
    }
}