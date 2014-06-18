﻿using System;
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
    public partial class FormLijekovi : Form
    {
        public FormLijekovi()
        {
            InitializeComponent();
        }

        private void PrikaziLijekove()
        {
            BindingList<lijekovi> listaLijekova = null;
            using (var db = new appotekaDBEntities())
            {
                listaLijekova = new BindingList<lijekovi>(db.lijekovi.ToList());
            }
            lijekoviBindingSource.DataSource = listaLijekova;
        }

        private void PrikaziKategorije()
        {
            lijekovi selektiraniLijek = lijekoviBindingSource.Current as lijekovi;
            if (selektiraniLijek != null)
            {
                using (var db = new appotekaDBEntities())
                {
                    var kategorija = from t3 in db.kategorijeLijekova
                                 from t2 in t3.lijekovi.Where(
              x => x.naziv == selektiraniLijek.naziv)
                                 select new { t3.IdKategorije, t3.naziv };

                    this.dataGridLijekoviKategorije.DataSource = kategorija.ToList();
                }
            }

        }
        /*
        private void PrikaziLadice()
        {
            kategorijeLijekova selektiranaKategorija = kategorijeLijekova.Current as kategorijeLijekova;
            if (selektiranaKategorija != null)
            {
                using (var db = new appotekaDBEntities())
                {
                    var ladica = from t3 in db.ladice
                                     from t2 in t3.kategorijeLijekova.Where(
                  x => x.naziv == selektiranaKategorija.naziv)
                                     select new { t3.kapacitet };

                    this.dataGridLijekoviLadice.DataSource = ladica.ToList();
                }
            }

        }
         */
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.kategorijeLijekova' table. You can move, or remove it, as needed.
            this.kategorijeLijekovaTableAdapter1.Fill(this.appotekaDBDataSet2.kategorijeLijekova);
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.lijekovi_has_kategorije' table. You can move, or remove it, as needed.
            this.lijekovi_has_kategorijeTableAdapter.Fill(this.appotekaDBDataSet2.lijekovi_has_kategorije);
            // TODO: This line of code loads data into the 'appotekaDBDataSet1.kategorijeLijekova' table. You can move, or remove it, as needed.
            this.kategorijeLijekovaTableAdapter.Fill(this.appotekaDBDataSet1.kategorijeLijekova);
            // TODO: This line of code loads data into the 'appotekaDBDataSet.lijekovi' table. You can move, or remove it, as needed.
            //this.lijekoviTableAdapter.Fill(this.appotekaDBDataSet.lijekovi);
            PrikaziLijekove();

        }

        private void btnLijekoviNovi_Click(object sender, EventArgs e)
        {
            FormLijekoviNovi LijekoviNoviForm = new FormLijekoviNovi();
            LijekoviNoviForm.ShowDialog();
            PrikaziLijekove();
        }

        private void btnLijekoviNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLijekoviIzmjeni_Click(object sender, EventArgs e)
        {
            lijekovi selektiraniLijek = lijekoviBindingSource.Current as lijekovi;
            if (selektiraniLijek != null)
            {
                FormLijekoviNovi LijekNoviForma = new FormLijekoviNovi(selektiraniLijek);
                LijekNoviForma.ShowDialog();
                PrikaziLijekove();
            }
        }

        private void btnLijekIzbrisi_Click(object sender, EventArgs e)
        {
            lijekovi selektiraniLijek = lijekoviBindingSource.Current as lijekovi;
            if (selektiraniLijek != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new appotekaDBEntities())
                    {
                        db.lijekovi.Attach(selektiraniLijek);
                        db.lijekovi.Remove(selektiraniLijek);
                        db.SaveChanges();
                    }
                    PrikaziLijekove();

                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziKategorije();
        }

        private void dataGridLijekoviKategorije_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
