using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Bicycle: Vehiclee, IWheel
    {
        public string PedalKind { get; set; }
        public double WheelThickness { get; set; }
        public override double AverageSpeed()
        {
            return 0;
        }
    }
}
