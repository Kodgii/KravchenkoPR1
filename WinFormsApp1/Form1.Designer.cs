namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnExit = new Button();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtSumma = new TextBox();
            btnCount = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nav2 = new Button();
            Nav3 = new Button();
            Nav4 = new Button();
            Nav5 = new Button();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 0);
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.FlatAppearance.BorderColor = Color.Black;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(697, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(32, 93);
            txtA.Name = "txtA";
            txtA.Size = new Size(137, 23);
            txtA.TabIndex = 1;
            txtA.Text = "0";
            txtA.TextChanged += txtA_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(210, 93);
            txtB.Name = "txtB";
            txtB.Size = new Size(137, 23);
            txtB.TabIndex = 2;
            txtB.Text = "0";
            txtB.TextChanged += txtB_TextChanged;
            // 
            // txtC
            // 
            txtC.Location = new Point(384, 93);
            txtC.Name = "txtC";
            txtC.Size = new Size(137, 23);
            txtC.TabIndex = 3;
            txtC.Text = "0";
            txtC.TextChanged += txtC_TextChanged;
            // 
            // txtSumma
            // 
            txtSumma.Location = new Point(593, 93);
            txtSumma.Name = "txtSumma";
            txtSumma.Size = new Size(143, 23);
            txtSumma.TabIndex = 4;
            // 
            // btnCount
            // 
            btnCount.BackColor = Color.LightGreen;
            btnCount.FlatAppearance.BorderSize = 0;
            btnCount.FlatStyle = FlatStyle.Flat;
            btnCount.Location = new Point(300, 373);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(169, 23);
            btnCount.TabIndex = 5;
            btnCount.Text = "Вычислить";
            btnCount.UseVisualStyleBackColor = false;
            btnCount.Click += btnCount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 75);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Число 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Число 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 75);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Число 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(593, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Результат";
            // 
            // Nav2
            // 
            Nav2.BackColor = Color.MediumPurple;
            Nav2.FlatAppearance.BorderSize = 0;
            Nav2.FlatStyle = FlatStyle.Flat;
            Nav2.Location = new Point(-2, 216);
            Nav2.Name = "Nav2";
            Nav2.Size = new Size(808, 23);
            Nav2.TabIndex = 10;
            Nav2.Text = "Вычисление площади треугольника по трем сторонам";
            Nav2.UseVisualStyleBackColor = false;
            Nav2.Click += Nav2_Click;
            // 
            // Nav3
            // 
            Nav3.BackColor = Color.MediumPurple;
            Nav3.FlatAppearance.BorderSize = 0;
            Nav3.FlatStyle = FlatStyle.Flat;
            Nav3.Location = new Point(-2, 245);
            Nav3.Name = "Nav3";
            Nav3.Size = new Size(808, 23);
            Nav3.TabIndex = 11;
            Nav3.Text = "Вычисление площад прямоугольника по двум сторонам";
            Nav3.UseVisualStyleBackColor = false;
            Nav3.Click += Nav3_Click;
            // 
            // Nav4
            // 
            Nav4.BackColor = Color.MediumPurple;
            Nav4.FlatAppearance.BorderSize = 0;
            Nav4.FlatStyle = FlatStyle.Flat;
            Nav4.Location = new Point(-2, 274);
            Nav4.Name = "Nav4";
            Nav4.Size = new Size(808, 23);
            Nav4.TabIndex = 12;
            Nav4.Text = "Вычисление площади треугольника по двум сторонам и углу между ними";
            Nav4.UseVisualStyleBackColor = false;
            Nav4.Click += Nav4_Click;
            // 
            // Nav5
            // 
            Nav5.BackColor = Color.MediumPurple;
            Nav5.FlatAppearance.BorderSize = 0;
            Nav5.FlatStyle = FlatStyle.Flat;
            Nav5.Location = new Point(-2, 303);
            Nav5.Name = "Nav5";
            Nav5.Size = new Size(808, 23);
            Nav5.TabIndex = 13;
            Nav5.Text = "Вычисление процента от числа";
            Nav5.UseVisualStyleBackColor = false;
            Nav5.Click += Nav5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 40);
            label5.Name = "label5";
            label5.Size = new Size(223, 15);
            label5.TabIndex = 14;
            label5.Text = "Вычисление суммы трёх любых чисел";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(Nav5);
            Controls.Add(Nav4);
            Controls.Add(Nav3);
            Controls.Add(Nav2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCount);
            Controls.Add(txtSumma);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtSumma;
        private Button btnCount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Nav2;
        private Button Nav3;
        private Button Nav4;
        private Button Nav5;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}
