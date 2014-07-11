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
            Font font2 = new Font("Courier New", 12, FontStyle.Underline | FontStyle.Bold);
            Font font3 = new Font("Courier New", 12, FontStyle.Underline);

            SolidBrush brush = new SolidBrush(Color.Black);
            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 270;

            graphic.DrawString("Appoteka j.d.o.o", new Font("Courier New", 18,FontStyle.Bold), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("42000 VARAŽDIN, Ludbreška 3 \nOIB: 22383729384 vl. Gazda Šef", font, new SolidBrush(Color.Black),startX, startY + 30);

            string datum = "Datum: "+DateTime.Now.ToString("dd.MM.yyyy").PadRight(25);
            string vrijeme ="Vrijeme: "+DateTime.Now.ToString("hh:mm");
            string datumVrijeme = datum + vrijeme;
            graphic.DrawString(datumVrijeme, font, new SolidBrush(Color.Black),startX,startY +100);
            string izdao = "Račun izdao: " + comboBox1.Text;
            graphic.DrawString(izdao, font, brush, startX, startY + 130);
            graphic.DrawString("RAČUN broj: 33/2 ",new Font("Courier New",12,FontStyle.Bold),brush,startX,startY +160);

            string headNaziv = "Naziv".PadRight(15);
            string headKolicina = "Kolicina".PadRight(10);
            string headDopunsko = "Dopunsko".PadRight(15);
            string headIznos = "Iznos__".PadRight(45);
            string glavnaLinija = headNaziv + headKolicina + headDopunsko + headIznos;

            graphic.DrawString(glavnaLinija, font2, brush, startX, startY + 230);


            foreach (DataGridViewRow x in dataGridView1.Rows)
            {
                if (x.Cells[0].Value != null)
                {
                    string naziv = x.Cells[1].Value.ToString().PadRight(15);
                    string kolicina = x.Cells[4].Value.ToString().PadRight(10);
                    string dopunsko = string.Format("{0}%",x.Cells[3].Value.ToString()).PadRight(15);
                    string iznos = string.Format("{0} kn",x.Cells[5].Value.ToString()).PadRight(45);
                    string linija = naziv + kolicina + dopunsko + iznos;

                    graphic.DrawString(linija, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5;

                }

              
            }
            offset = offset + 20;

            graphic.DrawString("Total".PadRight(40) + string.Format("{0} kn", textRacuniIznos.Text), font, new SolidBrush(Color.Black), startX, startY + offset);
            
            float PDV = float.Parse(textRacuniIznos.Text)*25/100;
            string PDVispis = PDV.ToString();
            float UKUPNO = float.Parse(textRacuniIznos.Text) + PDV;
            string UKUPNOispis = UKUPNO.ToString();

            graphic.DrawString("PDV".PadRight(40) + string.Format("{0} kn", PDVispis), font3, brush, startX, startY + offset + 20);
            graphic.DrawString("UKUPNO za platiti:".PadRight(32) + string.Format("{0} kn", UKUPNOispis), new Font("Courier New", 14, FontStyle.Bold), brush, startX, startY + offset + 50);


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
                            else if (int.Parse(x.Cells[4].Value.ToString()) < 0) MessageBox.Show("Količina ne može biti negativna!");
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
                        MessageBox.Show("Niste unijeli količine!");
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

                    PrintanjeRacuna();
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
