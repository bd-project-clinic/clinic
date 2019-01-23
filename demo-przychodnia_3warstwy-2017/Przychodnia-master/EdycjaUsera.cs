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
    public partial class EdycjaUsera : Form
    {
        public EdycjaUsera()
        {
            InitializeComponent();
        }
        private string patient_uname;


        public EdycjaUsera(string uname) : this()
        {
            patient_uname = uname;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            User usr = new User();
           
            usr.uname = patient_uname;
            usr.DT_retire = Convert.ToDateTime(textBox2.Text);
            
            AdminFacade.UpdateUserData(usr);
            // viewPatient();
            //(Form)this.Parent.
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
