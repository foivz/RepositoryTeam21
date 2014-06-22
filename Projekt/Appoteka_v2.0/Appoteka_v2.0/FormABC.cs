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
    public partial class FormABC : Form
    {
        public FormABC()
        {
            InitializeComponent();
        }

        private void txtKlasificiraj_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, 800);
            int y = random.Next(0, 800);
            Cursor.Position = new Point(x, y);
            int r = random.Next(0, 255);
            int g = random.Next(0, 255);
            int b = random.Next(0, 255);
            this.BackColor = Color.FromArgb(r,g,b);
            

        }
    }
}
