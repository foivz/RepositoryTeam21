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
    public partial class FormZaposleniciNovi : Form
    {
        private zaposlenici zaposlenikZaIzmjenu;
        public FormZaposleniciNovi()
        {
            InitializeComponent();
        }

        public FormZaposleniciNovi(zaposlenici Zaposlenik)
        {
            InitializeComponent();
            zaposlenikZaIzmjenu = Zaposlenik;
        }

        private void FormZaposleniciNovi_Load(object sender, EventArgs e)
        {
            textZaposleniciPrezime.Focus();
            if (zaposlenikZaIzmjenu != null)
            {
                textZaposleniciOIB.Text = zaposlenikZaIzmjenu.OIB;
                textZaposleniciIme.Text = zaposlenikZaIzmjenu.ime;
                textZaposleniciPrezime.Text = zaposlenikZaIzmjenu.prezime;
                textZaposleniciKorime.Text = zaposlenikZaIzmjenu.korIme;
                textZaposleniciLozinka.Text = zaposlenikZaIzmjenu.lozinka;
                textZaposleniciAdresa.Text = zaposlenikZaIzmjenu.adresa;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnZaposleniciNoviSpremi_Click(object sender, EventArgs e)
        {

            using (var db = new appotekaDBEntities())
            {
                if (zaposlenikZaIzmjenu == null)
                {
                    zaposlenici Zaposlenik = new zaposlenici
                    {
                        OIB = textZaposleniciOIB.Text,
                        ime = textZaposleniciIme.Text,
                        prezime = textZaposleniciPrezime.Text,
                        korIme = textZaposleniciKorime.Text,
                        lozinka = textZaposleniciLozinka.Text,
                        adresa = textZaposleniciAdresa.Text
                    };
                    

                    if (textZaposleniciOIB.TextLength != 11)
                    {
                        textZaposleniciOIB.Focus();
                        MessageBox.Show("OIB mora sadržavati 11 znakova", "Neispravan unos");
                                        
                        
                    }
                    else
                    {
                        db.zaposlenici.Add(Zaposlenik);
                        db.SaveChanges();
                        MessageBox.Show("Uspješno ste dodali novog zaposlenika", "Ispravan unos");
                    }
                }
                else
                {
                    db.zaposlenici.Attach(zaposlenikZaIzmjenu);
                    zaposlenikZaIzmjenu.ime = textZaposleniciIme.Text;
                    zaposlenikZaIzmjenu.prezime = textZaposleniciPrezime.Text;
                    zaposlenikZaIzmjenu.korIme = textZaposleniciKorime.Text;
                    zaposlenikZaIzmjenu.lozinka = textZaposleniciLozinka.Text;
                    zaposlenikZaIzmjenu.adresa = textZaposleniciAdresa.Text;
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste izmijenili podatke o zaposleniku", "Promjena podataka");


                }


            }
            Close();
        }

        private void btnZaposleniciNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
