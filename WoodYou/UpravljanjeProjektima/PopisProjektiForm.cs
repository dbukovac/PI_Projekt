using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeProjektima
{
    public partial class PopisProjektiForm : Form
    {
        public PopisProjektiForm()
        {
            InitializeComponent();
        }

        private void PopisProjektiForm_Load(object sender, EventArgs e)
        {
            PrikaziProjekte();
            PrikaziFaze(projektBindingSource.Current as Projekt);
        }

        private void PrikaziProjekte()
        {
            projektiDataGridView.Rows.Clear();
            BindingList < Projekt > listaProjekta = null;
            BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
            using (var db = new UpravljanjeProjektimaEntities())
            {
                listaProjekta = new BindingList<Projekt>(db.Projekt.ToList());

                foreach(var K in listaProjekta)
                {
                    listaKorisnika.Add(K.Korisnik as Korisnik);
                }
            }
            projektBindingSource.DataSource = listaProjekta;
            korisnikBindingSource.DataSource = listaKorisnika;
        }

        private void PrikaziFaze(Projekt projekt)
        {
            fazeDataGridView.Rows.Clear();
            if(projekt != null)
            {
                List<Faze_projekta> listaFaze_projekta = null;
                BindingList<Faza> listaFaza = new BindingList<Faza>();
                using (var db = new UpravljanjeProjektimaEntities())
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

        private void noviProjektButton_Click(object sender, EventArgs e)
        {
            NoviProjektForm noviProjektforma = new NoviProjektForm();
            noviProjektforma.ShowDialog();
            PrikaziProjekte();
        }

        private void izmjeniProjektButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if(selektiraniProjekt != null)
            {
                NoviProjektForm noviProjektforma = new NoviProjektForm(selektiraniProjekt);
                noviProjektforma.ShowDialog();
                PrikaziProjekte();
            }
        }

        private void pokreniProjektButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if(selektiraniProjekt != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using(var db = new UpravljanjeProjektimaEntities())
                    {
                        db.Projekt.Attach(selektiraniProjekt);
                        if(selektiraniProjekt.aktivan == 0 && selektiraniProjekt.Faze_projekta.Count > 0)
                        {
                            selektiraniProjekt.aktivan = 1;
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Projekt je već pokrenut");
                        }
                    }
                }
            }
        }

        private void projektiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziFaze(projektBindingSource.Current as Projekt);
        }

        private void brisiProjektButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if(selektiraniProjekt != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpravljanjeProjektimaEntities())
                    {
                        db.Projekt.Attach(selektiraniProjekt);
                        if(selektiraniProjekt.Faze_projekta.Count == 0)
                        {
                            db.Projekt.Remove(selektiraniProjekt);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati projekt koji sadrži faze");
                        }
                    }
                    PrikaziProjekte();
                    PrikaziFaze(projektBindingSource.Current as Projekt);
                }
            }
        }

        private void dodajFazuButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if(selektiraniProjekt != null)
            {
                PopisFazaForm popisFazaforma = new PopisFazaForm(selektiraniProjekt);
                popisFazaforma.ShowDialog();
                PrikaziFaze(selektiraniProjekt);
            }
        }

        private void brisiFazuButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Faza selektiranaFaza = fazaBindingSource.Current as Faza;
                Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
                Faze_projekta brisanje = null;
                using (var db = new UpravljanjeProjektimaEntities())
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
                                brisanje = P;
                            }
                        }
                    }
                    db.Faze_projekta.Remove(brisanje);
                    db.SaveChanges();
                }
                MessageBox.Show("Uspješno obrisana faza");
                PrikaziFaze(projektBindingSource.Current as Projekt);
            }
        }
    }
}
