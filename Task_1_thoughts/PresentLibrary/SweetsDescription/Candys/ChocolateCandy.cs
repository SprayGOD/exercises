using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.SweetsDescription.Candys
{
    public class ChocolateCandy : Candy
    {
        int chocolatePercentage;
        public int ChocolatePercentage
        {
            get
            {
                return chocolatePercentage;
            }
            private set
            {
                if (isValid(value))
                    chocolatePercentage = value;
                else
                    throw new ArgumentException("Invalid value.");
            }
        }

        public ChocolateCandy(int chocolatePercentage, string name, int weight, int sugar) :
            base(name, weight, sugar)
        {
            ChocolatePercentage = chocolatePercentage;
        }
    }
}
