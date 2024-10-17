using Fatory;


namespace Fatory
{
    public class Program
    {
        public static void Main()
        {
            string documentType = "pdf"; 
            string filePath = "/path/to/document.pdf";

            IDecumentProcessor processor = DecumentProcessingFactory.CreateProcessor(documentType);
            processor.Process(filePath);
        }
    }
}
