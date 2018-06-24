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
        /// <summary>
        /// Prilikom učitavanja forme pozivaju se metode za prikazivanje podataka projekta i njegovih faza i materijala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OdabraniRacunForm_Load(object sender, EventArgs e)
        {
            PrikaziProjekt();
            PrikaziFaze(odabraniProjekt);
            PrikaziMaterijal();
        }
        /// <summary>
        /// Metoda koja puni polja sa podacima prosljeđenog projekta
        /// </summary>
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
            tboxKorisnik.Text = odabraniProjekt.Korisnik.korisnicko_ime.ToString();
            tboxPartner.Text = odabraniProjekt.Partner.ime.ToString();
        }
        /// <summary>
        /// Metoda koja vraća sve faze koje projekt sadrži
        /// prolazi kroz svaku Faze_projekta i dohvaća Faza
        /// </summary>
        /// <param name="projekt"></param>
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
        /// <summary>
        /// Metoda koja koristi metodu za dohvaćanje faze_projekta preko označene faze u datagridviewu
        /// Za tu fazu_projekta dohvaća sve stavke materijala (Faza_ima_materijal) i preuzima materijala
        /// iz tih stavki za prikazivanje na datagridviewu
        /// </summary>
        private void PrikaziMaterijal()
        {
            Faze_projekta materijal = vratiFazuProjekta(1);
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
        /// <summary>
        /// Metoda koja za označenu fazu unutar datagridviewa puni listu faza_projekta i za označeni projekt puni listu faza_projekta
        /// kako bi se uspoređivanjem spremile u listu one faze projekta koje su zajedničke.
        /// parametar kontroler postoji zbog korištenja na drugoj formi (objašnjeno u PopisProjektiForm)
        /// Trenutno korištenje je sa parametrom = 1, time vraća prvu fazu_projekta koju nađe
        /// </summary>
        /// <param name="kontroler"></param>
        /// <returns></returns>
        private Faze_projekta vratiFazuProjekta(int kontroler)
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
                                if (kontroler == 1)
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
        /// Prilikom označavanja druge faze poziva se metoda za priakzivanje materijala
        /// koji je dodan na označenu fazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziMaterijal();
        }
        /// <summary>
        /// Pritiskom na tipku zatvara se forma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izadiButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Pritiskom na tipku otvara se forma RacunReport koja prikazuje izvješće
        /// i prosljeđuje se projekt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printajButton_Click(object sender, EventArgs e)
        {
            RacunReportForm forma = new RacunReportForm(odabraniProjekt);
            forma.ShowDialog();
        }
    }
}
