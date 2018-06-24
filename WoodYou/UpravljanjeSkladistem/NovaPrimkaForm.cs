using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeSkladistem
{
    public partial class NovaPrimkaForm : Form
    {
        Primka trenutnaPrimka = null;
        private int idKorisnika;
        /// <summary>
        /// Konstruktor forme NovaPrimkaForm
        /// </summary>
        /// <param name="idKorisnika">ID korisnika koji je ulogiran</param>
        public NovaPrimkaForm(int idKorisnika)
        {
            InitializeComponent();
            this.idKorisnika = idKorisnika;
        }
        /// <summary>
        /// Konstruktor forme NovaPrimkaForm za rad u modu za ažuriranje
        /// </summary>
        /// <param name="primka">Objekt tipa Primka, primka koja se ažurira</param>
        public NovaPrimkaForm(Primka primka)
        {
            InitializeComponent();
            trenutnaPrimka = primka;
        }
        /// <summary>
        /// Metoda koja dohvaća listu partnera iz baze i dodjeljuje ju kao DataSource ComboBox-a
        /// </summary>
        private void DohvatiPartnere()
        {
            BindingList<Partner> partneri = null;
            using (var db = new UpraljanjeSkladistemEntities())
            {
                partneri = new BindingList<Partner>(db.Partner.ToList());
            }
            partnerBindingSource.DataSource = partneri;
        }
        /// <summary>
        /// Metoda koja se poziva prilikom pokretanja forme.
        /// Poziva metodu za dohvaćanje partnera, te ako je u modu za ažuriranje,
        /// postavlja partnera i datum za primku koja se ažurira.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovaPrimkaForm_Load(object sender, EventArgs e)
        {
            DohvatiPartnere();
            if (trenutnaPrimka != null)
            {
                datumPrimitkaDateTimePicker.Value = trenutnaPrimka.datumPrimitka;
                partnerComboBox.SelectedValue = trenutnaPrimka.partnerId;
            }

        }
        /// <summary>
        /// Metoda koja se poziva na tipku ureduButton ("U redu").
        /// Sprema novu primku u bazu, odnosno sprema promjene nastale
        /// na staroj primci.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UreduButton_Click(object sender, EventArgs e)
        {
            using (var db = new UpraljanjeSkladistemEntities())
            {
                if (trenutnaPrimka == null)
                {
                    Primka novaPrimka = new Primka
                    {
                        datumPrimitka = datumPrimitkaDateTimePicker.Value,
                        korisnikId = idKorisnika,
                        partnerId = int.Parse(partnerComboBox.SelectedValue.ToString())
                    };
                    db.Primka.Add(novaPrimka);
                    db.SaveChanges();
                }
                else
                {
                    db.Primka.Attach(trenutnaPrimka);
                    trenutnaPrimka.datumPrimitka = datumPrimitkaDateTimePicker.Value;
                    trenutnaPrimka.partnerId = int.Parse(partnerComboBox.SelectedValue.ToString());
                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}
