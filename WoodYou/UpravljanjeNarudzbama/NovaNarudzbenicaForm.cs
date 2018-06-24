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
        public NovaNarudzbenicaForm()
        {
            InitializeComponent();
        }
        public NovaNarudzbenicaForm(Narudzbenica narudzbenica)
        {
            InitializeComponent();
            this.trenutnaNarudzbenica = narudzbenica;
        }
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

        private void DohvatiPartnere()
        {
            BindingList<Partner> partneri = null;
            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                partneri = new BindingList<Partner>(db.Partner.ToList());
            }
            partnerBindingSource.DataSource = partneri;
        }

        private void SpremiNarudzbuButton_Click(object sender, EventArgs e)
        {

            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                if (trenutnaNarudzbenica == null)
                {
                    Narudzbenica narudzbenica = new Narudzbenica
                    {
                        korisnikId = 2,
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
