using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rodrigo_Act_8__Linked_List_in_OOP
{
    internal class Country : Place
    {
        public Country(string name) : base(name) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("Country: " + Name);
        }
    }
}
