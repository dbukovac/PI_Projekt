﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjePoslovnimPartnerima
{
    public partial class PoslovniPartneriForm : Form
    {
        private int tipKorisnika;
        public PoslovniPartneriForm(int tipKorisnika)
        {
            InitializeComponent();
            this.tipKorisnika = tipKorisnika;
        }

        private void PoslovniPartneriForm_Load(object sender, EventArgs e)
        {
            PrikaziPartnere();
        }

        private void PrikaziPartnere()
        {
            BindingList<Partner> listaPartnera = null;
            BindingList<Tip_partnera> listaTipova = new BindingList<Tip_partnera>();
            using(var db = new UpravljanjePoslovnimPartnerimaEntities())
            {
                listaPartnera = new BindingList<Partner>(db.Partner.ToList());
                foreach (var P in listaPartnera)
                {
                    listaTipova.Add(P.Tip_partnera1 as Tip_partnera);
                }
            }
            partnerBindingSource.DataSource = listaPartnera;
            tippartneraBindingSource.DataSource = listaTipova;
        }

        private void noviPartnerbutton_Click(object sender, EventArgs e)
        {
            NoviPartnerForm forma = new NoviPartnerForm();
            forma.ShowDialog();
            PrikaziPartnere();
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            Partner selektiraniPartner = partnerBindingSource.Current as Partner;

            if(selektiraniPartner != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new UpravljanjePoslovnimPartnerimaEntities())
                    {
                        db.Partner.Attach(selektiraniPartner);
                        db.Partner.Remove(selektiraniPartner);
                        try
                        {
                            db.SaveChanges();
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Nije moguće obrisati partnera");
                        }
                    }
                }
                PrikaziPartnere();
            }
        }

        private void urediButton_Click(object sender, EventArgs e)
        {
            Partner selekitraniPartner = partnerBindingSource.Current as Partner;
            if(selekitraniPartner != null)
            {
                NoviPartnerForm forma = new NoviPartnerForm(selekitraniPartner);
                forma.ShowDialog();
                PrikaziPartnere();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingList<Partner> listaPartnera = null;
            BindingList<Partner> bindingListaPartnera = new BindingList<Partner>();
            BindingList<Tip_partnera> listaTipova = new BindingList<Tip_partnera>();
            using (var db = new UpravljanjePoslovnimPartnerimaEntities())
            {
                listaPartnera = new BindingList<Partner>(db.Partner.ToList());
                foreach (var P in listaPartnera)
                {
                    if(P.ime.ToLower().Contains(tboxPretrazi.Text))
                    {
                        bindingListaPartnera.Add(P);
                        listaTipova.Add(P.Tip_partnera1 as Tip_partnera);
                    }
                }
            }
            partnerBindingSource.DataSource = bindingListaPartnera;
            tippartneraBindingSource.DataSource = listaTipova;
        }
    }
}
