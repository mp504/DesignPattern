using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatory
{
    public class WordDecumentProcessor : IDecumentProcessor
    {
        public void Process(string filePath)
        {
            Console.WriteLine(" word processing here!: " + filePath);

        }

    }
}
