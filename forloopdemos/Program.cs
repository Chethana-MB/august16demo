using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopdemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //finding factorial of number using for loop
            int i;
            int n;
            float f = 1.0F;
            //decimal kk=34.56M//Convention
            Console.WriteLine("enter a number to find factorial");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("The factorial of {0} is {1}", n, f);
            Console.ReadLine();
        }
    }
}
