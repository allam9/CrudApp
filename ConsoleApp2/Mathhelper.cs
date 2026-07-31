using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class Mathhelper
    {
        public static double CalcAmount(double amount)
        {
            return amount * 0.16;
        }

        public static double CalculateDis(double amount, double percentage)
        {
            return amount - (amount * percentage / 100);
        }
    }
}
