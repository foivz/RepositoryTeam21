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
    public partial class FormHzzoProvjeriBroj : Form
    {
        private hzzoKlijent klijent;
        private List<hzzoRecept> recept = null;
        private List<hzzoLijekovi> lijek = null;
        private string zdrastvenaBroj;

        public FormHzzoProvjeriBroj(string zB)
        {
            InitializeComponent();
            zdrastvenaBroj = zB;
        }

        private void PrikaziKlijenta()
        {
            using (var db = new  HzzoDBEntities())
            {
                klijent = (from k in db.hzzoKlijent where k.zdrastvenaIskaznica == zdrastvenaBroj
                               select k).FirstOrDefault<hzzoKlijent>();


                if (klijent != null)
                {
                    recept = (from r in db.hzzoRecept
                              where r.OIB == klijent.OIB
                              select r).ToList();

                }
            }
            hzzoReceptBindingSource.DataSource = recept;

        }
        private void PrikaziLijek()
        {
            hzzoRecept selektiraniRecept = hzzoReceptBindingSource.Current as hzzoRecept;
            if (selektiraniRecept != null)
            {
                using (var db = new HzzoDBEntities())
                {
                    lijek = (from l in db.hzzoLijekovi
                             where l.serijskiBroj == selektiraniRecept.serijskiBroj
                             select l).ToList();
                }
            }
            hzzoLijekoviBindingSource.DataSource = lijek;
        }



        private void FormHzzoProvjeriBroj_Load(object sender, EventArgs e)
        {
           
            PrikaziKlijenta();
            
            
            if (klijent == null)
            {
                MessageBox.Show("Ne postoji korisnik sa tom zdrastvenom iskaznicom", "Greška");
                
            }
            else
            {
                textKlijentIme.Focus();
                textKlijentIme.Text = klijent.ime.ToString();
                textKlijentPrezime.Text = klijent.prezime.ToString();
                textKlijentOib.Text = klijent.OIB.ToString();
                textKlijentZdrastvena.Text = klijent.zdrastvenaIskaznica.ToString();
            }

        }

        private void dataGridView2_MouseUp(object sender, MouseEventArgs e)
        {
            PrikaziLijek();
        }

        private void btnProvjeriBrojIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        

        
    }
}
