// ITN114 Wireless Internet and Pervasive Computing
// Switch case C# exercise 1
// Azalea Mae C. Manimog

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time of day (Day/Night):");
            String input = Console.ReadLine();

            switch (input)
            {
                case "D":
                    Console.WriteLine("Day");
            break;
                case "N":
                    Console.WriteLine("Night");
            break;
            }

        }

    }
}
