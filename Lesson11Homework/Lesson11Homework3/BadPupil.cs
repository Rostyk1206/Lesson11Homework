using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11Homework3
{
    class BadPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Everything is bad!");
        }
        public override void Read()
        {
            Console.WriteLine("Everything is bad!");
        }
        public override void Write()
        {
            Console.WriteLine("Everything is bad!");
        }
        public override void Relax()
        {
            Console.WriteLine("Everything is bad!");
        }
    }
}
