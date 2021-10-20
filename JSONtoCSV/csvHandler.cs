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

namespace JSONtoCSV
{
    class csvHandler
    {
        public static object CsvExport { get; private set; }

        public static void getCSV()
        {
            string csvpath = @"C:\Users\91807\Desktop\Batch67\JSONtoCSV\data.csv";
            string jsonpath = @"C:\Users\91807\Desktop\Batch67\JSONtoCSV\NewFile.json";

            List<DataModel> records = JsonConvert.DeserializeObject<List<DataModel>>(File.ReadAllText(jsonpath));

            Console.WriteLine("Reading from JSON file--------");
            using (var writer = new StreamWriter(csvpath))
            using (var CsvWrite = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                CsvWrite.WriteRecords(records);
            }

        }
    }
}
