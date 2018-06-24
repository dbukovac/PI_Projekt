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
    public partial class SkladisteForm : Form
    {
        /// <summary>
        /// Konstruktor forme
        /// </summary>
        private int tipKorisnika = 0;
        public SkladisteForm(int tipKorisnika)
        {
            InitializeComponent();
            this.tipKorisnika = tipKorisnika;
        }

        /// <summary>
        /// Metoda koja dohvaća sve materijal unesene u sustav,
        /// te postavlja odgovarajući DataSource
        /// </summary>
        private void DohvatiMaterijale()
        {
            BindingList<Materijal> materijali = null;
            using (var db = new UpraljanjeSkladistemEntities())
            {
                materijali = new BindingList<Materijal>(db.Materijal.ToList());
            }
            materijalBindingSource.DataSource = materijali;
        }
        /// <summary>
        /// Metoda koja se poziva kada se forma učita.
        /// Poziva metodu za dohvaćanje materijala.
        /// Ako je tip korisnika administrator,
        /// omogućuje gum za uređivanje materijala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkladisteForm_Load(object sender, EventArgs e)
        {
            DohvatiMaterijale();
            if(tipKorisnika == 1)
            {
                urediMaterijalButton.Enabled = true;
                urediMaterijalButton.Visible = true;
            }
        }
        /// <summary>
        /// Poziva se na gumb noviMaterijalButton.
        /// Otvara formu NoviMaterijalForm.
        /// Nakon zatvaranja poziva metodu za dovaćanje materijala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoviMaterijalButton_Click(object sender, EventArgs e)
        {
            NoviMaterijalForm materijalForm = new NoviMaterijalForm();
            materijalForm.ShowDialog(this);
            DohvatiMaterijale();
        }
        /// <summary>
        /// Poziva se na gumb urediMaterijalButton.
        /// Otvara formu NoviMaterijalForm u modu za ažuriranje.
        /// Nakon zatvaranja poziva metodu za dovaćanje materijala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UrediMaterijalButton_Click(object sender, EventArgs e)
        {
            Materijal trenutniMaterijal = materijalBindingSource.Current as Materijal;
            if(trenutniMaterijal != null)
            {
                NoviMaterijalForm materijalForm = new NoviMaterijalForm(trenutniMaterijal);
                materijalForm.ShowDialog(this);
                DohvatiMaterijale();
            }
        }
    }
}
