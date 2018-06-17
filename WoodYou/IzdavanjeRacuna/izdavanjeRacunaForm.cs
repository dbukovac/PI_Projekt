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
        public IzdavanjeRacunaForm()
        {
            InitializeComponent();
        }

        private void izdavanjeRacunaForm_Load(object sender, EventArgs e)
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

        private bool ProvjeriZavrsenostFaza(Projekt projekt)
        {
            List<Faze_projekta> listaFaza = null;
            bool zavrseno = true;
            using (var db = new IzdavanjeRacunEntities())
            {
                db.Projekt.Attach(projekt);
                listaFaza = new List<Faze_projekta>(projekt.Faze_projekta.ToList());
                foreach (var F in listaFaza)
                {
                    if(F.zakljucano == 0)
                    {
                        zavrseno = false;
                    }
                }
            }
            return zavrseno;
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

        private void pregledRačunaButton_Click(object sender, EventArgs e)
        {
            PregledRacunForm forma = new PregledRacunForm();
            forma.ShowDialog();
        }

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
                    if (p.datum_zavrsetka != null)
                    {
                        if (p.aktivan == 1 && p.datum_zavrsetka < DateTime.Now && p.gotovo == 0)
                        {
                            if(p.ime.ToLower().Contains(tboxPretrazi.Text))
                            {
                                listaProjekta.Add(p);
                            }
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

        private void predracunButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if (selektiraniProjekt != null)
            {
                RacunReportForm forma = new RacunReportForm(selektiraniProjekt);
                forma.ShowDialog();
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
