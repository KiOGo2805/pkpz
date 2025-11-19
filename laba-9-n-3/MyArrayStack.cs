namespace laba_9_n_3
{
    public class MyArrayStack
    {
        private readonly int[] array;
        private int top;
        private readonly int capacity;

        public MyArrayStack(int size)
        {
            capacity = size;
            array = new int[capacity];
            top = -1;
        }

        public void Push(int position)
        {
            if (top >= capacity - 1)
            {
                throw new StackOverflowException("Стек переповнений.");
            }
            array[++top] = position;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Спроба витягти елемент з порожнього стека.");
            }
            return array[top--];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}