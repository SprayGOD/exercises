using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.SweetsDescription.Waffles
{
    public class Waffle : Sweets
    {
        private int flourPercentage;
        public int FlourPercentage
        {
            get
            {
                return flourPercentage;
            }
            private set
            {
                if (isValid(value))
                    flourPercentage = value;
                else
                    throw new ArgumentException("Invalid value.");
            }
        }

        public Waffle(int flour, string name, int weight, int sugar) : 
            base(name, weight, sugar)
        {
            FlourPercentage = flour;
        }
    }
}
