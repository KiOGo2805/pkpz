namespace laba_8_n_3
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
            label1 = new Label();
            cmbBrands = new ComboBox();
            btnGetInfo = new Button();
            txtOutput = new TextBox();
            groupBox1 = new GroupBox();
            btnContinue = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(463, 32);
            label1.TabIndex = 0;
            label1.Text = "Вікторина: Оберіть марку автомобіля";
            // 
            // cmbBrands
            // 
            cmbBrands.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrands.Font = new Font("Segoe UI", 11F);
            cmbBrands.FormattingEnabled = true;
            cmbBrands.Location = new Point(48, 102);
            cmbBrands.Margin = new Padding(5, 6, 5, 6);
            cmbBrands.Name = "cmbBrands";
            cmbBrands.Size = new Size(501, 38);
            cmbBrands.TabIndex = 1;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGetInfo.Location = new Point(48, 188);
            btnGetInfo.Margin = new Padding(5, 6, 5, 6);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(503, 77);
            btnGetInfo.TabIndex = 2;
            btnGetInfo.Text = "Показати інформацію";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtOutput.Location = new Point(25, 58);
            txtOutput.Margin = new Padding(5, 6, 5, 6);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(501, 160);
            txtOutput.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnContinue);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(txtOutput);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(23, 298);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(555, 356);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Результат";
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(25, 263);
            btnContinue.Margin = new Padding(5, 6, 5, 6);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(247, 67);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Продовжити";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.MistyRose;
            btnExit.Location = new Point(282, 263);
            btnExit.Margin = new Padding(5, 6, 5, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(247, 67);
            btnExit.TabIndex = 5;
            btnExit.Text = "Завершити";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 681);
            Controls.Add(groupBox1);
            Controls.Add(btnGetInfo);
            Controls.Add(cmbBrands);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "laba-8-n-3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrands;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnExit;
    }
}