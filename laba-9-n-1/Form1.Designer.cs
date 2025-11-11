namespace laba_9_n_1
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
            btnProcessAndSave = new Button();
            btnShowSavedFile = new Button();
            lstResult = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtInputL1 = new TextBox();
            txtInputL2 = new TextBox();
            SuspendLayout();
            // 
            // btnProcessAndSave
            // 
            btnProcessAndSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProcessAndSave.Location = new Point(14, 555);
            btnProcessAndSave.Margin = new Padding(5, 6, 5, 6);
            btnProcessAndSave.Name = "btnProcessAndSave";
            btnProcessAndSave.Size = new Size(656, 87);
            btnProcessAndSave.TabIndex = 2;
            btnProcessAndSave.Text = "Обробити дані та Зберегти у L1_modified.txt";
            btnProcessAndSave.UseVisualStyleBackColor = true;
            btnProcessAndSave.Click += btnProcessAndSave_Click;
            // 
            // btnShowSavedFile
            // 
            btnShowSavedFile.Enabled = false;
            btnShowSavedFile.Font = new Font("Segoe UI", 10F);
            btnShowSavedFile.Location = new Point(20, 1023);
            btnShowSavedFile.Margin = new Padding(5, 6, 5, 6);
            btnShowSavedFile.Name = "btnShowSavedFile";
            btnShowSavedFile.Size = new Size(650, 87);
            btnShowSavedFile.TabIndex = 4;
            btnShowSavedFile.Text = "Показати вміст файлу L1_modified.txt";
            btnShowSavedFile.UseVisualStyleBackColor = true;
            btnShowSavedFile.Click += btnShowSavedFile_Click;
            // 
            // lstResult
            // 
            lstResult.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            lstResult.FormattingEnabled = true;
            lstResult.ItemHeight = 23;
            lstResult.Location = new Point(20, 683);
            lstResult.Margin = new Padding(5, 6, 5, 6);
            lstResult.Name = "lstResult";
            lstResult.Size = new Size(650, 303);
            lstResult.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(20, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 5;
            label1.Text = "Введіть Список L1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(350, 21);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 6;
            label2.Text = "Введіть Список L2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(20, 648);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 7;
            label3.Text = "Результат";
            // 
            // txtInputL1
            // 
            txtInputL1.Font = new Font("Consolas", 9.75F);
            txtInputL1.Location = new Point(20, 52);
            txtInputL1.Margin = new Padding(5, 6, 5, 6);
            txtInputL1.Multiline = true;
            txtInputL1.Name = "txtInputL1";
            txtInputL1.ScrollBars = ScrollBars.Vertical;
            txtInputL1.Size = new Size(320, 470);
            txtInputL1.TabIndex = 0;
            txtInputL1.Text = "яблуко\r\nгруша\r\nслива\r\nабрикос\r\nапельсин\r\nгруша\r\nвиноград\r\nперсик\r\nяблуко\r\nманго\r\nківі\r\nбанан";
            // 
            // txtInputL2
            // 
            txtInputL2.Font = new Font("Consolas", 9.75F);
            txtInputL2.Location = new Point(350, 52);
            txtInputL2.Margin = new Padding(5, 6, 5, 6);
            txtInputL2.Multiline = true;
            txtInputL2.Name = "txtInputL2";
            txtInputL2.ScrollBars = ScrollBars.Vertical;
            txtInputL2.Size = new Size(320, 470);
            txtInputL2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 1134);
            Controls.Add(txtInputL2);
            Controls.Add(txtInputL1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstResult);
            Controls.Add(btnShowSavedFile);
            Controls.Add(btnProcessAndSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "laba_9_n_1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessAndSave;
        private System.Windows.Forms.Button btnShowSavedFile;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputL1;
        private System.Windows.Forms.TextBox txtInputL2;
    }
}