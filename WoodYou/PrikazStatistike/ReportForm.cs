using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;

namespace PrikazStatistike
{
    public partial class ReportForm : Form
    {
        /// <summary>
        /// deklariranje lista za korištenje u svim metodama
        /// </summary>
        public BindingList<Projekt> listaProjekta = null;
        public BindingList<Faza> listaFaza = null;
        public BindingList<Materijal> listaMaterijala = null;
        public BindingList<Korisnik> listaKorisnika = null;
        public BindingList<Stavka_primke> listaStavkiPrimke = null;
        public BindingList<Stavka_narudzbenice> listaStavkiNarudzbenica = null;
        public BindingList<Partner> listaPartnera= null;

        public ReportForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Prilikom učitavanja forme poziva se metoda za popunjevanje svih lista
        /// sa podacima i osvježava se report viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportForm_Load(object sender, EventArgs e)
        {
            PopuniListe();
            this.reportViewer.RefreshReport();
        }
        /// <summary>
        /// Metoda za stavljanje svih data source-a na null
        /// kako bi se mogla koristit jedna forma za sve reportove
        /// da ove metode nema podaci bi se duplirali ili bi bili krivi za
        /// pojedine reportove
        /// </summary>
        private void ZatvoriSve()
        {
            fazaBindingSource.DataSource = null;
            projektBindingSource.DataSource = null;
            materijalBindingSource.DataSource = null;
            primkaBindingSource.DataSource = null;
            narudzbenicaBindingSource.DataSource = null;
            korisnikBindingSource.DataSource = null;
            partnerBindingSource.DataSource = null;
            tipkorisnikaBindingSource.DataSource = null;
            stavkanarudzbeniceBindingSource.DataSource = null;
            stavkaprimkeBindingSource.DataSource = null;
        }
        /// <summary>
        /// Metoda koja puni sve liste sa podacima iz baze i za neke uključuje podatke navigacijskih svojstva
        /// </summary>
        private void PopuniListe()
        {
            using (var db = new PrikazStatistikeEntities())
            {
                listaProjekta = new BindingList<Projekt>(db.Projekt.ToList());
                listaFaza = new BindingList<Faza>(db.Faza.ToList());
                listaKorisnika = new BindingList<Korisnik>(db.Korisnik.Include(x => x.Tip_korisnika).ToList());
                listaStavkiPrimke = new BindingList<Stavka_primke>(db.Stavka_primke.Include(x => x.Primka).ToList());
                listaMaterijala = new BindingList<Materijal>(db.Materijal.ToList());
                listaStavkiNarudzbenica = new BindingList<Stavka_narudzbenice>(db.Stavka_narudzbenice.Include(x => x.Narudzbenica).ToList());
                listaPartnera = new BindingList<Partner>(db.Partner.Include(x => x.Tip_partnera1).ToList());
            }
        }
        /// <summary>
        /// Velika metoda koja prema već zadanim vrijednostima padajućeg izbornika
        /// prikazuje reportove za izabranu tablicu. Unutar if petlje dohvaćaju se potrebni detalji vezani za glavnu tablicu
        /// koji se dodijeljuju svojim data sourcevima, te poziva se odgovarajuća report datoteka.
        /// Za svaki izbor iz padajućeg izbornika postoji report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxIzbor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxIzbor.Text == "Projekti")
            {
                BindingList<Projekt> projekts = new BindingList<Projekt>();
                BindingList<Korisnik> korisniks = new BindingList<Korisnik>();
                BindingList<Partner> partners = new BindingList<Partner>();
                ZatvoriSve();
                foreach (var P in listaProjekta)
                {
                    if (P.datum_pocetka > dtProjekti1.Value && P.datum_pocetka < dtProjekti2.Value)
                    {
                        projekts.Add(P);
                        korisniks.Add(P.Korisnik);
                        partners.Add(P.Partner);
                    }
                }
                projektBindingSource.DataSource = projekts;
                partnerBindingSource.DataSource = partners;
                korisnikBindingSource.DataSource = korisniks;
                //reportViewer.Reset();
                //ReportDataSource RDC = new ReportDataSource();
                //RDC.Name = "DataSetProjekt";
                //RDC.Value = this.projektBindingSource;
                //this.reportViewer.LocalReport.DataSources.Add(RDC);
                this.reportViewer.LocalReport.ReportPath = "C:/Users/Danko/Git/WoodYou/PrikazStatistike/ReportProjekti.rdlc";                
                //this.reportViewer.LocalReport.ReportEmbeddedResource = "C:/Users/Danko/Git/WoodYou/PrikazStatistike/Report.rdlc";
                //this.reportViewer.RefreshReport();
            }
            if (cboxIzbor.Text == "Faze")
            {
                ZatvoriSve();
                fazaBindingSource.DataSource = listaFaza;
                this.reportViewer.LocalReport.ReportPath = "C:/Users/Danko/Git/WoodYou/PrikazStatistike/ReportFaze.rdlc";
            }
            if (cboxIzbor.Text == "Materijal")
            {
                ZatvoriSve();
                materijalBindingSource.DataSource = listaMaterijala;
                this.reportViewer.LocalReport.ReportPath = "C:/Users/Danko/Git/WoodYou/PrikazStatistike/ReportMaterijal.rdlc";
            }
            if (cboxIzbor.Text == "Primke")
            {
                BindingList<Korisnik> korisniks = new BindingList<Korisnik>();
                BindingList<Partner> partners = new BindingList<Partner>();
                BindingList<Materijal> materijals = new BindingList<Materijal>();
                BindingList<Primka> primkas = new BindingList<Primka>();
                BindingList<Stavka_primke> stavkas_p = new BindingList<Stavka_primke>();
                ZatvoriSve();
                foreach (var P in listaStavkiPrimke)
                {
                    if(P.Primka.datumPrimitka > dtProjekti1.Value && P.Primka.datumPrimitka < dtProjekti2.Value)
                    {
                        stavkas_p.Add(P);
                        korisniks.Add(P.Primka.Korisnik);
                        partners.Add(P.Primka.Partner);
                        primkas.Add(P.Primka);
                        materijals.Add(P.Materijal);
                    }
                }
                stavkaprimkeBindingSource.DataSource = stavkas_p;
                korisnikBindingSource.DataSource = korisniks;
                partnerBindingSource.DataSource = partners;
                materijalBindingSource.DataSource = materijals;
                primkaBindingSource.DataSource = primkas;
                this.reportViewer.LocalReport.ReportPath = "C:/Users/Danko/Git/WoodYou/PrikazStatistike/ReportPrimke.rdlc";
            }
            if (cboxIzbor.Text == "Narudzbenice")
            {
                BindingList<Korisnik> korisniks = new BindingList<Korisnik>();
                BindingList<Partner> partners = new BindingList<Partner>();
                BindingList<Materijal> materijals = new BindingList<Materijal>();
                BindingList<Narudzbenica> narudzbenicas = new BindingList<Narudzbenica>();
                BindingList<Stavka_narudzbenice> stavkas_n = new BindingList<Stavka_narudzbenice>();
                ZatvoriSve();
                foreach (var P in listaStavkiNarudzbenica)
                {
                    if (P.Narudzbenica.datum_slanja > dtProjekti1.Value && P.Narudzbenica.datum_slanja < dtProjekti2.Value)
                    {
                        stavkas_n.Add(P);
                        korisniks.Add(P.Narudzbenica.Korisnik);
                        partners.Add(P.Narudzbenica.Partner);
                        narudzbenicas.Add(P.Narudzbenica);
                        materijals.Add(P.Materijal);
                    }
                }
                stavkanarudzbeniceBindingSource.DataSource = stavkas_n;
                korisnikBindingSource.DataSource = korisniks;
                partnerBindingSource.DataSource = partners;
                materijalBindingSource.DataSource = materijals;
                narudzbenicaBindingSource.DataSource = narudzbenicas;
                this.reportViewer.LocalReport.ReportPath = "C:/Users/Danko/Git/WoodYou/PrikazStatistike/ReportNarudzbenice.rdlc";
            }
            if (cboxIzbor.Text == "Korisnici")
            {
                BindingList<Tip_korisnika> tipovi = new BindingList<Tip_korisnika>();
                ZatvoriSve();
                korisnikBindingSource.DataSource = listaKorisnika;
                foreach (var P in listaKorisnika)
                {
                    tipovi.Add(P.Tip_korisnika);
                }
                tipkorisnikaBindingSource.DataSource = tipovi;
                this.reportViewer.LocalReport.ReportPath = "C:/Users/Danko/Git/WoodYou/PrikazStatistike/ReportKorisnici.rdlc";
            }
            if (cboxIzbor.Text == "Poslovni partneri")
            {
                BindingList<Tip_partnera> tipovi = new BindingList<Tip_partnera>();
                ZatvoriSve();
                partnerBindingSource.DataSource = listaPartnera;
                foreach (var P in listaPartnera)
                {
                    tipovi.Add(P.Tip_partnera1);
                }
                tippartneraBindingSource.DataSource = tipovi;
                this.reportViewer.LocalReport.ReportPath = "C:/Users/Danko/Git/WoodYou/PrikazStatistike/ReportPartneri.rdlc";
            }
            this.reportViewer.RefreshReport();
        }
    }
}
