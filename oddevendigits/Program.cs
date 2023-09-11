using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddevendigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            int outputNumber = ConstructOutputNumber(inputNumber);

            Console.WriteLine($"Output number: {outputNumber}");

            Console.ReadLine();
        }

        static int ConstructOutputNumber(int originalNumber)
        {
            int outputNumber = 0;
            int multiplier = 1;

            while (originalNumber > 0)
            {
                int digit = originalNumber % 10;
                int nextOdd = FindNextOddDigit(digit);
                int nextEven = FindNextEvenDigit(digit);

                if (digit % 2 == 0)
                {
                    outputNumber = (nextEven * multiplier) + outputNumber;
                }
                else
                {
                    outputNumber = (nextOdd * multiplier) + outputNumber;
                }

                multiplier *= 10;
                originalNumber /= 10;
            }

            return outputNumber;
        }

        static int FindNextOddDigit(int digit)
        {
            while (true)
            {
                digit++;
                if (digit % 2 == 1)
                {
                    return digit;
                }
            }
        }

        static int FindNextEvenDigit(int digit)
        {
            while (true)
            {
                digit++;
                if (digit % 2 == 0)
                {
                    return digit;
                }
            }
        }
    }
}


