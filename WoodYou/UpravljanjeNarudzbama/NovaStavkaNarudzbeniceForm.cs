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
        private List<Stavka_narudzbenice> stavke = new List<Stavka_narudzbenice>();
        private BindingList<Materijal> dodaniMaterijali = new BindingList<Materijal>();
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

        private void NovaStavkaNarudzbenice_Load(object sender, EventArgs e)
        {
            PrikaziMaterijal();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            Materijal trenutniMaterijal = materijalBindingSource.Current as Materijal;
            if(trenutniMaterijal != null)
            {
                bool novaStavka = true;

                foreach(Stavka_narudzbenice stavka in stavke)
                {
                    if(trenutniMaterijal.materijalId == stavka.materijalId)
                    {
                        novaStavka = false;
                        stavka.kolicina += (int)kolicinaNumericUpDown.Value;
                    }
                }

                if(novaStavka)
                {
                    Stavka_narudzbenice stavkaZaDodat = new Stavka_narudzbenice
                    {
                        narudzbenicaId = trenutnaNarudzbenica.narudzbenicaId,
                        materijalId = trenutniMaterijal.materijalId,
                        kolicina = (int)kolicinaNumericUpDown.Value
                    };
                    stavke.Add(stavkaZaDodat);
                    Materijal dodaniMaterijal = new Materijal
                    {
                        materijalId = trenutniMaterijal.materijalId,
                        naziv = trenutniMaterijal.naziv,
                        kolicina = (int)kolicinaNumericUpDown.Value
                    };
                    dodaniMaterijali.Add(dodaniMaterijal);
                    dodaniMaterijalBindingSource.DataSource = dodaniMaterijali;
                }
                else
                {
                    foreach (Materijal materijal in dodaniMaterijali)
                    {
                        if (trenutniMaterijal.materijalId == materijal.materijalId)
                        {
                            materijal.kolicina += (int)kolicinaNumericUpDown.Value;
                        }
                    }
                    dodaniMaterijali.ResetBindings();
                    dodaniMaterijalBindingSource.DataSource = dodaniMaterijali;
                }
            }
        }

        private void SpremiButton_Click(object sender, EventArgs e)
        {
            foreach(Stavka_narudzbenice stavka in stavke)
            {
                using (var db = new UpravljanjeNarudzbamaEntities())
                {
                    db.Stavka_narudzbenice.Add(stavka);
                    db.SaveChanges();
                }
            }
            Close();          
        }
    }
}
