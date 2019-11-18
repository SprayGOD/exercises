using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary
{
    public class Chocolate : Candy
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

        public Chocolate(int chocolatePercentage, string name, double weight, int sugar) :
            base(name,  weight, sugar)
        {
            ChocolatePercentage = chocolatePercentage;
        }
    }
}
