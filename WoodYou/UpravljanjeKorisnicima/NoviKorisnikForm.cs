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
using System.Xml.Linq;

namespace UpravljanjeKorisnicima
{
    public partial class NoviKorisnikForm : Form
    {
        private Korisnik odabraniKorisnik = null;

        private string staroKorime = null;

        public NoviKorisnikForm()
        {
            InitializeComponent();
        }

        public NoviKorisnikForm(Korisnik korisnik)
        {
            InitializeComponent();
            odabraniKorisnik = korisnik;
        }
        /// <summary>
        /// Ako se radi o izmjeni, polja se pune podacima označenog korisnika,
        /// lozinka se dohvaća pomoću metode dohvatiLozinku, sprema se staro korisničko ime,
        /// za ažuriranje xml datoteke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                tboxLozinka.Text = dohvatiLozinku(odabraniKorisnik.korisnicko_ime);
                cboxTip.Text = odabraniKorisnik.Tip_korisnika.naziv;

                staroKorime = odabraniKorisnik.korisnicko_ime;
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Spremanje podataka iz polja, ako je novi korisnik kreira se objekt podacima iz polja,
        /// lozinka se pretvara u hash oblika pomoću metode Hash iz HashKlase dll-a Hash,
        /// kreira se zapis lozinke u čitljivom obliku u xml datoteci
        /// Ako je izmjena nova lozinka se hash-ira i sprema se izmjenjena lozinka u čitljivom obliku u xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                kreirajZapis(tboxKorime.Text, tboxLozinka.Text);
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
                spremiLozinku(staroKorime, tboxLozinka.Text, tboxKorime.Text);
            }
            MessageBox.Show("Uspješno dodan korisnik");
        }
        
        /// <summary>
        /// Metoda za spremanje izmjenjene lozinke i korisničkog imena u xml datoteku prema
        /// starom korisničkom imenu
        /// </summary>
        /// <param name="staroKorime"></param>
        /// <param name="lozinka"></param>
        /// <param name="novoKorime"></param>
        private void spremiLozinku(string staroKorime, string lozinka, string novoKorime)
        {
            XDocument doc = XDocument.Load("../../../UpravljanjeKorisnicima/Lozinke.xml");
            foreach (var korisnik in doc.Descendants("korisnik"))
            {
                if ((string)korisnik.Attribute("korisnicko_ime") == staroKorime)
                {
                    korisnik.SetAttributeValue("lozinka", lozinka);
                    korisnik.SetAttributeValue("korisnicko_ime", novoKorime);
                }
            }
            doc.Save("../../../UpravljanjeKorisnicima/Lozinke.xml");
        }
        /// <summary>
        /// Metoda za učitavanje lozinke u čitljivom obliku iz xml datoteke preko korisničkog imena
        /// </summary>
        /// <param name="korime"></param>
        /// <returns></returns>
        private string dohvatiLozinku(string korime)
        {
            string izlaz = "";
            XDocument doc = XDocument.Load("../../../UpravljanjeKorisnicima/Lozinke.xml");
            foreach (var korisnik in doc.Elements("korisnici"))
            {
                foreach (var atributi in korisnik.Descendants("korisnik"))
                {
                    if ((string)atributi.Attribute("korisnicko_ime") == korime)
                    {
                        izlaz = (string)atributi.Attribute("lozinka");
                    }
                }
            }
            return izlaz;
        }
        /// <summary>
        /// Metoda za spremanje nove lozinke korisničkog imena u xml datoteku
        /// </summary>
        /// <param name="korime"></param>
        /// <param name="lozinka"></param>
        private void kreirajZapis(string korime, string lozinka)
        {
            XDocument doc = XDocument.Load("../../../UpravljanjeKorisnicima/Lozinke.xml");
            XElement korisnik = new XElement("korisnik", new XAttribute("korisnicko_ime", korime), new XAttribute("lozinka", lozinka));
            XElement pozicija = doc.Element("korisnici");
            pozicija.Add(korisnik);
            doc.Save("../../../UpravljanjeKorisnicima/Lozinke.xml");
        }
    }
}
