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
    public partial class NovaStavkaNarudzbeniceForm : Form
    {
        private Narudzbenica trenutnaNarudzbenica = null;
        /// <summary>
        /// Konstruktor forme
        /// Postavlja trenutnu narudzbenicu
        /// </summary>
        /// <param name="narudzbenica">Narudzbenica na koju se dodaju stavke</param>
        public NovaStavkaNarudzbeniceForm(Narudzbenica narudzbenica)
        {
            InitializeComponent();
            trenutnaNarudzbenica = narudzbenica;
        }
        /// <summary>
        /// Dohvaća i prikazuje materijal dostupan na skladištu
        /// </summary>
        private void PrikaziMaterijal()
        {
            BindingList<Materijal> materijali = null;
            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                materijali = new BindingList<Materijal>(db.Materijal.ToList());
            }
            materijalBindingSource.DataSource = materijali;
        }
        /// <summary>
        /// Dohvaća i prikazuje stavke već dodane na narudzbenicu
        /// </summary>
        private void PrikaziStavke()
        {
            BindingList<Stavka_narudzbenice> stavke = null;
            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                db.Narudzbenica.Attach(trenutnaNarudzbenica);
                db.Entry(trenutnaNarudzbenica).Collection(n => n.Stavka_narudzbenice).Load();
                stavke = new BindingList<Stavka_narudzbenice>(trenutnaNarudzbenica.Stavka_narudzbenice.ToList());
            }
            stavkanarudzbeniceBindingSource.DataSource = stavke;
        }
        /// <summary>
        /// Metoda koja se poziva na učitavanje forme
        /// Poziva metode za prikaz materijala i stavki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovaStavkaNarudzbenice_Load(object sender, EventArgs e)
        {
            PrikaziMaterijal();
            PrikaziStavke();
        }
        /// <summary>
        /// Metoda koja se poziva na klik tipke dodajButton
        /// Provjerava ima li već dodanog materijala na narudžbenici,
        /// ako nema dodaje ga na narudžbenicu, ako ga ima
        /// prikazuje osgovarajuću poruku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DodajButton_Click(object sender, EventArgs e)
        {
            Materijal trenutniMaterijal = materijalBindingSource.Current as Materijal;
            if(trenutniMaterijal != null)
            {
                int dodanaKolicina = (int)kolicinaNumericUpDown.Value;
                if (dodanaKolicina != 0)
                {
                    bool novaStavka = true;

                    foreach (Stavka_narudzbenice stavka in stavkanarudzbeniceBindingSource)
                    {
                        if (trenutniMaterijal.materijalId == stavka.materijalId)
                        {
                            novaStavka = false;
                        }
                    }

                    if (novaStavka)
                    {
                        using (var db = new UpravljanjeNarudzbamaEntities())
                        {
                            Stavka_narudzbenice stavkaZaDodat = new Stavka_narudzbenice
                            {
                                narudzbenicaId = trenutnaNarudzbenica.narudzbenicaId,
                                materijalId = trenutniMaterijal.materijalId,
                                kolicina = dodanaKolicina
                            };
                            db.Stavka_narudzbenice.Add(stavkaZaDodat);
                            db.SaveChanges();
                        }
                        PrikaziStavke();
                    }
                    else
                    {
                        MessageBox.Show("Ne možete dodati istu stavku na narudžbenicu!", "Greška");
                    }
                }
            }
        }
        /// <summary>
        /// Metoda koja se poziva na klik tipke dodajButton
        /// Prikazuje odgovarajuću poruku, na potvrdan odgovor
        /// briše stavku narudžbenice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrisiMaterijalButton_Click(object sender, EventArgs e)
        {
            Stavka_narudzbenice trenutnaStavka = stavkanarudzbeniceBindingSource.Current as Stavka_narudzbenice;
            if (trenutnaStavka != null)
            {
                if (MessageBox.Show("Želite li zaista obrisati stavku narudzbenice?", "Upozorenje", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    using (var db = new UpravljanjeNarudzbamaEntities())
                    {
                        db.Stavka_narudzbenice.Attach(trenutnaStavka);
                        db.Stavka_narudzbenice.Remove(trenutnaStavka);
                        db.SaveChanges();
                    }
                    PrikaziStavke();
                }
            }
        }
        /// <summary>
        /// Zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpremiButton_Click(object sender, EventArgs e)
        {
            Close();          
        }
    }
}
