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

                    if ((textSerijskiBroj.Text).Length != 8)
                    {
                        MessageBox.Show("Serijski broj mora sadržavati točno 8 znakova", "Neispravan unos");
                    }
                    else
                    {
                        db.lijekovi.Add(Lijek);
                        db.SaveChanges();
                        MessageBox.Show("Uspješno ste dodali novi lijek", "Ispravan unos");
                    }

                    

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
       
    }
}
