using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11Homework
{
    class Model:Printer
    {
        public override void Print(string model)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Model:{model}");
        }
    }
}
