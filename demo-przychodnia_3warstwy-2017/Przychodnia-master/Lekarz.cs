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
    public partial class Lekarz : Form
    {
        public Lekarz()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = DoctorFacade.GetVisits(DateTime.Today);
            //dataGridView1.DataSource = RegistrationFacade.GetVisits(null);
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

           dataGridView1.Columns.Clear();
           dataGridView1.DataSource = DoctorFacade.GetVisits(dateTimePicker1.Value.Date);


        }
        int id_wizyty;
        string status_wizyty;
        private void button1_Click(object sender, EventArgs e)
        {
            string imie;
            string nazwisko;
            string diagnoza;
            string opis;
            string stan;
            string rejestracja;
         
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int id;
            if (selectedRowCount == 1)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                imie = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                nazwisko = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                opis = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                diagnoza = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                stan = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                rejestracja = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox1.Text = diagnoza;
                textBox2.Text = opis;
                label7.Text = imie;
                label8.Text = nazwisko;
                label9.Text = stan;
                label10.Text = rejestracja;
                id_wizyty = id;
                status_wizyty = stan;
            }

            else if (selectedRowCount > 1)
                MessageBox.Show("Zaznaczyles wiecej niz jedna wizyte!");
            else if (selectedRowCount == 0)
                MessageBox.Show("Nie zaznaczyles wizyty!");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string diagnoza;
            diagnoza = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visit vis = new Visit();
            vis.Id_Vis = id_wizyty;
            vis.Diagnosis = textBox1.Text;
            vis.Description = textBox2.Text;
            DoctorFacade.UpdateVisitDesc(vis);
            DoctorFacade.UpdateVisitDiag(vis);
            MessageBox.Show("Zmiany zostały zatwierdzone. Odśwież wizyty.");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string opis;
            opis = textBox2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                ZlecBadanieLaboratoryjne newBadanie = new ZlecBadanieLaboratoryjne(dataGridView1);
                newBadanie.ShowDialog();
            }
            else MessageBox.Show("Nie zaznaczyłeś wizyty"); 

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                if (status_wizyty=="ENDBAD")
                {
                    Visit vis = new Visit();
                    vis.Id_Vis = id_wizyty;
                    vis.Status = "ENDVIS";
                    DoctorFacade.UpdateVisitStat(vis);
                    MessageBox.Show("Wizyta zakonczona");
                }
                else MessageBox.Show("Nie możesz zakończyć wizyty, gdyż trwają badania.");

            }
            else MessageBox.Show("Nie zaznaczyłeś wizyty");
           

        }
       

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = DoctorFacade.GetVisits(DateTime.Today);
            textBox1.Text = null;
            textBox2.Text = null;
            label7.Text = null;
            label8.Text = null;
            label9.Text = null;
            label10.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                WyswietlBadLabPacjenta newBadanie = new WyswietlBadLabPacjenta(dataGridView1);
                newBadanie.ShowDialog();
            }
            else MessageBox.Show("Nie zaznaczyłeś wizyty");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            Visit allvisits = new Visit();
            dataGridView1.DataSource = DoctorFacade.GetVisits(allvisits);
        }
    }
}
