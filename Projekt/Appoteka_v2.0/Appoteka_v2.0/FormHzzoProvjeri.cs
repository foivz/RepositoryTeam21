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
    public partial class FormHzzoProvjeri : Form
    {
        public FormHzzoProvjeri()
        {
            InitializeComponent();
            textZdrastvena.MaxLength = 10;
        }

        private void textSerijskiBroj_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void btnFormHzzoProvjeri_Click(object sender, EventArgs e)
        {
            try
            {
                double provjera = double.Parse(textZdrastvena.Text);
                if (provjera > 0000000000 && provjera < 9999999999)
                {
                    string selektiraniBroj = textZdrastvena.Text;
                    FormHzzoProvjeriBroj ProvjeriBrojForm = new FormHzzoProvjeriBroj(selektiraniBroj);
                    ProvjeriBrojForm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Unesite ponovno broj");
            }
        }

        private void textZdrastvena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selektiraniBroj = textZdrastvena.Text;
                FormHzzoProvjeriBroj ProvjeriBrojForm = new FormHzzoProvjeriBroj(selektiraniBroj);
                ProvjeriBrojForm.ShowDialog();
            }
        }
    }
}
