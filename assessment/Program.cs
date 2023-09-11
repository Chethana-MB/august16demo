using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter values in x and y");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x == 0 && y == 0)
            {
                Console.WriteLine("it lies in origin");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("it lies in first quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("it lies in second");
            }
        }
    }
}


       
