using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.Sweets.Candys
{
    public abstract class Candy : Sweet
    {
        public Candy(string name, int weight, int sugarPercentage)
            : base
                (name, weight, sugarPercentage)
        {
        }
    }
}
