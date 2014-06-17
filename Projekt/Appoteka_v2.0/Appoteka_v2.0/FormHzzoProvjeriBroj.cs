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

                    hzzoRecept selektiraniRecept = hzzoReceptBindingSource.Current as hzzoRecept;
                    if (selektiraniRecept != null)
                    {
                        MessageBox.Show("Ne postoji korisnik sa tom zdrastvenom iskaznicom", "Greška");
                        lijek = (from l in db.hzzoLijekovi
                                    where l.serijskiBroj == selektiraniRecept.serijskiBroj
                                    select l).ToList();
                        
                    }

                }
                
                           
            }
            hzzoReceptBindingSource.DataSource = recept;
            
        }

       
        


        private void FormHzzoProvjeriBroj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hzzoDBDataSet.hzzoLijekovi' table. You can move, or remove it, as needed.
            //this.hzzoLijekoviTableAdapter.Fill(this.hzzoDBDataSet.hzzoLijekovi);
            // TODO: This line of code loads data into the 'hzzoDBDataSet.hzzoRecept' table. You can move, or remove it, as needed.
            //this.hzzoReceptTableAdapter.Fill(this.hzzoDBDataSet.hzzoRecept);
            // TODO: This line of code loads data into the 'hzzoDBDataSet.hzzoKlijent' table. You can move, or remove it, as needed.
            // this.hzzoKlijentTableAdapter.Fill(this.hzzoDBDataSet.hzzoKlijent);
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
    }
}
