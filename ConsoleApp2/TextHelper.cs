using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class TextHelper
    {
        public static string captialize(string name)
        {
            return name.Substring(0,1).ToUpper() + name.Substring(1).ToLower();
        }

        public static int CountWords(string text)
        {
            var words = text.Split(" ");
            return words.Length;
        }
    }
}
