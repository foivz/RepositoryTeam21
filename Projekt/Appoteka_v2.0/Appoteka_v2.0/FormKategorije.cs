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
    public partial class FormKategorije : Form
    {
        public FormKategorije()
        {
            InitializeComponent();
        }

        private void PrikaziKategorije()
        {
            BindingList<kategorijeLijekova> listaKategorija = null;
            using (var db = new appotekaDBEntities())
            {
                listaKategorija = new BindingList<kategorijeLijekova>(db.kategorijeLijekova.ToList());
            }

            kategorijeLijekovaBindingSource.DataSource = listaKategorija;
        }

        private void FormKategorije_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet1.kategorijeLijekova' table. You can move, or remove it, as needed.
            //this.kategorijeLijekovaTableAdapter.Fill(this.appotekaDBDataSet1.kategorijeLijekova);

            PrikaziKategorije();

        }

        private void btnKategorijeNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKategorijeNovi_Click(object sender, EventArgs e)
        {
            FormKategorijeNovi KategorijaNoviForma = new FormKategorijeNovi();
            KategorijaNoviForma.ShowDialog();
            PrikaziKategorije();
        }

        private void btnKategorijeIzmjeni_Click(object sender, EventArgs e)
        {
            kategorijeLijekova selektiranaKategorija = kategorijeLijekovaBindingSource.Current as kategorijeLijekova;
            if (selektiranaKategorija != null)
            {
                FormKategorijeNovi KategorijaNoviForma = new FormKategorijeNovi(selektiranaKategorija);
                KategorijaNoviForma.ShowDialog();
                PrikaziKategorije();

            }
        }

        private void btnKategorijeIzbrisi_Click(object sender, EventArgs e)
        {
            kategorijeLijekova selektiranaKategorija = kategorijeLijekovaBindingSource.Current as kategorijeLijekova;
            if (selektiranaKategorija != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new appotekaDBEntities())
                    {
                        db.kategorijeLijekova.Attach(selektiranaKategorija);
                        db.kategorijeLijekova.Remove(selektiranaKategorija);
                        db.SaveChanges();
                    }
                    PrikaziKategorije();
                }
            }
        }


    }
}
