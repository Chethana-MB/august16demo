using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j, n;
            Console.Write("multiplication table:\n");

            Console.Write("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
            Console.ReadLine();
        }
    }
}





    