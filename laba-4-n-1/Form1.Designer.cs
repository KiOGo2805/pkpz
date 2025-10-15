namespace laba_4_n_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelInput = new Label();
            textBoxInput = new TextBox();
            labelOutput = new Label();
            textBoxOutput = new TextBox();
            buttonLoad = new Button();
            buttonFilter = new Button();
            buttonSave = new Button();
            dataGridView1 = new DataGridView();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelInput.Location = new Point(30, 25);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(104, 28);
            labelInput.TabIndex = 0;
            labelInput.Text = "Input file:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(130, 22);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(220, 34);
            textBoxInput.TabIndex = 1;
            textBoxInput.Text = "InputData.txt";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelOutput.Location = new Point(540, 25);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(121, 28);
            labelOutput.TabIndex = 3;
            labelOutput.Text = "Output file:";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(650, 22);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(220, 34);
            textBoxOutput.TabIndex = 4;
            textBoxOutput.Text = "OutputData.txt";
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(370, 20);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(140, 36);
            buttonLoad.TabIndex = 2;
            buttonLoad.Text = "📂 Load Data";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += BtnLoad_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonFilter.Location = new Point(1040, 20);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(200, 36);
            buttonFilter.TabIndex = 6;
            buttonFilter.Text = "Show > 50 games";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += BtnFilter_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(890, 20);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 36);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "💾 Save Table";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += BtnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1210, 530);
            dataGridView1.TabIndex = 7;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            labelStatus.ForeColor = Color.Gray;
            labelStatus.Location = new Point(30, 620);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(73, 25);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Ready...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 680);
            Controls.Add(labelStatus);
            Controls.Add(dataGridView1);
            Controls.Add(buttonFilter);
            Controls.Add(buttonSave);
            Controls.Add(textBoxOutput);
            Controls.Add(labelOutput);
            Controls.Add(buttonLoad);
            Controls.Add(textBoxInput);
            Controls.Add(labelInput);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 4 — Footballers (filter > 50 games)";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelStatus;
    }
}
