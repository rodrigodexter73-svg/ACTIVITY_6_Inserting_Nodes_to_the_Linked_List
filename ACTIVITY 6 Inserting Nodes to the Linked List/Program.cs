using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_6_Inserting_Nodes_to_the_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Dexter V. Rodrigo      //Date: Jan,22,2026      
            //Section: IT402P
            //Activity: Inserting Nodes to the Linked List (Procedural Approach)

            LinkedList<string> list = new LinkedList<string>();

            int count;

            do
            {
                Console.Write("Enter number of names: ");
                count = Convert.ToInt32(Console.ReadLine());
            }
            while (count < 5 || count > 10);

            Console.WriteLine("\n(~~~My Friends Last Name~~~)");

            //insert nodes using loop 
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter Friend LastName: ");
                string name = Console.ReadLine();
                list.AddLast(name); //node insert
            }
            //linked list display 
            Console.WriteLine("\n(~~~Linked List Content~~~)");
            foreach(string name in list)
            {
              Console.Write("Friends Last Names: ");
              Console.WriteLine(name);
            }
            Console.ReadKey();














        }
    }
}
