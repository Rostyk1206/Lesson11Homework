using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11Homework5
{
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in new format!!");       
        }
    }
}
