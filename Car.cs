using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{ 
    public class Car : Vehicle, IEngine, IWheel, ITransmission
    {
        public int DoorCount { get; set; }
        public string WinCode { get; set; }
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public double WheelThickness { get; set; }
        public string TransmissionKind { get; set; }
        public override double AverageSpeed()
        {
            return 0;
        }
    }
   
}
