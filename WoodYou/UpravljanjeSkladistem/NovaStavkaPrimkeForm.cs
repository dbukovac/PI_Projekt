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
    public partial class NovaStavkaPrimkeForm : Form
    {
        Primka trenutnaPrimka = null;
        BindingList<Materijal> materijali = null;
        /// <summary>
        /// Konstruktor forme.
        /// Postavlja trenutnu primku.
        /// </summary>
        /// <param name="primka"></param>
        public NovaStavkaPrimkeForm(Primka primka)
        {
            InitializeComponent();
            trenutnaPrimka = primka;
        }
        /// <summary>
        /// Dohvaća materijale dostupne u sustavu
        /// </summary>
        private void DohvatiMaterijale()
        {
            materijali = new BindingList<Materijal>();
            using (var db = new UpraljanjeSkladistemEntities())
            {
                materijali = new BindingList<Materijal>(db.Materijal.ToList());
            }
            materijalBindingSource.DataSource = materijali;
        }
        /// <summary>
        /// Dohvaća stavke već dodane na primku.
        /// </summary>
        private void DohvatiStavke()
        {
            BindingList<Stavka_primke> stavke = null;
            using (var db = new UpraljanjeSkladistemEntities())
            {
                db.Primka.Attach(trenutnaPrimka);
                db.Entry(trenutnaPrimka).Collection(p => p.Stavka_primke).Load();
                stavke = new BindingList<Stavka_primke>(trenutnaPrimka.Stavka_primke.ToList());
            }
            stavkaprimkeBindingSource.DataSource = stavke;
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
                if (materijal != null && materijal.kolicina >= stavka.kolicina)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Metoda koja se poziva klikom na tipku dodajMaterijalButton.
        /// Provjerava ima li dodanog materijala već na primci, ako nema
        /// dodaje ga na primku, ako da onda ispisuje ogovarajuću poruku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DodajMaterijalButton_Click(object sender, EventArgs e)
        {
            Materijal trenutniMaterijal = materijalBindingSource.Current as Materijal;
            if (trenutniMaterijal != null)
            {
                int dodanaKolicina = (int)kolicinaNumericUpDown.Value;
                if (dodanaKolicina != 0)
                {
                    bool novaStavka = true;

                    foreach (Stavka_primke stavka in stavkaprimkeBindingSource)
                    {
                        if (trenutniMaterijal.materijalId == stavka.materijalId)
                        {
                            novaStavka = false;
                        }
                    }

                    if (novaStavka)
                    {
                        using (var db = new UpraljanjeSkladistemEntities())
                        {
                            Stavka_primke stavkaZaDodat = new Stavka_primke
                            {
                                primkaId = trenutnaPrimka.primkaId,
                                materijalId = trenutniMaterijal.materijalId,
                                kolicina = dodanaKolicina
                            };
                            db.Stavka_primke.Add(stavkaZaDodat);
                            db.SaveChanges();
                        }
                        DohvatiStavke();
                    }
                    else
                    {
                        MessageBox.Show("Ne možete dodati istu stavku na primku!", "Greška");
                    }
                }
            }
        }
        /// <summary>
        /// Metoda koja se poziva na klik tipke brisiMaterijalButton
        /// Poziva metodu za provjeru skladista.
        /// Brise materijal sa primke ako može
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrisiMaterijalButton_Click(object sender, EventArgs e)
        {
            Stavka_primke trenutnaStavka = stavkaprimkeBindingSource.Current as Stavka_primke;
            if (trenutnaStavka != null)
            {
                if(MessageBox.Show("Želite li zaista obrisati stavku primke?", "Upozorenje", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    if(ProvjeraSkladista(trenutnaStavka))
                    {
                        using (var db = new UpraljanjeSkladistemEntities())
                        {
                            db.Stavka_primke.Attach(trenutnaStavka);
                            db.Stavka_primke.Remove(trenutnaStavka);
                            db.SaveChanges();
                        }
                        DohvatiStavke();
                    }
                    else
                    {
                        MessageBox.Show("Nema dovoljno materijala na skladištu za brisanje stavke!", "Greška!");
                    }
                }
            }
        }
        /// <summary>
        /// Metoda koja se pozica na ureduButton
        /// Zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UreduButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Poziva se na učitavanje forme.
        /// Poziva metodu za dohvaćanje materijala i stavki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovaStavkaPrimkeForm_Load(object sender, EventArgs e)
        {
            DohvatiMaterijale();
            DohvatiStavke();
        }
    }
}
