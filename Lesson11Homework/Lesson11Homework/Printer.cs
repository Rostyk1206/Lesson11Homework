using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11Homework
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine($"{value}");
        }
    }
}
