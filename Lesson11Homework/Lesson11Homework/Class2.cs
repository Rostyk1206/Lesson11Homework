using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11Homework
{
    class Color : Printer
    {
        public override void Print(string color)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Color:{color}");
        }
    }
}
