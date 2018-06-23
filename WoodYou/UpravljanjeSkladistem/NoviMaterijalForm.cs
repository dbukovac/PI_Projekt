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
    public partial class NoviMaterijalForm : Form
    {
        private Materijal materijal=null;

        public NoviMaterijalForm()
        {
            InitializeComponent();
        }

        public NoviMaterijalForm(Materijal materijal)
        {
            InitializeComponent();
            this.materijal = materijal;
        }

        private void SpremiButton_Click(object sender, EventArgs e)
        {
            using (var db = new UpraljanjeSkladistemEntities())
            {
                if (materijal == null)
                {
                    Materijal noviMaterijal = new Materijal
                    {
                        naziv = nazivTextBox.Text,
                        cijena = cijenaNumericUpDown.Value,
                        kolicina = (int)kolicinaNumericUpDown.Value
                    };
                    db.Materijal.Add(noviMaterijal);
                    db.SaveChanges();
                }
                else
                {
                    db.Materijal.Attach(materijal);
                    materijal.naziv = nazivTextBox.Text;
                    materijal.cijena = cijenaNumericUpDown.Value;
                    materijal.kolicina = (int)kolicinaNumericUpDown.Value;
                    db.SaveChanges();
                }
                Close();
            }
        }

        private void NoviMaterijalForm_Load(object sender, EventArgs e)
        {
            if(materijal != null) {
                nazivTextBox.Text = materijal.naziv;
                cijenaNumericUpDown.Value = materijal.cijena;
                kolicinaNumericUpDown.Value = materijal.kolicina;
            }
        }
    }
}
