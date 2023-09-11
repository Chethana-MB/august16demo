using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findingpowerdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("enter the base :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the exponent :");
            y = Convert.ToInt32(Console.ReadLine());
            float result = 1.0F;
            if (y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
            }
            Console.WriteLine("x to the poweer y is :" + result);
            Console.ReadLine();
        }
    }
}


