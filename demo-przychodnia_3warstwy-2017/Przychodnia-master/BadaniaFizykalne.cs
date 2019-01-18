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
    public partial class BadaniaFizykalne : Form
    {
        int id_wizyty;
        public BadaniaFizykalne()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
        //    dataGridView1.DataSource=BadaniaFizykalne.Get
            Visit vis = new Visit();
            id_wizyty = vis.Id_Vis;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
