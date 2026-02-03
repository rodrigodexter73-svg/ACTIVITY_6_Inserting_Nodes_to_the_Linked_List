using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigo_ACTIVITY_7_InsertingNodeswithExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Dexter V. Rodrigo
            //Date: Feb,3,2026
            //Section: IT402P
            //Activity: Inserting Nodes to the Linked List (Procedural Approach with Exception Handling and Sorting)

            LinkedList<string> list = new LinkedList<string>();
            int count = 0;
            bool valid = false;

            // ===== Exception Handling for number of names =====
            do
            {
                try
                {
                    Console.Write("Enter number of names (5 to 10): ");
                    count = Convert.ToInt32(Console.ReadLine());

                    if (count < 5 || count > 10)
                    {
                        Console.WriteLine("Error: Please enter a number between 5 and 10.\n");
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a NUMBER only.\n");
                }

            } while (!valid);

            Console.WriteLine("\n(~~~My Friends Last Name~~~)");

            // ===== Insert nodes using loop =====
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter Friend LastName: ");
                string name = Console.ReadLine();
                list.AddLast(name);
            }

            // ===== Display original linked list =====
            Console.WriteLine("\n(~~~Linked List Content~~~)");
            foreach (string name in list)
            {
                Console.WriteLine("Friends Last Names: " + name);
            }

            // ===== Sort using Array =====
            string[] arr = new string[list.Count];
            list.CopyTo(arr, 0);   // Copy linked list to array

            Array.Sort(arr);      // Sort array

            // Clear linked list and re-add sorted values
            list.Clear();
            foreach (string name in arr)
            {
                list.AddLast(name);
            }

            // ===== Display sorted linked list =====
            Console.WriteLine("\n(~~~Sorted Linked List Content~~~)");
            foreach (string name in list)
            {
                Console.WriteLine("Friends Last Names: " + name);
            }

            Console.ReadKey();
        }
    }
}
