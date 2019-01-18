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
    public partial class RejestracjaPacjenta : Form
    {
        public RejestracjaPacjenta()
        {
            InitializeComponent();
            dataGridView1.DataSource = RegistrationFacade.GetDoctors(null);
            
            
        }

        private int patientId;

        public RejestracjaPacjenta(int Id):this ()
        {
            patientId = Id;
        }

        private void viewPatient()
        {

            Patient searchCrit = new Patient();
            searchCrit.Id_Pat = patientId;
            IQueryable<Patient> patList = RegistrationFacade.GetPatients(searchCrit);
            Patient patientDTO = patList.SingleOrDefault();
            textBox2.Text = patientDTO.FirstName;
            textBox3.Text = patientDTO.LastName;
        }


        private void validatePatient()
        {

        }

        private void RejestracjaPacjenta_Load(object sender, EventArgs e)
        {
            viewPatient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visit visitDTO = new Visit();
            visitDTO.Status = "REG";
            visitDTO.DT_Reg = Convert.ToDateTime(textBox1.Text);
            visitDTO.Id_Pat = patientId;
            visitDTO.Id_Doc = (int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            RegistrationFacade.NewVisitData(visitDTO);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RejestracjaPacjenta_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewPatient();
        }
    }
}
