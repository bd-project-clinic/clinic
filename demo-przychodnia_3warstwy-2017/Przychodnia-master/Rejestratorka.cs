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
    public partial class Rejestratorka : Form

    {

        Patient patientSearchCriteria;

        public Rejestratorka()
        {
            InitializeComponent();
            dataGridViewVisits.DataSource = RegistrationFacade.GetVisits(null);
        }

        private void viewPatients ()
        {
            // var result = RegistrationFacade.GetPatients(null);

            // budowa kryteriów
            patientSearchCriteria = new Patient();
            patientSearchCriteria.LastName = textBox1.Text;
            patientSearchCriteria.FirstName = textBox4.Text;
            patientSearchCriteria.PESEL = textBox3.Text;

            // ładowanie obiektu dataGridView
            dataGridView1.Columns.Clear();
            // dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = RegistrationFacade.GetPatients(patientSearchCriteria);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NowyPacjent frmNowyPacjent = new NowyPacjent();
            DialogResult res = frmNowyPacjent.ShowDialog(this);

            if (res == DialogResult.OK)
                viewPatients();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisits.Rows.Count == 0)
            {
                MessageBox.Show("Brak Wizyt");
                return;
            }

            int VisDeleteId = (int)(dataGridViewVisits.Rows[dataGridViewVisits.CurrentCell.RowIndex].Cells[0].Value);
            string status = (string)(dataGridViewVisits.Rows[dataGridViewVisits.CurrentCell.RowIndex].Cells[6].Value);

            if(status != "ENDVIS    ")
            {
                MessageBox.Show("UWAGA TA WIZYTA NIE JEST JESZCZE ZAKOŃCZONA");
            }

            DialogResult DeleteConfirm = MessageBox.Show("Czy na pewno chcesz usunąć wybraną wizyte ?", "UWAGA", MessageBoxButtons.YesNo);
            if(DeleteConfirm == DialogResult.Yes)
            {
                RegistrationFacade.DeleteVisitData(VisDeleteId);
                dataGridViewVisits.DataSource = RegistrationFacade.GetVisits(null);
            }          
            else if (DeleteConfirm == DialogResult.No)
            {
                return;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewPatients();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Brak pacjentów");
                return;
            }


            patientSearchCriteria = new Patient();
            patientSearchCriteria.Id_Pat = (int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);



            if (patientSearchCriteria.Id_Pat == 0)
            {
                MessageBox.Show("Wybierz pacjenta");
                return;
            }
            else
            {
                MessageBox.Show(String.Format("Wybrano pacjenta o identyfikatorze {0}", patientSearchCriteria.Id_Pat));

            }
            RejestracjaPacjenta frmRejestracjaPacjenta = new RejestracjaPacjenta(patientSearchCriteria.Id_Pat);
            DialogResult res = frmRejestracjaPacjenta.ShowDialog(this);
            
            if (res == DialogResult.OK)
                viewPatients();
        }

        private void Rejestratorka_Load(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Brak pacjentów");
                return;
            }

            
            patientSearchCriteria = new Patient();
            patientSearchCriteria.Id_Pat = (int) ( dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value); 



            if  (patientSearchCriteria.Id_Pat == 0)
            {
                MessageBox.Show("Wybierz pacjenta");
                return;
            }
            else
            {
                MessageBox.Show(String.Format("Wybrano pacjenta o identyfikatorze {0}", patientSearchCriteria.Id_Pat));

            }
            EdycjaPacjenta frmEdycjaPacjenta = new EdycjaPacjenta(patientSearchCriteria.Id_Pat);
            DialogResult res =  frmEdycjaPacjenta.ShowDialog(this);
            // button1_Click(null, null); :) :)
            if (res == DialogResult.OK)
                viewPatients();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowVisists_Click(object sender, EventArgs e)
        {
            dataGridViewVisits.DataSource = RegistrationFacade.GetVisits(null);
   
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridViewVisits.DataSource = RegistrationFacade.GetVisitsData(DateTime.Today);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewVisits.Columns.Clear();
            dataGridViewVisits.DataSource = RegistrationFacade.GetVisitsData(dateTimePicker1.Value.Date);
        }
    }
}
