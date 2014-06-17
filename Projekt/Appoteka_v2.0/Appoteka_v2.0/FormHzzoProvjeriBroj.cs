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
    public partial class FormHzzoProvjeriBroj : Form
    {
        public FormHzzoProvjeriBroj()
        {
            InitializeComponent();
        }

        private void FormHzzoProvjeriBroj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hzzoDBDataSet.hzzoKlijent' table. You can move, or remove it, as needed.
            this.hzzoKlijentTableAdapter.Fill(this.hzzoDBDataSet.hzzoKlijent);

        }
    }
}
