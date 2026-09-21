using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_en
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a; // lower limit of safe readings
            uint b; // upper limit of safe readings
            uint n; // interference level value
            uint c = 0; // counter for safe readings
            uint d = 0; // variable to store the length of the safe reading segment
            uint m; // maximum length of the safe reading segment
                    // Data input
            Console.WriteLine("Enter the safety limits for readings");
            Console.Write("Lower limit: ");
            uint.TryParse(Console.ReadLine(), out a);
            Console.Write("Upper limit: ");
            uint.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Enter orbital station sensor readings");
            Console.WriteLine("0 - end data input");
            uint.TryParse(Console.ReadLine(), out n); // Input the first interference level value
            while (n != 0) // Input readings until the value is 0
            {
                if ((n >= a) && (n <= b)) // condition for safe readings
                {
                    c++; // Increment the safe readings counter
                }
                else
                {
                    d = c; // If readings are unsafe, store the count of safe readings
                    c = 0; // and reset the counter
                }
                uint.TryParse(Console.ReadLine(), out n); // input the next data point
            }
            /* Determine the maximum length of the segment
            where readings are safe. If the counter was reset
            (the chain of safe data was interrupted), the maximum length
            is the old counter value (variable "d"). 
            Otherwise, it is the current (new) counter value (variable "c").
            */
            if (d > c)
                m = d;
            else
                m = c;
            // Output information to the screen
            Console.WriteLine("Length of the interval where all readings are safe: " + m);
            Console.Read(); // Pause screen output until "Enter" is pressed"
        }
    }
}
