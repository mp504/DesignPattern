using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatory
{

    public class ExcelDecumentProcessing: IDecumentProcessor
    {
        public void Process(string filePath)
        {
            Console.WriteLine("Excel processing!: " + filePath);
        }
    }
}
