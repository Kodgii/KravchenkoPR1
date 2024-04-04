﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double result = a * (b / 100);
                txtSumma.Text = result.ToString();
                errorProvider1.SetError(txtA, "");
                errorProvider1.SetError(txtB, "");
            }
            catch
            {
                errorProvider1.SetError(txtA, "Неправильно введено значение");
                errorProvider1.SetError(txtB, "Неправильно введено значение");

            }
            if (txtSumma.Text == "")
            {
                MessageBox.Show("Вы что-то неправильно сделали");
            }
            else
            {
                MessageBox.Show("Спасибо что воспользовались данной программой.РАБОТУ ВЫПОЛНИЛА СТРЕЛЬЦОВА А.А");
            }


        }

        private void Nav4_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            Hide();
        }

        private void Nav3_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }

        private void Nav2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }

        private void Nav1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo("cmd", $"/c start https://github.com/Kodgii"));
        }
    }
}
