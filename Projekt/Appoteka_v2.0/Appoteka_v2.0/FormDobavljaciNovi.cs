using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appoteka_v2._0
{
    public partial class FormDobavljaciNovi : Form
    {
        private dobavljaci dobavljacZaIzmjenu;
        public FormDobavljaciNovi()
        {
            InitializeComponent();
        }

        public FormDobavljaciNovi(dobavljaci Dobavljac)
        {
            InitializeComponent();
            dobavljacZaIzmjenu = Dobavljac;
        }

        private void FormDobavljaciNovi_Load(object sender, EventArgs e)
        {
            textDobavljaciNaziv.Focus();
            if (dobavljacZaIzmjenu != null)
            {
                textDobavljaciNaziv.Text = dobavljacZaIzmjenu.naziv;
                textDobavljaciOIB.Text = dobavljacZaIzmjenu.OIB;
                textDobavljaciIBAN.Text = dobavljacZaIzmjenu.IBAN;
                textDobavljaciAdresa.Text = dobavljacZaIzmjenu.adresa;

            }
        }

        private void btnDobavljaciNoviSpremi_Click(object sender, EventArgs e)
        {

            using (var db = new appotekaDBEntities())
            {
                if (dobavljacZaIzmjenu == null)
                {
                    dobavljaci Dobavljac = new dobavljaci
                    {
                        OIB = textDobavljaciOIB.Text,
                        naziv = textDobavljaciNaziv.Text,
                        IBAN = textDobavljaciIBAN.Text,
                        adresa = textDobavljaciAdresa.Text
                    };
                    db.dobavljaci.Add(Dobavljac);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste dodali novog dobavljača", "Ispravan unos");
                }
                else
                {
                    db.dobavljaci.Attach(dobavljacZaIzmjenu);
                    dobavljacZaIzmjenu.naziv = textDobavljaciNaziv.Text;
                    dobavljacZaIzmjenu.IBAN = textDobavljaciIBAN.Text;
                    dobavljacZaIzmjenu.adresa = textDobavljaciAdresa.Text;
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste izmijenili podatke o dobavljaču", "Promjena podataka");


                }


            }
            Close();
        }

        private void btnDobavljaciNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
