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
    public partial class DodajRejestr : Form
    {
        public DodajRejestr()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                MessageBox.Show("Nie wpisano nazwy użytkownika");
            else if (textBox3.Text == "")
                MessageBox.Show("Nie wpisano hasła");
            else if (textBox1.Text == "")
                MessageBox.Show("Nie wpisano imienia");
            else if (textBox2.Text == "")
                MessageBox.Show("Nie wpisano nazwiska");
            else if (textBox5.Text == "")
                MessageBox.Show("Nie wpisano daty wygaśnięcia konta");
            else
            {
                User usr = new User();
                usr.uname = textBox4.Text;
                usr.pass = textBox3.Text;
                usr.DT_retire = Convert.ToDateTime(textBox5.Text);
                usr.role = "REJ";
                string check = AdminFacade.NewUserData(usr);

                Register reg = new Register();
                reg.uname = textBox4.Text;
                reg.Name = textBox1.Text;
                reg.Surname = textBox2.Text;
                if (check == "tak")
                    AdminFacade.NewRegData(reg);
                else
                    MessageBox.Show("Login jest już używany");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
