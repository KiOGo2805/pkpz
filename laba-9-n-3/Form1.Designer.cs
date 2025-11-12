namespace laba_9_n_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            // btnSaveResult видалено
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть математичний вираз (GUI):";
            // 
            // txtExpression
            // 
            this.txtExpression.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExpression.Location = new System.Drawing.Point(15, 33);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(557, 25);
            this.txtExpression.TabIndex = 1;
            this.txtExpression.Text = "(2-4b)/((a-3)+(a+3))/(a-1))";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProcess.Location = new System.Drawing.Point(15, 74);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(557, 45);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Зберегти, Зчитати з файлу та Перевірити баланс дужок";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат:";
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 15;
            this.lstResult.Location = new System.Drawing.Point(15, 151);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(557, 199); // Збільшено висоту
            this.lstResult.TabIndex = 9;
            // 
            // btnSaveResult
            // 
            // (Блок btnSaveResult видалено)
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 365); // Зменшено висоту форми
            // this.Controls.Add(this.btnSaveResult); // Видалено
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна 9 (laba_9_n_3): Стек на масиві";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstResult;
        // private System.Windows.Forms.Button btnSaveResult; // Видалено
    }
}