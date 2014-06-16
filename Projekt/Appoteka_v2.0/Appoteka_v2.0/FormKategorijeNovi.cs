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
    public partial class FormKategorijeNovi : Form
    {

        private kategorijeLijekova kategorijaZaIzmjenu;

        public FormKategorijeNovi()
        {
            InitializeComponent();
        }

        public FormKategorijeNovi(kategorijeLijekova kategorijaLijeka)
        {
            InitializeComponent();
            kategorijaZaIzmjenu = kategorijaLijeka;
        }

        private void FormKategorijeNovi_Load(object sender, EventArgs e)
        {
            textKategorijaNaziv.Focus();
            if (kategorijaZaIzmjenu != null)
            {
                textKategorijaNaziv.Text = kategorijaZaIzmjenu.naziv.ToString();
                textKategorijaOpis.Text = kategorijaZaIzmjenu.opis.ToString();
            }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKategorijeNoviSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new appotekaDBEntities())
            {
                if (kategorijaZaIzmjenu == null)
                {
                    kategorijeLijekova kategorijaLijek = new kategorijeLijekova 
                    { 
                        naziv = textKategorijaNaziv.Text,
                        opis = textKategorijaOpis.Text
                    };
                    db.kategorijeLijekova.Add(kategorijaLijek);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste dodali novu kategoriju lijeka", "Ispravan unos");
                }
                else
                {
                    db.kategorijeLijekova.Attach(kategorijaZaIzmjenu);
                    kategorijaZaIzmjenu.naziv = textKategorijaNaziv.Text;
                    kategorijaZaIzmjenu.opis = textKategorijaOpis.Text;
                    db.SaveChanges();
                }
            }
            Close();
        }

        
    }
}
