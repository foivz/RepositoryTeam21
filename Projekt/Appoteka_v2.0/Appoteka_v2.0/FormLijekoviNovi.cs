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
    public partial class FormLijekoviNovi : Form
    {
        public static BindingList<kategorijeLijekova> LijekoviKategorije;


        public FormLijekoviNovi()
        {
            InitializeComponent();
        }

        private void btnLijekoviNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        private lijekovi LijekZaIzmjenu;

        public FormLijekoviNovi(lijekovi Lijek)
        {
            InitializeComponent();
            LijekZaIzmjenu = Lijek;
        }

        private void FormLijekoviNovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet1.kategorijeLijekova' table. You can move, or remove it, as needed.
            //this.kategorijeLijekovaTableAdapter.Fill(this.appotekaDBDataSet1.kategorijeLijekova);
            textSerijskiBroj.Focus();
            if (LijekZaIzmjenu != null)
            {
                textSerijskiBroj.Text = LijekZaIzmjenu.serijskiBroj.ToString();
                textNaziv.Text = LijekZaIzmjenu.naziv;
                textProizvodac.Text = LijekZaIzmjenu.proizvodac;
                textCijenaKupovna.Text = LijekZaIzmjenu.cijenaKupovna.ToString();
                textCijenaProdajna.Text = LijekZaIzmjenu.cijenaProdajna.ToString();
                dateRokTrajanja.MaxDate = LijekZaIzmjenu.rokTrajanja;
                textKolicina.Text = LijekZaIzmjenu.kolicina.ToString();
                textDopunsko.Text = LijekZaIzmjenu.dopunsko.ToString();
            }



        }

        

        private void btnLijekoviNoviSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new appotekaDBEntities())
            {
                if (LijekZaIzmjenu == null)
                {
                    lijekovi Lijek = new lijekovi
                    {
                        serijskiBroj = Convert.ToInt32(textSerijskiBroj.Text),
                        naziv = textNaziv.Text,
                        proizvodac = textProizvodac.Text,
                        cijenaKupovna = Math.Round(Convert.ToSingle(textCijenaKupovna.Text), 2),
                        cijenaProdajna = Math.Round(Convert.ToSingle(textCijenaProdajna.Text), 2),
                        rokTrajanja = dateRokTrajanja.MaxDate,
                        kolicina = Convert.ToInt32(textKolicina.Text),
                        dopunsko = Convert.ToInt32(textDopunsko.Text)
                    };

                    
                        
                        foreach (DataGridViewRow x in dataGridView1.Rows)
                        {
                            if (x.Cells[1].Value != null)
                            {
                                int k = int.Parse(x.Cells[1].Value.ToString());
                                var kategorija = ( from kl in db.kategorijeLijekova 
                                                   where kl.IdKategorije == k select kl).SingleOrDefault();

                                Lijek.kategorijeLijekova.Add(kategorija);

                            }
                        }

                        
                        db.lijekovi.Add(Lijek);
                            db.SaveChanges();
                        MessageBox.Show("Uspješno ste dodali novi lijek", "Ispravan unos");
                    }


                else
                {
                    db.lijekovi.Attach(LijekZaIzmjenu);
                    LijekZaIzmjenu.serijskiBroj = Convert.ToInt32(textSerijskiBroj.Text);
                    LijekZaIzmjenu.naziv = textNaziv.Text;
                    LijekZaIzmjenu.proizvodac = textProizvodac.Text;
                    LijekZaIzmjenu.cijenaKupovna = Convert.ToSingle(textCijenaKupovna.Text);
                    LijekZaIzmjenu.cijenaProdajna = Convert.ToSingle(textCijenaProdajna.Text);
                    LijekZaIzmjenu.rokTrajanja = Convert.ToDateTime(dateRokTrajanja.Text);
                    LijekZaIzmjenu.kolicina = Convert.ToInt32(textKolicina.Text);
                    LijekZaIzmjenu.dopunsko = Convert.ToInt32(textDopunsko.Text);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste izmijenili podatke o lijeku", "Izmjena podataka");


                }

                                
            }
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            FormDodavanjeKategorija FormaDodajKategorije = new FormDodavanjeKategorija();
            FormaDodajKategorije.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormLijekoviNovi_Activated(object sender, EventArgs e)
        {
            kategorijeLijekovaBindingSource.DataSource = LijekoviKategorije;

        }

        private void btnIzbrisiKategoriju_Click(object sender, EventArgs e)
        {
            kategorijeLijekova selektiranaKategorija = kategorijeLijekovaBindingSource.Current as kategorijeLijekova;

            LijekoviKategorije.Remove(selektiranaKategorija);
            kategorijeLijekovaBindingSource.DataSource = LijekoviKategorije;
        }

        private void textKolicina_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textKolicina.Text) <= 0)
            {
                MessageBox.Show("Neispravan unos");
                textKolicina.Focus();
            }
        }

        private void textCijenaKupovna_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textCijenaKupovna.Text) <= 0)
            {
                MessageBox.Show("Neispravan unos");
                textCijenaKupovna.Focus();
            }
        }

        private void textCijenaProdajna_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textCijenaProdajna.Text) <= 0)
            {
                MessageBox.Show("Neispravan unos");
                textCijenaProdajna.Focus();
            }
        }

        private void textDopunsko_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textDopunsko.Text) <= 0)
            {
                MessageBox.Show("Neispravan unos");
                textDopunsko.Focus();
            }
        }

        private void textSerijskiBroj_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textSerijskiBroj.Text) != 8)
            {
                MessageBox.Show("Serijski broj mora sadržavati 8 znakova", "Neispravan unos");
                textSerijskiBroj.Focus();
            }
        }
       
    }
}
