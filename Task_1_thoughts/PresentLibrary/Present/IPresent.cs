using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentLibrary.Sweets;

namespace PresentLibrary.Present
{
    interface IPresent
    {
        int GetWeight();

        IEnumerable<Sweet> SearchBySugar(double min, double max);

        IEnumerable<Sweet> SortBySugar(bool isDescending);

        IEnumerable<Sweet> SortByWeight(bool isDescending);
    }
}
