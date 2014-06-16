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
    public partial class FormAppoteka : Form
    {
        public FormAppoteka()
        {
            InitializeComponent();
        }

        private void miBrowseLijekovi_MouseUp(object sender, MouseEventArgs e)
        {
            FormLijekovi LijekoviForma = new FormLijekovi();
            LijekoviForma.MdiParent = this;
            LijekoviForma.WindowState = FormWindowState.Maximized;
            LijekoviForma.Show();
        }

        private void miFileExit_MouseUp(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void miManagementKategorije_MouseUp(object sender, MouseEventArgs e)
        {
            FormKategorije KategorijeForm = new FormKategorije();
            KategorijeForm.MdiParent = this;
            KategorijeForm.WindowState = FormWindowState.Maximized;
            KategorijeForm.Show();
        }
    }
}
