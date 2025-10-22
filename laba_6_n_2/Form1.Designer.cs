namespace laba_6_n_2
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
            groupBox1 = new GroupBox();
            txtOccupants = new TextBox();
            label5 = new Label();
            txtLocation = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            cmbType = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnShowOwnMethods = new Button();
            btnShowInterfaceInfo = new Button();
            btnCreate = new Button();
            txtOutput = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOccupants);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbType);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(20, 23);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(617, 471);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Введення даних";
            // 
            // txtOccupants
            // 
            txtOccupants.Location = new Point(258, 381);
            txtOccupants.Margin = new Padding(5, 6, 5, 6);
            txtOccupants.Name = "txtOccupants";
            txtOccupants.Size = new Size(327, 34);
            txtOccupants.TabIndex = 9;
            txtOccupants.Text = "5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 387);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 28);
            label5.TabIndex = 8;
            label5.Text = "К-сть мешканців:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(258, 304);
            txtLocation.Margin = new Padding(5, 6, 5, 6);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(327, 34);
            txtLocation.TabIndex = 7;
            txtLocation.Text = "вул. Любителів пива, 7/77";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 310);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 6;
            label4.Text = "Адреса притулку:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(258, 227);
            txtAge.Margin = new Padding(5, 6, 5, 6);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(327, 34);
            txtAge.TabIndex = 5;
            txtAge.Text = "3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 233);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 28);
            label3.TabIndex = 4;
            label3.Text = "Вік:";
            // 
            // txtName
            // 
            txtName.Location = new Point(258, 150);
            txtName.Margin = new Padding(5, 6, 5, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(327, 34);
            txtName.TabIndex = 3;
            txtName.Text = "Мурчик";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 156);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 2;
            label2.Text = "Ім'я (тварини):";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(258, 73);
            cmbType.Margin = new Padding(5, 6, 5, 6);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(327, 36);
            cmbType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 79);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 0;
            label1.Text = "Тип об'єкта:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnShowOwnMethods);
            groupBox2.Controls.Add(btnShowInterfaceInfo);
            groupBox2.Controls.Add(btnCreate);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(647, 23);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(473, 471);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Керування";
            // 
            // btnShowOwnMethods
            // 
            btnShowOwnMethods.Location = new Point(35, 325);
            btnShowOwnMethods.Margin = new Padding(5, 6, 5, 6);
            btnShowOwnMethods.Name = "btnShowOwnMethods";
            btnShowOwnMethods.Size = new Size(408, 104);
            btnShowOwnMethods.TabIndex = 2;
            btnShowOwnMethods.Text = "Шось зробити";
            btnShowOwnMethods.UseVisualStyleBackColor = true;
            btnShowOwnMethods.Click += btnShowOwnMethods_Click;
            // 
            // btnShowInterfaceInfo
            // 
            btnShowInterfaceInfo.Location = new Point(35, 194);
            btnShowInterfaceInfo.Margin = new Padding(5, 6, 5, 6);
            btnShowInterfaceInfo.Name = "btnShowInterfaceInfo";
            btnShowInterfaceInfo.Size = new Size(408, 104);
            btnShowInterfaceInfo.TabIndex = 1;
            btnShowInterfaceInfo.Text = "Показати інфу";
            btnShowInterfaceInfo.UseVisualStyleBackColor = true;
            btnShowInterfaceInfo.Click += btnShowInterfaceInfo_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(35, 63);
            btnCreate.Margin = new Padding(5, 6, 5, 6);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(408, 104);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Створити об'єкт";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtOutput.Location = new Point(20, 558);
            txtOutput.Margin = new Padding(5, 6, 5, 6);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(1097, 456);
            txtOutput.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(20, 515);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 28);
            label6.TabIndex = 3;
            label6.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 1040);
            Controls.Add(label6);
            Controls.Add(txtOutput);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "лаба 6-2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOccupants;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowOwnMethods;
        private System.Windows.Forms.Button btnShowInterfaceInfo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label6;
    }
}