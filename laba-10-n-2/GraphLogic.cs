namespace laba_10_n_2
{
    public class DirectedGraph
    {
        private readonly List<string> vertices;
        private readonly List<(string from, string to)> edges;

        public DirectedGraph()
        {
            vertices = ["a", "b", "c", "d", "e", "f"];

            edges =
            [
                ("a", "a"), // e1
                ("a", "b"), // e2
                ("a", "e"), // e3
                ("b", "f"), // e4
                ("b", "c"), // e5
                ("c", "c"), // e6
                ("c", "e"), // e7
                ("c", "b"), // e8
                ("d", "a"), // e9
                ("d", "b"), // e10
                ("f", "c"), // e11
                ("e", "b")  // e12
            ];
        }

        public List<string> GetVertices() => vertices;
        public List<(string from, string to)> GetEdges() => edges;

        public int[,] GetAdjacencyMatrix()
        {
            int vCount = vertices.Count;
            int[,] matrix = new int[vCount, vCount];

            foreach (var (from, to) in edges)
            {
                int i = vertices.IndexOf(from);
                int j = vertices.IndexOf(to);

                if (i != -1 && j != -1)
                {
                    // A[i, j] = 1, якщо є ребро з i в j
                    matrix[i, j] = 1;
                }
            }
            return matrix;
        }

        public int[,] GetIncidenceMatrix()
        {
            int vCount = vertices.Count;
            int eCount = edges.Count;
            int[,] matrix = new int[vCount, eCount];

            for (int j = 0; j < eCount; j++)
            {
                var (from, to) = edges[j];
                int i_from = vertices.IndexOf(from);
                int i_to = vertices.IndexOf(to);

                // Для спрямованих графів:
                // +1 (або 1), якщо вершина є початком ребра
                // -1, якщо вершина є кінцем ребра
                // 0, якщо не інцидентна

                if (i_from == i_to)
                {
                    // Для ПЕТЛІ (a->a) ставимо 0 (або інше спец. значення)
                    // Оскільки +1 і -1 в одній комірці поставити не можна.
                    // Використовуємо 0, як поширену конвенцію.
                    matrix[i_from, j] = 0;
                }
                else
                {
                    matrix[i_from, j] = 1;
                    matrix[i_to, j] = -1;
                }
            }
            return matrix;
        }
    }
}