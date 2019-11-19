using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.Sweets.Cookies
{
    public class Cookie : Sweet
    {
        private int chocolatePercentage;
        public int ChocolatePercentage 
        { 
            get 
            { 
                return chocolatePercentage; 
            } 
            private set 
            { 
                if (IsValid(value))
                    chocolatePercentage = value; 
                else 
                    throw new ArgumentException("Invalid value."); 
            }
        }

        public Cookie(int chocolatePercentage, ManufacturerType manufacturer, int weight, int sugar) :
            base(manufacturer, weight, sugar)
        {
            ChocolatePercentage = chocolatePercentage;
        }

        public override string ToString()
        {
            return base.ToString() + "; chocolate percentage: " + ChocolatePercentage;
        }
    }
}
