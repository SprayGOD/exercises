using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Parser.TextParser;


namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {


            TextParser textParser = new TextParser(ConfigurationManager.AppSettings["TextFile"]);

            string line;
            try
            {
                using(StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["TextFile"]))
                {
                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
