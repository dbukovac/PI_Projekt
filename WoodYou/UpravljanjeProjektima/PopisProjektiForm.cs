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
            PrikaziMaterijal();
        }

        private void PrikaziMaterijal()
        {
            materijalDataGridView.Rows.Clear();
            Faze_projekta materijal = vratiFazuProjekta(1);
            BindingList<Faza_ima_materijal> listaMaterijala = null;
            BindingList<Materijal> listaMaterijalId = new BindingList<Materijal>();
            if(materijal != null)
            {
                using (var db = new UpravljanjeProjektimaEntities())
                {
                    db.Faze_projekta.Attach(materijal);
                    listaMaterijala = new BindingList<Faza_ima_materijal>(materijal.Faza_ima_materijal.ToList());
                    foreach (Faza_ima_materijal M  in listaMaterijala)
                    {
                        listaMaterijalId.Add(M.Materijal as Materijal);
                    }
                }
                fazaimamaterijalBindingSource.DataSource = listaMaterijala;
                materijalBindingSource.DataSource = listaMaterijalId;
            }
        }

        private void PrikaziProjekte()
        {
            projektiDataGridView.Rows.Clear();
            BindingList < Projekt > listaProjekta = null;
            BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
            BindingList<Partner> listaPartnera = new BindingList<Partner>();
            using (var db = new UpravljanjeProjektimaEntities())
            {
                listaProjekta = new BindingList<Projekt>(db.Projekt.ToList());

                foreach(var P in listaProjekta)
                {
                    listaKorisnika.Add(P.Korisnik as Korisnik);
                    listaPartnera.Add(P.Partner as Partner);
                }
            }
            projektBindingSource.DataSource = listaProjekta;
            korisnikBindingSource.DataSource = listaKorisnika;
            partnerBindingSource.DataSource = listaPartnera;
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
                            selektiraniProjekt.datum_pocetka = DateTime.Today;
                            DateTime datum = (DateTime)selektiraniProjekt.datum_zavrsetka;
                            datum.AddDays((double)selektiraniProjekt.potrebno_vrijeme);
                            selektiraniProjekt.datum_zavrsetka = datum;
                            db.SaveChanges();
                            PrikaziProjekte();
                        }
                        else
                        {
                            MessageBox.Show("Projekt je već pokrenut ili nema postavljenih faza");
                        }
                    }
                }
            }
        }

        private void projektiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziFaze(projektBindingSource.Current as Projekt);
            PrikaziMaterijal();
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
            BindingList<Faza> listaFaza = (BindingList<Faza>)fazaBindingSource.DataSource;
            if(selektiraniProjekt != null)
            {
                PopisFazaForm popisFazaforma = new PopisFazaForm(selektiraniProjekt, listaFaza);
                popisFazaforma.ShowDialog();
                PrikaziFaze(selektiraniProjekt);
                PrikaziProjekte();
            }
        }

        private Faze_projekta vratiFazuProjekta(int kontroler)
        {
            Faza selektiranaFaza = fazaBindingSource.Current as Faza;
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            Faze_projekta vrati = null;
            if (selektiranaFaza != null && selektiraniProjekt != null)
            {
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
                                vrati = P;
                                if(kontroler == 1)
                                {
                                    return vrati;
                                }
                            }
                        }
                    }
                }
            }
            return vrati;
        }

        private void brisiFazuButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (selektiraniProjekt.gotovo != 1)
                {
                    Faze_projekta selektiranaFazaProjekta = vratiFazuProjekta(0);
                    using (var db = new UpravljanjeProjektimaEntities())
                    {
                        db.Faze_projekta.Attach(selektiranaFazaProjekta);
                        db.Faze_projekta.Remove(selektiranaFazaProjekta);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Uspješno obrisana faza");
                    PrikaziFaze(projektBindingSource.Current as Projekt);
                }
                else
                {
                    MessageBox.Show("Projekt je završen!");
                }
            }
        }

        private void dodajMaterijalButton_Click(object sender, EventArgs e)
        {
            Faza selektiranaFaza = fazaBindingSource.Current as Faza;
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            BindingList<Materijal> listaMaterijala = (BindingList<Materijal>)materijalBindingSource.DataSource;
            if(selektiraniProjekt.gotovo != 1)
            {
                Faze_projekta selektiranaFazaProjekta = vratiFazuProjekta(1);
                if (selektiranaFazaProjekta != null)
                {
                    PopisMaterijalaForm materijaliForma = new PopisMaterijalaForm(selektiranaFazaProjekta, listaMaterijala);
                    materijaliForma.ShowDialog();
                    PrikaziProjekte();
                }
            }
            else
            {
                MessageBox.Show("Projekt je završen!");
            }
        }

        private void brisiMaterijalButton_Click(object sender, EventArgs e)
        {
            Faza_ima_materijal selektiranaFazaImaMaterijal = fazaimamaterijalBindingSource.Current as Faza_ima_materijal;
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if (selektiraniProjekt.gotovo != 1)
            {
                if (selektiranaFazaImaMaterijal != null)
                {
                    using (var db = new UpravljanjeProjektimaEntities())
                    {
                        db.Faza_ima_materijal.Attach(selektiranaFazaImaMaterijal);
                        db.Faza_ima_materijal.Remove(selektiranaFazaImaMaterijal);
                        db.SaveChanges();
                    }
                    PrikaziMaterijal();
                }
            }
            else
            {
                MessageBox.Show("Projekt je završen!");
            }
        }

        private void fazeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziMaterijal();
        }

        private void tboxPretrazi_TextChanged(object sender, EventArgs e)
        {
            projektiDataGridView.Rows.Clear();
            BindingList<Projekt> listaProjekta = null;
            BindingList<Projekt> bindingListaProjekta = new BindingList<Projekt>();
            BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
            BindingList<Partner> listaPartnera = new BindingList<Partner>();
            using (var db = new UpravljanjeProjektimaEntities())
            {
                listaProjekta = new BindingList<Projekt>(db.Projekt.ToList());

                foreach (var P in listaProjekta)
                {
                    if(P.ime.ToLower().Contains(tboxPretrazi.Text))
                    {
                        bindingListaProjekta.Add(P);
                        listaKorisnika.Add(P.Korisnik as Korisnik);
                        listaPartnera.Add(P.Partner as Partner);
                    }
                }
            }
            projektBindingSource.DataSource = bindingListaProjekta;
            korisnikBindingSource.DataSource = listaKorisnika;
            partnerBindingSource.DataSource = listaPartnera;
        }

        private void PretraziPoDatumu()
        {
            projektiDataGridView.Rows.Clear();
            BindingList<Projekt> listaProjekta = null;
            BindingList<Projekt> bindingListaProjekta = new BindingList<Projekt>();
            BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
            BindingList<Partner> listaPartnera = new BindingList<Partner>();
            using (var db = new UpravljanjeProjektimaEntities())
            {
                listaProjekta = new BindingList<Projekt>(db.Projekt.ToList());

                foreach (var P in listaProjekta)
                {
                    if (P.datum_pocetka > dtProjekti1.Value && P.datum_pocetka < dtProjekti2.Value)
                    {
                        bindingListaProjekta.Add(P);
                        listaKorisnika.Add(P.Korisnik as Korisnik);
                        listaPartnera.Add(P.Partner as Partner);
                    }
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
            PrikaziProjekte();
        }
    }
}
