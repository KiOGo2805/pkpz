namespace laba_9_n_3
{
    /// <summary>
    /// Вимога 1.3: Реалізація стека з використанням "одновимірного масиву чисел".
    /// Цей стек буде зберігати НОМЕРИ ПОЗИЦІЙ (int) дужок, що відкриваються.
    /// </summary>
    public class MyArrayStack
    {
        private readonly int[] array;  // Одновимірний масив чисел
        private int top;      // Індекс вершини стека
        private readonly int capacity; // Максимальна місткість

        public MyArrayStack(int size)
        {
            capacity = size;
            array = new int[capacity];
            top = -1; // Стек спочатку порожній
        }

        /// <summary>
        /// Вставка елемента (номер позиції) у стек.
        /// </summary>
        public void Push(int position)
        {
            if (top >= capacity - 1)
            {
                // Це має ніколи не статися, якщо масив розміром з вираз
                throw new StackOverflowException("Стек переповнений.");
            }
            // Збільшуємо індекс 'top' і додаємо елемент
            array[++top] = position;
        }

        /// <summary>
        /// Витягування елемента (номера позиції) зі стека.
        /// </summary>
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Спроба витягти елемент з порожнього стека.");
            }
            // Повертаємо елемент і зменшуємо індекс 'top'
            return array[top--];
        }

        /// <summary>
        /// Перевіряє, чи стек порожній.
        /// </summary>
        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}