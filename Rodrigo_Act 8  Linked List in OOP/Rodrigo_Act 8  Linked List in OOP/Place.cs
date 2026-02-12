using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigo_Act_8__Linked_List_in_OOP
{
    internal class Place
    {
        public string Name;

        public Place(string name)
        {
            this.Name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Place: " + Name);
        }

    }
}
