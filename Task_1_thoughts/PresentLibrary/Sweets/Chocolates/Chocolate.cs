using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.Sweets.Chocolates
{
    public class Chocolate : Sweet
    {
        public ChocolateType ChocolateType { get; private set; }

        public Chocolate(ChocolateType chocolateType, ManufacturerType manufacturer, int weight, int sugar) :
            base(manufacturer, weight, sugar)
        {
            ChocolateType = chocolateType;
        }

        public override string ToString()
        {
            return base.ToString() + "; chocolate type: " + ChocolateType;
        }
    }
}
