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

        private void PrikazNarudzbi()
        {
            BindingList<Narudzbenica> narudzbenice = null;
            BindingList<Korisnik> korisnici = new BindingList<Korisnik>();
            BindingList<Partner> partneri = new BindingList<Partner>();
            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                narudzbenice = new BindingList<Narudzbenica>(db.Narudzbenica.ToList());
                foreach(Narudzbenica narudzbenica in narudzbenice)
                {
                    korisnici.Add(narudzbenica.Korisnik);
                    partneri.Add(narudzbenica.Partner);
                }
            }
            narudzbenicaBindingSource.DataSource = narudzbenice;
            partnerBindingSource.DataSource = partneri;
            korisnikBindingSource.DataSource = korisnici;
        }

        private void PrikazStavki(Narudzbenica narudzbenica)
        {
            BindingList<Stavka_narudzbenice> stavke = null;
            BindingList<Materijal> materijali = new BindingList<Materijal>();
            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                db.Narudzbenica.Attach(narudzbenica);
                stavke = new BindingList<Stavka_narudzbenice>(narudzbenica.Stavka_narudzbenice.ToList());
                foreach(Stavka_narudzbenice stavka in stavke)
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
            PrikazStavki(narudzbenicaBindingSource.Current as Narudzbenica);
        }

        private void NarudzbeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            if(narudzbenica != null)
            {
                PrikazStavki(narudzbenica);
            }
        }
    }
}
