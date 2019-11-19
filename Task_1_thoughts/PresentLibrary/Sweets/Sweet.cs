using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.Sweets
{
    public abstract class Sweet
    {
        int sugarPercentage;
        public ManufacturerType Manufacturer { get; private set; }
        public int Weight { get; private set; }
        public int SugarPercentage
        {
            get 
            { 
                return sugarPercentage; 
            }
            private set
            {
                if (IsValid(value))
                    sugarPercentage = value;
                else
                    throw new ArgumentException("Invalid value.");
            }
        }

        public Sweet(ManufacturerType manufacturer, int weight, int sugarPercentage)
        {
            Manufacturer = manufacturer;
            Weight = weight;
            SugarPercentage = sugarPercentage; 
        }

        protected bool IsValid(int value)
        {
            if (value < 0 || value > 100)
                return false;
            else
                return true;
        }

        public override string ToString()
        {
            return "Name: " + Manufacturer + "; weight: " + Weight + "; sugar percentage: " + SugarPercentage; 
        }
    }
}
