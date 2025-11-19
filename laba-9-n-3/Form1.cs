namespace laba_9_n_3
{
    public partial class Form1 : Form
    {
        private const string INPUT_FILE = "expression.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtExpression.Text;
                if (string.IsNullOrWhiteSpace(expression))
                {
                    MessageBox.Show("Будь ласка, введіть математичний вираз.");
                    return;
                }

                File.WriteAllText(INPUT_FILE, expression);

                string expressionFromFile = File.ReadAllText(INPUT_FILE);

                var processingResult = CheckParentheses(expressionFromFile);

                DisplayResult(processingResult);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка");
            }
        }

        private static List<string> CheckParentheses(string expression)
        {
            MyArrayStack stack = new(expression.Length);
            var pairs = new List<(int openIdx, int closeIdx)>();

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (c == '(')
                {
                    stack.Push(i);
                }
                else if (c == ')')
                {
                    if (stack.IsEmpty())
                    {
                        return [$"Помилка: Незбалансована дужка, що закривається, на позиції {i}."];
                    }
                    else
                    {
                        int openIndex = stack.Pop();
                        pairs.Add((openIndex, i));
                    }
                }
            }

            if (!stack.IsEmpty())
            {
                return ["Помилка: Незбалансовано. Не всі дужки, що відкриваються, закрито."];
            }

            List<string> results = ["Вираз збалансовано."];

            return results;
        }

        private void DisplayResult(List<string> results)
        {
            lstResult.Items.Clear();
            foreach (var item in results)
            {
                lstResult.Items.Add(item);
            }
        }
    }
}