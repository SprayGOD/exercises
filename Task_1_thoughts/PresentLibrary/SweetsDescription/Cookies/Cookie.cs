using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary.SweetsDescription.Cookies
{
    public class Cookie : Sweets, ISugarFree
    {
        public bool IsSugarFree { get; set; }
        private int chocolatePercentage;
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

        public Cookie(int chocolatePercentage, string name, int weight, int sugar) :
            base(name,  weight, sugar)
        {
            ChocolatePercentage = chocolatePercentage;
        }
    }
}
