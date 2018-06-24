using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpravljanjeSkladistem;
using UpravljanjeNarudzbama;
using UpravljanjeProjektima;
using UpravljanjeKorisnicima;
using UpravljanjePoslovnimPartnerima;
using IzdavanjeRacuna;
using PrikazStatistike;
using System.Threading;

namespace GlavniIzbornik
{
    delegate void ShowFormDelegate(Form form, Form parentForm);

    public partial class GlavnaForm : Form
    {
        private Korisnik logirani_korisnik = null;

        public GlavnaForm(Korisnik kor)
        {
            InitializeComponent();
            logirani_korisnik = kor;
        }
        /// <summary>
        /// Prilikom učitavanja forme provjerava se ako je korisnik admin 
        /// da mu se prikaže opcija za upravljanje korisnicima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlavnaForm_Load(object sender, EventArgs e)
        {
            if (logirani_korisnik.tip_korisnikaId == 1)
            {
                korisniciToolStripMenuItem.Visible = true;
            }
        }
        /// <summary>
        /// Metoda za prikazivanje forme korištenjem delegata kako bi se smanjio teret na glavnoj dretvi
        /// </summary>
        /// <param name="form"></param>
        /// <param name="parentForm"></param>
        private void ShowForm(Form form, Form parentForm)
        {
            if(form.InvokeRequired)
            {
                ShowFormDelegate showFormDelegate = new ShowFormDelegate(ShowForm);
                form.BeginInvoke(showFormDelegate, form, parentForm);
            }
            else
            {
                form.MdiParent = parentForm;
                parentForm.Size = new Size(form.Width+15, form.Height+25);
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
        }
        /// <summary>
        /// Metode za obradu klika na izbonik na vrhu stranice,
        /// na klik otvaraju formu istog imena, te prosljeđuju tip korisnika i id korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrimkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimkeForm primkeForm = new PrimkeForm(logirani_korisnik.tip_korisnikaId, logirani_korisnik.korisnikId);
            ShowForm(primkeForm, this);
        }

        private void PregledSkladistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkladisteForm skladisteForm = new SkladisteForm(logirani_korisnik.tip_korisnikaId);
            ShowForm(skladisteForm, this);
        }

        private void PregledNarudžbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NarudzbeForm narudzbeForm = new NarudzbeForm(logirani_korisnik.tip_korisnikaId, logirani_korisnik.korisnikId);
            ShowForm(narudzbeForm, this);
        }

        private void PregledProjekataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopisProjektiForm projektiForm = new PopisProjektiForm(logirani_korisnik.tip_korisnikaId, logirani_korisnik.korisnikId);
            ShowForm(projektiForm, this);
        }
        /// <summary>
        /// Metode za obradu klika na izbonik na vrhu stranice,
        /// na klik otvaraju formu istog imena, te prosljeđuju samo tip korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PregledRacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledRacunForm pregledRacunForm = new PregledRacunForm(logirani_korisnik.tip_korisnikaId);
            ShowForm(pregledRacunForm, this);
        }

        private void IzdavanjeRacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzdavanjeRacunaForm izdavanjeRacunaForm = new IzdavanjeRacunaForm(logirani_korisnik.tip_korisnikaId);
            ShowForm(izdavanjeRacunaForm, this);
        }

        private void KorisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KorisniciForm korisniciForm  = new KorisniciForm(logirani_korisnik.tip_korisnikaId);
            ShowForm(korisniciForm, this);
        }

        private void StatistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            ShowForm(reportForm, this);
        }

        private void PoslovniPartneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoslovniPartneriForm partneriForm = new PoslovniPartneriForm(logirani_korisnik.tip_korisnikaId);
            ShowForm(partneriForm, this);
        }
    }
}
