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
    public partial class Dodajlekarza : Form
    {
        public Dodajlekarza()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User usr = new User();
            usr.uname = textBox4.Text;
            usr.pass = textBox3.Text;
            usr.role = "DOC";
            usr.DT_retire = Convert.ToDateTime(textBox6.Text);
            AdminFacade.NewUserData(usr);

            Doctor doc = new Doctor();
            doc.uname = textBox4.Text;
            doc.Name = textBox1.Text;
            doc.Surname = textBox2.Text;
            doc.NPWZ = textBox5.Text;

            AdminFacade.NewDoctorData(doc);
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
