namespace laba_7_n_3
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
            numRoundSeconds = new NumericUpDown();
            label7 = new Label();
            numRoundMinutes = new NumericUpDown();
            label6 = new Label();
            numRound = new NumericUpDown();
            label5 = new Label();
            txtLoser = new TextBox();
            label4 = new Label();
            txtWinner = new TextBox();
            label3 = new Label();
            dtpStartTime = new DateTimePicker();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            btnAddKnockout = new Button();
            txtOutput = new TextBox();
            label8 = new Label();
            tabControl1 = new TabControl();
            tabGeneral = new TabPage();
            btnFindShortestThisYear = new Button();
            btnShowLast3Months = new Button();
            btnShowAll = new Button();
            tabSearch = new TabPage();
            groupBox3 = new GroupBox();
            dtpSearchDate = new DateTimePicker();
            btnSearchByDate = new Button();
            groupBox2 = new GroupBox();
            dtpRangeEnd = new DateTimePicker();
            label10 = new Label();
            dtpRangeStart = new DateTimePicker();
            label9 = new Label();
            btnCountRound3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRoundSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoundMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRound).BeginInit();
            tabControl1.SuspendLayout();
            tabGeneral.SuspendLayout();
            tabSearch.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numRoundSeconds);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numRoundMinutes);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numRound);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtLoser);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtWinner);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpStartTime);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAddKnockout);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(20, 23);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(607, 762);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додати запис про нокаут";
            // 
            // numRoundSeconds
            // 
            numRoundSeconds.Location = new Point(447, 552);
            numRoundSeconds.Margin = new Padding(5, 6, 5, 6);
            numRoundSeconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numRoundSeconds.Name = "numRoundSeconds";
            numRoundSeconds.Size = new Size(125, 34);
            numRoundSeconds.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 556);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 28);
            label7.TabIndex = 13;
            label7.Text = "сек:";
            // 
            // numRoundMinutes
            // 
            numRoundMinutes.Location = new Point(252, 552);
            numRoundMinutes.Margin = new Padding(5, 6, 5, 6);
            numRoundMinutes.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numRoundMinutes.Name = "numRoundMinutes";
            numRoundMinutes.Size = new Size(125, 34);
            numRoundMinutes.TabIndex = 12;
            numRoundMinutes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 556);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(166, 28);
            label6.TabIndex = 11;
            label6.Text = "Час в раунді (хв):";
            // 
            // numRound
            // 
            numRound.Location = new Point(252, 473);
            numRound.Margin = new Padding(5, 6, 5, 6);
            numRound.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numRound.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRound.Name = "numRound";
            numRound.Size = new Size(320, 34);
            numRound.TabIndex = 10;
            numRound.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 477);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 28);
            label5.TabIndex = 9;
            label5.Text = "Раунд нокауту:";
            // 
            // txtLoser
            // 
            txtLoser.Location = new Point(252, 394);
            txtLoser.Margin = new Padding(5, 6, 5, 6);
            txtLoser.Name = "txtLoser";
            txtLoser.Size = new Size(317, 34);
            txtLoser.TabIndex = 8;
            txtLoser.Text = "Боксер Б";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 400);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 7;
            label4.Text = "ПІБ (поразка):";
            // 
            // txtWinner
            // 
            txtWinner.Location = new Point(252, 315);
            txtWinner.Margin = new Padding(5, 6, 5, 6);
            txtWinner.Name = "txtWinner";
            txtWinner.Size = new Size(317, 34);
            txtWinner.TabIndex = 6;
            txtWinner.Text = "Боксер А";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 321);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 5;
            label3.Text = "ПІБ (перемога):";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Location = new Point(252, 154);
            dtpStartTime.Margin = new Padding(5, 6, 5, 6);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(317, 34);
            dtpStartTime.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 163);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 3;
            label2.Text = "Час початку:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(252, 75);
            dtpDate.Margin = new Padding(5, 6, 5, 6);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(317, 34);
            dtpDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 85);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 1;
            label1.Text = "Дата:";
            // 
            // btnAddKnockout
            // 
            btnAddKnockout.Location = new Point(37, 644);
            btnAddKnockout.Margin = new Padding(5, 6, 5, 6);
            btnAddKnockout.Name = "btnAddKnockout";
            btnAddKnockout.Size = new Size(535, 87);
            btnAddKnockout.TabIndex = 0;
            btnAddKnockout.Text = "Додати запис";
            btnAddKnockout.UseVisualStyleBackColor = true;
            btnAddKnockout.Click += btnAddKnockout_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtOutput.Location = new Point(20, 833);
            txtOutput.Margin = new Padding(5, 6, 5, 6);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(1431, 412);
            txtOutput.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(20, 790);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 2;
            label8.Text = "Результат:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabGeneral);
            tabControl1.Controls.Add(tabSearch);
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(637, 23);
            tabControl1.Margin = new Padding(5, 6, 5, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(817, 762);
            tabControl1.TabIndex = 3;
            // 
            // tabGeneral
            // 
            tabGeneral.Controls.Add(btnFindShortestThisYear);
            tabGeneral.Controls.Add(btnShowLast3Months);
            tabGeneral.Controls.Add(btnShowAll);
            tabGeneral.Location = new Point(4, 37);
            tabGeneral.Margin = new Padding(5, 6, 5, 6);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(5, 6, 5, 6);
            tabGeneral.Size = new Size(809, 721);
            tabGeneral.TabIndex = 0;
            tabGeneral.Text = "Загальні операції";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // btnFindShortestThisYear
            // 
            btnFindShortestThisYear.Location = new Point(32, 277);
            btnFindShortestThisYear.Margin = new Padding(5, 6, 5, 6);
            btnFindShortestThisYear.Name = "btnFindShortestThisYear";
            btnFindShortestThisYear.Size = new Size(742, 100);
            btnFindShortestThisYear.TabIndex = 2;
            btnFindShortestThisYear.Text = "Вимога 4: Найкоротший поєдинок цього року";
            btnFindShortestThisYear.UseVisualStyleBackColor = true;
            btnFindShortestThisYear.Click += btnFindShortestThisYear_Click;
            // 
            // btnShowLast3Months
            // 
            btnShowLast3Months.Location = new Point(32, 154);
            btnShowLast3Months.Margin = new Padding(5, 6, 5, 6);
            btnShowLast3Months.Name = "btnShowLast3Months";
            btnShowLast3Months.Size = new Size(742, 100);
            btnShowLast3Months.TabIndex = 1;
            btnShowLast3Months.Text = "Вимога 2: Нокаути за останні 3 місяці";
            btnShowLast3Months.UseVisualStyleBackColor = true;
            btnShowLast3Months.Click += btnShowLast3Months_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(32, 31);
            btnShowAll.Margin = new Padding(5, 6, 5, 6);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(742, 100);
            btnShowAll.TabIndex = 0;
            btnShowAll.Text = "Вимога 1: Вивести всіх (з розрахунком часу)";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // tabSearch
            // 
            tabSearch.Controls.Add(groupBox3);
            tabSearch.Controls.Add(groupBox2);
            tabSearch.Location = new Point(4, 37);
            tabSearch.Margin = new Padding(5, 6, 5, 6);
            tabSearch.Name = "tabSearch";
            tabSearch.Padding = new Padding(5, 6, 5, 6);
            tabSearch.Size = new Size(809, 721);
            tabSearch.TabIndex = 1;
            tabSearch.Text = "Пошук";
            tabSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpSearchDate);
            groupBox3.Controls.Add(btnSearchByDate);
            groupBox3.Location = new Point(27, 390);
            groupBox3.Margin = new Padding(5, 6, 5, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 6, 5, 6);
            groupBox3.Size = new Size(747, 279);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Пошук за датою";
            // 
            // dtpSearchDate
            // 
            dtpSearchDate.Format = DateTimePickerFormat.Short;
            dtpSearchDate.Location = new Point(30, 81);
            dtpSearchDate.Margin = new Padding(5, 6, 5, 6);
            dtpSearchDate.Name = "dtpSearchDate";
            dtpSearchDate.Size = new Size(679, 34);
            dtpSearchDate.TabIndex = 2;
            // 
            // btnSearchByDate
            // 
            btnSearchByDate.Location = new Point(30, 156);
            btnSearchByDate.Margin = new Padding(5, 6, 5, 6);
            btnSearchByDate.Name = "btnSearchByDate";
            btnSearchByDate.Size = new Size(682, 87);
            btnSearchByDate.TabIndex = 1;
            btnSearchByDate.Text = "Знайти всі поєдинки на цю дату";
            btnSearchByDate.UseVisualStyleBackColor = true;
            btnSearchByDate.Click += btnSearchByDate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpRangeEnd);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dtpRangeStart);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnCountRound3);
            groupBox2.Location = new Point(27, 31);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(747, 348);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Нокаути у 3-му раунді";
            // 
            // dtpRangeEnd
            // 
            dtpRangeEnd.Format = DateTimePickerFormat.Short;
            dtpRangeEnd.Location = new Point(83, 148);
            dtpRangeEnd.Margin = new Padding(5, 6, 5, 6);
            dtpRangeEnd.Name = "dtpRangeEnd";
            dtpRangeEnd.Size = new Size(626, 34);
            dtpRangeEnd.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 158);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(42, 28);
            label10.TabIndex = 3;
            label10.Text = "До:";
            // 
            // dtpRangeStart
            // 
            dtpRangeStart.Format = DateTimePickerFormat.Short;
            dtpRangeStart.Location = new Point(83, 71);
            dtpRangeStart.Margin = new Padding(5, 6, 5, 6);
            dtpRangeStart.Name = "dtpRangeStart";
            dtpRangeStart.Size = new Size(626, 34);
            dtpRangeStart.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 81);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(43, 28);
            label9.TabIndex = 1;
            label9.Text = "Від:";
            // 
            // btnCountRound3
            // 
            btnCountRound3.Location = new Point(30, 229);
            btnCountRound3.Margin = new Padding(5, 6, 5, 6);
            btnCountRound3.Name = "btnCountRound3";
            btnCountRound3.Size = new Size(682, 87);
            btnCountRound3.TabIndex = 0;
            btnCountRound3.Text = "Підрахувати";
            btnCountRound3.UseVisualStyleBackColor = true;
            btnCountRound3.Click += btnCountRound3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 1271);
            Controls.Add(tabControl1);
            Controls.Add(label8);
            Controls.Add(txtOutput);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "laba-7-n-3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRoundSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoundMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRound).EndInit();
            tabControl1.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            tabSearch.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddKnockout;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWinner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRoundSeconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numRoundMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Button btnShowLast3Months;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCountRound3;
        private System.Windows.Forms.DateTimePicker dtpRangeEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpRangeStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFindShortestThisYear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.Button btnSearchByDate;
    }
}