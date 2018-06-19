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
    public partial class NovaStavkaPrimkeForm : Form
    {
        Primka trenutnaPrimka = null;
        BindingList<Stavka_primke> stavke = null;
        BindingList<Materijal> dodaniMaterijal = null;
        public NovaStavkaPrimkeForm(Primka primka)
        {
            InitializeComponent();
            trenutnaPrimka = primka;
            stavke = new BindingList<Stavka_primke>();
            dodaniMaterijal = new BindingList<Materijal>();
        }

        public void DohvatiMaterijale()
        {
            BindingList<Materijal> materijali = null;
            using (var db = new UpraljanjeSkladistemEntities())
            {
                materijali = new BindingList<Materijal>(db.Materijal.ToList());
            }
            materijalBindingSource.DataSource = materijali;
        }

        private void DodajMaterijalButton_Click(object sender, EventArgs e)
        {
            Materijal trenutniMaterijal = materijalBindingSource.Current as Materijal;
            if (trenutniMaterijal != null)
            {
                int dodanaKolicina = int.Parse(kolicinaNumericUpDown.Value.ToString());
                if (dodanaKolicina != 0)
                {
                    bool novaStavka = true;

                    foreach (Stavka_primke stavka in stavke)
                    {
                        if (trenutniMaterijal.materijalId == stavka.materijalId)
                        {
                            novaStavka = false;
                            stavka.kolicina += (int)kolicinaNumericUpDown.Value;
                        }
                    }

                    if (novaStavka)
                    {
                        Stavka_primke stavkaZaDodat = new Stavka_primke
                        {
                            primkaId = trenutnaPrimka.primkaId,
                            materijalId = trenutniMaterijal.materijalId,
                            kolicina = (int)kolicinaNumericUpDown.Value
                        };
                        stavke.Add(stavkaZaDodat);
                        Materijal noviMaterijal = new Materijal
                        {
                            materijalId = trenutniMaterijal.materijalId,
                            naziv = trenutniMaterijal.naziv,
                            kolicina = dodanaKolicina
                        };
                        dodaniMaterijal.Add(noviMaterijal);
                        dodaniMaterijalBindingSource.DataSource = dodaniMaterijal;
                    }
                    else
                    {
                        foreach (Materijal materijal in dodaniMaterijal)
                        {
                            if (trenutniMaterijal.materijalId == materijal.materijalId)
                            {
                                materijal.kolicina += (int)kolicinaNumericUpDown.Value;
                            }
                        }
                        dodaniMaterijal.ResetBindings();
                        dodaniMaterijalBindingSource.DataSource = dodaniMaterijal;
                    }
                }
            }
        }

        private void BrisiMaterijalButton_Click(object sender, EventArgs e)
        {
            Materijal trenutniMaterijal = dodaniMaterijalBindingSource.Current as Materijal;
            if (trenutniMaterijal != null)
            {
                for (int i = 0; i < stavke.Count; i++)
                {
                    if (trenutniMaterijal.materijalId == stavke[i].materijalId)
                    {
                        stavke.RemoveAt(i);
                        dodaniMaterijal.Remove(trenutniMaterijal);
                    }
                }
            }
            dodaniMaterijal.ResetBindings();
            dodaniMaterijalBindingSource.DataSource = dodaniMaterijal;
        }

        private void UreduButton_Click(object sender, EventArgs e)
        {
            foreach (Stavka_primke stavka in stavke)
            {
                using (var db = new UpraljanjeSkladistemEntities())
                {
                    db.Stavka_primke.Add(stavka);
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void NovaStavkaPrimkeForm_Load(object sender, EventArgs e)
        {
            DohvatiMaterijale();
        }
    }
}
