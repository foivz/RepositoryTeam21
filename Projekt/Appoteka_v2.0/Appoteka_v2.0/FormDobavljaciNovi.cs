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

        //konstruktor za izmjenu (kao parametar prima selektiranog dobavljaca)
        public FormDobavljaciNovi(dobavljaci Dobavljac)
        {
            InitializeComponent();
            dobavljacZaIzmjenu = Dobavljac;
        }

       //nakon ucitavanja forme, fokus je na nazivu
        //ukoliko se radi o izmjeni (proslijeden parametar), na formi se prikazuju podaci selektiranog dobavljaca
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
                //ako se radi o unosu novog dobavljaca, stvara se nova instanca klase dobavljaci i popunjuje se podacima
                if (dobavljacZaIzmjenu == null)
                {
                    dobavljaci Dobavljac = new dobavljaci
                    {
                        OIB = textDobavljaciOIB.Text,
                        naziv = textDobavljaciNaziv.Text,
                        IBAN = textDobavljaciIBAN.Text,
                        adresa = textDobavljaciAdresa.Text
                    };

                    
                   //ako duljina OIB-a ili IBAN-a ne odgovara zadanom, greska
                    if (textDobavljaciOIB.TextLength != 11 || textDobavljaciIBAN.TextLength != 21)
                    {
                        textDobavljaciOIB.Focus();
                        MessageBox.Show("Neispravna duljina znakova kod unosa", "Neispravan unos");
                    }
                    else
                    {
                        //ukoliko je unos ispravan, novi dobavljac se dodaje i sprema u bazu
                        db.dobavljaci.Add(Dobavljac);
                        db.SaveChanges();
                        MessageBox.Show("Uspješno ste dodali novog dobavljača", "Ispravan unos");
                    }
                }
                else
                {
                    //ukoliko se radi o izmjeni, dobavljac za izmjenu se registrira i mijenjaju mu se podaci i spremaju u bazu podataka
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
