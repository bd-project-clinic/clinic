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
    public partial class Admin : Form
    {
        User userSearchCriteria;
        private void viewUsers()
        {
            // var result = RegistrationFacade.GetPatients(null);

            // budowa kryteriów
            userSearchCriteria = new User();
            userSearchCriteria.uname = textBox1.Text;
            userSearchCriteria.role = textBox3.Text;
            if (textBox4.Text == "")
                userSearchCriteria.DT_retire = default(DateTime);
            else
            userSearchCriteria.DT_retire = Convert.ToDateTime(textBox4.Text);

            // ładowanie obiektu dataGridView
            dataGridViewVisits.Columns.Clear();
            // dataGridView1.AutoGenerateColumns = true;
            dataGridViewVisits.DataSource = AdminFacade.GetUsers(userSearchCriteria);

        }
        public Admin()
        {
            InitializeComponent();
        }

        private void dataGridViewVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajUsera frmDodajusera = new DodajUsera();
            DialogResult res = frmDodajusera.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisits.Rows.Count == 0)
            {
                MessageBox.Show("Brak Userów");
                return;
            }

            
            userSearchCriteria = new User();
            userSearchCriteria.uname = (string)(dataGridViewVisits.Rows[dataGridViewVisits.CurrentCell.RowIndex].Cells[0].Value);



            if (userSearchCriteria.uname == "")
            {
                MessageBox.Show("Wybierz pacjenta");
                return;
            }
            else
            {
                MessageBox.Show(String.Format("Wybrano pacjenta o identyfikatorze {0}", userSearchCriteria.uname));

            }
            EdycjaUsera frmEdycjaPacjenta = new EdycjaUsera(userSearchCriteria.uname);
            DialogResult res = frmEdycjaPacjenta.ShowDialog(this);
            // button1_Click(null, null); :) :)
            viewUsers();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewUsers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisits.Rows.Count == 0)
            {
                MessageBox.Show("Brak użytkowników");
                return;
            }

            string VisDeleteId = (string)(dataGridViewVisits.Rows[dataGridViewVisits.CurrentCell.RowIndex].Cells[0].Value);

            DialogResult DeleteConfirm = MessageBox.Show("Czy na pewno chcesz usunąć wybranego użytkownika ?", "UWAGA", MessageBoxButtons.YesNo);
            if (DeleteConfirm == DialogResult.Yes)
            {
                AdminFacade.DeleteUserData(VisDeleteId);
                dataGridViewVisits.DataSource = AdminFacade.GetUsers(userSearchCriteria);
            }
            else if (DeleteConfirm == DialogResult.No)
            {
                return;
            }

        }
    }
}
