using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeKorisnicima
{
    public partial class KorisniciForm : Form
    {
        private int tipKorisnika;
        public KorisniciForm(int tipKorisnika)
        {
            InitializeComponent();
            this.tipKorisnika = tipKorisnika;
        }
        /// <summary>
        /// Prilikom učitavanja forme poziva se metoda za prikazivanje korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KorisniciForm_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();
        }
        /// <summary>
        /// Metoda za prikazivanje korisnika, dohvaća i tipove korisnika za prikazivanje imena umjesto id-a
        /// </summary>
        private void PrikaziKorisnike()
        {
            BindingList<Korisnik> listaKorisnika = null;
            BindingList<Tip_korisnika> listaTipova = new BindingList<Tip_korisnika>();
            using(var db = new UpravljanjeKorisnicimaEntities())
            {
                listaKorisnika = new BindingList<Korisnik>(db.Korisnik.ToList());
                foreach (Korisnik kor in listaKorisnika)
                {
                    listaTipova.Add(kor.Tip_korisnika);
                }
            }
            korisnikBindingSource.DataSource = listaKorisnika;
            tipkorisnikaBindingSource.DataSource = listaTipova;
        }
        /// <summary>
        /// Provjerava se ako je označen korisnik, javlja se poruka upozorenja, briše se korisnik
        /// ako referencijalni integritet baze to dopušta
        /// uz try catch hvata se iznimka baze ako se ne može brisati
        /// osvježava se datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void obrisiButton_Click(object sender, EventArgs e)
        {
            Korisnik selektiraniKorisnik = korisnikBindingSource.Current as Korisnik;
            if(selektiraniKorisnik != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using(var db = new UpravljanjeKorisnicimaEntities())
                    {
                        db.Korisnik.Attach(selektiraniKorisnik);
                        db.Korisnik.Remove(selektiraniKorisnik);
                        try
                        {
                            db.SaveChanges();
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Nije moguće obrisati korisnika koji se koristi");
                        }
                    }
                    PrikaziKorisnike();
                    MessageBox.Show("Uspješno obrisan korisnik");
                }
            }
        }
        /// <summary>
        /// Otvara novu formu za unos korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noviButton_Click(object sender, EventArgs e)
        {
            NoviKorisnikForm forma = new NoviKorisnikForm();
            forma.ShowDialog();
            PrikaziKorisnike();
        }
        /// <summary>
        /// Otvara formu za izmjenu korisnika i prosljeđuje označenog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izmjeniButton_Click(object sender, EventArgs e)
        {
            Korisnik selektiraniKorisnik = korisnikBindingSource.Current as Korisnik;
            if(selektiraniKorisnik != null)
            {
                NoviKorisnikForm forma = new NoviKorisnikForm(selektiraniKorisnik);
                forma.ShowDialog();
                PrikaziKorisnike();
            }
        }
        /// <summary>
        /// Izmjenom teksta u polju za pretraživanje prikazuju se samo korisnici
        /// čiji naziv paše pretrazi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxPretrazi_TextChanged(object sender, EventArgs e)
        {
            BindingList<Korisnik> listaKorisnika = null;
            BindingList<Korisnik> bindingListaKorisnika = new BindingList<Korisnik>();
            BindingList<Tip_korisnika> listaTipova = new BindingList<Tip_korisnika>();
            using (var db = new UpravljanjeKorisnicimaEntities())
            {
                listaKorisnika = new BindingList<Korisnik>(db.Korisnik.ToList());
                foreach (Korisnik kor in listaKorisnika)
                {
                    if(kor.ime.ToLower().Contains(tboxPretrazi.Text))
                    {
                        bindingListaKorisnika.Add(kor);
                        listaTipova.Add(kor.Tip_korisnika);
                    }
                }
            }
            korisnikBindingSource.DataSource = bindingListaKorisnika;
            tipkorisnikaBindingSource.DataSource = listaTipova;
        }
    }
}
