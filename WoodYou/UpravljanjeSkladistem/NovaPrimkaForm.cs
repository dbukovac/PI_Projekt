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
        public NovaPrimkaForm()
        {
            InitializeComponent();
        }

        public NovaPrimkaForm(Primka primka)
        {
            InitializeComponent();
            trenutnaPrimka = primka;
        }

        private void DohvatiPartnere()
        {
            BindingList<Partner> partneri = null;
            using (var db = new UpraljanjeSkladistemEntities())
            {
                partneri = new BindingList<Partner>(db.Partner.ToList());
            }
            partnerBindingSource.DataSource = partneri;
        }

        private void NovaPrimkaForm_Load(object sender, EventArgs e)
        {
            DohvatiPartnere();
            if (trenutnaPrimka != null)
            {
                partnerComboBox.SelectedValue = trenutnaPrimka.partnerId;
            }

        }

        private void UreduButton_Click(object sender, EventArgs e)
        {
            using (var db = new UpraljanjeSkladistemEntities())
            {
                if (trenutnaPrimka == null)
                {
                    Primka novaPrimka = new Primka
                    {
                        datumPrimitka = datumPrimitkaDateTimePicker.Value,
                        korisnikId = 2,
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
