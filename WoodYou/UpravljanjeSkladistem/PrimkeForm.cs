using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeSkladistem
{
    public partial class PrimkeForm : Form
    {
        public PrimkeForm()
        {
            InitializeComponent();
        }

        private void PrikazPrimki()
        {
            BindingList<Primka> primke = null;
            BindingList<Korisnik> korisnici = null;
            BindingList<Partner> partneri = null;
            using (var db = new UpraljanjeSkladistemEntities())
            {
                primke = new BindingList<Primka>(db.Primka.ToList());
                korisnici = new BindingList<Korisnik>();
                partneri = new BindingList<Partner>();
                foreach (Primka primka in primke)
                {
                    korisnici.Add(primka.Korisnik);
                    partneri.Add(primka.Partner);
                }
            }
            korisnikBindingSource.DataSource = korisnici;
            partnerBindingSource.DataSource = partneri;
            primkaBindingSource.DataSource = primke;
        }
        
        private void PrikazStavki(Primka primka)
        {
            BindingList<Stavka_primke> stavke = null;
            BindingList<Materijal> materijali = null;
            using(var db = new UpraljanjeSkladistemEntities())
            {
                db.Primka.Attach(primka);
                stavke = new BindingList<Stavka_primke>(primka.Stavka_primke.ToList<Stavka_primke>());
                materijali = new BindingList<Materijal>();
                foreach (Stavka_primke stavka in stavke)
                {
                    materijali.Add(stavka.Materijal);
                }
            }
            stavka_primkeBindingSource.DataSource = stavke;
            materijalBindingSource.DataSource = materijali;
        }

        private void PrimkeForm_Load(object sender, EventArgs e)
        {
            PrikazPrimki();
            Primka primka = primkaBindingSource.Current as Primka;
            if(primka != null)
            {
                PrikazStavki(primka);
            }
        }

        private void PrimkaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Primka primka = primkaBindingSource.Current as Primka;
            if (primka != null)
            {
                PrikazStavki(primka);
            }
        }

        private void BrisiPrimkuButton_Click(object sender, EventArgs e)
        {
            Primka primka = primkaBindingSource.Current as Primka;
            if (primka != null)
            {
                if(MessageBox.Show("Želite li zaista izbrisati primku?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpraljanjeSkladistemEntities())
                    {
                        db.Primka.Attach(primka);
                        db.Primka.Remove(primka);
                        db.SaveChanges();
                    }

                    PrikazPrimki();
                    primka = primkaBindingSource.Current as Primka;
                    if (primka != null)
                    {
                        PrikazStavki(primka);
                    }
                }
            }
        }

        private void NovaPrimkaButton_Click(object sender, EventArgs e)
        {
            NovaPrimkaForm novaPrimkaForm = new NovaPrimkaForm();
            novaPrimkaForm.ShowDialog(this);
            PrikazPrimki();
        }

        private void UrediPrimkuButton_Click(object sender, EventArgs e)
        {
            Primka trenutnaPrimka = primkaBindingSource.Current as Primka;
            NovaPrimkaForm novaPrimkaForm = new NovaPrimkaForm(trenutnaPrimka);
            novaPrimkaForm.ShowDialog(this);
            PrikazPrimki();
        }

        private void NovaStavkaButton_Click(object sender, EventArgs e)
        {
            Primka trenutnaPrimka = primkaBindingSource.Current as Primka;
            NovaStavkaPrimkeForm novaStavkaPrimkeForm = new NovaStavkaPrimkeForm(trenutnaPrimka);
            novaStavkaPrimkeForm.ShowDialog(this);
            PrikazPrimki();
        }

        private void BrisiStavkuButton_Click(object sender, EventArgs e)
        {
            Stavka_primke trenutnaStavka = stavka_primkeBindingSource.Current as Stavka_primke;
            if (trenutnaStavka != null)
            {
                if (MessageBox.Show("Želite li zaista izbrisati stavku?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpraljanjeSkladistemEntities())
                    {
                        db.Stavka_primke.Attach(trenutnaStavka);
                        db.Stavka_primke.Remove(trenutnaStavka);
                        db.SaveChanges();
                    }
                }
            }
            PrikazPrimki();
        }
    }
}
