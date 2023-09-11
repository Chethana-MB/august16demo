using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotodemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
        L1: Console.WriteLine("\n enter value for num...");
            num = Convert.ToInt16((Console.ReadLine()));
            if(num==1)
            {
                goto test1;
            }
            else
            {
                goto L1;
            }
        test1: Console.WriteLine("its all done..");
            Console.ReadLine();
        }
    }
}
