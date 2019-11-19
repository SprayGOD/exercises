using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PresentLibrary.Presents;
using PresentLibrary.Sweets;
using PresentLibrary.Sweets.Candys;
using PresentLibrary.Sweets.Cookies;
using PresentLibrary.Sweets.Chocolates;
using PresentLibrary.Sweets.Waffles;

namespace PresentLibrary.PresentFactories
{
    public class ChocolatePresentFactory : PresentFactory
    {
        private Random random = new Random();

        public override Present CreatePresent(int count)
        {
            Present present = new Present();
            int index = 0;

            if(count <= index)
                throw new IndexOutOfRangeException("Invalid value.");
            else
            {
                while (index < count)
                {
                    Chocolate chocolate = new Chocolate(RandomEnumValue<ChocolateType>(), RandomEnumValue<ManufacturerType>(),
                        random.Next(5, 100), random.Next(1,99));
                    present.Add(chocolate);
                    index++;
                }
            }
            return present;  
        }

        private T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(random.Next(v.Length));
        }

    }
}
