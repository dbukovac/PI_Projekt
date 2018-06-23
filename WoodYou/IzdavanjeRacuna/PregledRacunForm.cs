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

        private void PregledRacunForm_Load(object sender, EventArgs e)
        {
            PrikaziRacune();
        }

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

        private void pregledRačunaButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if(selektiraniProjekt != null)
            {
                OdabraniRacunForm forma = new OdabraniRacunForm(selektiraniProjekt);
                forma.ShowDialog();
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void dtProjekti1_ValueChanged(object sender, EventArgs e)
        {
            PretraziPoDatumu();
        }

        private void dtProjekti2_ValueChanged(object sender, EventArgs e)
        {
            PretraziPoDatumu();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            PrikaziRacune();
        }
    }
}
