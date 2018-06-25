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
        private int tipKorisnika = 0;
        private int idKorisnika = 0;

        public PopisProjektiForm(int tipKorisnika, int idKorisnika)
        {
            InitializeComponent();
            this.tipKorisnika = tipKorisnika;
            this.idKorisnika = idKorisnika;
        }
        /// <summary>
        /// Pozivaju se metoda za prikaz svih projekata, 
        /// faza i materijala označenog (prvog na listi) projekta
        /// Provjerava se tip korisnika, ako je admin pokazuje se tipka za brisanje projekta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopisProjektiForm_Load(object sender, EventArgs e)
        {
            if(tipKorisnika == 1)
            {
                brisiProjektButton.Visible = true;
            }
            PrikaziProjekte();
            PrikaziFaze(projektBindingSource.Current as Projekt);
            PrikaziMaterijal();
        }
        /// <summary>
        /// Metoda za prikazivanje materijala na datagridviewu prema označenom projektu i fazi
        /// koristi metodu vratifazuProjekta za dohvaćanje faze_projekta i preko toga dohvaća faza_ima_materijal
        /// i pripadajući materijal
        /// </summary>
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
        /// <summary>
        /// Metoda za prikazivanje svih projekata na datagridviewu
        /// dohvaća se iz korisnici i partneri za prikazivanje naziva
        /// umjesto id-eva
        /// </summary>
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
        /// <summary>
        /// Mateoda za prikazivanje faza označenog projekta, radi se preko faza_projekta(veza između projekta i faze)
        /// </summary>
        /// <param name="projekt"></param>
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
        /// <summary>
        /// Otvara novu formu za unos projekta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noviProjektButton_Click(object sender, EventArgs e)
        {
            NoviProjektForm noviProjektforma = new NoviProjektForm(idKorisnika);
            noviProjektforma.ShowDialog();
            PrikaziProjekte();
        }
        /// <summary>
        /// Otvara novu formu za izmjenu projekta i prosljeđuje
        /// označeni projekt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Ako se potvri poruka pokreće se projekt, postavlja se datum početka na trenutni datum,
        /// ažurira se datum završetka prema potrebnom vremenu i datumu početka, postavlja se aktivan na 1
        /// Projekt se neć pokrenuti ako nema faza na sebi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            DateTime datum = DateTime.Today;
                            selektiraniProjekt.datum_zavrsetka = datum.AddDays((double)selektiraniProjekt.potrebno_vrijeme);
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
        /// <summary>
        /// Prema označenom projektu zovu se metode za priakzivanje njegovih fza i materijala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void projektiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziFaze(projektBindingSource.Current as Projekt);
            PrikaziMaterijal();
        }
        /// <summary>
        /// Briše se projekt ako nema dodijeljenih faza, osvježavaju se datagridview-ovi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// Otvara se forma s izbornikom faza, prosljeđuje se odabrani projekt i lista njegovih faza,
        /// zatvaranjem otvorene forme osvježavaju se datagridview-ovi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajFazuButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            BindingList<Faza> listaFaza = (BindingList<Faza>)fazaBindingSource.DataSource;
            if(selektiraniProjekt != null)
            {
                PopisFazaForm popisFazaforma = new PopisFazaForm(selektiraniProjekt, listaFaza, tipKorisnika);
                popisFazaforma.ShowDialog();
                PrikaziFaze(selektiraniProjekt);
                PrikaziProjekte();
            }
        }
        /// <summary>
        /// Metoda koja vraća fazu_projekta prema označenom projektu i fazi
        /// koristi parametar za kontrolu povratne informacije, 1 vraća prvi pronađeni element
        /// 0 vraća zadnji pronađeni element. Koriste se lista faza_projekta dobivenih iz
        /// navigacijskog svojstva projekta i lista od navigacijskog od faze
        /// traže se zajedničke faze_projekta, a važno je koja se vraća zbog
        /// mogućnosti postojanja istih faza na jednom projektu,
        /// ako se briše šalje se 0, a ako se dodaje i prikazuje materijal 1
        /// </summary>
        /// <param name="kontroler"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Briše se faza samo ako nije zaključana i ako za projekt nije izdan račun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brisiFazuButton_Click(object sender, EventArgs e)
        {
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (selektiraniProjekt.gotovo != 1)
                {
                    Faze_projekta selektiranaFazaProjekta = vratiFazuProjekta(0);
                    if(selektiranaFazaProjekta.zakljucano == 0)
                    {
                        using (var db = new UpravljanjeProjektimaEntities())
                        {
                            db.Faze_projekta.Attach(selektiranaFazaProjekta);
                            db.Faze_projekta.Remove(selektiranaFazaProjekta);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Uspješno obrisana faza");
                    }
                    else
                    {
                        MessageBox.Show("Faza je zaključana, nije moguće brisati zaključane faze");
                    }
                    PrikaziFaze(projektBindingSource.Current as Projekt);
                }
                else
                {
                    MessageBox.Show("Projekt je završen!");
                }
            }
        }
        /// <summary>
        /// Otvara se nova forma za unos novog materijala samo ako nije izdan račun za projekt,
        /// prosljeđuje se odabrana faza i lista već dodanog materijala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Briše se materijal sa odabrane faze odabranog projekta ako ta faza nije zaključana ili
        /// ako za projekt nije izdan račun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brisiMaterijalButton_Click(object sender, EventArgs e)
        {
            Faza_ima_materijal selektiranaFazaImaMaterijal = fazaimamaterijalBindingSource.Current as Faza_ima_materijal;
            Projekt selektiraniProjekt = projektBindingSource.Current as Projekt;
            if (selektiraniProjekt.gotovo != 1)
            {
                if (selektiranaFazaImaMaterijal != null)
                {
                    if(selektiranaFazaImaMaterijal.Faze_projekta.zakljucano == 0)
                    {
                        using (var db = new UpravljanjeProjektimaEntities())
                        {
                            db.Faza_ima_materijal.Attach(selektiranaFazaImaMaterijal);
                            db.Faza_ima_materijal.Remove(selektiranaFazaImaMaterijal);
                            db.SaveChanges();
                        }
                        PrikaziMaterijal();
                    }
                    else
                    {
                        MessageBox.Show("Materijal pripada zaključanoj fazi, nije moguće brisati");
                    }
                }
            }
            else
            {
                MessageBox.Show("Projekt je završen!");
            }
        }
        /// <summary>
        /// Prikazuje se materijal prema označenoj fazi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fazeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziMaterijal();
        }
        /// <summary>
        /// Pretražuju se projekti prema nazivu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Pretražuju se projekti prema datumu početka
        /// </summary>
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
        /// <summary>
        /// Poziva se metoda za filtriranje prema datumu
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
        /// Resetira se filtriranje i prikazuju se svi projekti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            PrikaziProjekte();
        }
    }
}
