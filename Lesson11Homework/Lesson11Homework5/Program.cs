using System;

namespace Lesson11Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose access key:pro, exp or press enter. Please, access key:");
            string accesskey = Console.ReadLine();
            if (accesskey=="")
            {
                DocumentWorker document = new DocumentWorker();
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }
            else if (accesskey =="pro")
            {
                ProDocumentWorker document = new ProDocumentWorker();
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }
            else if (accesskey == "exp")
            {
                ExpertDocumentWorker document = new ExpertDocumentWorker();
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }

        }
    }
}
