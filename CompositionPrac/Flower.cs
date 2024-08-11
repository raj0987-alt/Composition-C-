using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionPrac
{
    public class Flower
    {
        private readonly Vest _vest;
        public Flower(Vest vest)
        {
            _vest = vest;
        }
        public void FlowerKeep()
        {
            _vest.KeepInVest("Flower Is Kept In The Vest.");
        }
    }
}
