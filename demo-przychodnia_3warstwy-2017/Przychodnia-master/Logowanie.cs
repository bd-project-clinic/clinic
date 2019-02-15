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
            textBox2.UseSystemPasswordChar = true;
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

            
            
                role = AdminFacade.GetUsersLogin(user_check);
            
           
            
            
                if (role == "DOC       ")
                {
                    Doctor doc1 = new Doctor();
                    int IDdoc = AdminFacade.GetUsersLoginDoctor(user_check);
                    doc1.Id_Doc = IDdoc;

                    Lekarz frmLekarz = new Lekarz(doc1.Id_Doc);
                    DialogResult res = frmLekarz.ShowDialog(this);
                                      
                }
            else if (role == "LAB       ")
                {


                    Lab lab1 = new Lab();
                    int IDlab = AdminFacade.GetUsersLoginLab(user_check);
                    lab1.Id_Lab = IDlab;

                    Laborant frmlaborant = new Laborant(lab1.Id_Lab); // tutaj powinno być okno laboranta
                    DialogResult res = frmlaborant.ShowDialog(this);
                    

                }
            else if (role == "SLAB      ")
            {


                SLab slab1 = new SLab();
                int IDlab = AdminFacade.GetUsersLoginSLab(user_check);
                slab1.Id_SLab = IDlab;

                Szef_laborant frmszef = new Szef_laborant(slab1.Id_SLab);
                DialogResult res = frmszef.ShowDialog(this);


            }

            else if (role == "REJ       ")
                {
                Register Reg1 = new Register();
                int IDReg = AdminFacade.GetUsersLoginReg(user_check);
                Reg1.Id_Reg = IDReg;
                    
                    Rejestratorka frmDodajRejestr = new Rejestratorka(Reg1.Id_Reg);
                    DialogResult res = frmDodajRejestr.ShowDialog(this);
                    

                }
                else if (role == "ADM       ")
                {
                    Admin frmAdmin = new Admin();
                    DialogResult res = frmAdmin.ShowDialog(this);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
