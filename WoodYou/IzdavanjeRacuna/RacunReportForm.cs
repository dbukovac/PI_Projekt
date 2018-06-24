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
    public partial class RacunReportForm : Form
    {
        private Projekt odabraniProjekt = null;

        public RacunReportForm(Projekt projekt)
        {
            InitializeComponent();
            odabraniProjekt = projekt;
        }
        /// <summary>
        /// Prilikom učitavanja forme Projekt data sourceu dodaje se prosljeđeni projekt
        /// i u listu faza_projekta dohvaćaju se sve faze_projekta prosljeđenog projekta
        /// Ta lista faza_projekta prosljeđuje se metodi materijal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RacunReportForm_Load(object sender, EventArgs e)
        {
            BindingList<Projekt> lista = new BindingList<Projekt>();
            lista.Add(odabraniProjekt);
            ProjektBindingSource.DataSource = lista;
            List<Faze_projekta> listaFaze_projekta = Faze(odabraniProjekt);
            Materijal(listaFaze_projekta);
            this.reportViewer1.RefreshReport();
        }
        /// <summary>
        /// Metoda za koja popunjava data sourceove za fazu i fazu_projekta te vraća listu faza projekta
        /// za prosljeđeni projekt
        /// </summary>
        /// <param name="projekt"></param>
        /// <returns></returns>
        private List<Faze_projekta> Faze(Projekt projekt)
        {
            List<Faze_projekta> listaFaze_projekta = null;

            if (projekt != null)
            {
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
                FazaBindingSource.DataSource = listaFaza;
                fazeprojektaBindingSource.DataSource = listaFaze_projekta;
            }

            return listaFaze_projekta;
        }
        /// <summary>
        /// Metoda koja prima listu faza_projekta i za te faze projekta popunjava data sourceove za 
        /// stavke materijala na fazi projekta i materijal
        /// </summary>
        /// <param name="listaFaze_projekta"></param>
        private void Materijal(List<Faze_projekta> listaFaze_projekta)
        {
            BindingList<Faza_ima_materijal> listaMaterijala = new BindingList<Faza_ima_materijal>();
            BindingList<Materijal> listaMaterijalId = new BindingList<Materijal>();
            if (listaFaze_projekta != null)
            {
                using (var db = new IzdavanjeRacunEntities())
                {
                    foreach (var fp in listaFaze_projekta)
                    {
                        db.Faze_projekta.Attach(fp);
                        foreach (var fm in fp.Faza_ima_materijal)
                        {
                            listaMaterijala.Add(fm);
                            listaMaterijalId.Add(fm.Materijal);
                        }
                        //foreach (Faza_ima_materijal M in listaMaterijala)
                        //{
                        //    if(M.kolicina != 0)
                        //    {
                        //        listaMaterijalId.Add(M.Materijal as Materijal);
                        //    }
                        //}
                    }
                }
                Faza_ima_materijalBindingSource.DataSource = listaMaterijala;
                materijalBindingSource.DataSource = listaMaterijalId;
            }
        }
    }
}
