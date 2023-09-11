using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //simplewhile();
            Console.WriteLine("start counting using do while loop.. ");
            int counter = 1;
            //bool keepgoing = true;
            do
            {
                Console.Write("{0,5}", counter);
                if (counter % 100 == 0 && counter != 0)
                {
                    Console.WriteLine("\n do you want to continue<y/n>?");
                    if(Console.ReadLine()!="y")
                    {
                        //keepgoing = false;
                        break;
                    }
                }
                counter = counter + 1;
            } while (true);
            Console.WriteLine("\n counting finished here.....");
            
            Console.ReadLine();

        }

        private static void simplewhile()
        {
            int counter = 200;
            while (counter < 100)
            {
                Console.Write("{0,5}", counter);
                counter++;
            }
        }
    }
}
