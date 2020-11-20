using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11Homework5
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("The doucment is opened!!");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document is editing in the PRO version!!");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Documen is saving in the PRO version!!");
        }
    }
}
