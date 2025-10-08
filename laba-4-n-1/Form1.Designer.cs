//namespace laba_4_n_1
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Обов’язковий компонент контейнера.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Очищення всіх використовуваних ресурсів.
//        /// </summary>
//        /// <param name="disposing">true, якщо необхідно звільнити керовані ресурси; інакше — false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            this.labelInput = new System.Windows.Forms.Label();
//            this.textBoxInput = new System.Windows.Forms.TextBox();
//            this.labelOutput = new System.Windows.Forms.Label();
//            this.textBoxOutput = new System.Windows.Forms.TextBox();
//            this.buttonLoad = new System.Windows.Forms.Button();
//            this.buttonFilter = new System.Windows.Forms.Button();
//            this.buttonSave = new System.Windows.Forms.Button();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.labelStatus = new System.Windows.Forms.Label();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // labelInput
//            // 
//            this.labelInput.AutoSize = true;
//            this.labelInput.Location = new System.Drawing.Point(10, 15);
//            this.labelInput.Name = "labelInput";
//            this.labelInput.Size = new System.Drawing.Size(83, 20);
//            this.labelInput.TabIndex = 0;
//            this.labelInput.Text = "Input file:";
//            // 
//            // textBoxInput
//            // 
//            this.textBoxInput.Location = new System.Drawing.Point(100, 10);
//            this.textBoxInput.Name = "textBoxInput";
//            this.textBoxInput.Size = new System.Drawing.Size(250, 27);
//            this.textBoxInput.TabIndex = 1;
//            this.textBoxInput.Text = "InputData.txt";
//            // 
//            // labelOutput
//            // 
//            this.labelOutput.AutoSize = true;
//            this.labelOutput.Location = new System.Drawing.Point(370, 15);
//            this.labelOutput.Name = "labelOutput";
//            this.labelOutput.Size = new System.Drawing.Size(93, 20);
//            this.labelOutput.TabIndex = 2;
//            this.labelOutput.Text = "Output file:";
//            // 
//            // textBoxOutput
//            // 
//            this.textBoxOutput.Location = new System.Drawing.Point(470, 10);
//            this.textBoxOutput.Name = "textBoxOutput";
//            this.textBoxOutput.Size = new System.Drawing.Size(250, 27);
//            this.textBoxOutput.TabIndex = 3;
//            this.textBoxOutput.Text = "OutputData.txt";
//            // 
//            // buttonLoad
//            // 
//            this.buttonLoad.Location = new System.Drawing.Point(740, 8);
//            this.buttonLoad.Name = "buttonLoad";
//            this.buttonLoad.Size = new System.Drawing.Size(150, 32);
//            this.buttonLoad.TabIndex = 4;
//            this.buttonLoad.Text = "📂 Load Data";
//            this.buttonLoad.UseVisualStyleBackColor = true;
//            this.buttonLoad.Click += new System.EventHandler(this.BtnLoad_Click);
//            // 
//            // buttonFilter
//            // 
//            this.buttonFilter.Location = new System.Drawing.Point(900, 8);
//            this.buttonFilter.Name = "buttonFilter";
//            this.buttonFilter.Size = new System.Drawing.Size(170, 32);
//            this.buttonFilter.TabIndex = 5;
//            this.buttonFilter.Text = "⚽ Filter > 50 games";
//            this.buttonFilter.UseVisualStyleBackColor = true;
//            this.buttonFilter.Click += new System.EventHandler(this.BtnFilter_Click);
//            // 
//            // buttonSave
//            // 
//            this.buttonSave.Location = new System.Drawing.Point(1080, 8);
//            this.buttonSave.Name = "buttonSave";
//            this.buttonSave.Size = new System.Drawing.Size(170, 32);
//            this.buttonSave.TabIndex = 6;
//            this.buttonSave.Text = "💾 Save Table";
//            this.buttonSave.UseVisualStyleBackColor = true;
//            this.buttonSave.Click += new System.EventHandler(this.BtnSave_Click);
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.AllowUserToAddRows = false;
//            this.dataGridView1.AllowUserToDeleteRows = false;
//            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
//            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Location = new System.Drawing.Point(10, 50);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.ReadOnly = true;
//            this.dataGridView1.RowHeadersWidth = 51;
//            this.dataGridView1.RowTemplate.Height = 29;
//            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.dataGridView1.Size = new System.Drawing.Size(1240, 580);
//            this.dataGridView1.TabIndex = 7;
//            // 
//            // labelStatus
//            // 
//            this.labelStatus.AutoSize = true;
//            this.labelStatus.Location = new System.Drawing.Point(10, 640);
//            this.labelStatus.Name = "labelStatus";
//            this.labelStatus.Size = new System.Drawing.Size(0, 20);
//            this.labelStatus.TabIndex = 8;
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1280, 680);
//            this.Controls.Add(this.labelStatus);
//            this.Controls.Add(this.dataGridView1);
//            this.Controls.Add(this.buttonSave);
//            this.Controls.Add(this.buttonFilter);
//            this.Controls.Add(this.buttonLoad);
//            this.Controls.Add(this.textBoxOutput);
//            this.Controls.Add(this.labelOutput);
//            this.Controls.Add(this.textBoxInput);
//            this.Controls.Add(this.labelInput);
//            this.Name = "Form1";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Lab 4 — Footballers (filter > 50 games)";
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label labelInput;
//        private System.Windows.Forms.TextBox textBoxInput;
//        private System.Windows.Forms.Label labelOutput;
//        private System.Windows.Forms.TextBox textBoxOutput;
//        private System.Windows.Forms.Button buttonLoad;
//        private System.Windows.Forms.Button buttonFilter;
//        private System.Windows.Forms.Button buttonSave;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.Label labelStatus;
//    }
//}


namespace laba_4_n_1
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTop.Controls.Add(this.labelInput);
            this.panelTop.Controls.Add(this.textBoxInput);
            this.panelTop.Controls.Add(this.labelOutput);
            this.panelTop.Controls.Add(this.textBoxOutput);
            this.panelTop.Controls.Add(this.buttonLoad);
            this.panelTop.Controls.Add(this.buttonFilter);
            this.panelTop.Controls.Add(this.buttonSave);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 50;
            this.panelTop.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBottom.Controls.Add(this.labelStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 35;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelInput.Location = new System.Drawing.Point(10, 15);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(79, 21);
            this.labelInput.Text = "Input file:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(90, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(220, 27);
            this.textBoxInput.Text = "InputData.txt";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelOutput.Location = new System.Drawing.Point(320, 15);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(91, 21);
            this.labelOutput.Text = "Output file:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(410, 12);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(220, 27);
            this.textBoxOutput.Text = "OutputData.txt";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(650, 8);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(130, 32);
            this.buttonLoad.Text = "📂 Load Data";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonFilter.ForeColor = System.Drawing.Color.White;
            this.buttonFilter.Location = new System.Drawing.Point(790, 8);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(160, 32);
            this.buttonFilter.Text = "⚽ Filter > 50 games";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(960, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(140, 32);
            this.buttonSave.Text = "💾 Save Table";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(10, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 530);
            // 
            // labelStatus
            // 
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelStatus.ForeColor = System.Drawing.Color.Black;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1130, 640);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 4 — Footballers (Filter > 50 Games)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
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
