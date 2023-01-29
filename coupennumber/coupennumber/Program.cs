using System;
using System.IO;
using System.Linq;
using System.Web;

namespace coupon
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Enter the number of distinct Coupon number you want:");
            Console.ReadKey();
            
            
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var chars ="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            
            var stringChars = new char[8];
            var random = new Random();
            

            for (int j = 0; j < n; j++)
            {


                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];

                }
            }

            var String1 = new String(stringChars);
            Console.WriteLine(String1);




        }
    }
}
