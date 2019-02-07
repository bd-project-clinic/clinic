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
    public partial class Szef_laborant : Form
    {
        public Szef_laborant()
        {
            InitializeComponent();
            dataGridView1.DataSource = SLabFacade.GetResearch(null);
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
            textBox4.Text = labDTO.SL_Exam.Code.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SLabFacade.GetResearchData(DateTime.Today);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SLabFacade.GetResearch(null);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = SLabFacade.GetResearchData(dateTimePicker1.Value.Date);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exam_Lab labDTO = new Exam_Lab();
            labDTO.Id_Exam_lab = (int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            labDTO.supervisor_comments = textBox2.Text;
            SLabFacade.UpdateExamData(labDTO);

            MessageBox.Show("Zapisano");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exam_Lab labDTO = new Exam_Lab();
            labDTO.Id_Exam_lab = (int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            if ((int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value) != 2)
            {
                MessageBox.Show("wybrano badanie z niepoprawnym statusem");
                return;
            }


            DialogResult DeleteConfirm = MessageBox.Show("Czy na pewno chcesz zaakceptować to badanie ?", "UWAGA", MessageBoxButtons.YesNo);
            if (DeleteConfirm == DialogResult.Yes)
            {
                labDTO.supervisor_comments = textBox2.Text;
                SLabFacade.UpdateExamData(labDTO);

                SLabFacade.AcceptExamData(labDTO);
                dataGridView1.DataSource = SLabFacade.GetResearch(null);
            }
            else if (DeleteConfirm == DialogResult.No)
            {
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exam_Lab labDTO = new Exam_Lab();
            labDTO.Id_Exam_lab = (int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);


            if ((int)(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value) != 2)
            {
                MessageBox.Show("wybrano badanie z niepoprawnym statusem");
                return;
            }

            DialogResult DeleteConfirm = MessageBox.Show("Czy na pewno chcesz odrzucić to badanie  ?", "UWAGA", MessageBoxButtons.YesNo);
            if (DeleteConfirm == DialogResult.Yes)
            {
                labDTO.supervisor_comments = textBox2.Text;
                SLabFacade.UpdateExamData(labDTO);

                SLabFacade.DeclineExamData(labDTO);
                dataGridView1.DataSource = SLabFacade.GetResearch(null);
            }
            else if (DeleteConfirm == DialogResult.No)
            {
                return;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            viewInfo();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
