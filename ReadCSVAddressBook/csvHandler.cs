using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace ReadCSVAddressBook
{
    class csvHandler
    {
        public static object CsvExport { get; private set; }

        public static void getCSV()
        {
            string path = @"C:\Users\91807\Desktop\Batch67\ReadCSVAddressBook\data.csv";
            //string newpath = @"C:\Users\91807\source\repos\FileIOCSV\newdata.csv";
          
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<DataModel>().ToList();
                Console.WriteLine("Successfull");

                foreach (DataModel dataModel in records)
                {
                    Console.WriteLine(dataModel.ToString());
                }
                Console.WriteLine("-------------------------------------");

            }


        }
    }
}
