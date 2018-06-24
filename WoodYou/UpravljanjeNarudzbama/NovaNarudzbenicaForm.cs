using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeNarudzbama
{
    public partial class NovaNarudzbenicaForm : Form
    {
        private Narudzbenica trenutnaNarudzbenica = null;
        private int idKorisnik;
        /// <summary>
        /// Konstruktor forme
        /// Postavlja ID trenutnog korisnika
        /// </summary>
        /// <param name="idKorisnik">ID korisnika</param>
        public NovaNarudzbenicaForm(int idKorisnik)
        {
            InitializeComponent();
            this.idKorisnik = idKorisnik;
        }
        /// <summary>
        /// Konstruktor forme za otvaranje forme u modu za ažuriranje
        /// </summary>
        /// <param name="narudzbenica">Trenutna narudzbenica</param>
        public NovaNarudzbenicaForm(Narudzbenica narudzbenica)
        {
            InitializeComponent();
            this.trenutnaNarudzbenica = narudzbenica;
        }
        /// <summary>
        /// Metoda koja se poziva na učitavanje forme.
        /// Poziva metodu za dohvaćanje partnera.
        /// Ako je u modu za uređivanje postavlja podatke o narudžbenici
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovaNarudzbenicaForm_Load(object sender, EventArgs e)
        {
            DohvatiPartnere();
            if (trenutnaNarudzbenica == null)
            {
                datumSlanjaDateTimePicker.MinDate = DateTime.Now;
                datumSlanjaDateTimePicker.MinDate = datumSlanjaDateTimePicker.MinDate.AddDays(-7);
                datumSlanjaDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                this.Text = "Uređivanje narudžbenice";
                datumSlanjaDateTimePicker.Value = trenutnaNarudzbenica.datum_slanja;
                partnerComboBox.SelectedValue = trenutnaNarudzbenica.partnerId;
            }
        }
        /// <summary>
        /// Metoda koja dohvaća listu partnera iz baze i dodjeljuje ju kao DataSource ComboBox-a
        /// </summary>
        private void DohvatiPartnere()
        {
            BindingList<Partner> partneri = null;
            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                partneri = new BindingList<Partner>(db.Partner.ToList());
            }
            partnerBindingSource.DataSource = partneri;
        }
        /// <summary>
        /// Metoda koja se poziva na tipku spremiNarudzbuButton
        /// Sprema novu narudzbenicu u bazu, odnosno sprema promjene nastale
        /// na staroj narudzbenici.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpremiNarudzbuButton_Click(object sender, EventArgs e)
        {

            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                if (trenutnaNarudzbenica == null)
                {
                    Narudzbenica narudzbenica = new Narudzbenica
                    {
                        korisnikId = idKorisnik,
                        partnerId = int.Parse(partnerComboBox.SelectedValue.ToString()),
                        datum_slanja = datumSlanjaDateTimePicker.Value
                    };
                    db.Narudzbenica.Add(narudzbenica);
                    db.SaveChanges();
                }
                else
                {
                    db.Narudzbenica.Attach(trenutnaNarudzbenica);
                    trenutnaNarudzbenica.datum_slanja = datumSlanjaDateTimePicker.Value;
                    trenutnaNarudzbenica.partnerId = int.Parse(partnerComboBox.SelectedValue.ToString());
                    db.SaveChanges();
                }
            }
            Close();
        } 
    }
}
