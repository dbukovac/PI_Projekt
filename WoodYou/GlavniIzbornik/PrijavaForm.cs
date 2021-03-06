﻿using System;
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
        /// <summary>
        /// Metoda koja se poziva na klik tipke prijavi se, 
        /// iz liste korisnika uspoređuje prema korisničkom imenu, 
        /// te nad pronađenom loznikom poziva funkciju za provjeru lozinke,
        /// iz dll-a Hash.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrijaviSe_Click(object sender, EventArgs e)
        {
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
                this.Show();
            }
            else
            {
                MessageBox.Show("Nesupješna prijava");
            }
        }
    }
}
