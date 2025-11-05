namespace laba_8_n_1
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
            numCardID = new NumericUpDown();
            btnAddPerson = new Button();
            numBirthYear = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            grpSpecificSearch = new GroupBox();
            btnFindAndShowAll = new Button();
            numSearchID = new NumericUpDown();
            label8 = new Label();
            btnShowSpecific = new Button();
            cmbFieldSelect = new ComboBox();
            label5 = new Label();
            btnShowAll = new Button();
            btnCountFreePassage = new Button();
            lstPeople = new ListBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCardID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBirthYear).BeginInit();
            groupBox2.SuspendLayout();
            grpSpecificSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSearchID).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numCardID);
            groupBox1.Controls.Add(btnAddPerson);
            groupBox1.Controls.Add(numBirthYear);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(20, 23);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(542, 644);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додати особу";
            // 
            // numCardID
            // 
            numCardID.Location = new Point(242, 406);
            numCardID.Margin = new Padding(5, 6, 5, 6);
            numCardID.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCardID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCardID.Name = "numCardID";
            numCardID.Size = new Size(267, 34);
            numCardID.TabIndex = 3;
            numCardID.Value = new decimal(new int[] { 1001, 0, 0, 0 });
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(70, 517);
            btnAddPerson.Margin = new Padding(5, 6, 5, 6);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(400, 87);
            btnAddPerson.TabIndex = 4;
            btnAddPerson.Text = "Додати";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // numBirthYear
            // 
            numBirthYear.Location = new Point(242, 298);
            numBirthYear.Margin = new Padding(5, 6, 5, 6);
            numBirthYear.Name = "numBirthYear";
            numBirthYear.Size = new Size(267, 34);
            numBirthYear.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 412);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 5;
            label4.Text = "ID Картки (додат.):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 302);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 28);
            label3.TabIndex = 4;
            label3.Text = "Рік народження:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(242, 190);
            txtFirstName.Margin = new Padding(5, 6, 5, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(264, 34);
            txtFirstName.TabIndex = 1;
            txtFirstName.Text = "Іван";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 196);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 2;
            label2.Text = "Ім'я (додат.):";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(242, 83);
            txtLastName.Margin = new Padding(5, 6, 5, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(264, 34);
            txtLastName.TabIndex = 0;
            txtLastName.Text = "Петренко";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 88);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 0;
            label1.Text = "Прізвище:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grpSpecificSearch);
            groupBox2.Controls.Add(btnShowAll);
            groupBox2.Controls.Add(btnCountFreePassage);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(572, 23);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(742, 644);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Операції";
            // 
            // grpSpecificSearch
            // 
            grpSpecificSearch.Controls.Add(btnFindAndShowAll);
            grpSpecificSearch.Controls.Add(numSearchID);
            grpSpecificSearch.Controls.Add(label8);
            grpSpecificSearch.Controls.Add(btnShowSpecific);
            grpSpecificSearch.Controls.Add(cmbFieldSelect);
            grpSpecificSearch.Controls.Add(label5);
            grpSpecificSearch.Location = new Point(38, 196);
            grpSpecificSearch.Margin = new Padding(5, 6, 5, 6);
            grpSpecificSearch.Name = "grpSpecificSearch";
            grpSpecificSearch.Padding = new Padding(5, 6, 5, 6);
            grpSpecificSearch.Size = new Size(667, 309);
            grpSpecificSearch.TabIndex = 4;
            grpSpecificSearch.TabStop = false;
            grpSpecificSearch.Text = "Виведення конкретного значення";
            // 
            // btnFindAndShowAll
            // 
            btnFindAndShowAll.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnFindAndShowAll.Location = new Point(35, 227);
            btnFindAndShowAll.Margin = new Padding(5, 6, 5, 6);
            btnFindAndShowAll.Name = "btnFindAndShowAll";
            btnFindAndShowAll.Size = new Size(292, 67);
            btnFindAndShowAll.TabIndex = 6;
            btnFindAndShowAll.Text = "Знайти та показати ВСІ дані";
            btnFindAndShowAll.UseVisualStyleBackColor = true;
            btnFindAndShowAll.Click += btnFindAndShowAll_Click;
            // 
            // numSearchID
            // 
            numSearchID.Location = new Point(228, 60);
            numSearchID.Margin = new Padding(5, 6, 5, 6);
            numSearchID.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSearchID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSearchID.Name = "numSearchID";
            numSearchID.Size = new Size(407, 34);
            numSearchID.TabIndex = 0;
            numSearchID.Value = new decimal(new int[] { 1001, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 63);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 28);
            label8.TabIndex = 5;
            label8.Text = "Знайти за ID:";
            // 
            // btnShowSpecific
            // 
            btnShowSpecific.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowSpecific.Location = new Point(343, 227);
            btnShowSpecific.Margin = new Padding(5, 6, 5, 6);
            btnShowSpecific.Name = "btnShowSpecific";
            btnShowSpecific.Size = new Size(292, 67);
            btnShowSpecific.TabIndex = 3;
            btnShowSpecific.Text = "Показати одне поле";
            btnShowSpecific.UseVisualStyleBackColor = true;
            btnShowSpecific.Click += btnShowSpecific_Click;
            // 
            // cmbFieldSelect
            // 
            cmbFieldSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFieldSelect.FormattingEnabled = true;
            cmbFieldSelect.Location = new Point(228, 144);
            cmbFieldSelect.Margin = new Padding(5, 6, 5, 6);
            cmbFieldSelect.Name = "cmbFieldSelect";
            cmbFieldSelect.Size = new Size(404, 36);
            cmbFieldSelect.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 150);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 28);
            label5.TabIndex = 0;
            label5.Text = "Оберіть поле:";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(38, 75);
            btnShowAll.Margin = new Padding(5, 6, 5, 6);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(667, 96);
            btnShowAll.TabIndex = 3;
            btnShowAll.Text = "Показати повний список";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnCountFreePassage
            // 
            btnCountFreePassage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCountFreePassage.Location = new Point(38, 517);
            btnCountFreePassage.Margin = new Padding(5, 6, 5, 6);
            btnCountFreePassage.Name = "btnCountFreePassage";
            btnCountFreePassage.Size = new Size(667, 87);
            btnCountFreePassage.TabIndex = 0;
            btnCountFreePassage.Text = "Підрахувати осіб > 60 років";
            btnCountFreePassage.UseVisualStyleBackColor = true;
            btnCountFreePassage.Click += btnCountFreePassage_Click;
            // 
            // lstPeople
            // 
            lstPeople.Font = new Font("Consolas", 9.75F);
            lstPeople.FormattingEnabled = true;
            lstPeople.ItemHeight = 23;
            lstPeople.Location = new Point(20, 731);
            lstPeople.Margin = new Padding(5, 6, 5, 6);
            lstPeople.Name = "lstPeople";
            lstPeople.Size = new Size(1291, 234);
            lstPeople.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(20, 689);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 28);
            label7.TabIndex = 5;
            label7.Text = "Список осіб:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 984);
            Controls.Add(label7);
            Controls.Add(lstPeople);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "laba-8-n-1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCardID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBirthYear).EndInit();
            groupBox2.ResumeLayout(false);
            grpSpecificSearch.ResumeLayout(false);
            grpSpecificSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSearchID).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.NumericUpDown numBirthYear;
        private System.Windows.Forms.Button btnCountFreePassage;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox grpSpecificSearch;
        private System.Windows.Forms.Button btnShowSpecific;
        private System.Windows.Forms.ComboBox cmbFieldSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstPeople;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numCardID;
        private System.Windows.Forms.NumericUpDown numSearchID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFindAndShowAll;
        private System.Windows.Forms.TextBox txtSpecificOutput;
        private System.Windows.Forms.Label label6;
    }
}