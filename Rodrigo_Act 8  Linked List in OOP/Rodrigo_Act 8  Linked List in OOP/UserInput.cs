using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigo_Act_8__Linked_List_in_OOP
{
    internal class UserInput
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int GetInt(string message)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    value = int.Parse(Console.ReadLine());
                    return value;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
}   }