using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Factorial");
            Console.WriteLine("Enter any number");
            string fact = Console.ReadLine();

            int factorialNo = 0;
            int.TryParse(fact, out factorialNo);

            if (factorialNo > 0)
            {
                int result = GetFactorial(factorialNo);
                Console.WriteLine("Factorial of " + fact + "! is " + result +".");
            }
            else
            {
                Console.WriteLine("You have entered invalid number.");
            }

            Console.WriteLine("Thank You. Press enter to close");
            Console.ReadLine();
        }

        static int GetFactorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }


            return fact;
        }
    }
}
