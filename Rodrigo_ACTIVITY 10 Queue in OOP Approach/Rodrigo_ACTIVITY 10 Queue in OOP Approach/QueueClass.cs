using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigo_ACTIVITY_10_Queue_in_OOP_Approach
{
    internal class QueueClass
    {
        int[] queue;
        int front, rear, size;

        public QueueClass(int s)
        {
            size = s;
            queue = new int[size];
            front = -1;
            rear = -1;
        }

        public void Enqueue(int value)
        {
            if (rear == size - 1)
            {
                Console.WriteLine("Queue Overflow!");
            }
            else
            {
                if (front == -1)
                    front = 0;

                rear++;
                queue[rear] = value;
                Console.WriteLine(value + " inserted into queue.");
            }
        }

        public void Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue Underflow!");
            }
            else
            {
                Console.WriteLine("Removed: " + queue[front]);
                front++;
            }
        }

        public void Display()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                Console.WriteLine("Queue elements:");
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(queue[i] + " ");
                }
                Console.WriteLine();
            }
        }
 }   }