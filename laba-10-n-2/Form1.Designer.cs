namespace laba_10_n_2
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
            this.btnShowAdjacency = new System.Windows.Forms.Button();
            this.btnShowIncidence = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowAdjacency
            // 
            this.btnShowAdjacency.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAdjacency.Location = new System.Drawing.Point(12, 12);
            this.btnShowAdjacency.Name = "btnShowAdjacency";
            this.btnShowAdjacency.Size = new System.Drawing.Size(280, 50);
            this.btnShowAdjacency.TabIndex = 0;
            this.btnShowAdjacency.Text = "Показати Матрицю Суміжності (A)";
            this.btnShowAdjacency.UseVisualStyleBackColor = true;
            this.btnShowAdjacency.Click += new System.EventHandler(this.btnShowAdjacency_Click);
            // 
            // btnShowIncidence
            // 
            this.btnShowIncidence.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowIncidence.Location = new System.Drawing.Point(298, 12);
            this.btnShowIncidence.Name = "btnShowIncidence";
            this.btnShowIncidence.Size = new System.Drawing.Size(280, 50);
            this.btnShowIncidence.TabIndex = 1;
            this.btnShowIncidence.Text = "Показати Матрицю Інцидентності (B)";
            this.btnShowIncidence.UseVisualStyleBackColor = true;
            this.btnShowIncidence.Click += new System.EventHandler(this.btnShowIncidence_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 91);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(566, 258);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вивід (Вимога 2: задання графу на екран):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnShowIncidence);
            this.Controls.Add(this.btnShowAdjacency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна 10 (laba_10_n_2): Графи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAdjacency;
        private System.Windows.Forms.Button btnShowIncidence;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
    }
}