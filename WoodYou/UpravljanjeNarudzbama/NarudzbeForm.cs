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
        private int tipKorisnika = 0;
        private int idKorisnika = 0;
        public NarudzbeForm(int tipKorisnika, int idKorisnika)
        {
            InitializeComponent();
            this.tipKorisnika = tipKorisnika;
            this.idKorisnika = idKorisnika;
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
        /// <summary>
        /// Metoda koja se poziva na učitavanje forme.
        /// Poziva metodu za prikaz narudžbi.
        /// Provjerava je li tip korisnika administrator,
        /// ako je omogućuje tipku za brisanje narudzbenice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NarudzbeForm_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
            if(tipKorisnika == 1)
            {
                obrisiNarudzbuButton.Enabled = true;
                obrisiNarudzbuButton.Visible = true;
            }
        }
        /// <summary>
        /// Metoda koja se poziva na promjenu izbora narudžbe.
        /// Poziva metodu za prikazivanje stavke trenutne narudzbenice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NarudzbeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            if (narudzbenica != null)
            {
                PrikazStavki(narudzbenica);
            }
        }
        /// <summary>
        /// Metoda koja se poziva na klik tipke novaNarudzbaButton.
        /// Otvara formu NovaNarudzbaForm
        /// Poziva metodu za prikaz narudzbi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovaNarudzbaButton_Click(object sender, EventArgs e)
        {
            NovaNarudzbenicaForm novaNarudzbenicaForm = new NovaNarudzbenicaForm(idKorisnika);
            novaNarudzbenicaForm.ShowDialog(this);
            PrikazNarudzbi();
        }
        /// <summary>
        /// Metoda koja se poziva na pritisak tipke urediNarudzbzbuButton
        /// Otvara formu NovaNarudzbaForm u modu za uređivanje
        /// Poziva metodu za dohvaćanje narudžbi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoda koja se poziva na klik tipke novaStavkaButton
        /// Otvara formu NovaStavkaNarudzbeniceForm
        /// Poziva metodu za prikazivanje narudzbe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoda koja se poziva na klik tipke obrisiNarudzbuButton.
        /// Prikazuje odgovarajuću poruku te ako se odgovori potvrdno
        /// briše se narudžbenica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoda koja se poziva na klik tipke obrisiStavkuButton.
        /// Prikazuje odgovarajuću poruku te ako se odgovori potvrdno
        /// briše se stavka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoda koja se poziva na klik tipke ispisNarudzbeniceButton.
        /// Prikazuje formu za prikaz dokumenta narudžbenice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
