namespace laba_5_n_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboType = new ComboBox();
            labelType = new Label();
            labelName = new Label();
            txtName = new TextBox();
            labelAge = new Label();
            txtAge = new TextBox();
            labelGender = new Label();
            txtGender = new TextBox();
            labelWeight = new Label();
            txtWeight = new TextBox();
            labelHeight = new Label();
            txtHeight = new TextBox();
            labelExtra1 = new Label();
            txtExtra1 = new TextBox();
            btnCreate = new Button();
            btnShow = new Button();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // comboType
            // 
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.Font = new Font("Segoe UI", 10F);
            comboType.Location = new Point(268, 27);
            comboType.Margin = new Padding(4);
            comboType.Name = "comboType";
            comboType.Size = new Size(249, 36);
            comboType.TabIndex = 0;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 10F);
            labelType.Location = new Point(50, 30);
            labelType.Margin = new Padding(4, 0, 4, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(121, 28);
            labelType.TabIndex = 1;
            labelType.Text = "Тип об’єкта:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F);
            labelName.Location = new Point(50, 81);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(50, 28);
            labelName.TabIndex = 2;
            labelName.Text = "Ім’я:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(268, 80);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(249, 34);
            txtName.TabIndex = 3;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 10F);
            labelAge.Location = new Point(50, 125);
            labelAge.Margin = new Padding(4, 0, 4, 0);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(42, 28);
            labelAge.TabIndex = 4;
            labelAge.Text = "Вік:";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10F);
            txtAge.Location = new Point(268, 123);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(249, 34);
            txtAge.TabIndex = 5;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 10F);
            labelGender.Location = new Point(50, 169);
            labelGender.Margin = new Padding(4, 0, 4, 0);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(64, 28);
            labelGender.TabIndex = 6;
            labelGender.Text = "Стать:";
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 10F);
            txtGender.Location = new Point(268, 167);
            txtGender.Margin = new Padding(4);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(249, 34);
            txtGender.TabIndex = 7;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 10F);
            labelWeight.Location = new Point(50, 212);
            labelWeight.Margin = new Padding(4, 0, 4, 0);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(90, 28);
            labelWeight.TabIndex = 8;
            labelWeight.Text = "Вага (кг):";
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Segoe UI", 10F);
            txtWeight.Location = new Point(268, 211);
            txtWeight.Margin = new Padding(4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(249, 34);
            txtWeight.TabIndex = 9;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI", 10F);
            labelHeight.Location = new Point(50, 256);
            labelHeight.Margin = new Padding(4, 0, 4, 0);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(80, 28);
            labelHeight.TabIndex = 10;
            labelHeight.Text = "Ріст (м):";
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 10F);
            txtHeight.Location = new Point(268, 254);
            txtHeight.Margin = new Padding(4);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(249, 34);
            txtHeight.TabIndex = 11;
            // 
            // labelExtra1
            // 
            labelExtra1.AutoSize = true;
            labelExtra1.Font = new Font("Segoe UI", 10F);
            labelExtra1.Location = new Point(50, 300);
            labelExtra1.Margin = new Padding(4, 0, 4, 0);
            labelExtra1.Name = "labelExtra1";
            labelExtra1.Size = new Size(164, 28);
            labelExtra1.TabIndex = 12;
            labelExtra1.Text = "Додаткове поле:";
            // 
            // txtExtra1
            // 
            txtExtra1.Font = new Font("Segoe UI", 10F);
            txtExtra1.Location = new Point(268, 298);
            txtExtra1.Margin = new Padding(4);
            txtExtra1.Name = "txtExtra1";
            txtExtra1.Size = new Size(249, 34);
            txtExtra1.TabIndex = 13;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10F);
            btnCreate.Location = new Point(525, 59);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(225, 50);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Створити";
            btnCreate.Click += btnCreate_Click;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 10F);
            btnShow.Location = new Point(525, 138);
            btnShow.Margin = new Padding(4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(225, 50);
            btnShow.TabIndex = 15;
            btnShow.Text = "Показати інформацію";
            btnShow.Click += btnShow_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 10F);
            txtOutput.Location = new Point(50, 375);
            txtOutput.Margin = new Padding(4);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(699, 249);
            txtOutput.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 675);
            Controls.Add(comboType);
            Controls.Add(labelType);
            Controls.Add(labelName);
            Controls.Add(txtName);
            Controls.Add(labelAge);
            Controls.Add(txtAge);
            Controls.Add(labelGender);
            Controls.Add(txtGender);
            Controls.Add(labelWeight);
            Controls.Add(txtWeight);
            Controls.Add(labelHeight);
            Controls.Add(txtHeight);
            Controls.Add(labelExtra1);
            Controls.Add(txtExtra1);
            Controls.Add(btnCreate);
            Controls.Add(btnShow);
            Controls.Add(txtOutput);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна №3 — Поліморфізм методів класу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label labelExtra1;
        private System.Windows.Forms.TextBox txtExtra1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtOutput;
    }
}
