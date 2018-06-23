using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeNarudzbama
{
    public partial class NarudzbeForm : Form
    {
        public NarudzbeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda kojom se dohvaca lista narudzenice, 
        /// korisnik koji je izdao narudzbenicu i dobavljac 
        /// od kojeg su proizvodi naruceni.
        /// </summary>
        private void PrikazNarudzbi()
        {
            BindingList<Narudzbenica> narudzbenice = null;
            BindingList<Partner> partneri = null;
            BindingList<Korisnik> korisnici = null;

            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                korisnici = new BindingList<Korisnik>();
                partneri = new BindingList<Partner>();
                narudzbenice = new BindingList<Narudzbenica>(db.Narudzbenica.ToList());
                foreach (Narudzbenica narudzbenica in narudzbenice)
                {
                    korisnici.Add(narudzbenica.Korisnik);
                    partneri.Add(narudzbenica.Partner);
                }
            }
            narudzbenicaBindingSource.DataSource = narudzbenice;
            partnerBindingSource.DataSource = partneri;
            korisnikBindingSource.DataSource = korisnici;
        }
        /// <summary>
        /// Metoda kojom se dohvacaju lista stavki 
        /// narudzbenice i proizvod u stavki
        /// </summary>
        /// <param name="narudzbenica">Narudzbenica cije stavke zelimo prikazati</param>
        private void PrikazStavki(Narudzbenica narudzbenica)
        {
            BindingList<Stavka_narudzbenice> stavke = null;
            BindingList<Materijal> materijali = null;

            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                materijali = new BindingList<Materijal>();
                db.Narudzbenica.Attach(narudzbenica);
                stavke = new BindingList<Stavka_narudzbenice>(narudzbenica.Stavka_narudzbenice.ToList());
                foreach (Stavka_narudzbenice stavka in stavke)
                {
                    materijali.Add(stavka.Materijal);
                }
            }
            stavkanarudzbeniceBindingSource.DataSource = stavke;
            materijalBindingSource.DataSource = materijali;
        }
        private void NarudzbeForm_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
        }
        private void NarudzbeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            if (narudzbenica != null)
            {
                PrikazStavki(narudzbenica);
            }
        }
        private void NovaNarudzbaButton_Click(object sender, EventArgs e)
        {
            NovaNarudzbenicaForm novaNarudzbenicaForm = new NovaNarudzbenicaForm();
            novaNarudzbenicaForm.ShowDialog(this);
            PrikazNarudzbi();
        }
        private void UrediNarudzbuButton_Click(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            if (narudzbenica != null)
            {
                NovaNarudzbenicaForm novaNarudzbenicaForm = new NovaNarudzbenicaForm(narudzbenica);
                novaNarudzbenicaForm.ShowDialog(this);
                PrikazNarudzbi();
            }
        }
        private void NovaStavkaButton_Click(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            if (narudzbenica != null)
            {
                NovaStavkaNarudzbeniceForm novaStavkaForm = new NovaStavkaNarudzbeniceForm(narudzbenica);
                novaStavkaForm.ShowDialog(this);
                PrikazNarudzbi();
            }
        }

        private void ObrisiNarudzbuButton_Click(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            if (narudzbenica != null)
            {
                if (MessageBox.Show("Želite li zaista izbrisati narudžbenicu?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpravljanjeNarudzbamaEntities())
                    {
                        db.Narudzbenica.Attach(narudzbenica);
                        db.Narudzbenica.Remove(narudzbenica);
                        db.SaveChanges();
                    }
                    PrikazNarudzbi();
                }
            }
        }
        private void ObrisiStavkuButton_Click(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            Stavka_narudzbenice stavka = stavkanarudzbeniceBindingSource.Current as Stavka_narudzbenice;
            if (stavka != null)
            {
                if (MessageBox.Show("Želite li zaista izbrisati stavku?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpravljanjeNarudzbamaEntities())
                    {
                        db.Stavka_narudzbenice.Attach(stavka);
                        db.Stavka_narudzbenice.Remove(stavka);
                        db.SaveChanges();
                    }
                    PrikazStavki(narudzbenica);
                }
            }
        }

        private void IspisNarudzbeniceButton_Click(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            if(narudzbenica != null)
            {
                NarudzbeReportForm reportForm = new NarudzbeReportForm(narudzbenica);
                reportForm.ShowDialog(this);
            }
        }
    }
}
