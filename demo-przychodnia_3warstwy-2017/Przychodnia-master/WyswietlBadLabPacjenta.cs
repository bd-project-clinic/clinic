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
    public partial class WyswietlBadLabPacjenta : Form
    {

        public WyswietlBadLabPacjenta(DataGridView grid)
        {
            InitializeComponent();
            label3.Text= grid.SelectedRows[0].Cells[1].Value.ToString();
            label4.Text=grid.SelectedRows[0].Cells[2].Value.ToString();
            dataGridView1.Columns.Clear();
            Exam_Lab exam = new Exam_Lab();
            exam.Id_Vis= (int)grid.SelectedRows[0].Cells[0].Value;
            dataGridView1.DataSource = ExamFacade.GetExam_Lab(exam);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string wynik;
            string komentarz;
       
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int status = (int)dataGridView1.SelectedRows[0].Cells[5].Value;
            if (selectedRowCount == 1)
            {
                if (status==3)
                {
                    wynik = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    komentarz = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    textBox1.Text = wynik;
                    textBox2.Text = komentarz;
                }
                else MessageBox.Show("Brak badań/wyników badań!");

            }
            else if (selectedRowCount > 1)
                MessageBox.Show("Zaznaczyles wiecej niz jedno badanie!");
            else if (selectedRowCount == 0)
                MessageBox.Show("Nie zaznaczyles badania!");

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
