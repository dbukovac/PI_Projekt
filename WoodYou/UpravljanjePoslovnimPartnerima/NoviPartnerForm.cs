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
        /// <summary>
        /// Postoje dva konstruktora, bez parametra za novog partnera i s konstruktorom za izmjenu partnera
        /// </summary>
        public NoviPartnerForm()
        {
            InitializeComponent();
        }

        public NoviPartnerForm(Partner partner)
        {
            InitializeComponent();
            odabraniPartner = partner;
        }
        /// <summary>
        /// Učitava se tip partnera za prikaz u padajućem izborniku i pune se polja ukoliko se radi
        /// o izmjeni partnera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Radi se novi objekt partner ako se radi o novom unosu, posebno se provjerava ako je OIB broj
        /// te se sprema u bazu podataka. Ako se radi o izmjeni podaci se ažuriraju i spremaju u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spremiButton_Click(object sender, EventArgs e)
        {
            if(odabraniPartner == null)
            {
                using(var db = new UpravljanjePoslovnimPartnerimaEntities())
                {
                    int OIB;
                    if (!int.TryParse(tboxOIB.Text, out OIB) && tboxOIB.Text.Length == 11)
                    {
                        Partner noviPartner = new Partner
                        {
                            ime = tboxIme.Text,
                            adresa = tboxAdresa.Text,
                            OIB = tboxOIB.Text,
                            tip_partnera = cboxTip.SelectedValue.ToString(),
                        };
                        db.Partner.Add(noviPartner);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("OIB sadrži nedopuštene znakove");
                    }
                }
            }
            else
            {
                using(var db = new UpravljanjePoslovnimPartnerimaEntities())
                {
                    db.Partner.Attach(odabraniPartner);
                    odabraniPartner.ime = tboxIme.Text;
                    odabraniPartner.adresa = tboxAdresa.Text;
                    odabraniPartner.OIB = tboxOIB.Text;
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
