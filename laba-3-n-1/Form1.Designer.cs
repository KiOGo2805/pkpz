namespace laba_3_n_1
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
            inputTextBox = new TextBox();
            checkButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(350, 150);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 0;
            label1.Text = "Введіть рядок";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(325, 175);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(150, 23);
            inputTextBox.TabIndex = 1;
            inputTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(350, 210);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(100, 30);
            checkButton.TabIndex = 2;
            checkButton.Text = "Перевірити";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = false;
            resultLabel.Location = new Point(250, 260);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(300, 30);
            resultLabel.TabIndex = 3;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(checkButton);
            Controls.Add(inputTextBox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Перевірка дужок";
            this.AcceptButton = this.checkButton;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private Button checkButton;
        private Label resultLabel;
    }
}
