using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace laba_3_n_3
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

        private void InitializeComponent()
        {
            inputTextBox = new TextBox();
            checkButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(150, 100);
            inputTextBox.Multiline = true;
            inputTextBox.Size = new Size(500, 80);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.TextAlign = HorizontalAlignment.Left;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(325, 200);
            checkButton.Size = new Size(150, 30);
            checkButton.Name = "checkButton";
            checkButton.Text = "Обробити текст";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = false;
            resultLabel.Location = new Point(150, 260);
            resultLabel.Size = new Size(500, 100);
            resultLabel.Name = "resultLabel";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputTextBox);
            Controls.Add(checkButton);
            Controls.Add(resultLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обробка тексту";
            AcceptButton = checkButton;
            ResumeLayout(false);
        }

        private TextBox inputTextBox;
        private Button checkButton;
        private Label resultLabel;
    }
}
