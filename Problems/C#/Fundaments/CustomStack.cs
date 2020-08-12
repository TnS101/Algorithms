namespace Interview_Prep.Fundaments
{
    using System;
    using System.Text;

    public class CustomStack<T> where T : class 
    {
        private readonly int maxSize;
        private readonly T[] stackArray;
        private int top;

        public CustomStack(int maxSize)
        {
            this.maxSize = maxSize;
            stackArray = new T[maxSize];
            top = -1;
        }

        public void Push(T data) 
        {
            if (this.IsFull())
            {
                Console.WriteLine("The stack is FULL!");
            }
            else
            {
                top++;
                stackArray[top] = data;
            }
        }

        public T Pop() 
        {
            if (this.IsEmpty)
            {
                Console.WriteLine("The stack is EMPTY!");
                return null;
            }
            else
            {
                return stackArray[top--]; 
            }
        }

        public T Peak() 
        {
            if (this.IsEmpty)
            {
                Console.WriteLine("The stack is EMPTY!");
                return null;
            }
            else
            {
                return stackArray[top];
            }
        }

        public int Length { get => this.top + 1; }

        public bool IsEmpty { get => this.top == -1; }

        private bool IsFull() 
        {
            return (maxSize - 1 == top);
        }
    }
}
