using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzdavanjeRacuna
{
    public partial class IzdavanjeRacunaForm : Form
    {
        private int tipKorisnika = 0;
        public IzdavanjeRacunaForm(int tipKorisnika)
        {
            InitializeComponent();
            this.tipKorisnika = tipKorisnika;
        }
        /// <summary>
        /// Prilikom učitavanja forme poziva se metoda za prikaz projekata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izdavanjeRacunaForm_Load(object sender, EventArgs e)
        {
            PrikaziRacune();
        }
        /// <summary>
        /// Metoda za generiranje praznog korisnika koja se koristi
        /// kako se nebi javljala greška ukoliko nema računa za ispisati
        /// </summary>
        /// <param name="lista"></param>
        private void generirajPrazniKorisnik(BindingList<Korisnik> lista)
        {
            Korisnik prazniKorisnik = new Korisnik
            {
                korisnicko_ime = "nema",
                korisnikId = 0
            };
            lista.Add(prazniKorisnik);
            korisnikBindingSource.DataSource = lista;
        }
        /// <summary>
        /// Metoda za generiranje praznog partnera koja se koristi
        /// kako se nebi javljala greška ukoliko nema računa za ispisati
        /// </summary>
        /// <param name="lista"></param>
        private void generirajPrazniPartner(BindingList<Partner> lista)
        {
            Partner prazniPartner = new Partner
            {
                partnerId = 0,
                ime = "nema"
            };
            lista.Add(prazniPartner);
            partnerBindingSource.DataSource = lista;
        }
        /// <summary>
        /// Metoda za provjeru ako su sve faze prosljeđenog projekta zaključane(gotove)
        /// </summary>
        /// <param name="projekt"></param>
        /// <returns></returns>
        private bool ProvjeriZavrsenostFaza(Projekt projekt)
        {
            List<Faze_projekta> listaFaza = null;
            bool zavrseno = true;
            listaFaza = new List<Faze_projekta>(projekt.Faze_projekta.ToList());
            foreach (var F in listaFaza)
            {
                if(F.zakljucano == 0)
                {
                    zavrseno = false;
                }
            }
            return zavrseno;
        }
        /// <summary>
        /// Metoda za prikaz svih projekata koji su aktivni, za koje nije izdan račun i
        /// kojima su sve faze završene. Ukoliko ne postoji niti jedan takav pozivaju se 
        /// metode za generiranje praznih polja. Dohvaćaju se podaci za korisnike i partnere,
        /// kako bi se prikazali nazivi umjesto id-eva
        /// </summary>
        /// <returns></returns>
        private BindingList<Projekt> PrikaziRacune()
        {
            BindingList<Projekt> Projekti = null;
            BindingList<Projekt> listaProjekta = new BindingList<Projekt>();
            BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
            BindingList<Partner> listaPartnera = new BindingList<Partner>();
            using (var db = new IzdavanjeRacunEntities())
            {
                Projekti = new BindingList<Projekt>(db.Projekt.ToList());
                foreach (Projekt p in Projekti)
                {
                    if(p.aktivan == 1 && p.gotovo == 0 && ProvjeriZavrsenostFaza(p) == true)
                    {
                        listaProjekta.Add(p);
                    }
                }
                foreach (Projekt P in listaProjekta)
                {
                    listaKorisnika.Add(P.Korisnik as Korisnik);
                    listaPartnera.Add(P.Partner as Partner);
                }
            }
            projektBindingSource.DataSource = listaProjekta;
            if (listaKorisnika.Count > 0)
            {
                korisnikBindingSource.DataSource = listaKorisnika;
            }
            else
            {
                generirajPrazniKorisnik(listaKorisnika);
            }
            if (listaPartnera.Count > 0)
            {
                partnerBindingSource.DataSource = listaPartnera;
            }
            else
            {
                generirajPrazniPartner(listaPartnera);
            }
            return listaProjekta;
        }
        /// <summary>
        /// Pritiskom na tipku otvara se forma PregledRacuna i prosljeđuje se tip korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pregledRačunaButton_Click(object sender, EventArgs e)
        {
            PregledRacunForm forma = new PregledRacunForm(tipKorisnika);
            forma.ShowDialog();
        }
        /// <summary>
        /// Pritiskom na tipku provjerava se ako je označen projekt, ako je
        /// javlja se poruka upozorenja čijom se potvrdom onda izdaje račun i zapisuje vrijeme izdaje računa.
        /// Osvježava se datagridview sa računima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izdajRacunButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if (selektiraniProjekt != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new IzdavanjeRacunEntities())
                    {
                        db.Projekt.Attach(selektiraniProjekt);
                        selektiraniProjekt.gotovo = 1;
                        selektiraniProjekt.datum_izdavanja_racuna = DateTime.Now;
                        db.SaveChanges();
                    }
                    RacunReportForm forma = new RacunReportForm(selektiraniProjekt);
                    forma.ShowDialog();
                    MessageBox.Show("Uspješno izdan račun");
                }
                PrikaziRacune();
            }
        }
        /// <summary>
        /// Metoda koja se aktivira na promjenu teksta u polju za pretraživanje,
        /// pretražuje se prema istim uvjetima kao i kod učitavanja, ali se još provjerava
        /// postojanja dijela teksta u nazivu projekta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingList<Projekt> Projekti = null;
            BindingList<Projekt> listaProjekta = new BindingList<Projekt>();
            BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
            BindingList<Partner> listaPartnera = new BindingList<Partner>();
            using (var db = new IzdavanjeRacunEntities())
            {
                Projekti = new BindingList<Projekt>(db.Projekt.ToList());
                foreach (Projekt p in Projekti)
                {
                    if (p.aktivan == 1 && p.gotovo == 0 && ProvjeriZavrsenostFaza(p) == true)
                    {
                        if(p.ime.ToLower().Contains(tboxPretrazi.Text))
                        {
                            listaProjekta.Add(p);
                        }
                    }
                }
                foreach (Projekt P in listaProjekta)
                {
                    listaKorisnika.Add(P.Korisnik as Korisnik);
                    listaPartnera.Add(P.Partner as Partner);
                }
            }
            projektBindingSource.DataSource = listaProjekta;
            korisnikBindingSource.DataSource = listaKorisnika;
            partnerBindingSource.DataSource = listaPartnera;
        }
        /// <summary>
        /// Pritiskom na tipku poziva se forma sa reportom za račun tj. predračun i prosljeđuje se 
        /// projekt koji se želi prikazati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void predracunButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if (selektiraniProjekt != null)
            {
                RacunReportForm forma = new RacunReportForm(selektiraniProjekt);
                forma.ShowDialog();
            }
        }
        /// <summary>
        /// Metoda za dohvaćanje i spremanje u data sourceove one projekte
        /// čiji se datum početka slaže sa odabranim datumima na 2 datetime pickera
        /// </summary>
        private void PretraziPoDatumu()
        {
            ProjektidataGridView.Rows.Clear();
            BindingList<Projekt> listaProjekta = PrikaziRacune();
            BindingList<Projekt> bindingListaProjekta = new BindingList<Projekt>();
            BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
            BindingList<Partner> listaPartnera = new BindingList<Partner>();
            foreach (var P in listaProjekta)
            {
                if (P.datum_pocetka > dtProjekti1.Value && P.datum_pocetka < dtProjekti2.Value)
                {
                    bindingListaProjekta.Add(P);
                    listaKorisnika.Add(P.Korisnik as Korisnik);
                    listaPartnera.Add(P.Partner as Partner);
                }
            }
            projektBindingSource.DataSource = bindingListaProjekta;
            korisnikBindingSource.DataSource = listaKorisnika;
            partnerBindingSource.DataSource = listaPartnera;
        }
        /// <summary>
        /// Na promjenu datetime pickera poziva se metoda za dohvaćanje projekata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtProjekti1_ValueChanged(object sender, EventArgs e)
        {
            PretraziPoDatumu();
        }

        private void dtProjekti2_ValueChanged(object sender, EventArgs e)
        {
            PretraziPoDatumu();
        }
        /// <summary>
        /// Pritiskom na tipku Reset učitavaju se projekti koji ne ovise o filterima datuma i naziva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            PrikaziRacune();
        }
    }
}
