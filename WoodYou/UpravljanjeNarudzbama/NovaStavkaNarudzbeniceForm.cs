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
        public NovaStavkaNarudzbeniceForm(Narudzbenica narudzbenica)
        {
            InitializeComponent();
            trenutnaNarudzbenica = narudzbenica;
        }

        private void PrikaziMaterijal()
        {
            BindingList<Materijal> materijali = null;
            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                materijali = new BindingList<Materijal>(db.Materijal.ToList());
            }
            materijalBindingSource.DataSource = materijali;
        }

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

        private void NovaStavkaNarudzbenice_Load(object sender, EventArgs e)
        {
            PrikaziMaterijal();
            PrikaziStavke();
        }

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

        private void SpremiButton_Click(object sender, EventArgs e)
        {
            Close();          
        }
    }
}
