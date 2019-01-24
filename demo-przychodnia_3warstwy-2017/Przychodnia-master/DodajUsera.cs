using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class DodajUsera : Form
    {
        public DodajUsera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dodajlekarza frmDodajlekarza = new Dodajlekarza();
            DialogResult res = frmDodajlekarza.ShowDialog(this);

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajLaboranta frmDodajlaboranta = new DodajLaboranta();
            DialogResult res = frmDodajlaboranta.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajRejestr frmDodajRejestr = new DodajRejestr();
            DialogResult res = frmDodajRejestr.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DodajKierownika frmDodajKierownika = new DodajKierownika();
            DialogResult res = frmDodajKierownika.ShowDialog(this);

        }
    }
}
