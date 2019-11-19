using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.Sweets.Candys
{
    public class GlazedCandy : Candy
    {
        public FillingType Filling { get; private set; }

        public GlazedCandy(FillingType filling, ManufacturerType manufacturer, int weight, int sugar) :
            base(manufacturer, weight, sugar)
        {
            Filling = filling;
        }

        public override string ToString()
        {
            return base.ToString() + "; filling type: " + Filling;
        }
    }
}
