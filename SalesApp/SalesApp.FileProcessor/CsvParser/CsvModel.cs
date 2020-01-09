using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppConsole.CsvParser
{
    public class CsvModel
    {
        public DateTime Date { get; set; }
        public string ClientName { get; set; }
        public string ItemName { get; set; }
        public int Sum { get; set; }
    }
}
