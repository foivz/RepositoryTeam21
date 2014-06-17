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
    public partial class FormNarudzbeNovi : Form
    {
        private narudzbe narudzbaZaIzmjenu;
        public FormNarudzbeNovi()
        {
            InitializeComponent();
        }

        public FormNarudzbeNovi(narudzbe Narudzba)
        {
            InitializeComponent();
            narudzbaZaIzmjenu = Narudzba;
        }

        private void FormNarudzbeNovi_Load(object sender, EventArgs e)
        {
            textNarudzbeIznos.Focus();
            if (narudzbaZaIzmjenu != null)
            {
                textNarudzbeIznos.Text = narudzbaZaIzmjenu.iznos.ToString();
                dateTimeNaruzbeDatum.MaxDate = narudzbaZaIzmjenu.datum;
            }
        }

        private void btnNarudzbeNoviSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new appotekaDBEntities())
            {
                if (narudzbaZaIzmjenu == null)
                {
                    narudzbe Narudzba = new narudzbe
                    {
                        iznos = Math.Round(Convert.ToSingle(textNarudzbeIznos.Text), 2),
                        datum = Convert.ToDateTime(dateTimeNaruzbeDatum.Text),
                    };
                    db.narudzbe.Add(Narudzba);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste dodali novu narudžbu", "Ispravan unos");
                }
                else
                {
                    db.narudzbe.Attach(narudzbaZaIzmjenu);
                    narudzbaZaIzmjenu.iznos = Convert.ToSingle(textNarudzbeIznos.Text);
                    narudzbaZaIzmjenu.datum = Convert.ToDateTime(dateTimeNaruzbeDatum.Text);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste izmijenili narudžbu", "Izmjena podataka");

                }


            }
            Close();
        }

        private void btnNarudzbeNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
