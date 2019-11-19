using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentLibrary.Sweets;

namespace PresentLibrary.Presents
{
    interface IPresent
    {
        int GetWeight();

        IEnumerable<Sweet> SearchBySugar(int min, int max);

        IEnumerable<Sweet> SortBySugar(bool isDescending);

        IEnumerable<Sweet> SortByWeight(bool isDescending);
    }
}
