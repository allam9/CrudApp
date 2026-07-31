using System;
using System.Globalization;
using System.Net.Security;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 250;
            double TAX = Mathhelper.CalcAmount(price);

            double discountedPrice = Mathhelper.CalculateDis(price,10);

        }

        public static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach(string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}