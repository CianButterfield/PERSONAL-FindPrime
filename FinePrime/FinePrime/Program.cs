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
            Greet();
            bool exit = false;
            while (!exit)
            {
                string inputString = Console.ReadLine();
                if (inputString != "exit" && inputString != "Exit" && inputString != "e" && inputString != "E")
                {
                    int inputInt = Convert.ToInt32(inputString);
                    int wantPrime = inputInt;
                    Console.WriteLine(loopCheck(wantPrime));
                }
                else
                {
                    exit = true;
                }
            }
            Console.WriteLine("Thank you for using the program");
            Console.ReadKey();
        }

        static int loopCheck(int end)
        {
            int primeCount = 4;
            int currentNumCheck = 11;
            while (primeCount < end)
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

        static void Greet()
        {
            Console.WriteLine("What prime do you want?");
            Console.WriteLine("WARNING: Inputs less than 5 will not desplay correct answers\nWARNING: Inputs over 10,0000 may take a long time");
            Console.WriteLine("Type 'exit' or 'e' to end program");
        }
    }
}
