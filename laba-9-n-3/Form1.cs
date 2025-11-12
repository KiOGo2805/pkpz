namespace laba_9_n_3
{
    public partial class Form1 : Form
    {
        private const string INPUT_FILE = "expression.txt";
        // Файл для виводу більше не потрібен
        // private const string OUTPUT_FILE = "result.txt";

        // Поле для зберігання результату більше не потрібне
        // private List<string> processingResult;

        public Form1()
        {
            InitializeComponent();
            // Кнопка збереження видалена
            // btnSaveResult.Enabled = false;
        }

        /// <summary>
        /// Кнопка 1: Зберігає, Зчитує та Обробляє
        /// </summary>
        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                // Крок 1: Введення з GUI
                string expression = txtExpression.Text;
                if (string.IsNullOrWhiteSpace(expression))
                {
                    MessageBox.Show("Будь ласка, введіть математичний вираз.");
                    return;
                }

                // Крок 2: Зберігаємо введений вираз у файл
                File.WriteAllText(INPUT_FILE, expression);

                // Крок 3: "зчитати список... із файлу"
                string expressionFromFile = File.ReadAllText(INPUT_FILE);

                // Крок 4: "провести обробку... згідно варіанту"
                // Тепер це локальна змінна
                var processingResult = CheckParentheses(expressionFromFile);

                // Крок 5: "результат... вивести на GUI"
                DisplayResult(processingResult);

                // Кнопка збереження видалена
                // btnSaveResult.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка");
            }
        }

        //
        // МЕТОД btnSaveResult_Click БУВ ПОВНІСТЮ ВИДАЛЕНИЙ
        //

        /// <summary>
        /// Головний метод обробки (Вимога Варіанту 1.3)
        /// </summary>
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

            List<string> results = ["Вираз збалансовано.", "Знайдені пари (позиція_відкриття, позиція_закриття):"];

            foreach (var (openIdx, closeIdx) in pairs)
            {
                results.Add($"Пара знайдена: ({openIdx}, {closeIdx})");
            }

            return results;
        }

        /// <summary>
        /// Допоміжний метод для виведення у ListBox
        /// </summary>
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