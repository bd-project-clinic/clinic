﻿using System;
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
    public partial class DodajKierownika : Form
    {
        public DodajKierownika()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User usr = new User();
            usr.uname = textBox4.Text;
            usr.pass = textBox3.Text;
            usr.DT_retire = Convert.ToDateTime(textBox5.Text);
            usr.role = "SLAB";
            AdminFacade.NewUserData(usr);

            SLab lb = new SLab();
            lb.uname = textBox4.Text;
            lb.Name = textBox1.Text;
            lb.Surname = textBox2.Text;
            AdminFacade.NewSLabData(lb);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}