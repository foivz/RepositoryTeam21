using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appoteka_v2._0
{
    public partial class FormRacuniNovi : Form
    {
        private racun racunZaIzmjenu;
        public static BindingList<lijekovi> lijekoviRacun;


        public FormRacuniNovi()
        {
            InitializeComponent();
        }


        public FormRacuniNovi(racun Racun)
        {
            InitializeComponent();
            racunZaIzmjenu = Racun;
        }

        public FormRacuniNovi(BindingList<lijekovi> lR)
	    {
            InitializeComponent();
            lijekoviRacun = lR;
	    }


        private void PrintanjeRacuna()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += printDocument_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Racun ljekarna", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);

        }

        private void FormRacuniNovi_Load(object sender, EventArgs e)
        {
            this.zaposleniciTableAdapter.Fill(this.appotekaDBDataSet2.zaposlenici);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lijekoviBindingSource.DataSource = lijekoviRacun;
            float suma = 0;


            foreach (DataGridViewRow x in dataGridView1.Rows)
            {
                if (x.Cells[2].Value != null)
                {
                    try
                    {

                        using (var db = new appotekaDBEntities())
                        {
                            int sb = int.Parse(x.Cells[0].Value.ToString());
                            var lijek = (from l in db.lijekovi
                                         where
                                             l.serijskiBroj == sb
                                         select l).SingleOrDefault();

                            if (lijek.kolicina - int.Parse(x.Cells[4].Value.ToString()) < 0)
                            {
                                MessageBox.Show("Tražena količina ne postoji na skladištu");
                                x.Cells[5].Value = null;
                                x.Cells[4].Value = null;

                            }
                            else
                            {
                                float popust = float.Parse(x.Cells[2].Value.ToString()) *
                                float.Parse(x.Cells[4].Value.ToString()) * float.Parse(x.Cells[3].Value.ToString()) / 100;


                                suma += float.Parse(x.Cells[2].Value.ToString()) *
                                    float.Parse(x.Cells[4].Value.ToString()) - popust;

                                x.Cells[5].Value = float.Parse(x.Cells[2].Value.ToString()) *
                                    float.Parse(x.Cells[4].Value.ToString()) - popust;

                            }
                        }


                    }
                    catch
                    {
                        MessageBox.Show("Niste unjeli količine!");
                    }
                }

            }
            textRacuniIznos.Text = suma.ToString();


        }

        private void btnRacuniNoviSpremi_Click(object sender, EventArgs e)
        {

            using (var db = new appotekaDBEntities())
            {
                if (racunZaIzmjenu == null)
                {
                    
                     MessageBox.Show("Selected Item Text: " +comboBox1.SelectedValue.ToString()+ "\n" +
                    "Index: " + comboBox1.SelectedIndex.ToString());
                    racun Racun = new racun
                    {
                        iznos = Math.Round(Convert.ToSingle(textRacuniIznos.Text), 2),
                        datum = Convert.ToDateTime(dateTimeRacuniDatum.Text),
                        OIB = comboBox1.SelectedValue.ToString()
                        

                    };

                    db.racun.Add(Racun);

                    foreach (DataGridViewRow x in dataGridView1.Rows)
                    {
                        if (x.Cells[0].Value != null)
                        {
                            int sb = int.Parse(x.Cells[0].Value.ToString());
                            var lijek = (from l in db.lijekovi
                                         where
                                             l.serijskiBroj == sb
                                         select l).SingleOrDefault();

                            int novaKolicina = lijek.kolicina - int.Parse(x.Cells[4].Value.ToString());

                            db.lijekovi.Attach(lijek);
                            lijek.kolicina = novaKolicina;

                            Racun.lijekovi.Add(lijek);

                            db.SaveChanges();

                            
                        }
                    }

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

        private void btnNoviRacunDodaj_Click(object sender, EventArgs e)
        {
            FormDodavanjeLijekova dodajLijekForma = new FormDodavanjeLijekova();
            dodajLijekForma.Show();
            
        }

        //private void FormRacuniNovi_Click(object sender, EventArgs e)
        //{
        //    lijekoviBindingSource.DataSource = lijekoviRacun;

        //}

        //private void FormRacuniNovi_Activated(object sender, EventArgs e)
        //{
        //}

       

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormRacuniNovi_Activated_1(object sender, EventArgs e)
        {
            lijekoviBindingSource.DataSource = lijekoviRacun;
        }

        
    }
}
