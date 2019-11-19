using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentLibrary.Sweets;
using PresentLibrary.Presents;
using PresentLibrary.Sweets.Candys;
using PresentLibrary.Sweets.Cookies;
using PresentLibrary.Sweets.Chocolates;
using PresentLibrary.Sweets.Waffles;

namespace PresentLibrary.PresentFactories
{
    public abstract class PresentFactory
    {
        public abstract Present CreatePresent(int count);
    }
}
