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

        private void ReportForm_Load(object sender, EventArgs e)
        {
            PopuniListe();
            this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();
        }

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

        private void cboxIzbor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxIzbor.Text == "Projekti")
            {
                BindingList<Korisnik> korisniks = new BindingList<Korisnik>();
                BindingList<Partner> partners = new BindingList<Partner>();
                ZatvoriSve();
                projektBindingSource.DataSource = listaProjekta;
                foreach (var P in listaProjekta)
                {
                    korisniks.Add(P.Korisnik);
                    partners.Add(P.Partner);
                }
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
                ZatvoriSve();
                stavkaprimkeBindingSource.DataSource = listaStavkiPrimke;
                foreach (var P in listaStavkiPrimke)
                {
                    korisniks.Add(P.Primka.Korisnik);
                    partners.Add(P.Primka.Partner);
                    primkas.Add(P.Primka);
                    materijals.Add(P.Materijal);
                }
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
                ZatvoriSve();
                stavkanarudzbeniceBindingSource.DataSource = listaStavkiNarudzbenica;
                foreach (var P in listaStavkiNarudzbenica)
                {
                    korisniks.Add(P.Narudzbenica.Korisnik);
                    partners.Add(P.Narudzbenica.Partner);
                    narudzbenicas.Add(P.Narudzbenica);
                    materijals.Add(P.Materijal);
                }
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
