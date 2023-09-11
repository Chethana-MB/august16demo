using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumpositivenumbersdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            do
            {
                Console.WriteLine("enter num value");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    continue;
                }
                else
                {
                    sum = sum + num;
                }
                if (num == 0)
                {
                    break;
                }
            }
            while (true);
            Console.WriteLine("sum of positive nums : " + sum);
            Console.ReadLine();

        }
    }
}
