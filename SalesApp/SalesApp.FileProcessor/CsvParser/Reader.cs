using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesAppConsole;
using CsvHelper;

namespace SalesAppConsole.CsvParser
{
    public class Reader
    {
        public void ReadFile(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csvReader = new CsvReader(reader))
            {
                var records = csvReader.GetRecords<CsvModel>();
            }
        }
    }
}
