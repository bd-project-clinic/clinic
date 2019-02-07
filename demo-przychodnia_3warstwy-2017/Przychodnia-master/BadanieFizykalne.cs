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
    public partial class BadanieFizykalne : Form
    {
   
        int id_wizyty;
        string wynik;
        string nazwa_badania;
        int kod;
        public BadanieFizykalne(DataGridView grid)
        {
      //      wynik = textBox1.Text;
            InitializeComponent();
            dataGridView1.ClearSelection();
            dataGridView1.Columns.Clear();
            id_wizyty = (int)grid.SelectedRows[0].Cells[0].Value;
            label5.Text = grid.SelectedRows[0].Cells[1].Value.ToString();
            label6.Text = grid.SelectedRows[0].Cells[2].Value.ToString();
            label7.Text = Convert.ToString(id_wizyty);
            wynik = textBox1.Text;
            dataGridView1.DataSource = ExamFacade.GetSL_Exam_Fiz();

        }

        private void BadanieFizykalne_Load(object sender, EventArgs e)
        {

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
      //          typ = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                nazwa_badania = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                label9.Text = nazwa_badania;
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exam_Physical badanie = new Exam_Physical();
            badanie.Result = textBox1.Text;
            badanie.Code = kod;
            badanie.Id_Vis = id_wizyty;
            ExamFacade.NewExam_Fiz(badanie);
            MessageBox.Show("Badanie zakończone");
            this.Close();
        }
    }
}
