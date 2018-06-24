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
    public partial class PregledRacunForm : Form
    {
        private int tipKorisnika = 0;
        public PregledRacunForm(int tipKorisnika)
        {
            InitializeComponent();
            this.tipKorisnika = tipKorisnika;
        }
        /// <summary>
        /// Prilikom učitavanja forme poziva se metoda za prikazivanje svih izdanih računa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PregledRacunForm_Load(object sender, EventArgs e)
        {
            PrikaziRacune();
        }
        /// <summary>
        /// Metoda za gereriranje praznog korisnika kako bi se spriječilo pojavljivanje 
        /// greške kad nema projekata za učitati
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
        /// Metoda za učitavanje projekata za koje je izdan račun u datagridview
        /// dohvaćaju se odgovarajući korisnici i partneri kako bi se prikazali nazivi a ne id-evi
        /// Ukoliko nema takvi projekta pozivaju se metoda za generiranje praznih podataka
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
                    if (p.datum_izdavanja_racuna != null)
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
            if(listaKorisnika.Count > 0)
            {
                korisnikBindingSource.DataSource = listaKorisnika;
            }
            else
            {
                generirajPrazniKorisnik(listaKorisnika);
            }
            if(listaPartnera.Count > 0)
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
        /// Pritiskom na tipku otvara se forma za prikaza detaljnih podataka jednog projekta
        /// prosljeđuje se odabrani projekt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pregledRačunaButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if(selektiraniProjekt != null)
            {
                OdabraniRacunForm forma = new OdabraniRacunForm(selektiraniProjekt);
                forma.ShowDialog();
            }
        }
        /// <summary>
        /// Pritiskom na tipku forma se zatvara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Prilikom promjene teksta u polju za pretraživanje prema nazivu
        /// učitavaju se u datagridview projekti i njihovi partneri i korisnici
        /// gdje u nazivu projekta ima dio teksta u polju
        /// Ukoliko nema takvih projekata pozivaju se metode za generiranje praznih podataka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxPretrazi_TextChanged(object sender, EventArgs e)
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
                    if (p.datum_izdavanja_racuna != null)
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
