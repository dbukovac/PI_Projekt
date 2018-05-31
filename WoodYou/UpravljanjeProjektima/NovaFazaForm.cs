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
    public partial class NovaFazaForm : Form
    {
        private Faza odabranaFaza = null;

        public NovaFazaForm()
        {
            InitializeComponent();
        }

        public NovaFazaForm(Faza faza)
        {
            InitializeComponent();
            odabranaFaza = faza;
        }

        private void NovaFazaForm_Load(object sender, EventArgs e)
        {
            if(odabranaFaza != null)
            {
                tboxNaziv.Text = odabranaFaza.naziv.ToString();
                tboxCijena.Text = odabranaFaza.cijena.ToString();
                tboxTrajanje.Text = odabranaFaza.trajanje.ToString();
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajFazuButton_Click(object sender, EventArgs e)
        {
            if(odabranaFaza == null)
            {
                using(var db = new UpravljanjeProjektimaEntities())
                {
                    Faza novaFaza = new Faza
                    {
                        naziv = tboxNaziv.Text,
                        cijena = decimal.Parse(tboxCijena.Text.ToString()),
                        trajanje = int.Parse(tboxTrajanje.Text.ToString()),
                    };
                    db.Faza.Add(novaFaza);
                    db.SaveChanges();
                }
                MessageBox.Show("Faza uspješno dodana");
            }
            else
            {
                using(var db = new UpravljanjeProjektimaEntities())
                {
                    db.Faza.Attach(odabranaFaza);
                    odabranaFaza.naziv = tboxNaziv.Text.ToString();
                    odabranaFaza.cijena = decimal.Parse(tboxCijena.Text.ToString());
                    odabranaFaza.trajanje = int.Parse(tboxTrajanje.Text.ToString());
                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}
