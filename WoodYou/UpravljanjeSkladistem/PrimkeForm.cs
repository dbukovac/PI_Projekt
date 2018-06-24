using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace UpravljanjeSkladistem
{
    public partial class PrimkeForm : Form
    {
        BindingList<Materijal> materijali = null;
        BindingList<Stavka_primke> stavke = null;
        int tipKorisnika = 0;
        int idKorisnika = 0;
        /// <summary>
        /// Konstruktor forme PrimkeForm. Postavlja tip i ID prijavljenog korisnika.
        /// </summary>
        /// <param name="tipKorisnika">Tip ulogiranog korisnika</param>
        /// <param name="idKorisnika">ID ulogiranog korisnika</param>
        public PrimkeForm(int tipKorisnika, int idKorisnika)
        {
            InitializeComponent();
            this.tipKorisnika = tipKorisnika;
            this.idKorisnika = idKorisnika;
        }
        /// <summary>
        /// Metoda koja dohvaća primke i, korisnike i partnere vezane uz primku.
        /// Postavlja DataSource-ove za prikaz podataka.
        /// </summary>
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
        /// <summary>
        /// Dohvaća sve stavke za određenu primku, te dohvaća materijale vezane uz stavke.
        /// Postavlja DataSource-ove za prikaz podataka.
        /// </summary>
        /// <param name="primka">Primka za koju ispisujemo stavke</param>
        private void PrikazStavki(Primka primka)
        {
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
        /// <summary>
        /// Dohvaća sve listu svih materijala na skladištu za provjeru količine.
        /// </summary>
        private void DohvatiMaterijale()
        {
            using (var db = new UpraljanjeSkladistemEntities())
            {
                materijali = new BindingList<Materijal>(db.Materijal.ToList());
            }
        }
        /// <summary>
        /// Provjerava ima li dovoljno materijala na skladištu za skinuti.
        /// Služi kako ne bi stanje materijala na skladištu palo ispod 0,
        /// prilikom brisanja primke.
        /// </summary>
        /// <param name="stavka">Stavka koja se provjerava</param>
        /// <returns>Vraća true ako ima dovoljno materijala, false ako nema.</returns>
        private bool ProvjeraSkladista(Stavka_primke stavka)
        {
            DohvatiMaterijale();
            if (stavka != null)
            {
                Materijal materijal = materijali.SingleOrDefault(m => m.materijalId == stavka.materijalId);
                if(materijal != null && materijal.kolicina >= stavka.kolicina)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme.
        /// Poziva funkciju za prikaz primki i prikaz stavki za označenu primku
        /// Omogućuje tipku za brisanje primki ako je tip korisnika administrator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrimkeForm_Load(object sender, EventArgs e)
        {
            PrikazPrimki();
            Primka primka = primkaBindingSource.Current as Primka;
            if(primka != null)
            {
                PrikazStavki(primka);
            }
            materijali = new BindingList<Materijal>();
            if(tipKorisnika == 1)
            {
                brisiPrimkuButton.Enabled = true;
                brisiPrimkuButton.Visible = true;
            }
        }
        /// <summary>
        /// Metoda koja se poziva kada se označi neka druga primka.
        /// Poziva se metoda za prikaz stavki za označenu primku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrimkaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Primka primka = primkaBindingSource.Current as Primka;
            if (primka != null)
            {
                PrikazStavki(primka);
            }
        }
        /// <summary>
        /// Metoda koja se poziva na klik tipke brisiPrimkuButton,
        /// koja služi za brisanje primki.
        /// Provjerava ima li stavki na primci, te ako nema dozvoljava
        /// brisanje primke, ako ne onda prikazuje odgovrajuću poruku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrisiPrimkuButton_Click(object sender, EventArgs e)
        {
            Primka primka = primkaBindingSource.Current as Primka;
            if (primka != null)
            {
                if(MessageBox.Show("Želite li zaista izbrisati primku?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    if(stavke.Count == 0)
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
                    else
                    {
                        MessageBox.Show("Nije moguće obrisati primku sa stavkama!", "Greška!");
                    }
                }
            }
        }
        /// <summary>
        /// Metoda koja se poziva na klik tipke novaPrimkaButton,
        /// koja služi za otvaranje forme za unos nove primke.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovaPrimkaButton_Click(object sender, EventArgs e)
        {
            NovaPrimkaForm novaPrimkaForm = new NovaPrimkaForm(idKorisnika);
            novaPrimkaForm.ShowDialog(this);
            PrikazPrimki();
        }
        /// <summary>
        /// Metoda koja se poziva na klik tipke urediPrimkuButton,
        /// koja služi za uređivanje primki.
        /// Otvara formu za novu primku u modu za uređivanje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UrediPrimkuButton_Click(object sender, EventArgs e)
        {
            Primka trenutnaPrimka = primkaBindingSource.Current as Primka;
            NovaPrimkaForm novaPrimkaForm = new NovaPrimkaForm(trenutnaPrimka);
            novaPrimkaForm.ShowDialog(this);
            PrikazPrimki();
        }
        /// <summary>
        /// Metoda koja se poziva na klik tipke novaStavkaButton,
        /// koja služi za dodavanje stavki na primku.
        /// Otvara formu za dodavanje stavki na primku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovaStavkaButton_Click(object sender, EventArgs e)
        {
            Primka trenutnaPrimka = primkaBindingSource.Current as Primka;
            NovaStavkaPrimkeForm novaStavkaPrimkeForm = new NovaStavkaPrimkeForm(trenutnaPrimka);
            novaStavkaPrimkeForm.ShowDialog(this);
            PrikazPrimki();
        }
        /// <summary>
        /// Metoda kojom se mogu brisati stavke primke.
        /// Poziva metodu za provjeru skladišta te ako je
        /// moguće briše se stavka primke.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrisiStavkuButton_Click(object sender, EventArgs e)
        {
            Stavka_primke trenutnaStavka = stavka_primkeBindingSource.Current as Stavka_primke;
            if (trenutnaStavka != null)
            {
                if (MessageBox.Show("Želite li zaista izbrisati stavku?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    if(ProvjeraSkladista(trenutnaStavka))
                    {
                        using (var db = new UpraljanjeSkladistemEntities())
                        {
                            db.Stavka_primke.Attach(trenutnaStavka);
                            db.Stavka_primke.Remove(trenutnaStavka);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nema dovoljno materijala na skladištu za brisanje stavke!", "Greška!");
                    }
                }
            }
            PrikazPrimki();
        }
    }
}
