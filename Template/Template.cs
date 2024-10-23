using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class DataProcessor
    {
        // Template method
        public void ProcessData()
        {
            ReadData();
            Process();
            SaveData();
        }

        protected abstract void ReadData();
        protected abstract void Process();
        protected abstract void SaveData();
    }


    public class CsvDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading data from CSV file.");
        }

        protected override void Process()
        {
            Console.WriteLine("Processing CSV data.");
        }

        protected override void SaveData()
        {
            Console.WriteLine("Saving processed CSV data.");
        }
    }

    public class XmlDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading data from XML file.");
        }

        protected override void Process()
        {
            Console.WriteLine("Processing XML data.");
        }

        protected override void SaveData()
        {
            Console.WriteLine("Saving processed XML data.");
        }
    }



}
