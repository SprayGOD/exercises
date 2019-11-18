using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.Sweets.Waffles
{
    public class Waffle : Sweet
    {
        public WaffleType WaffleType { get; private set; }

        public Waffle(WaffleType waffleType, string name, int weight, int sugar) : 
            base(name, weight, sugar)
        {
            WaffleType = waffleType;
        }
    }
}
