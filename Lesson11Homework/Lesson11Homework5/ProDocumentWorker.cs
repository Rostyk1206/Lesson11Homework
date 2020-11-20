using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11Homework5
{
    class ProDocumentWorker:DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("The doucment has been edited!!");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document has been saved in old format.Saving in other format is in Expert version!");
        }
    }
}
