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

        public Cookie(int chocolatePercentage, string name, int weight, int sugar) :
            base(name,  weight, sugar)
        {
            ChocolatePercentage = chocolatePercentage;
        }
    }
}
