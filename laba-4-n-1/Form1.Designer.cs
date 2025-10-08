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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelInput.Location = new Point(30, 25);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new Size(87, 23);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input file:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new Point(130, 22);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new Size(220, 27);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.Text = "InputData.txt";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new Point(370, 20);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new Size(140, 30);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "📂 Load Data";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelOutput.Location = new Point(540, 25);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new Size(103, 23);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Output file:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new Point(650, 22);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new Size(220, 27);
            this.textBoxOutput.TabIndex = 4;
            this.textBoxOutput.Text = "OutputData.txt";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new Point(890, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(130, 30);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "💾 Save Table";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonFilter.Location = new Point(1040, 20);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new Size(200, 30);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "⚽ Show > 50 games";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new Point(30, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new Size(1210, 530);
            this.dataGridView1.TabIndex = 7;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            this.labelStatus.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus.Location = new Point(30, 620);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new Size(67, 21);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Ready...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1280, 680);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.Font = new Font("Segoe UI", 10F);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lab 4 — Footballers (filter > 50 games)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
