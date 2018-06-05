using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeKorisnicima
{
    public partial class KorisniciForm : Form
    {
        public KorisniciForm()
        {
            InitializeComponent();
        }

        private void KorisniciForm_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();
        }

        private void PrikaziKorisnike()
        {
            BindingList<Korisnik> listaKorisnika = null;
            BindingList<Tip_korisnika> listaTipova = new BindingList<Tip_korisnika>();
            using(var db = new UpravljanjeKorisnicimaEntities())
            {
                listaKorisnika = new BindingList<Korisnik>(db.Korisnik.ToList());
                foreach (Korisnik kor in listaKorisnika)
                {
                    listaTipova.Add(kor.Tip_korisnika);
                }
            }
            korisnikBindingSource.DataSource = listaKorisnika;
            tipkorisnikaBindingSource.DataSource = listaTipova;
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            Korisnik selektiraniKorisnik = korisnikBindingSource.Current as Korisnik;
            if(selektiraniKorisnik != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using(var db = new UpravljanjeKorisnicimaEntities())
                    {
                        db.Korisnik.Attach(selektiraniKorisnik);
                        db.Korisnik.Remove(selektiraniKorisnik);
                        db.SaveChanges();
                    }
                    PrikaziKorisnike();
                    MessageBox.Show("Uspješno obrisan korisnik");
                }
            }
        }

        private void noviButton_Click(object sender, EventArgs e)
        {
            NoviKorisnikForm forma = new NoviKorisnikForm();
            forma.ShowDialog();
            PrikaziKorisnike();
        }

        private void izmjeniButton_Click(object sender, EventArgs e)
        {
            Korisnik selektiraniKorisnik = korisnikBindingSource.Current as Korisnik;
            if(selektiraniKorisnik != null)
            {
                NoviKorisnikForm forma = new NoviKorisnikForm(selektiraniKorisnik);
                forma.ShowDialog();
                PrikaziKorisnike();
            }
        }
    }
}
