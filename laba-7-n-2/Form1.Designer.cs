namespace laba_7_n_2
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
            btnAddTrain = new Button();
            dtpTime = new DateTimePicker();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            txtTrainNum = new TextBox();
            label2 = new Label();
            txtDestination = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnShowAll = new Button();
            btnSearch = new Button();
            txtSearchDest = new TextBox();
            label5 = new Label();
            btnSort = new Button();
            txtOutput = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddTrain);
            groupBox1.Controls.Add(dtpTime);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTrainNum);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDestination);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(20, 23);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(583, 538);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додати потяг";
            // 
            // btnAddTrain
            // 
            btnAddTrain.Location = new Point(103, 419);
            btnAddTrain.Margin = new Padding(5, 6, 5, 6);
            btnAddTrain.Name = "btnAddTrain";
            btnAddTrain.Size = new Size(377, 87);
            btnAddTrain.TabIndex = 8;
            btnAddTrain.Text = "Додати до розкладу";
            btnAddTrain.UseVisualStyleBackColor = true;
            btnAddTrain.Click += btnAddTrain_Click;
            // 
            // dtpTime
            // 
            dtpTime.Location = new Point(275, 335);
            dtpTime.Margin = new Padding(5, 6, 5, 6);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(271, 34);
            dtpTime.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 340);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 28);
            label4.TabIndex = 6;
            label4.Text = "Час відправлення:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(275, 251);
            dtpDate.Margin = new Padding(5, 6, 5, 6);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(271, 34);
            dtpDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 256);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 4;
            label3.Text = "Дата відправлення:";
            // 
            // txtTrainNum
            // 
            txtTrainNum.Location = new Point(275, 164);
            txtTrainNum.Margin = new Padding(5, 6, 5, 6);
            txtTrainNum.Name = "txtTrainNum";
            txtTrainNum.Size = new Size(271, 34);
            txtTrainNum.TabIndex = 3;
            txtTrainNum.Text = "701";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 167);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 2;
            label2.Text = "Номер:";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(275, 80);
            txtDestination.Margin = new Padding(5, 6, 5, 6);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(271, 34);
            txtDestination.TabIndex = 1;
            txtDestination.Text = "Київ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 83);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 28);
            label1.TabIndex = 0;
            label1.Text = "Пункт призначення:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnShowAll);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearchDest);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnSort);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(613, 23);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(700, 538);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Операції з розкладом";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(35, 63);
            btnShowAll.Margin = new Padding(5, 6, 5, 6);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(633, 87);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Показати весь розклад";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(35, 419);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(633, 87);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchDest
            // 
            txtSearchDest.Location = new Point(287, 337);
            txtSearchDest.Margin = new Padding(5, 6, 5, 6);
            txtSearchDest.Name = "txtSearchDest";
            txtSearchDest.Size = new Size(381, 34);
            txtSearchDest.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 340);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 1;
            label5.Text = "Пошук за пунктом:";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(35, 181);
            btnSort.Margin = new Padding(5, 6, 5, 6);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(633, 87);
            btnSort.TabIndex = 0;
            btnSort.Text = "Впорядкувати за датою";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtOutput.Location = new Point(20, 617);
            txtOutput.Margin = new Padding(5, 6, 5, 6);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(1291, 512);
            txtOutput.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(20, 575);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 3;
            label6.Text = "Розклад";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 1156);
            Controls.Add(label6);
            Controls.Add(txtOutput);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "laba-7-n-2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrainNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchDest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowAll;
    }
}