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

        public Waffle(WaffleType waffleType, ManufacturerType manufacturer, int weight, int sugar) :
            base(manufacturer, weight, sugar)
        {
            WaffleType = waffleType;
        }

        public override string ToString()
        {
            return base.ToString() + "; waffle type: " + WaffleType;
        }
    }
}
