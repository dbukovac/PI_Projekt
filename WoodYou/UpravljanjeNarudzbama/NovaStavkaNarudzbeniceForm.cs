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
            Materijal materijal = materijalBindingSource.Current as Materijal;
            if(materijal != null)
            {
                Stavka_narudzbenice stavka = new Stavka_narudzbenice
                {
                    narudzbenicaId = trenutnaNarudzbenica.narudzbenicaId,
                    materijalId = materijal.materijalId,
                    kolicina = (int)kolicinaNumericUpDown.Value
                };
                stavke.Add(stavka);
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
