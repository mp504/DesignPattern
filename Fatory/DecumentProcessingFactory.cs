using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatory
{
    public static class DecumentProcessingFactory
    {

        public static IDecumentProcessor CreateProcessor(string decumentType)
        {
            switch (decumentType.ToLower()) 
            {
                case "pdf":
                    return new PDFDecumentProcessor();
                    break;

                case "excel":
                    return new ExcelDecumentProcessing();
                    break;
                case "word":
                    return new WordDecumentProcessor();
                    break;
                default:
                    throw new ArgumentException("Unsupported Decument Type");     
            }


        }
    }
}
