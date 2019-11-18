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

        public Chocolate(ChocolateType chocolateType, string name, int weight, int sugar) :
            base(name,  weight, sugar)
        {
            ChocolateType = chocolateType;
        }
    }
}
