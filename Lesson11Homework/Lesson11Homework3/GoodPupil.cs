using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11Homework3
{
    class GoodPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Everything is good!");
        }
        public override void Read()
        {
            Console.WriteLine("Everything is good!");
        }
        public override void Write()
        {
            Console.WriteLine("Everything is good!");
        }
        public override void Relax()
        {
            Console.WriteLine("Everything is good!");
        }
    }
}
