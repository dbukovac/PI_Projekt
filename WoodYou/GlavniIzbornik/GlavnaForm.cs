using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlavniIzbornik
{
    public partial class GlavnaForm : Form
    {
        private Korisnik logirani_korisnik = null;

        public GlavnaForm(Korisnik kor)
        {
            InitializeComponent();
            logirani_korisnik = kor;
        }
    }
}
