using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Nav1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void Nav2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }

        private void Nav4_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            Hide();
        }

        private void Nav5_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
            Hide();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double s = a * b;
                txtSumma.Text = s.ToString();
                txtSumma.Text = s.ToString();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSumma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
