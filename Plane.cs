using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Plane: Vehicle, IEngine
    {
        public double WingLength { get; set; }
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil {  get; set; }
        public string FuelType { get; set; }
        public override double AverageSpeed()
        {
            return 0;
        }
    }
}
