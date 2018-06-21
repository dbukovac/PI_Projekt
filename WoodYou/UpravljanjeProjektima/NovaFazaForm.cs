using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeProjektima
{
    public partial class NovaFazaForm : Form
    {
        private Faza odabranaFaza = null;

        private string staroImeFaze = null;

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
                numCijena.Value = odabranaFaza.cijena;
                numTrajanje.Value = odabranaFaza.trajanje;

                staroImeFaze = odabranaFaza.naziv.ToString();
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generirajQRKod(string naziv)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(naziv, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save(naziv + ".jpeg", ImageFormat.Jpeg);
            MessageBox.Show("Generiran novi QR kod");
        }

        private void zamijeniQRKod(string naziv)
        {
            generirajQRKod(naziv);

            if (File.Exists(staroImeFaze + ".jpeg"))
            {
                File.Delete(staroImeFaze + ".jpeg");
            }
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
                        cijena = numCijena.Value,
                        trajanje = (int)numTrajanje.Value,
                    };
                    db.Faza.Add(novaFaza);
                    db.SaveChanges();
                }
                generirajQRKod(tboxNaziv.Text);
            }
            else
            {
                using(var db = new UpravljanjeProjektimaEntities())
                {
                    db.Faza.Attach(odabranaFaza);
                    odabranaFaza.naziv = tboxNaziv.Text.ToString();
                    odabranaFaza.cijena = numCijena.Value;
                    odabranaFaza.trajanje = (int)numTrajanje.Value;
                    db.SaveChanges();
                }

                if(tboxNaziv.Text != staroImeFaze)
                {
                    zamijeniQRKod(tboxNaziv.Text);
                }

                Close();
            }
        }
    }
}
