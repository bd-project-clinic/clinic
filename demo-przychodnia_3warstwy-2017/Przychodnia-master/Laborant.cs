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
    public partial class Laborant : Form
    {
        public Laborant()
        {
            InitializeComponent();
        }

        private void viewInfo()
        {

            Exam_Lab searchCrit = new Exam_Lab();
            searchCrit.Id_Exam_lab = (int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            IQueryable<Exam_Lab> labList = LabFacade.GetLabInfo(searchCrit);
            Exam_Lab labDTO = labList.SingleOrDefault();
            textBox1.Text = labDTO.results;
            textBox2.Text = labDTO.supervisor_comments;
            textBox3.Text = labDTO.doctor_comments;
            textBox4.Text = labDTO.SL_Exam.type;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LabFacade.GetResearchData(DateTime.Today);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LabFacade.GetResearch(null);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = LabFacade.GetResearchData(dateTimePicker1.Value.Date);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exam_Lab labDTO = new Exam_Lab();
            labDTO.Id_Exam_lab = (int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            labDTO.results = textBox1.Text;
            LabFacade.UpdateExamData(labDTO);

            MessageBox.Show("Zapisano");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exam_Lab labDTO = new Exam_Lab();
            labDTO.Id_Exam_lab = (int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            DialogResult DeleteConfirm = MessageBox.Show("Czy na pewno chcesz przesłać te badanie do sprawdzenia ?", "UWAGA", MessageBoxButtons.YesNo);
            if (DeleteConfirm == DialogResult.Yes)
            {
                LabFacade.SendExamData(labDTO);
                dataGridView1.DataSource = LabFacade.GetResearch(null);
            }
            else if (DeleteConfirm == DialogResult.No)
            {
                return;
            }
        }
    }
}
