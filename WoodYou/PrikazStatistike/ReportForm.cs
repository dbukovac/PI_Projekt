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

namespace PrikazStatistike
{
    public partial class ReportForm : Form
    {
        public BindingList<Projekt> listaProjekta = null;
        public BindingList<Faza> listaFaza = null;
        public BindingList<Materijal> listaMaterijala = null;
        public BindingList<Korisnik> listaKorisnika = null;
        public BindingList<Primka> listaPrimka = null;
        public BindingList<Narudzbenica> listaNarudzbenica = null;
        public BindingList<Partner> listaPartnera= null;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            PopuniListe();
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
        }

        private void PopuniListe()
        {
            using (var db = new PrikazStatistikeEntities())
            {
                listaProjekta = new BindingList<Projekt>(db.Projekt.ToList());
                listaFaza = new BindingList<Faza>(db.Faza.ToList());
                listaKorisnika = new BindingList<Korisnik>(db.Korisnik.ToList());
                listaPrimka = new BindingList<Primka>(db.Primka.ToList());
                listaMaterijala = new BindingList<Materijal>(db.Materijal.ToList());
                listaNarudzbenica = new BindingList<Narudzbenica>(db.Narudzbenica.ToList());
                listaPartnera = new BindingList<Partner>(db.Partner.ToList());
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
                this.reportViewer.RefreshReport();


                
                //this.reportViewer.LocalReport.ReportEmbeddedResource = "C:/Users/Danko/Git/WoodYou/PrikazStatistike/Report.rdlc";
                //this.reportViewer.RefreshReport();
            }
            if (cboxIzbor.Text == "Faze")
            {
                ZatvoriSve();
                fazaBindingSource.DataSource = listaFaza;
            }
            if (cboxIzbor.Text == "Materijal")
            {
                ZatvoriSve();
                materijalBindingSource.DataSource = listaMaterijala;
            }
            if (cboxIzbor.Text == "Primke")
            {
                ZatvoriSve();
                primkaBindingSource.DataSource = listaPrimka;
            }
            if (cboxIzbor.Text == "Narudzbenice")
            {
                ZatvoriSve();
                narudzbenicaBindingSource.DataSource = listaNarudzbenica;
            }
            if (cboxIzbor.Text == "Korisnici")
            {
                ZatvoriSve();
                korisnikBindingSource.DataSource = listaKorisnika;
            }
            if (cboxIzbor.Text == "Poslovni partneri")
            {
                ZatvoriSve();
                partnerBindingSource.DataSource = listaPartnera;
            }
            this.reportViewer.RefreshReport();
        }
    }
}
