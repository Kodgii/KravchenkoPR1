using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                int summa = Int32.Parse(txtA.Text) + Int32.Parse(txtB.Text) + Int32.Parse(txtC.Text);
                txtSumma.Text = summa.ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nav2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }

        private void Nav3_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
