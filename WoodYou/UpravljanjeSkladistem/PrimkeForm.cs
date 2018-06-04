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
    public partial class PrimkeForm : Form
    {
        public PrimkeForm()
        {
            InitializeComponent();
        }

        private void PrikazPrimki()
        {
            BindingList<Primka> primke = null;
            using (var db = new UpraljanjeSkladistemEntities())
            {
                primke = new BindingList<Primka>(db.Primka.ToList());
            }
            primkaBindingSource.DataSource = primke;
        }
        
        private void PrikazStavki(Primka primka)
        {
            BindingList<Stavka_primke> stavke = null;
            using(var db = new UpraljanjeSkladistemEntities())
            {
                db.Primka.Attach(primka);
                stavke = new BindingList<Stavka_primke>(primka.Stavka_primke.ToList<Stavka_primke>());
            }
            stavka_primkeBindingSource.DataSource = stavke;
        }

        private void PrimkeForm_Load(object sender, EventArgs e)
        {
            PrikazPrimki();
            Primka primka = primkaBindingSource.Current as Primka;
            if(primka != null)
            {
                PrikazStavki(primka);
            }
        }

        private void PrimkaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Primka primka = primkaBindingSource.Current as Primka;
            if (primka != null)
            {
                PrikazStavki(primka);
            }
        }

        private void BrisiPrimkuButton_Click(object sender, EventArgs e)
        {
            Primka primka = primkaBindingSource.Current as Primka;
            if (primka != null)
            {
                if(MessageBox.Show("Želite li zaista izbrisati primku?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpraljanjeSkladistemEntities())
                    {
                        db.Primka.Attach(primka);
                        db.Primka.Remove(primka);
                        db.SaveChanges();
                    }

                    PrikazPrimki();
                    primka = primkaBindingSource.Current as Primka;
                    if (primka != null)
                    {
                        PrikazStavki(primka);
                    }
                }
                
            }
        }
    }
}
