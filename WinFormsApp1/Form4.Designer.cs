namespace WinFormsApp1
{
    partial class Form4
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
            Nav3 = new Button();
            Nav2 = new Button();
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
            linkLabel1 = new LinkLabel();
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
            Nav5.Size = new Size(809, 23);
            Nav5.TabIndex = 19;
            Nav5.Text = "Вычисление процента от числа";
            Nav5.UseVisualStyleBackColor = false;
            Nav5.Click += Nav5_Click;
            // 
            // Nav3
            // 
            Nav3.BackColor = Color.MediumPurple;
            Nav3.FlatAppearance.BorderSize = 0;
            Nav3.FlatStyle = FlatStyle.Flat;
            Nav3.Location = new Point(-2, 274);
            Nav3.Name = "Nav3";
            Nav3.Size = new Size(809, 23);
            Nav3.TabIndex = 18;
            Nav3.Text = "Вычисление площад прямоугольника по двум сторонам";
            Nav3.UseVisualStyleBackColor = false;
            Nav3.Click += Nav3_Click;
            // 
            // Nav2
            // 
            Nav2.BackColor = Color.MediumPurple;
            Nav2.FlatAppearance.BorderSize = 0;
            Nav2.FlatStyle = FlatStyle.Flat;
            Nav2.Location = new Point(-2, 245);
            Nav2.Name = "Nav2";
            Nav2.Size = new Size(809, 23);
            Nav2.TabIndex = 17;
            Nav2.Text = "Вычисление площади треугольника по трем сторонам";
            Nav2.UseVisualStyleBackColor = false;
            Nav2.Click += Nav2_Click;
            // 
            // Nav1
            // 
            Nav1.BackColor = Color.MediumPurple;
            Nav1.FlatAppearance.BorderSize = 0;
            Nav1.FlatStyle = FlatStyle.Flat;
            Nav1.Location = new Point(-2, 216);
            Nav1.Name = "Nav1";
            Nav1.Size = new Size(809, 23);
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
            label4.Location = new Point(618, 56);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 35;
            label4.Text = "Результат";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 56);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 34;
            label3.Text = "Угол";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 56);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 33;
            label2.Text = "Сторона 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 56);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 32;
            label1.Text = "Сторона 1";
            // 
            // txtSumma
            // 
            txtSumma.Location = new Point(618, 74);
            txtSumma.Name = "txtSumma";
            txtSumma.Size = new Size(143, 23);
            txtSumma.TabIndex = 31;
            txtSumma.TextChanged += txtSumma_TextChanged;
            // 
            // txtC
            // 
            txtC.Location = new Point(409, 74);
            txtC.Name = "txtC";
            txtC.Size = new Size(137, 23);
            txtC.TabIndex = 30;
            txtC.Text = "0";
            txtC.TextChanged += txtC_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(235, 74);
            txtB.Name = "txtB";
            txtB.Size = new Size(137, 23);
            txtB.TabIndex = 29;
            txtB.Text = "0";
            txtB.TextChanged += txtB_TextChanged;
            // 
            // txtA
            // 
            txtA.Location = new Point(57, 74);
            txtA.Name = "txtA";
            txtA.Size = new Size(137, 23);
            txtA.TabIndex = 28;
            txtA.Text = "0";
            txtA.TextChanged += txtA_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 24);
            label5.Name = "label5";
            label5.Size = new Size(421, 15);
            label5.TabIndex = 36;
            label5.Text = "Вычисление площади треугольника по двум сторонам и углу между ними";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(343, 399);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(82, 15);
            linkLabel1.TabIndex = 46;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ссылка на git";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
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
            Controls.Add(Nav3);
            Controls.Add(Nav2);
            Controls.Add(Nav1);
            Controls.Add(btnCount);
            Controls.Add(btnExit);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Nav5;
        private Button Nav3;
        private Button Nav2;
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
        private LinkLabel linkLabel1;
    }
}