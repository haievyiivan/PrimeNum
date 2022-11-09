using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); // Enter num
            bool common = true; // Is num common or no 

            // Loop
            for (int i = 2; i < x; i++)
            {
                // Check if remainder == 0 (equal)
                if (x % i == 0)
                {
                    // If remainder == 0 brake the loop 
                    common = false;
                    break;
                }
            }

            // Write  answer to the console
            if (common) // if its common
            {
                Console.WriteLine($"{x} is common number");
            }
            else // if its not common
            {
                Console.WriteLine($"{x} isnt common number");
            }

            // ReadKey
            Console.ReadKey();
        }
    }
}
