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

        public GlazedCandy(FillingType filling, string name, int weight, int sugar) :
            base(name, weight, sugar)
        {
            Filling = filling;
        }
    }
}
