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

        private void BrisiMaterijalButton_Click(object sender, EventArgs e)
        {
            Materijal materijal = materijalBindingSource.Current as Materijal;
            if(materijal != null)
            {
                if (MessageBox.Show("Želite li zaista izbrisati materijal?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpraljanjeSkladistemEntities())
                    {
                        db.Materijal.Attach(materijal);
                        db.Materijal.Remove(materijal);
                        db.SaveChanges();
                    }
                    DohvatiMaterijale();
                }
            }
        }

        private void SmanjiKolicinuButton_Click(object sender, EventArgs e)
        {
            Materijal materijal = materijalBindingSource.Current as Materijal;
            if (materijal != null)
            {
                using (var db = new UpraljanjeSkladistemEntities())
                {
                    db.Materijal.Attach(materijal);
                    materijal.kolicina -= (int)kolicinaNumericUpDown.Value;
                    db.SaveChanges();
                }
                kolicinaNumericUpDown.Value = 0;
                DohvatiMaterijale();
            }
        }

        private void PrimkeButton_Click(object sender, EventArgs e)
        {
            PrimkeForm primkeForm = new PrimkeForm();
            primkeForm.ShowDialog(this);
        }
    }
}
