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
    public partial class NoviProjektForm : Form
    {
        private Projekt odabraniProjekt = null;

        public NoviProjektForm()
        {
            InitializeComponent();
        }
        public NoviProjektForm(Projekt projekt)
        {
            InitializeComponent();
            odabraniProjekt = projekt;
        }

        public string GenerirajKod(int duzina)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < duzina--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void NoviProjektForm_Load(object sender, EventArgs e)
        {
            BindingList<Partner> listaPartnera = null;
            using (var db = new UpravljanjeProjektimaEntities())
            {
                listaPartnera = new BindingList<Partner>(db.Partner.ToList());
            }
            partnerBindingSource.DataSource = listaPartnera;

            if (odabraniProjekt != null)
            {
                tboxNaziv.Text = odabraniProjekt.ime.ToString();
                dtDatum.Text = odabraniProjekt.datum_pocetka.ToString();
                cboxPartner.Text = odabraniProjekt.Partner.ime;
            }
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if(odabraniProjekt == null)
            {
                using (var db = new UpravljanjeProjektimaEntities())
                {
                    Projekt noviProjekt = new Projekt
                    {
                        ime = tboxNaziv.Text,
                        datum_pocetka = dtDatum.Value,
                        partnerId = int.Parse(cboxPartner.SelectedValue.ToString()),
                        aktivan = 0,
                        gotovo = 0,
                        ukupna_cijena = 0,
                        cijena_bez_pdv = 0,
                        iznos_pdv = 0,
                        datum_zavrsetka = null,
                        korisnikId = 3,
                        potrebno_vrijeme = 0,
                        kod = GenerirajKod(6),
                    };
                    db.Projekt.Add(noviProjekt);
                    db.SaveChanges();
                }
            }
            else
            {
                using (var db = new UpravljanjeProjektimaEntities())
                {
                    db.Projekt.Attach(odabraniProjekt);
                    odabraniProjekt.ime = tboxNaziv.Text;
                    odabraniProjekt.datum_pocetka = dtDatum.Value;
                    odabraniProjekt.partnerId = int.Parse(cboxPartner.SelectedValue.ToString());
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Uspješno dodan projekt");
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
