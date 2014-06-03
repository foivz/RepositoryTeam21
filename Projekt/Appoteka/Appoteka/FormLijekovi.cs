using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appoteka
{
    public partial class FormLijekovi : Form
    {
        public FormLijekovi()
        {
            InitializeComponent();
        }

        private void FormLijekovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet.lijekovi' table. You can move, or remove it, as needed.
           // this.lijekoviTableAdapter.Fill(this.appotekaDBDataSet.lijekovi);

            BindingList<lijekovi> listaLijekova = null;
            using (var db = new appotekaDBEntities2())
            {
                listaLijekova = new BindingList<lijekovi>(db.lijekovi.ToList());
            }
            lijekoviBindingSource.DataSource = listaLijekova;

        }
    }
}
