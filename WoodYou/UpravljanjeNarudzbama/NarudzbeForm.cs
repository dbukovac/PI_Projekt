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
    public partial class NarudzbeForm : Form
    {
        public NarudzbeForm()
        {
            InitializeComponent();
        }

        private void PrikazNarudzbi()
        {
            BindingList<Narudzbenica> narudzbenice = null;
            using (var db = new UpravljanjeNarudzbamaEntities())
            {
                narudzbenice = new BindingList<Narudzbenica>(db.Narudzbenica.ToList());
            }
            narudzbenicaBindingSource.DataSource = narudzbenice;
        }

        private void PrikazStavki(Narudzbenica narudzbenica)
        {
            BindingList<Stavka_narudzbenice> stavke = null;
            using(var db = new UpravljanjeNarudzbamaEntities())
            {
                db.Narudzbenica.Attach(narudzbenica);
                stavke = new BindingList<Stavka_narudzbenice>(narudzbenica.Stavka_narudzbenice.ToList<Stavka_narudzbenice>());
            }
            stavkanarudzbeniceBindingSource.DataSource = stavke;
        }

        private void NarudzbeForm_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
            PrikazStavki(narudzbenicaBindingSource.Current as Narudzbenica);
        }

        private void NarudzbeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            if(narudzbenica != null)
            {
                PrikazStavki(narudzbenica);
            }
        }
    }
}
