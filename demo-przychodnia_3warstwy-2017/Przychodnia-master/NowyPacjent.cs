﻿using System;
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
    public partial class NowyPacjent : Form
    {
        public NowyPacjent()
        {
            InitializeComponent();
        }

        private int patientId;
        


        private void NowyPacjent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patientDTO = new Patient();
            //patientDTO.Id_Pat = patientId;
            patientDTO.FirstName = textBox1.Text;
            patientDTO.LastName = textBox2.Text;
            patientDTO.PESEL = textBox3.Text;

            RegistrationFacade.NewPatientData(patientDTO);

            DialogResult = DialogResult.OK;
            this.Close();

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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
