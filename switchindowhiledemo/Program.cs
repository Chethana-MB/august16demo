using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchindowhiledemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, choice;
            Console.WriteLine("enter values in a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("\n enter your choice..");
                Console.WriteLine("**************");
                Console.WriteLine("1.Addition..");
                Console.WriteLine("2.Substraction..");
                Console.WriteLine("3.Multiplication..");
                Console.WriteLine("4.Division..");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        c = a + b;
                        Console.WriteLine("The sum is {0}", c);
                        break;
                    case 2:
                        c = (a > b) ? (a - b) : (b - a);
                        Console.WriteLine("the substarction is {0}", c);
                        break;
                    case 3:
                        c = a * b;
                        Console.WriteLine("The multiplication is {0}", c);
                        break;
                    case 4:
                        c = a / b;
                        Console.WriteLine("The division is {0}", c);
                        break;
                    default:
                        Console.WriteLine("select option from 1 to 4 only");
                        break;
                }
                Console.WriteLine("do you want to run menu <y/n>?");
                if(Console.ReadLine()!="y")
                {
                    break;
                }
                    
            } while (true);

        }
    }
}
