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
        public SkladisteForm()
        {
            InitializeComponent();
        }

        private void DohvatiMaterijale()
        {
            BindingList<Materijal> materijali = null;
            using (var db = new UpraljanjeSkladistemEntities())
            {
                materijali = new BindingList<Materijal>(db.Materijal.ToList());
            }
            materijalBindingSource.DataSource = materijali;
        }

        private void SkladisteForm_Load(object sender, EventArgs e)
        {
            DohvatiMaterijale();
        }

        private void PrimkeButton_Click(object sender, EventArgs e)
        {
            PrimkeForm primkeForm = new PrimkeForm();
            primkeForm.ShowDialog(this);
            DohvatiMaterijale();
        }

        private void NoviMaterijalButton_Click(object sender, EventArgs e)
        {
            NoviMaterijalForm materijalForm = new NoviMaterijalForm();
            materijalForm.ShowDialog(this);
            DohvatiMaterijale();
        }

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
