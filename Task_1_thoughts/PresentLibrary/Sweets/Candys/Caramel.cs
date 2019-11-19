using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.Sweets.Candys
{
    public class Caramel : Candy
    {
        int syrupPercentage;
        public int SyrupPercentage
        {
            get
            {
                return syrupPercentage;
            }
            private set
            {
                if (IsValid(value))
                    syrupPercentage = value;
                else
                    throw new ArgumentException("Invalid value.");
            }
        }

        public Caramel(int syrupPercentage, ManufacturerType manufacturer, int weight, int sugar) :
            base(manufacturer, weight, sugar)
        {
            SyrupPercentage = syrupPercentage;
        }
        public override string ToString()
        {
            return base.ToString() + "; syrup percentage: " + SyrupPercentage;
        }
    }
}
