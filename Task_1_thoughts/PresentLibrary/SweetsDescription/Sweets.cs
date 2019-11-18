using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.SweetsDescription
{
    public abstract class Sweets
    {
        int sugarPercentage;
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int SugarPercentage
        {
            get 
            { 
                return sugarPercentage; 
            }
            private set
            {
                if (isValid(value))
                    sugarPercentage = value;
                else
                    throw new ArgumentException("Invalid value.");
            }
        }

        public Sweets(string name, int weight, int sugarPercentage)
        {
            Name = name;
            Weight = weight;
            SugarPercentage = sugarPercentage; 
        }

        protected bool isValid(int value)
        {
            if (value < 0 || value > 100)
                return false;
            else
                return true;
        }
    }
}
