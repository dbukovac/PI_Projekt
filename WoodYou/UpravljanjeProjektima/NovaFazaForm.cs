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
        /// <summary>
        /// Popunjavaju se polja ako se radi o izmjeni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoda za generiranje QR koda koja koristi QRCodeGenerator dll
        /// generira se prema šifri faze i sprema se u output folder
        /// </summary>
        /// <param name="sifra"></param>
        private void generirajQRKod(string sifra)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(sifra, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save(sifra + ".jpeg", ImageFormat.Jpeg);
            MessageBox.Show("Generiran novi QR kod");
        }

        //private void zamijeniQRKod(string sifra)
        //{
        //    generirajQRKod(sifra);

        //    if (File.Exists(staroImeFaze + ".jpeg"))
        //    {
        //        File.Delete(staroImeFaze + ".jpeg");
        //    }
        //}

        /// <summary>
        /// Ako je novi unos onda se stvara novi objekt i generira se QR kod,
        /// ako je izmjena onda se mijenjaju podaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajFazuButton_Click(object sender, EventArgs e)
        {
            if(odabranaFaza == null)
            {
                string sifra;
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

                    sifra = novaFaza.fazaId.ToString();
                }
                generirajQRKod(sifra);
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
                Close();
            }
        }
    }
}
