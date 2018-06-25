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
    public partial class PopisFazaForm : Form
    {
        private Projekt odabraniProjekt = null;
        private BindingList<Faza> listaFaza = null;
        private int tipKorisnika;

        public PopisFazaForm(Projekt projekt, BindingList<Faza> lista, int id)
        {
            InitializeComponent();
            odabraniProjekt = projekt;
            listaFaza = lista;
            tipKorisnika = id;
        }
        /// <summary>
        /// Provjerava se tip korisnika i ako je admin prikazuju se tipke za njegove akcije
        /// Poziva se metoda za prikaz faza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopisFazaForm_Load(object sender, EventArgs e)
        {
            if(tipKorisnika == 1)
            {
                obrisiFazuButton.Visible = true;
                dodajFazuButton.Visible = true;
                izmjeniFazuButton.Visible = true;
            }
            PrikaziFaze();
        }
        /// <summary>
        /// Metoda za prikaz svih faza
        /// </summary>
        private void PrikaziFaze()
        {
            BindingList<Faza> listaFaza = null;
            using(var db = new UpravljanjeProjektimaEntities())
            {
                listaFaza = new BindingList<Faza>(db.Faza.ToList());
            }
            fazaBindingSource.DataSource = listaFaza;
        }
        /// <summary>
        /// Dodaje se faza na prosljeđeni projekt ako za projekt nije izdan račun
        /// stvara se novi objekt faza_projekta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajFazuButton_Click(object sender, EventArgs e)
        {
            Faza selektiranaFaza = fazaBindingSource.Current as Faza;
            if (odabraniProjekt.gotovo != 1)
            {
                using (var db = new UpravljanjeProjektimaEntities())
                {
                    //db.Faza.Attach(selektiranaFaza);
                    //db.Projekt.Attach(odabraniProjekt);
                    Faze_projekta novaFazaProjekta = new Faze_projekta
                    {
                        fazaId = selektiranaFaza.fazaId,
                        projektId = odabraniProjekt.projektId,
                        zakljucano = 0,
                    };
                    db.Faze_projekta.Add(novaFazaProjekta);
                    db.SaveChanges();
                }
                MessageBox.Show("Uspješno dodana faza");
            }
            else
            {
                MessageBox.Show("Projekt je završen!");
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Otvara formu za unos nove faze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void novaFazaButton_Click(object sender, EventArgs e)
        {
            NovaFazaForm novaFazaforma = new NovaFazaForm();
            novaFazaforma.ShowDialog();
            PrikaziFaze();
        }
        /// <summary>
        /// Otvara formu za izmjenu faze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izmjeniFazuButton_Click(object sender, EventArgs e)
        {
            NovaFazaForm novaFazaforma = new NovaFazaForm(fazaBindingSource.Current as Faza);
            novaFazaforma.ShowDialog();
            PrikaziFaze();
        }
        /// <summary>
        /// Briše se odabrana faza ako se potvrdi poruka i ako baza ne vrati iznimku
        /// zbog referencijalnog integriteta koja se obrađuje sa try catch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void obrisiFazuButton_Click(object sender, EventArgs e)
        {
            Faza selektiranaFaza = fazaBindingSource.Current as Faza;
            if(selektiranaFaza != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpravljanjeProjektimaEntities())
                    {
                        db.Faza.Attach(selektiranaFaza);
                        db.Faza.Remove(selektiranaFaza);
                        try
                        {
                            db.SaveChanges();
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Nije moguće izbrisati fazu koja se koristis");
                        }
                    }
                    PrikaziFaze();
                }
            }
        }
        /// <summary>
        /// Pretraživanje faza prema nazivu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxPretrazi_TextChanged(object sender, EventArgs e)
        {
            BindingList<Faza> listaFaza = null;
            BindingList<Faza> bindingListaFaza = new BindingList<Faza>();
            using (var db = new UpravljanjeProjektimaEntities())
            {
                listaFaza = new BindingList<Faza>(db.Faza.ToList());

                foreach (var F in listaFaza)
                {
                    if(F.naziv.ToLower().Contains(tboxPretrazi.Text))
                    {
                        bindingListaFaza.Add(F);
                    }
                }
            }
            fazaBindingSource.DataSource = bindingListaFaza;
        }
    }
}
