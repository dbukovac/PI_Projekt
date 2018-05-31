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

        public PopisFazaForm(Projekt projekt)
        {
            InitializeComponent();
            odabraniProjekt = projekt;
        }

        private void PopisFazaForm_Load(object sender, EventArgs e)
        {
            PrikaziFaze();
        }

        private void PrikaziFaze()
        {
            BindingList<Faza> listaFaza = null;
            using(var db = new UpravljanjeProjektimaEntities())
            {
                listaFaza = new BindingList<Faza>(db.Faza.ToList());
            }
            fazaBindingSource.DataSource = listaFaza;
        }

        private void dodajFazuButton_Click(object sender, EventArgs e)
        {
            Faza selektiranaFaza = fazaBindingSource.Current as Faza;
            using (var db = new UpravljanjeProjektimaEntities())
            {
                db.Faza.Attach(selektiranaFaza);
                db.Projekt.Attach(odabraniProjekt);
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

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novaFazaButton_Click(object sender, EventArgs e)
        {
            NovaFazaForm novaFazaforma = new NovaFazaForm();
            novaFazaforma.ShowDialog();
            PrikaziFaze();
        }

        private void izmjeniFazuButton_Click(object sender, EventArgs e)
        {
            NovaFazaForm novaFazaforma = new NovaFazaForm(fazaBindingSource.Current as Faza);
            novaFazaforma.ShowDialog();
            PrikaziFaze();
        }
    }
}
