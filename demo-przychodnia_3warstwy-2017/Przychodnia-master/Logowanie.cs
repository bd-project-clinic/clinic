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
            
                string role;

                User user_check = new User();
                user_check.uname = textBox1.Text;
                user_check.pass = textBox2.Text;

            
                role = AdminFacade.GetUsers(user_check);

            
                if (role == "DOC")
                {
                    Lekarz frmLekarz = new Lekarz();
                    DialogResult res = frmLekarz.ShowDialog(this);
                                      
                }
                else if (role == "LAB")
                {
                    DodajLaboranta frmDodajlaboranta = new DodajLaboranta(); // tutaj powinno być okno laboranta
                    DialogResult res = frmDodajlaboranta.ShowDialog(this);
                    

                }
                else if (role == "REJ")
                {
                    Rejestratorka frmDodajRejestr = new Rejestratorka();
                    DialogResult res = frmDodajRejestr.ShowDialog(this);
                    

                }
                else if (role == null)
                {
                    MessageBox.Show("Nie znaleziono użytkownika w bazie, podaj poprawny login i hasło");
                   
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
