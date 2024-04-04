using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
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
                double c = Convert.ToDouble(txtC.Text);
                double s = a * b * Math.Sin(c * 180 / Math.PI) / 2;
                txtSumma.Text = s.ToString();
                errorProvider1.SetError(txtA, "");
                errorProvider1.SetError(txtB, "");
                errorProvider1.SetError(txtC, "");

            }
            catch
            {
                errorProvider1.SetError(txtA, "Неправильно введено значение");
                errorProvider1.SetError(txtB, "Неправильно введено значение");
                errorProvider1.SetError(txtC, "Неправильно введено значение");

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

        private void Nav5_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
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

        private void txtSumma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo("cmd", $"/c start https://github.com/Kodgii"));
        }
    }
}
