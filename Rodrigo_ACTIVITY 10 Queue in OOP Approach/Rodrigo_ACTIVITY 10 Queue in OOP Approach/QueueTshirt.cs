using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigo_ACTIVITY_10_Queue_in_OOP_Approach
{
    internal class QueueTshirt
    {
        int max = 5;
        string[] queue;
        int front = -1;
        int rear = -1;

        public QueueTshirt()
        {
            queue = new string[max];
        }

        public void Enqueue()
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow!");
                return;
            }

            Console.Write("Enter T-shirt: ");
            string value = Console.ReadLine();

            if (front == -1)
                front = 0;

            rear++;
            queue[rear] = value;

            Console.WriteLine(value + " added to queue.");
        }

        public void Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine(queue[front] + " removed.");
            front++;
        }

        public void Display()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Queue elements:");

            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
}
