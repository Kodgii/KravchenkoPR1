namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Nav5 = new Button();
            Nav4 = new Button();
            Nav3 = new Button();
            Nav1 = new Button();
            btnCount = new Button();
            btnExit = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSumma = new TextBox();
            txtC = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Nav5
            // 
            Nav5.BackColor = Color.MediumPurple;
            Nav5.FlatAppearance.BorderSize = 0;
            Nav5.FlatStyle = FlatStyle.Flat;
            Nav5.Location = new Point(-2, 303);
            Nav5.Name = "Nav5";
            Nav5.Size = new Size(810, 23);
            Nav5.TabIndex = 19;
            Nav5.Text = "Вычисление процента от числа";
            Nav5.UseVisualStyleBackColor = false;
            Nav5.Click += Nav5_Click;
            // 
            // Nav4
            // 
            Nav4.BackColor = Color.MediumPurple;
            Nav4.FlatAppearance.BorderSize = 0;
            Nav4.FlatStyle = FlatStyle.Flat;
            Nav4.Location = new Point(-2, 274);
            Nav4.Name = "Nav4";
            Nav4.Size = new Size(810, 23);
            Nav4.TabIndex = 18;
            Nav4.Text = "Вычисление площади треугольника по двум сторонам и углу между ними";
            Nav4.UseVisualStyleBackColor = false;
            Nav4.Click += Nav4_Click;
            // 
            // Nav3
            // 
            Nav3.BackColor = Color.MediumPurple;
            Nav3.FlatAppearance.BorderSize = 0;
            Nav3.FlatStyle = FlatStyle.Flat;
            Nav3.Location = new Point(-2, 245);
            Nav3.Name = "Nav3";
            Nav3.Size = new Size(810, 23);
            Nav3.TabIndex = 17;
            Nav3.Text = "Вычисление площад прямоугольника по двум сторонам";
            Nav3.UseVisualStyleBackColor = false;
            Nav3.Click += Nav3_Click;
            // 
            // Nav1
            // 
            Nav1.BackColor = Color.MediumPurple;
            Nav1.FlatAppearance.BorderSize = 0;
            Nav1.FlatStyle = FlatStyle.Flat;
            Nav1.Location = new Point(-2, 216);
            Nav1.Name = "Nav1";
            Nav1.Size = new Size(810, 23);
            Nav1.TabIndex = 16;
            Nav1.Text = "Вычисление суммы трёх любых чисел";
            Nav1.UseVisualStyleBackColor = false;
            Nav1.Click += Nav1_Click;
            // 
            // btnCount
            // 
            btnCount.BackColor = Color.LightGreen;
            btnCount.FlatAppearance.BorderSize = 0;
            btnCount.FlatStyle = FlatStyle.Flat;
            btnCount.Location = new Point(300, 373);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(169, 23);
            btnCount.TabIndex = 15;
            btnCount.Text = "Вычислить";
            btnCount.UseVisualStyleBackColor = false;
            btnCount.Click += btnCount_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 0);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(697, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(590, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 27;
            label4.Text = "Результат";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 75);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 26;
            label3.Text = "Сторона 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 75);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 25;
            label2.Text = "Сторона 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 75);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 24;
            label1.Text = "Сторона 1";
            // 
            // txtSumma
            // 
            txtSumma.Location = new Point(590, 93);
            txtSumma.Name = "txtSumma";
            txtSumma.Size = new Size(143, 23);
            txtSumma.TabIndex = 23;
            txtSumma.TextChanged += txtSumma_TextChanged;
            // 
            // txtC
            // 
            txtC.Location = new Point(381, 93);
            txtC.Name = "txtC";
            txtC.Size = new Size(137, 23);
            txtC.TabIndex = 22;
            txtC.Text = "0";
            txtC.TextChanged += txtC_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(207, 93);
            txtB.Name = "txtB";
            txtB.Size = new Size(137, 23);
            txtB.TabIndex = 21;
            txtB.Text = "0";
            txtB.TextChanged += txtB_TextChanged;
            // 
            // txtA
            // 
            txtA.Location = new Point(29, 93);
            txtA.Name = "txtA";
            txtA.Size = new Size(137, 23);
            txtA.TabIndex = 20;
            txtA.Text = "0";
            txtA.TextChanged += txtA_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 50);
            label5.Name = "label5";
            label5.Size = new Size(312, 15);
            label5.TabIndex = 28;
            label5.Text = "Вычисление площади треугольника по трем сторонам";
            label5.Click += label5_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSumma);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(Nav5);
            Controls.Add(Nav4);
            Controls.Add(Nav3);
            Controls.Add(Nav1);
            Controls.Add(btnCount);
            Controls.Add(btnExit);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Nav5;
        private Button Nav4;
        private Button Nav3;
        private Button Nav1;
        private Button btnCount;
        private Button btnExit;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSumma;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}