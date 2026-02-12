using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigo_Act_8__Linked_List_in_OOP
{
    internal class LinkedListOperations
    {
        private LinkedList<Place> places = new LinkedList<Place>();

        public void Insert(Place place)
        {
            places.AddLast(place);
            Console.WriteLine("Place added successfully.");
        }

        public void Remove(string name)
        {
            var node = places.First;

            while (node != null)
            {
                if (node.Value.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    places.Remove(node);
                    Console.WriteLine("Place removed successfully.");
                    return;
                }
                node = node.Next;
            }

            Console.WriteLine("Place not found.");
        }

        public void Display()
        {
            if (places.Count == 0)
            {
                Console.WriteLine("Linked list is empty.");
                return;
            }

            Console.WriteLine("\n=== LINKED LIST OF PLACES ===");
            foreach (var place in places)
            {
                place.DisplayInfo();
            }
        }
    }
}