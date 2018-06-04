using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjePoslovnimPartnerima
{
    public partial class PoslovniPartneriForm : Form
    {
        public PoslovniPartneriForm()
        {
            InitializeComponent();
        }

        private void PoslovniPartneriForm_Load(object sender, EventArgs e)
        {
            PrikaziPartnere();
        }

        private void PrikaziPartnere()
        {
            BindingList<Partner> listaPartnera = null;
            BindingList<Tip_partnera> listaTipova = new BindingList<Tip_partnera>();
            using(var db = new UpravljanjePoslovnimPartnerimaEntities())
            {
                listaPartnera = new BindingList<Partner>(db.Partner.ToList());
                foreach (var P in listaPartnera)
                {
                    listaTipova.Add(P.Tip_partnera1 as Tip_partnera);
                }
            }
            partnerBindingSource.DataSource = listaPartnera;
            tippartneraBindingSource.DataSource = listaTipova;
        }

        private void noviPartnerbutton_Click(object sender, EventArgs e)
        {
            NoviPartnerForm forma = new NoviPartnerForm();
            forma.ShowDialog();
            PrikaziPartnere();
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            Partner selektiraniPartner = partnerBindingSource.Current as Partner;

            if(selektiraniPartner != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpravljanjePoslovnimPartnerimaEntities())
                    {
                        db.Partner.Attach(selektiraniPartner);
                        db.Partner.Remove(selektiraniPartner);
                        db.SaveChanges();
                    }
                }
                PrikaziPartnere();
            }
        }

        private void urediButton_Click(object sender, EventArgs e)
        {
            Partner selekitraniPartner = partnerBindingSource.Current as Partner;
            if(selekitraniPartner != null)
            {
                NoviPartnerForm forma = new NoviPartnerForm(selekitraniPartner);
                forma.ShowDialog();
                PrikaziPartnere();
            }
        }
    }
}
