namespace laba_4_n_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupOps;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbMul;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbPow;
        private System.Windows.Forms.Label lblRes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            btnImport = new Button();
            btnCalculate = new Button();
            btnExport = new Button();
            groupOps = new GroupBox();
            rbAdd = new RadioButton();
            rbSub = new RadioButton();
            rbMul = new RadioButton();
            rbDiv = new RadioButton();
            rbPow = new RadioButton();
            lblRes = new Label();
            groupOps.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(180, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(377, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Arithmetic Calculator";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(90, 90);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(200, 34);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(390, 90);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(200, 34);
            txtNum2.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.White;
            txtResult.Location = new Point(170, 375);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(430, 34);
            txtResult.TabIndex = 8;
            txtResult.Text = "";
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.LightSteelBlue;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Location = new Point(90, 150);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(150, 40);
            btnImport.TabIndex = 3;
            btnImport.Text = "📂 Import Data";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(46, 204, 113);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Location = new Point(270, 150);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 40);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "\U0001f9ee Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(155, 89, 182);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Location = new Point(450, 150);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(150, 40);
            btnExport.TabIndex = 5;
            btnExport.Text = "💾 Export Result";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // groupOps
            // 
            groupOps.Controls.Add(rbAdd);
            groupOps.Controls.Add(rbSub);
            groupOps.Controls.Add(rbMul);
            groupOps.Controls.Add(rbDiv);
            groupOps.Controls.Add(rbPow);
            groupOps.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupOps.Location = new Point(90, 220);
            groupOps.Name = "groupOps";
            groupOps.Size = new Size(510, 120);
            groupOps.TabIndex = 6;
            groupOps.TabStop = false;
            groupOps.Text = "Select Operation";
            // 
            // rbAdd
            // 
            rbAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbAdd.Location = new Point(35, 50);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(70, 50);
            rbAdd.TabIndex = 0;
            rbAdd.Text = "+";
            rbAdd.CheckedChanged += Radio_CheckedChanged;
            // 
            // rbSub
            // 
            rbSub.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbSub.Location = new Point(120, 50);
            rbSub.Name = "rbSub";
            rbSub.Size = new Size(70, 50);
            rbSub.TabIndex = 1;
            rbSub.Text = "-";
            rbSub.CheckedChanged += Radio_CheckedChanged;
            // 
            // rbMul
            // 
            rbMul.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbMul.Location = new Point(195, 50);
            rbMul.Name = "rbMul";
            rbMul.Size = new Size(70, 50);
            rbMul.TabIndex = 2;
            rbMul.Text = "*";
            rbMul.CheckedChanged += Radio_CheckedChanged;
            // 
            // rbDiv
            // 
            rbDiv.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbDiv.Location = new Point(270, 50);
            rbDiv.Name = "rbDiv";
            rbDiv.Size = new Size(70, 50);
            rbDiv.TabIndex = 3;
            rbDiv.Text = "/";
            rbDiv.CheckedChanged += Radio_CheckedChanged;
            // 
            // rbPow
            // 
            rbPow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbPow.Location = new Point(345, 50);
            rbPow.Name = "rbPow";
            rbPow.Size = new Size(70, 50);
            rbPow.TabIndex = 4;
            rbPow.Text = "^";
            rbPow.CheckedChanged += Radio_CheckedChanged;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRes.Location = new Point(90, 380);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(82, 30);
            lblRes.TabIndex = 7;
            lblRes.Text = "Result:";
            // 
            // Form1
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(680, 500);
            Controls.Add(lblTitle);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Controls.Add(btnImport);
            Controls.Add(btnCalculate);
            Controls.Add(btnExport);
            Controls.Add(groupOps);
            Controls.Add(lblRes);
            Controls.Add(txtResult);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task 3 — Arithmetic Calculator";
            groupOps.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
