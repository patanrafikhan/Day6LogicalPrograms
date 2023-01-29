using System;

namespace reverseprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 12345678;
            int rmd;
            int reverse = 0;
            while (N!= 0)
            {
                rmd = N % 10;
                reverse = reverse * 10+rmd;
                N= N / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
