using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.SweetsDescription.Chocolates
{
    public class Chocolate : Sweets, IDiabetic
    {
        private int chocolatePercentage;
        public ChocolateType ChocolateType { get; set; }
        public bool IsDiabetic { get; set; }
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

        public Chocolate(int chocolatePercentage, string name, int weight, int sugar) :
            base(name,  weight, sugar)
        {
            ChocolatePercentage = chocolatePercentage;
        }
    }
}
