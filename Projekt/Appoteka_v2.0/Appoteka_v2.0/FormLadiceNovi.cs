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
    public partial class FormLadiceNovi : Form
    {
        private ladice ladicaZaIzmjenu;
        public FormLadiceNovi()
        {
            InitializeComponent();
        }

        public FormLadiceNovi(ladice Ladica)
        {
            InitializeComponent();
            ladicaZaIzmjenu = Ladica;
        }

        private void FormLadiceNovi_Load(object sender, EventArgs e)
        {
            textLadiceNoviKapacitet.Focus();
            if (ladicaZaIzmjenu != null)
            {
                textLadiceNoviKapacitet.Text = ladicaZaIzmjenu.kapacitet.ToString();
            }
        }

        private void btnLadiceNoviSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new appotekaDBEntities())
            {
                if (ladicaZaIzmjenu == null)
                {
                    ladice Ladica = new ladice
                    {
                        kapacitet = Convert.ToInt32(textLadiceNoviKapacitet.Text)
                    };
                    db.ladice.Add(Ladica);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste dodali novu ladicu", "Ispravan unos");
                }
                else
                {
                    db.ladice.Attach(ladicaZaIzmjenu);
                    ladicaZaIzmjenu.kapacitet = Convert.ToInt32(textLadiceNoviKapacitet.Text);
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void btnLadiceNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
