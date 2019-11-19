using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentLibrary.Sweets;
using PresentLibrary.Sweets.Candys;
using PresentLibrary.Sweets.Chocolates;
using PresentLibrary.Sweets.Cookies;
using PresentLibrary.Sweets.Waffles;
using PresentLibrary.Presents;
using PresentLibrary.PresentFactories;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PresentFactory factory = new ChocolatePresentFactory();
            Present present = factory.CreatePresent(5);

            Console.WriteLine("-----------------Candys in present-----------------");
            foreach (var candy in present)
            {
                Console.WriteLine(candy.ToString());
            }

            Console.WriteLine("\n--------Searching by range (from 20 to 70 percentage of sugar)--------");
            var searchResult = present.SearchBySugar(20, 70);
            foreach (var candy in searchResult)
            {
                Console.WriteLine(candy.ToString());
            }

            Console.WriteLine("\n--------Sorting by Descending (sorting by weight)--------");  
            var sortByDescending = present.SortByWeight(true);
            foreach (var candy in sortByDescending)
            {
                Console.WriteLine(candy.ToString());
            }

            Console.WriteLine("\n--------Sorting by Ascending (sorting by sugar percentage)--------");
            var sortByDefault = present.SortBySugar(false);
            foreach (var candy in sortByDefault)
            {
                Console.WriteLine(candy.ToString());
            }

            Console.ReadLine();
        }
    }
}
