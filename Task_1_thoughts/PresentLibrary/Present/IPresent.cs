using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentLibrary.SweetsDescription;

namespace PresentLibrary.Present
{
    interface IPresent
    {
        int GetWeight();

        IList<Sweets> SearchBySugar(double min, double max);

        IList<Sweets> SortBySugar();

        IList<Sweets> SortByWeight();
    }
}
