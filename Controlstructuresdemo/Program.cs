using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlstructuresdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simpleifdemo();
            //elseifladder();
            //nestedif();

            Console.ReadLine();
        }

        private static void nestedif()
        {
            int x = 0, y = 0, z = 0;
            if (x == 0)
                if (y == 0)
                    if (z == 0)
                    {
                        Console.WriteLine("all are zero");
                    }
                    else
                    {
                        Console.WriteLine("only x and y are zero");
                    }
                else
                {
                    Console.WriteLine("only x is zero");

                }
            else
            {
                Console.WriteLine("no one is zero");
            }
        }

        private static void elseifladder()
        {
            int a, b, c, d;
            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c && a > d)
                Console.WriteLine("{0} is largest number", a);
            else if (b > c && b > d)
                Console.WriteLine("{0} is largest number", b);
            else if (c > d)
                Console.WriteLine("{0} is largest number", c);
            else
                Console.WriteLine("{0} is the largest number", d);
        }

        private static void Simpleifdemo()
        {
            int a, b, c, d, l;
            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            l = a;
            if (b > l)
                l = b;
            if (c > l)
                l = c;
            if (d > l)
                l = d;
            Console.WriteLine("The largest number among 4 is {0}", l);
        }
    }
}
