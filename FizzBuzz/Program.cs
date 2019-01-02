using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    /**
     * author: Nelson Nyland
     * contact: nelsonnyland@gmail.com
     */
    class Program
    {
        /**
        * 1. Pick a number between 1 and 99 (or just start from 1).
        * 2. Each person says the next number in the sequence, unless:
        *    a. The number contains a 5 or is divisible by 5, 
        *       the person says "Fizz!".
        *    b. The number contains a 7 or is divisible by 7,
        *       the person says "Buzz!".
        *    c. The number contains multiple conditions: 
        *       e.g.: "Fizz, fizz, buzz!" (contains and is divisible 
        *       by 5, and is divisible by 7)
        **/
        static void Main(string[] args)
        {
            FizzBuzz();
            Console.ReadKey();
        }

        static void FizzBuzz()
        {
            Console.Write("Pick a number between 1 and 99: ");
            string num = Console.ReadLine();            
            if (!String.IsNullOrWhiteSpace(num) &&
                Int32.TryParse(num, out int result))
            {
                for (int i = result; i < 100; i++)
                {
                    int count = 0;
                    if (i % 5 == 0)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write("Fizz ");
                            count++;
                        }                        
                        Console.WriteLine("Fizz ");
                        count++;
                    }
                    if (i % 7 == 0)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write("Buzz ");
                            count++;
                        }
                        Console.WriteLine("Buzz ");
                        count++;
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Must be a number between 1 and 99.");
                FizzBuzz();
            }
        }
    }
}
