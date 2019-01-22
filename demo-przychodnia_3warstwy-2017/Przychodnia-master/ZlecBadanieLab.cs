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
    public partial class ZlecBadanieLab : Form
    {
        int id_wizyty;
        public ZlecBadanieLab(int id)
        {
            InitializeComponent();
            textBox2.Text = Convert.ToString(DateTime.Today);
   //         dataGridView1.Columns.Clear();                    //jak zostanie zrobiony slownik to sprawdzic dzialanie
  //          dataGridView1.DataSource = SlownikFacade.GetSlownik();
            id_wizyty = id;
            label4.Text = Convert.ToString(id_wizyty);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                string komentarz;
                komentarz = textBox1.Text;
                int id_badania;
                id_badania=(int) dataGridView1.SelectedRows[0].Cells[0].Value;
                Exam_Lab exam = new Exam_Lab();
                exam.Id_Vis = id_wizyty;
                exam.doctor_comments = komentarz;
                exam.status = 1;                        //zmienic, gdy status w Exam_Lab bedzie char
                exam.dt_zle = DateTime.Today;
                exam.Code = id_badania;
                SlownikFacade.GiveExamStatus(exam);
                if (exam.status == 1)                   //to samo
                {
                    MessageBox.Show("Zlecono badanie");
                }
            }
            else if (selectedRowCount == 0)
                MessageBox.Show("Nie zaznaczyles badania!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
