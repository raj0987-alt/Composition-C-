using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionPrac
{
    public class Vegetable
    {
        private readonly Vest _vest;

        public Vegetable(Vest vest)
        {
            _vest = vest;
        }
        public void VegetableKeep()
        {
            _vest.KeepInVest("Vegetable Is Kept In The Vest.");
        }
    }
}
