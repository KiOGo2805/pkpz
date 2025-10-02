using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace laba_3_n_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                resultLabel.Text = "⚠️ Введіть текст.";
                return;
            }

            string[] words = Regex.Split(input, @"\W+");

            string lastWord = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    lastWord = words[i];
                    break;
                }
            }

            if (string.IsNullOrEmpty(lastWord))
            {
                resultLabel.Text = "⚠️ Не вдалося визначити останнє слово.";
                return;
            }

            string pattern = $@"\b{Regex.Escape(lastWord)}\b";
            string output = Regex.Replace(input, pattern, m =>
            {
                int pos = m.Index;
                if (pos == input.LastIndexOf(lastWord, StringComparison.OrdinalIgnoreCase))
                    return lastWord;
                return "";
            }, RegexOptions.IgnoreCase);

            resultLabel.Text = output.Trim();
        }


    }
}
