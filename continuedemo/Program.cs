using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continuedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<=10)
            {
                i++;
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("{0}",i);

            }
            Console.ReadLine();
        }
    }
}
