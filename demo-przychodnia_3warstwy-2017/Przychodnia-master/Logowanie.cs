using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer;

namespace Przychodnia
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
                string role; // zwracany przez funkcje string (DOC,LAB,REJ).

                User user_check = new User();
                user_check.uname = textBox1.Text;
                user_check.pass = textBox2.Text;

            
                role = AdminFacade.GetUsers(user_check); // sprawdzanie w bizzlayer czy istnieje takie hasło oraz użytkownik.

            
                if (role == "DOC") // ZMIENCIE SOBIE W BAZIE ROLE NA NCHAR(3), INACZEJ NIE BĘDZIE DZIAŁAĆ.
                {
                    Dodajlekarza frmDodajlekarza = new Dodajlekarza();
                    DialogResult res = frmDodajlekarza.ShowDialog(this);
                    

                }
                else if (role == "LAB")
                {
                    DodajLaboranta frmDodajlaboranta = new DodajLaboranta();
                    DialogResult res = frmDodajlaboranta.ShowDialog(this);
                    

                }
                else if (role == "REJ")
                {
                    DodajRejestr frmDodajRejestr = new DodajRejestr();
                    DialogResult res = frmDodajRejestr.ShowDialog(this);
                    

                }
                else if (role == null) // jesli nie istnite podajemy komunikat.
                {
                    MessageBox.Show("Nie znaleziono użytkownika w bazie, podaj poprawny login i hasło");
                    InitializeComponent();
                }


            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
