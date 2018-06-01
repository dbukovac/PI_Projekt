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
        public PregledRacunForm()
        {
            InitializeComponent();
        }

        private void PregledRacunForm_Load(object sender, EventArgs e)
        {
            PrikaziRacune();
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
            korisnikBindingSource.DataSource = listaKorisnika;
            partnerBindingSource.DataSource = listaPartnera;
        }

        private void pregledRačunaButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            OdabraniRacunForm forma = new OdabraniRacunForm(selektiraniProjekt);
            forma.ShowDialog();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
