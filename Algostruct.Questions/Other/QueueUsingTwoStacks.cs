using System;
using System.Collections.Generic;

namespace Algostruct.Questions.Other
{
    public class QueueUsingTwoStacks
    {
        public void Present()
        {
            Queue<int> queue = new(1, 2, 3, 4);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            Console.WriteLine("Enqueue: " + 1);
            queue.Enqueue(1);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
        }

        public class Queue<T>
        {
            private readonly Stack<T> input = new();
            private readonly Stack<T> output = new();

            public Queue() { }

            public Queue(params T[] values)
            {
                foreach (var value in values)
                {
                    input.Push(value);
                }
            }

            public void Enqueue(T item)
            {
                input.Push(item);
            }

            public T Dequeue()
            {
                if (output.Count == 0)
                {
                    while (input.Count != 0)
                        output.Push(input.Pop());
                }

                return output.Pop();
            }
        }
    }
}
