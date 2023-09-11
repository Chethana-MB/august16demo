using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printandscandemo
{
     class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter values in a and b..");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);
            Console.WriteLine("The sum of " + a + " and " + b + "is" + c);
            Console.WriteLine("The sum of {0,5} and {1,5} is {2,6}", a, b, c);


            //printing constants
            Console.WriteLine("{0}", 45.6);
            Console.WriteLine("Feb has either {0} or {1} days", 28, 29);
            Console.WriteLine("\n enter values in single line ");
            string input = Console.ReadLine();
            int m, n;
            m = Convert.ToInt32(input.Split(',')[0]);
            n = Convert.ToInt32(input.Split(',')[1]);
            Console.WriteLine("The sum of {0} amd {1} is {2}", m, n, (m + n));

            //knowing the datatype range
            Console.WriteLine("The int data type maxrange is {0} and " + "leastrange is {1}", int.MaxValue, int.MinValue);
            Console.WriteLine("The byte data type maxrange is {0} and " + "leastrange is {1}", byte.MaxValue, byte.MinValue);
            

            Console.ReadLine();
        }
    }
}
