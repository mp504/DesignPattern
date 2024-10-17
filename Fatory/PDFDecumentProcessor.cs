using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatory
{
    public interface IDecumentProcessor 
    {
        void Process(string filepath);
    }

    public class PDFDecumentProcessor : IDecumentProcessor
    {
     public void Process (string  filePath)
     {
            Console.WriteLine(" pdf processing here!: " +filePath);

     }   

    }
}
