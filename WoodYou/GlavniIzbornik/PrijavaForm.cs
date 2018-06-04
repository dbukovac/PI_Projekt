using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hash;

namespace GlavniIzbornik
{
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            HashKlasa hash = new HashKlasa();
            Korisnik logirani_korisnik = null;

            using(var db = new GlavniIzbornikEntities())
            {
                List<Korisnik> listaKorisnika = new List<Korisnik>(db.Korisnik.ToList());
                foreach (var kor in listaKorisnika)
                {
                    if(kor.korisnicko_ime == textboxKorime.Text)
                    {
                        var provjera = HashKlasa.Verify(textBoxLozinka.Text, kor.lozinka);
                        if(provjera == true)
                        {
                            logirani_korisnik = kor;
                        }
                    }
                }
            }
            if(logirani_korisnik != null)
            {
                GlavnaForm forma = new GlavnaForm(logirani_korisnik);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nesupješna prijava");
            }
        }

        private void postaviLozinkuButton_Click(object sender, EventArgs e)
        {
            HashKlasa hash = new HashKlasa();
            bool provjera = false;
            using(var db = new GlavniIzbornikEntities())
            {
                List<Korisnik> listaKorisnika = new List<Korisnik>(db.Korisnik.ToList());
                foreach (var kor in listaKorisnika)
                {
                    if (kor.korisnicko_ime == textboxKorime.Text)
                    {
                        db.Korisnik.Attach(kor);
                        kor.lozinka = HashKlasa.Hash(textBoxLozinka.Text);
                        db.SaveChanges();
                        provjera = true;
                    }
                }
            }
            if(provjera == true)
            {
                MessageBox.Show("Uspješno postavljanje lozinke");
            }
            else
            {
                MessageBox.Show("Neuspješno postavljanje lozinke");
            }
        }
    }
}
