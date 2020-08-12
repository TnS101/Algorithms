namespace Interview_Prep.Fundaments
{
    using System;
    using System.Text;

    public class CustomQueue<T> where T : class
    {
        private readonly int maxSize;
        private readonly T[] queueArray;
        private int front;
        private int rear;
        private int items;

        public CustomQueue(int maxSize)
        {
            this.maxSize = maxSize;
            this.queueArray = new T[maxSize];
            this.front = 0;
            this.rear = -1;
            this.items = 0;
        }

        public void Enqueue(T data) 
        {
            if (this.IsFull)
            {
                Console.WriteLine("Queue Is Full!");
                return;
            }

            if (rear == maxSize - 1)
            {
                rear = -1;
            }

            rear++;
            queueArray[rear] = data;
            items++;
        }

        public T Dequeue() 
        {
            if (this.IsEmpty)
            {
                Console.WriteLine("Queue is Empty!");
                return null;
            }

            T temp = queueArray[front];
            front++;
            if (front == maxSize)
            {
                front = 0;
            }

            return temp;
        }

        public T Peek() 
        {
            if (this.IsEmpty)
            {
                Console.WriteLine("Queue is Empty!");
                return null;
            }

            return queueArray[front];
        }

        public string View() 
        {
            var sb = new StringBuilder();
            for (int i = 0; i < queueArray.Length; i++)
            {
                sb.AppendLine(queueArray[i].ToString());
            }

            return sb.ToString();
        }

        public bool IsEmpty { get => items == 0; }

        private bool IsFull { get => items == maxSize; }
    }
}
