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

namespace CSVtoJson
{
    class csvHandler
    {
        public static object CsvExport { get; private set; }

        public static void getCSV()
        {
            string path = @"C:\Users\91807\Desktop\Batch67\CSVtoJson\data.csv";
            string jsonpath = @"C:\Users\91807\Desktop\Batch67\CSVtoJson\NewFile.json";
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

                JsonSerializer sr = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter(jsonpath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    sr.Serialize(writer,records);
                }
            }


        }
    }
}
