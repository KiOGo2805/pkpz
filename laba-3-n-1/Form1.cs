using System;
using System.Windows.Forms;

namespace laba_3_n_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            char[] chars = input.ToCharArray();

            int openCount = 0, closeCount = 0;

            foreach (char c in chars)
            {
                if (c == '[') openCount++;
                if (c == ']') closeCount++;
            }

            if (openCount == 0 && closeCount == 0)
                resultLabel.Text = "ℹ️ У рядку немає квадратних дужок.";
            else if (openCount == closeCount)
                resultLabel.Text = "✅ Кількість квадратних дужок однакова.";
            else
                resultLabel.Text = $"❌ Кількість не співпадає: [ = {openCount}, ] = {closeCount}";
        }
    }
}
