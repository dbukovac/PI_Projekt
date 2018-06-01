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
    public partial class OdabraniRacunForm : Form
    {
        private Projekt odabraniProjekt = null;

        public OdabraniRacunForm(Projekt projekt)
        {
            InitializeComponent();
            odabraniProjekt = projekt;
        }

        private void OdabraniRacunForm_Load(object sender, EventArgs e)
        {
            PrikaziProjekt();
            PrikaziFaze(odabraniProjekt);
            PrikaziMaterijal();
        }

        private void PrikaziProjekt()
        {
            tboxBrojRacuna.Text = odabraniProjekt.projektId.ToString();
            tboxNaziv.Text = odabraniProjekt.ime;
            tboxDatumPocetka.Text = odabraniProjekt.datum_pocetka.ToString();
            tboxDatumZavrsetka.Text = odabraniProjekt.datum_zavrsetka.ToString();
            tboxDatumIzdavanja.Text = odabraniProjekt.datum_izdavanja_racuna.ToString();
            tboxPotrebnoVrijeme.Text = odabraniProjekt.potrebno_vrijeme.ToString();
            tboxUkupnaCijena.Text = odabraniProjekt.ukupna_cijena.ToString();
            tboxIznosPdv.Text = odabraniProjekt.iznos_pdv.ToString();
            tboxCijenaBezPdv.Text = odabraniProjekt.cijena_bez_pdv.ToString();
        }

        private void PrikaziFaze(Projekt projekt)
        {
            if (projekt != null)
            {
                List<Faze_projekta> listaFaze_projekta = null;
                BindingList<Faza> listaFaza = new BindingList<Faza>();
                using (var db = new IzdavanjeRacunEntities())
                {
                    db.Projekt.Attach(projekt);
                    listaFaze_projekta = new List<Faze_projekta>(projekt.Faze_projekta.ToList());

                    foreach (var F in listaFaze_projekta)
                    {
                        listaFaza.Add(F.Faza as Faza);
                    }
                }
                fazaBindingSource.DataSource = listaFaza;
            }
        }

        private void PrikaziMaterijal()
        {
            Faze_projekta materijal = vratiFazuProjekta();
            BindingList<Faza_ima_materijal> listaMaterijala = null;
            BindingList<Materijal> listaMaterijalId = new BindingList<Materijal>();
            if (materijal != null)
            {
                using (var db = new IzdavanjeRacunEntities())
                {
                    db.Faze_projekta.Attach(materijal);
                    listaMaterijala = new BindingList<Faza_ima_materijal>(materijal.Faza_ima_materijal.ToList());
                    foreach (Faza_ima_materijal M in listaMaterijala)
                    {
                        listaMaterijalId.Add(M.Materijal as Materijal);
                    }
                }
                fazaimamaterijalBindingSource.DataSource = listaMaterijala;
                materijalBindingSource.DataSource = listaMaterijalId;
            }
        }

        private Faze_projekta vratiFazuProjekta()
        {
            Faza selektiranaFaza = fazaBindingSource.Current as Faza;
            Projekt selektiraniProjekt = odabraniProjekt;
            Faze_projekta vrati = null;
            if (selektiranaFaza != null && selektiraniProjekt != null)
            {
                using (var db = new IzdavanjeRacunEntities())
                {
                    db.Projekt.Attach(selektiraniProjekt);
                    db.Faza.Attach(selektiranaFaza);

                    List<Faze_projekta> listaOdProjekta = new List<Faze_projekta>(selektiraniProjekt.Faze_projekta.ToList());
                    List<Faze_projekta> listaOdFaze = new List<Faze_projekta>(selektiranaFaza.Faze_projekta.ToList());
                    foreach (var P in listaOdProjekta)
                    {
                        foreach (var F in listaOdFaze)
                        {
                            if (P.id == F.id)
                            {
                                vrati = P;
                            }
                        }
                    }
                }
            }
            return vrati;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziMaterijal();
        }

        private void izadiButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
