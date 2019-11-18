using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLibrary
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

        public Caramel(int syrupPercentage, string name, double weight, int sugar) :
            base(name, weight, sugar)
        {
            SyrupPercentage = syrupPercentage;
        }
    }
}
