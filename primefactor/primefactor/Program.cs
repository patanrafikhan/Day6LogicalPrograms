using System;
using System.Linq.Expressions;

namespace Returnprimefactor
{
        internal class Program
    {
        //Entry Point
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number :");
            int userInput=Convert.ToInt32(Console.ReadLine());

            PrimeFactors(userInput);

            Console.ReadLine();

        }

        public static void PrimeFactors(int n)
        {
            while(n%2==0)
            {
                Console.WriteLine(2 + "");
                n /= 2;
            }
            for (int i = 3; i & lt;= Math.Sqrt(n); i += 2) { while (n % i == 0) { Console.Write(i + " "); n /= i; } }
            if (n & gt; 2)
                // output factors
                Console.Write(n);
        }
    }
}
