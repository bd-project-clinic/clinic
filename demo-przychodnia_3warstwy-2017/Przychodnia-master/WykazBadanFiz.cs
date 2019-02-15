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
    public partial class WykazBadanFiz : Form
    {
        int id_wizyty;
        string nazwa_badania;
        int kod;
        public WykazBadanFiz(DataGridView grid)
        {
            InitializeComponent();
            dataGridView1.ClearSelection();
            dataGridView1.Columns.Clear();
            id_wizyty = (int)grid.SelectedRows[0].Cells[0].Value;
            label4.Text = grid.SelectedRows[0].Cells[1].Value.ToString();
            label5.Text = grid.SelectedRows[0].Cells[2].Value.ToString();
            label6.Text = Convert.ToString(id_wizyty);
            //         wynik = textBox1.Text;
            Exam_Physical wyniki = new Exam_Physical();
            wyniki.Id_Vis = id_wizyty;
            dataGridView1.DataSource = ExamFacade.GetResults(wyniki);
        }

        private void WykazBadanFiz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
