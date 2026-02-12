using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigo_Act_8__Linked_List_in_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListOperations listOps = new LinkedListOperations();
            int choice;

            do
            {
                
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Insert Country");
                Console.WriteLine("2. Remove Country");
                Console.WriteLine("3. Display Countries");
                Console.WriteLine("4. Exit");
              
                choice = UserInput.GetInt("Enter your choice: ");
                Console.WriteLine("\t");

                if (choice == 1)
                {
                    string name = UserInput.GetString("Enter country name: ");
                    Place country = new Country(name);
                    listOps.Insert(country);
                }
                else if (choice == 2)
                {
                    string removeName = UserInput.GetString("Enter country name to remove: ");
                    listOps.Remove(removeName);
                }
                else if (choice == 3)
                {
                    listOps.Display();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Exiting program...");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

            } while (choice != 4);

            Console.ReadKey();







        }
    }
}
