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
    public partial class PopisMaterijalaForm : Form
    {
        Faze_projekta odabranaFazaProjekta = null;

        public PopisMaterijalaForm(Faze_projekta faze_Projekta)
        {
            InitializeComponent();
            odabranaFazaProjekta = faze_Projekta;
        }

        private void PopisMaterijalaForm_Load(object sender, EventArgs e)
        {
            BindingList<Materijal> listaMaterijala = null;
            using(var db = new UpravljanjeProjektimaEntities())
            {
                listaMaterijala = new BindingList<Materijal>(db.Materijal.ToList());
            }
            materijalBindingSource.DataSource = listaMaterijala;
        }

        private void dodajMaterijalButton_Click(object sender, EventArgs e)
        {
            Materijal selektiranMaterijal = materijalBindingSource.Current as Materijal;
            if(selektiranMaterijal != null)
            {
                using (var db = new UpravljanjeProjektimaEntities())
                {
                    Faza_ima_materijal noviMaterijalFaza = new Faza_ima_materijal
                    {
                        id = odabranaFazaProjekta.id,
                        materijalId = selektiranMaterijal.materijalId,
                        kolicina = int.Parse(tboxKolicina.Text.ToString()),
                    };
                    db.Faza_ima_materijal.Add(noviMaterijalFaza);
                    db.SaveChanges();
                }
                MessageBox.Show("Uspješno dodan materijal");
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
