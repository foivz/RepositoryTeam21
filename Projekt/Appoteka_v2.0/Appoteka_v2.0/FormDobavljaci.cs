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
    public partial class FormDobavljaci : Form
    {
        public FormDobavljaci()
        {
            InitializeComponent();
        }

        private void PrikaziDobavljace()
        {
            BindingList<dobavljaci> listaDobavljaca = null;
            using (var db = new appotekaDBEntities())
            {
                listaDobavljaca = new BindingList<dobavljaci>(db.dobavljaci.ToList());
            }
            dobavljaciBindingSource.DataSource = listaDobavljaca;
        }


        private void FormDobavljaci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.dobavljaci' table. You can move, or remove it, as needed.
            //this.dobavljaciTableAdapter.Fill(this.appotekaDBDataSet2.dobavljaci);
            PrikaziDobavljace();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDobavljaciNovi_Click(object sender, EventArgs e)
        {
            FormDobavljaciNovi DobavljaciNoviForm = new FormDobavljaciNovi();
            DobavljaciNoviForm.ShowDialog();
            PrikaziDobavljace();
            
        }

        private void btnDobavljaciIzmijeni_Click(object sender, EventArgs e)
        {
            dobavljaci selektiraniDobavljac = dobavljaciBindingSource.Current as dobavljaci;
            if (selektiraniDobavljac != null)
            {
                FormDobavljaciNovi DobavljacNoviForma = new FormDobavljaciNovi(selektiraniDobavljac);
                DobavljacNoviForma.ShowDialog();
                PrikaziDobavljace();
            }
        }

        private void btnDobavljaciIzbrisi_Click(object sender, EventArgs e)
        {
            dobavljaci selektiraniDobavljac = dobavljaciBindingSource.Current as dobavljaci;
            if (selektiraniDobavljac != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new appotekaDBEntities())
                    {
                        db.dobavljaci.Attach(selektiraniDobavljac);
                        db.dobavljaci.Remove(selektiraniDobavljac);
                        db.SaveChanges();
                    }
                    PrikaziDobavljace();

                }
            }
        }
    }
}
