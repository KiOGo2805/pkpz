using System;
using System.Text;
using System.Windows.Forms;

namespace laba_10_n_2
{
    public partial class Form1 : Form
    {
        // Наш об'єкт, що "зберігає" граф
        private readonly DirectedGraph graph;

        public Form1()
        {
            InitializeComponent();

            // Створюємо екземпляр нашого графа
            graph = new DirectedGraph();

            // Встановлюємо моноширинний шрифт для виводу
            txtOutput.Font = new System.Drawing.Font("Consolas", 10F);
        }

        /// <summary>
        /// Кнопка: "Показати Матрицю Суміжності"
        /// </summary>
        private void btnShowAdjacency_Click(object sender, EventArgs e)
        {
            var matrix = graph.GetAdjacencyMatrix();
            var labels = graph.GetVertices().ToArray();

            txtOutput.Text = FormatMatrix(
                matrix,
                labels, // Назви рядків
                labels  // Назви стовпців
            );
        }

        /// <summary>
        /// Кнопка: "Показати Матрицю Інцидентності"
        /// </summary>
        private void btnShowIncidence_Click(object sender, EventArgs e)
        {
            var matrix = graph.GetIncidenceMatrix();
            var rowLabels = graph.GetVertices().ToArray();

            // Створюємо назви для стовпців (e1, e2, ... e12)
            var colLabels = new string[graph.GetEdges().Count];
            for (int i = 0; i < colLabels.Length; i++)
            {
                colLabels[i] = $"e{i + 1}";
            }

            txtOutput.Text = FormatMatrix(
                matrix,
                rowLabels,
                colLabels
            );
        }

        /// <summary>
        /// Допоміжний метод для красивого виводу матриці у TextBox.
        /// </summary>
        private string FormatMatrix(int[,] matrix, string[] rowLabels, string[] colLabels)
        {
            StringBuilder sb = new StringBuilder();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // 1. Друк заголовків стовпців
            sb.Append("      "); // Відступ для назв рядків
            foreach (string label in colLabels)
            {
                sb.Append($"{label,4}"); // 4 символи на стовпець
            }
            sb.AppendLine();
            sb.AppendLine("    " + new string('-', colLabels.Length * 4 + 4));

            // 2. Друк рядків
            for (int i = 0; i < rows; i++)
            {
                sb.Append($"{rowLabels[i],4} |"); // Назва рядка

                for (int j = 0; j < cols; j++)
                {
                    sb.Append($"{matrix[i, j],4}"); // Значення
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}