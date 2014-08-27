using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantPrime = 10001;
            Console.WriteLine(loopCheck(wantPrime - 1));
            Console.ReadKey();
        }

        static int loopCheck(int end)
        {
            int primeCount = 4;
            int currentNumCheck = 11;
            while (primeCount <= end)
            {
                if (checkPrime(currentNumCheck) == true)
                {
                    primeCount++;
                    //Take out in final version, testing purposes only
                    //Console.WriteLine(currentNumCheck);
                }
                currentNumCheck += 2;
            }
            return (currentNumCheck - 2);
        }

        static bool checkPrime(int number)
        {
            bool mayBePrime = false;
            bool isNotPrime = false;
            bool isPrime = false;
            for (int i = 3; i <= (Math.Floor(Math.Sqrt(number))) && !isNotPrime; i += 2)
            {
                if (number % i == 0)
                {
                    isNotPrime = true;
                }
                else
                {
                    mayBePrime = true;
                }
            }
            isPrime = (mayBePrime && !isNotPrime);
            return isPrime;
        }
    }
}
