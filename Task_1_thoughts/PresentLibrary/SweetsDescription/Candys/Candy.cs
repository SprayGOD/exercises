using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentLibrary.SweetsDescription;

namespace PresentLibrary.SweetsDescription.Candys
{
    public abstract class Candy : Sweets
    {
        public bool IsGlazed { get; set; }
        public bool IsChocolate { get; set; }

        public Candy(string name, int weight, int sugarPercentage)
            : base
                (name, weight, sugarPercentage)
        {
        }
    }
}
