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
    public partial class FormPrijava : Form
    {
       // private zaposlenici korime;
        public FormPrijava()
        {
            InitializeComponent();
        }

        private void provjeriZaposlenika()
        {
            

            using (var db = new appotekaDBEntities())
            {

                 var korime = (from z in db.zaposlenici where z.korIme == textPrijavaKorime.Text select z).SingleOrDefault();
                 

                if (korime != null)
                {
                   var lozinka = (from l in db.zaposlenici
                                   where l.lozinka == textPrijavaLozinka.Text
                                   select l).SingleOrDefault();

                   if (lozinka == null) MessageBox.Show("Neispravna lozinka", "Pogrešna prijava");
                   else
                   {
                       FormAppoteka NovaFormaAppoteka = new FormAppoteka();
                       NovaFormaAppoteka.Show();
                       this.Hide();
                       
                      
                   }

                }
                else
                    MessageBox.Show("Neispravno korisničko ime", "Pogrešna prijava");




            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            provjeriZaposlenika();
            
            

        }

        private void FormPrijava_Load(object sender, EventArgs e)
        {

        }
    }
}
