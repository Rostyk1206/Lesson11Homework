using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11Homework3
{
    class ClassRoom
    {
        public Pupil first;
        public Pupil second;
        public Pupil third;
        public Pupil fourth;

        public ClassRoom(Pupil first, Pupil second)
        {
            this.first = first;
            this.second = second;
        }
        public ClassRoom(Pupil first, Pupil second,Pupil third,Pupil fourth)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.fourth = fourth;
        }
    }
}
