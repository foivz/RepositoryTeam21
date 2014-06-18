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
    public partial class FormRacuniNovi : Form
    {
        private racun racunZaIzmjenu;
        private lijekovi lijekNaRacun;
        public FormRacuniNovi()
        {
            InitializeComponent();
        }

        public FormRacuniNovi(racun Racun)
        {
            InitializeComponent();
            racunZaIzmjenu = Racun;
        }

        public FormRacuniNovi (lijekovi lnr)
	    {
            InitializeComponent();
            lijekNaRacun = lnr;
	    }


        private void FormRacuniNovi_Load(object sender, EventArgs e)
        {
            
            dateTimeRacuniDatum.Focus();
            if (racunZaIzmjenu != null)
            {
                textRacuniIznos.Text = racunZaIzmjenu.iznos.ToString();
                dateTimeRacuniDatum.MaxDate = racunZaIzmjenu.datum;
            }
            else
            {
                lijekoviBindingSource.DataSource = lijekNaRacun;


            }
        }

        private void btnRacuniNoviSpremi_Click(object sender, EventArgs e)
        {

            using (var db = new appotekaDBEntities())
            {
                if (racunZaIzmjenu == null)
                {
                    racun Racun = new racun
                    {
                        iznos = Math.Round(Convert.ToSingle(textRacuniIznos.Text), 2),
                        datum = Convert.ToDateTime(dateTimeRacuniDatum.Text),
                    };
                    db.racun.Add(Racun);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste dodali novi račun", "Ispravan unos");
                }
                else
                {
                    db.racun.Attach(racunZaIzmjenu);
                    racunZaIzmjenu.iznos = Convert.ToSingle(textRacuniIznos.Text);
                    racunZaIzmjenu.datum = Convert.ToDateTime(dateTimeRacuniDatum.Text);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste izmijenili račun", "Izmjena podataka");

                }


            }
            Close();
        }

        private void btnRacuniNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
