using System;

namespace Lesson11Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new ExcelentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new BadPupil();
            Pupil pupil4 = new BadPupil();

            ClassRoom classRoom = new ClassRoom(pupil1,pupil2,pupil3,pupil4);
            pupil1.Study();
            pupil1.Read();
            pupil1.Write();
            pupil1.Relax();
            Console.WriteLine();
            pupil2.Study();
            pupil2.Read();
            pupil2.Write();
            pupil2.Relax();
            Console.WriteLine();
            pupil3.Study();
            pupil3.Read();
            pupil3.Write();
            pupil3.Relax();
            Console.WriteLine();
            pupil4.Study();
            pupil4.Read();
            pupil4.Write();
            pupil4.Relax();


        }
    }
}
