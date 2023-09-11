using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 12, 12, 45, 6, 12, 33 };
            string[] names = new string[] { "abc", "def", "ghi", "jkl" };
            Console.WriteLine("\n printing numbers..");
            foreach(int num in numbers)
            {
                Console.Write("{0,5}", num);
            }
            Console.WriteLine("\n printing names..");
            foreach(string name  in names)
            {
                Console.WriteLine("{0,5}",name);

            }
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = numbers[i] * 2;
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0,5}", numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
