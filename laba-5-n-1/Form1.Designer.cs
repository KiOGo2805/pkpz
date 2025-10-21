namespace laba_5_n_1
{
    partial class Form1
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

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            chkParking = new CheckBox();
            txtPurpose = new TextBox();
            label6 = new Label();
            txtYearBuilt = new TextBox();
            label5 = new Label();
            txtHeight = new TextBox();
            label4 = new Label();
            txtFloors = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSave = new Button();
            btnShow = new Button();
            btnCreate = new Button();
            txtOutput = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkParking);
            groupBox1.Controls.Add(txtPurpose);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtYearBuilt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFloors);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(435, 14);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(456, 508);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Дані про будівлю";
            // 
            // chkParking
            // 
            chkParking.AutoSize = true;
            chkParking.Location = new Point(29, 466);
            chkParking.Margin = new Padding(4, 5, 4, 5);
            chkParking.Name = "chkParking";
            chkParking.Size = new Size(211, 32);
            chkParking.TabIndex = 0;
            chkParking.Text = "Наявність паркінгу";
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(214, 345);
            txtPurpose.Margin = new Padding(4, 5, 4, 5);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(213, 34);
            txtPurpose.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 350);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 28);
            label6.TabIndex = 2;
            label6.Text = "Призначення:";
            // 
            // txtYearBuilt
            // 
            txtYearBuilt.Location = new Point(214, 287);
            txtYearBuilt.Margin = new Padding(4, 5, 4, 5);
            txtYearBuilt.Name = "txtYearBuilt";
            txtYearBuilt.Size = new Size(213, 34);
            txtYearBuilt.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 292);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 4;
            label5.Text = "Рік будівництва:";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(214, 228);
            txtHeight.Margin = new Padding(4, 5, 4, 5);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(213, 34);
            txtHeight.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 233);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 6;
            label4.Text = "Висота (м):";
            // 
            // txtFloors
            // 
            txtFloors.Location = new Point(214, 170);
            txtFloors.Margin = new Padding(4, 5, 4, 5);
            txtFloors.Name = "txtFloors";
            txtFloors.Size = new Size(213, 34);
            txtFloors.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 28);
            label3.TabIndex = 8;
            label3.Text = "Кількість поверхів:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(214, 112);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(213, 34);
            txtAddress.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 10;
            label2.Text = "Адреса:";
            // 
            // txtName
            // 
            txtName.Location = new Point(214, 53);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 34);
            txtName.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 12;
            label1.Text = "Назва:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(btnShow);
            groupBox2.Controls.Add(btnCreate);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(13, 14);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(400, 300);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Керування";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(57, 125);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(286, 58);
            btnSave.TabIndex = 0;
            btnSave.Text = "Зберегти у файл";
            btnSave.Click += btnSave_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(57, 193);
            btnShow.Margin = new Padding(4, 5, 4, 5);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(286, 58);
            btnShow.TabIndex = 1;
            btnShow.Text = "Показати інформацію";
            btnShow.Click += btnShow_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(57, 50);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(286, 58);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Створити об’єкт";
            btnCreate.Click += btnCreate_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(13, 351);
            txtOutput.Margin = new Padding(4, 5, 4, 5);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(400, 348);
            txtOutput.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 321);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 3;
            label7.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 713);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(txtOutput);
            Controls.Add(label7);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна 5_1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYearBuilt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFloors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkParking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label7;
    }
}