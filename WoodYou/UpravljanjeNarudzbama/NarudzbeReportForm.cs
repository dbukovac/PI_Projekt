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
    public partial class NarudzbeReportForm : Form
    {
        private Narudzbenica narudzbenica = null;
        public NarudzbeReportForm(Narudzbenica narudzbenica)
        {
            InitializeComponent();
            this.narudzbenica = narudzbenica;
        }

        private void NarudzbeReportForm_Load(object sender, EventArgs e)
        {
            NarudzbenicaBindingSource.DataSource = narudzbenica;
            DohvatiStavke();
            this.NarudzbenicaReportViewer.RefreshReport();
        }

        private void DohvatiStavke()
        {
            if (narudzbenica != null)
            {
                BindingList<Stavka_narudzbenice> stavke = null;
                BindingList<Materijal> materijali = new BindingList<Materijal>();
                using (var db = new UpravljanjeNarudzbamaEntities())
                {
                    db.Narudzbenica.Attach(narudzbenica);
                    stavke = new BindingList<Stavka_narudzbenice>(narudzbenica.Stavka_narudzbenice.ToList());
                    foreach (Stavka_narudzbenice stavka in stavke)
                    {
                        materijali.Add(stavka.Materijal);
                    }
                }
                Stavka_narudzbeniceBindingSource.DataSource = stavke;
                MaterijalBindingSource.DataSource = materijali;
            }
        }
    }
}
