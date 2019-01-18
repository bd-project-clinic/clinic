using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;

namespace Przychodnia
{
    public partial class DodajBadFiz : Form
    {
        public DodajBadFiz()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod;
            string typ;
            string nazwa;
            kod = Convert.ToInt32(textBox1.Text);
            typ = textBox2.Text;
            nazwa = textBox3.Text;
            SL_Exam ex = new SL_Exam();
            ex.Code = kod;
            ex.type = typ;
            ex.name = nazwa;
            SlownikFacade.NewBadanie(ex);
            MessageBox.Show("Dodano badanie");
            this.Close();
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
