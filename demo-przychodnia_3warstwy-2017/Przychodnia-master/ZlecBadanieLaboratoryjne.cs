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
    public partial class ZlecBadanieLaboratoryjne : Form
    {
        string komentarz_doc;
        int kod;
        string typ;
        string nazwa;
        bool wcisnieto = false;
        bool czy_zmiana = false;
        int id_wizyty;
        string badanie;
        public ZlecBadanieLaboratoryjne(DataGridView grid)
        {
            InitializeComponent();
            dataGridView1.ClearSelection();
            label2.Text = Convert.ToString(DateTime.Now);
            id_wizyty=(int)grid.SelectedRows[0].Cells[0].Value;
            label4.Text=grid.SelectedRows[0].Cells[1].Value.ToString();
            label6.Text=grid.SelectedRows[0].Cells[2].Value.ToString();
            komentarz_doc = textBox1.Text;
            badanie = textBox2.Text;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ExamFacade.GetSL_Exam();

            


        }
     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        //    komentarz_doc = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komentarz_doc = null;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komentarz_doc = textBox1.Text;
            if (wcisnieto == true)
            {
                Exam_Lab exam = new Exam_Lab();
                exam.Id_Vis = id_wizyty;
                exam.doctor_comments = komentarz_doc;
                exam.dt_zle = Convert.ToDateTime(label2.Text);
                exam.Code = kod;
                exam.status = 1;
                ExamFacade.NewExam_Lab(exam);
                MessageBox.Show("Badanie zostało zlecone");
                this.Close();

            }
            else MessageBox.Show("Nie zaznaczyłeś badania");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            badanie = textBox2.Text;
            SL_Exam szukaj = new SL_Exam();
            szukaj.type = badanie;
            szukaj.name = badanie;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource=ExamFacade.GetSL_Exam(szukaj);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ExamFacade.GetSL_Exam();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            czy_zmiana = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int szukaj_kod;
            if (czy_zmiana == false)
            {
                dataGridView1.Columns.Clear();
            }
            else if (czy_zmiana == true)
            {
                szukaj_kod = Convert.ToInt32(textBox3.Text);
                SL_Exam szukaj = new SL_Exam();
                szukaj.Code = szukaj_kod;
                dataGridView1.ClearSelection();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = ExamFacade.GetSL_Exam_Code(szukaj);
            }
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                kod = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                typ = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                nazwa = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                label9.Text = Convert.ToString(kod);
                label10.Text = typ;
                label11.Text = nazwa;
                wcisnieto = true;
            }
        }
    }
}
