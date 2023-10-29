using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public string DrivePath { get; set; }
        public abstract double AverageSpeed();
    }
    public interface IEngine
    {
        int HorsePower { get; set; }
        double TankSize { get; set; }
        double CurrentOil { get; set; }
        string FuelType { get; set; }
        double RemainOilAmount();
    }
    public interface IWheel
    {
        double WheelThickness { get; set; }
    }
    public interface ITransmission
    {
        string TransmissionKind { get; set; }
    }
}
