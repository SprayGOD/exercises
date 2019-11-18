using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary
{
    public class Glazed : Candy
    {
        private int fillingPercentage;
        public int FillingPercentage
        {
            get
            {
                return fillingPercentage;
            }
            private set
            {
                if (IsValid(value))
                    fillingPercentage = value;
                else
                    throw new ArgumentException("Invalid value.");
            }
        }

        public Glazed(int filling, string name, double weight, int sugar): 
            base(name, weight, sugar)
        {
            FillingPercentage = filling;
        }
    }
}
