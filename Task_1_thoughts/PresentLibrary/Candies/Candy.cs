using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary
{
    public abstract class Candy
    {
        private int sugarPercentage;
        public string Name { get; private set; }
        public double Weight { get; private set; }
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

        public Candy(string name, double weight, int sugarPercentage)
        {
            Name = name;
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
    }
}
