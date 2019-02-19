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
    public partial class EdycjaUserow : Form
    {
        public EdycjaUserow()
        {
            InitializeComponent();
        }
        private string patient_uname;
        private string patient_role;

        public EdycjaUserow(string uname,string role) : this()
        {
            patient_uname = uname;
            patient_role = role;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User usr = new User();
            usr.uname = patient_uname;
            if(textBox5.Text!= "")
            usr.DT_retire = Convert.ToDateTime(textBox5.Text);
            if (textBox3.Text != "")
            usr.pass = AdminFacade.CreateMD5(textBox3.Text);
            AdminFacade.UpdateUserData(usr);
            if (patient_role == "SLAB      ")
            {
                SLab kier = new SLab();
                kier.uname = patient_uname;
                kier.Name = textBox1.Text;
                kier.Surname = textBox2.Text;
                AdminFacade.UpdateSLAbData(kier);
            }
            if (patient_role == "LAB       ")
            {
                Lab kier = new Lab();
                kier.uname = patient_uname;
                kier.Name = textBox1.Text;
                kier.Surname = textBox2.Text;
                AdminFacade.UpdateLabData(kier);
            }
            if (patient_role == "REJ       ")
            {
                Register kier = new Register();
                kier.uname = patient_uname;
                kier.Name = textBox1.Text;
                kier.Surname = textBox2.Text;
                AdminFacade.UpdateRegisterData(kier);
            }
            if (patient_role == "DOC       ")
            {
                Doctor kier = new Doctor();
                kier.uname = patient_uname;
                kier.Name = textBox1.Text;
                kier.Surname = textBox2.Text;
                kier.NPWZ = textBox4.Text;
                AdminFacade.UpdateDoctorData(kier);
            }
            // viewPatient();
            //(Form)this.Parent.
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
