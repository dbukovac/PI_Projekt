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

        private void PrikaziRacune()
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
                    if(p.datum_zavrsetka != null)
                    {
                        if (p.aktivan == 1 && p.datum_zavrsetka < DateTime.Now && p.gotovo == 0)
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

        private void pregledRačunaButton_Click(object sender, EventArgs e)
        {
            PregledRacunForm forma = new PregledRacunForm();
            forma.ShowDialog();
        }

        private void izdajRacunButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
                using (var db = new IzdavanjeRacunEntities())
                {
                    db.Projekt.Attach(selektiraniProjekt);
                    selektiraniProjekt.gotovo = 1;
                    selektiraniProjekt.datum_izdavanja_racuna = DateTime.Now;
                    db.SaveChanges();
                }
                MessageBox.Show("Uspješno izdan račun");
            }
            PrikaziRacune();
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
    }
}
