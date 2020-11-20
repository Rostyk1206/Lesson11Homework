using System;

namespace Lesson11Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer model = new Model();
            model.Print("Acer");
            Printer color = new Color();
            color.Print("Red");
        }
    }
}
