using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hash;

namespace UpravljanjeKorisnicima
{
    public partial class NoviKorisnikForm : Form
    {
        private Korisnik odabraniKorisnik = null;

        public NoviKorisnikForm()
        {
            InitializeComponent();
        }

        public NoviKorisnikForm(Korisnik korisnik)
        {
            InitializeComponent();
            odabraniKorisnik = korisnik;
        }

        private void NoviKorisnikForm_Load(object sender, EventArgs e)
        {
            BindingList<Tip_korisnika> listaTipova = null;
            using(var db = new UpravljanjeKorisnicimaEntities())
            {
                listaTipova = new BindingList<Tip_korisnika>(db.Tip_korisnika.ToList());
            }
            tipkorisnikaBindingSource.DataSource = listaTipova;
            if (odabraniKorisnik != null)
            {
                tboxIme.Text = odabraniKorisnik.ime;
                tboxKorime.Text = odabraniKorisnik.korisnicko_ime;
                tboxPrezime.Text = odabraniKorisnik.prezime;
                tboxLozinka.Text = "x";
                cboxTip.Text = odabraniKorisnik.Tip_korisnika.naziv;
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if(odabraniKorisnik == null)
            {
                using(var db = new UpravljanjeKorisnicimaEntities())
                {
                    Korisnik noviKorisnik = new Korisnik
                    {
                        ime = tboxIme.Text,
                        prezime = tboxPrezime.Text,
                        korisnicko_ime = tboxKorime.Text,
                        lozinka = HashKlasa.Hash(tboxLozinka.Text),
                        tip_korisnikaId = int.Parse(cboxTip.SelectedValue.ToString())
                    };
                    db.Korisnik.Add(noviKorisnik);
                    db.SaveChanges();
                }
            }
            else
            {
                using(var db = new UpravljanjeKorisnicimaEntities())
                {
                    db.Korisnik.Attach(odabraniKorisnik);
                    odabraniKorisnik.ime = tboxIme.Text;
                    odabraniKorisnik.prezime = tboxPrezime.Text;
                    odabraniKorisnik.lozinka = HashKlasa.Hash(tboxLozinka.Text);
                    odabraniKorisnik.korisnicko_ime = tboxKorime.Text;
                    odabraniKorisnik.tip_korisnikaId = int.Parse(cboxTip.SelectedValue.ToString());
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Uspješno dodan korisnik");
        }
    }
}
