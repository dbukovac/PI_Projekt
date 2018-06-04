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
    public partial class NoviPartnerForm : Form
    {
        private Partner odabraniPartner = null;

        public NoviPartnerForm()
        {
            InitializeComponent();
        }

        public NoviPartnerForm(Partner partner)
        {
            InitializeComponent();
            odabraniPartner = partner;
        }

        private void NoviPartnerForm_Load(object sender, EventArgs e)
        {
            BindingList<Tip_partnera> listaTipova = null;
            using (var db = new UpravljanjePoslovnimPartnerimaEntities())
            {
                listaTipova = new BindingList<Tip_partnera>(db.Tip_partnera.ToList());
            }
            tippartneraBindingSource.DataSource = listaTipova;

            if (odabraniPartner != null)
            {
                using (var db = new UpravljanjePoslovnimPartnerimaEntities())
                {
                    db.Partner.Attach(odabraniPartner);
                    tboxIme.Text = odabraniPartner.ime.ToString();
                    tboxOIB.Text = odabraniPartner.OIB.ToString();
                    tboxAdresa.Text = odabraniPartner.adresa.ToString();
                }
            }
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if(odabraniPartner == null)
            {
                using(var db = new UpravljanjePoslovnimPartnerimaEntities())
                {
                    Partner noviPartner = new Partner
                    {
                        ime = tboxIme.Text,
                        adresa = tboxAdresa.Text,
                        OIB = int.Parse(tboxOIB.Text),
                        tip_partnera = cboxTip.SelectedValue.ToString(),
                    };
                    db.Partner.Add(noviPartner);
                    db.SaveChanges();
                }
            }
            else
            {
                using(var db = new UpravljanjePoslovnimPartnerimaEntities())
                {
                    db.Partner.Attach(odabraniPartner);
                    odabraniPartner.ime = tboxIme.Text;
                    odabraniPartner.adresa = tboxAdresa.Text;
                    odabraniPartner.OIB = int.Parse(tboxOIB.Text);
                    odabraniPartner.tip_partnera = cboxTip.SelectedValue.ToString();
                }
            }
            MessageBox.Show("Uspješno dodan partner");
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
