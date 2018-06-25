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
        BindingList<Materijal> listaM = null;
        /// <summary>
        /// Prima se prosljeđena faza_projekta i lista već dodanog materijala
        /// </summary>
        /// <param name="faze_Projekta"></param>
        /// <param name="lista"></param>
        public PopisMaterijalaForm(Faze_projekta faze_Projekta, BindingList<Materijal> lista)
        {
            InitializeComponent();
            odabranaFazaProjekta = faze_Projekta;
            listaM = lista;
        }
        /// <summary>
        /// Metoda za prikazivanje svih materijala
        /// </summary>
        private void PrikaziMaterijal()
        {
            BindingList<Materijal> listaMaterijala = null;
            using (var db = new UpravljanjeProjektimaEntities())
            {
                listaMaterijala = new BindingList<Materijal>(db.Materijal.ToList());
            }
            materijalBindingSource.DataSource = listaMaterijala;
        }
        /// <summary>
        /// Poziva se metoda za prikazivanje materijala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopisMaterijalaForm_Load(object sender, EventArgs e)
        {
            PrikaziMaterijal();
        }
        /// <summary>
        /// Provjerava se ako označeni materijal nije u listi već dodanog materijala
        /// dodaje se u listu materijala faze(kako se opet ne bi mogao dodati) i 
        /// ako je odabrana količina manja od one na skladištu stvara se stavka materijala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajMaterijalButton_Click(object sender, EventArgs e)
        {
            Materijal selektiranMaterijal = materijalBindingSource.Current as Materijal;
            if(selektiranMaterijal != null && listaM.SingleOrDefault(x => x.materijalId == selektiranMaterijal.materijalId)==null)
            {
                if(selektiranMaterijal.kolicina > (int)numKolicina.Value)
                {
                    listaM.Add(selektiranMaterijal);
                    using (var db = new UpravljanjeProjektimaEntities())
                    {
                        Faza_ima_materijal noviMaterijalFaza = new Faza_ima_materijal
                        {
                            id = odabranaFazaProjekta.id,
                            materijalId = selektiranMaterijal.materijalId,
                            kolicina = (int)numKolicina.Value,
                        };
                        db.Faza_ima_materijal.Add(noviMaterijalFaza);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Uspješno dodan materijal");
                }
                else
                {
                    MessageBox.Show("Nema toliko traženog materijala na skladištu");
                }
            }
            else
            {
                MessageBox.Show("Taj materijal je već dodan na fazu!");
            }
            PrikaziMaterijal();
        }
        /// <summary>
        /// Zatvara se forma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Pretraživanje materijala prema nazivu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxPretrazi_TextChanged(object sender, EventArgs e)
        {
            BindingList<Materijal> listaMaterijala = null;
            BindingList<Materijal> bindingListaMaterijala = new BindingList<Materijal>();
            using (var db = new UpravljanjeProjektimaEntities())
            {
                listaMaterijala = new BindingList<Materijal>(db.Materijal.ToList());

                foreach (var M in listaMaterijala)
                {
                    if(M.naziv.ToLower().Contains(tboxPretrazi.Text))
                    {
                        bindingListaMaterijala.Add(M);
                    }
                }
            }
            materijalBindingSource.DataSource = bindingListaMaterijala;
        }
    }
}
