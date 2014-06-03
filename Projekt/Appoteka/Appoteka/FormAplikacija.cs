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
    public partial class FormAplikacija : Form
    {
        public FormAplikacija()
        {
            InitializeComponent();
        }

        private void FormAplikacija_Load(object sender, EventArgs e)
        {

        }

        private void miDataLijekovi_MouseUp(object sender, MouseEventArgs e)
        {
            FormLijekovi lijekoviForma = new FormLijekovi();
            lijekoviForma.MdiParent = this;
            lijekoviForma.WindowState = FormWindowState.Maximized;
            lijekoviForma.Show();
        }
    }
}
