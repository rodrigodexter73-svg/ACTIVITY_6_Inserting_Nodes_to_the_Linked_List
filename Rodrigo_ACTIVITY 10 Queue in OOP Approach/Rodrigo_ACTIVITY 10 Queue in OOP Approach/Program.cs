using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigo_ACTIVITY_10_Queue_in_OOP_Approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueTshirt q = new QueueTshirt();
            int choice;

            do
            {
                Console.WriteLine("\n1. Enqueue T-shirt");
                Console.WriteLine("2. Dequeue T-shirt");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                        q.Enqueue();
                    else if (choice == 2)
                        q.Dequeue();
                    else if (choice == 3)
                        q.Display();
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                    choice = 0;
                }

            } while (choice != 4);
        }
    }
}
