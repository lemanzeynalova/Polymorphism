namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[10]
                int count = 0;
            while (true)
            {
                Console.WriteLine("1- Yeni Car yarat");
                Console.WriteLine("2-Yeni Bicycle yarat");
                Console.WriteLine("3- Yeni Plane yarat");
                Console.WriteLine("4-Butun Vehiclelara bax");
                Console.WriteLine("5-Vehicle sil");
                Console.WriteLine("6-Stop");

                switch (count)
                {
                    case 1:
                        Console.WriteLine("Carin melumatlarini daxil edin:");
                        Car newCar = new Car();
                        vehicles[count] = newCar;
                        count++;
                        break;

                    case 2:
                        Console.WriteLine("Bicyclein melumatlarini daxil edin:");
                        Bicycle newBicycle = new Bicycle();
                        vehicles[count] = new Bicycle;
                        count++;
                        break;
                    case 3:
                        Console.WriteLine("Planein melumatlarini daxil edin:");
                        Plane newPlane = new Plane();
                        vehicles[count] = newPlane;
                        count++;
                        break;
                    case 4:
                        Console.WriteLine("Butun vehiclelar:");
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("index{ i}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Silmek istediyiniz vehiclenin ixdexini daxil edin");
                        int indexToDelete = int.Parse(Console.ReadLine());
                        if (indexToDelete >= 0 && indexToDelete < count)
                        {
                            for (int i = indexToDelete; i < count - 1; i++)
                            {
                                Vehicle[i] = vehicles[i + 1];
                            }
                            vehicles[count - 1] = null
                                count--;
                            Console.WriteLine("Index silindi");
                        }
                }
            }
        }
    }
    static Car NewCar()
    {
        Car car = new Car();
        Console.Write("HorsePower: ");
        car.HorsePower = int.Parse(Console.ReadLine());
        Console.Write("TankSize: ");
        car.TankSize = double.Parse(Console.ReadLine());
        Console.Write("CurrentOil: ");
        car.CurrentOil = double.Parse(Console.ReadLine());
        Console.Write("FuelType: ");
        car.FuelType = Console.ReadLine();
        Console.Write("WheelThickness: ");
        car.WheelThickness = double.Parse(Console.ReadLine());
        Console.Write("TransmissionKind: ");
        car.TransmissionKind = Console.ReadLine();
        Console.Write("DoorCount: ");
        car.DoorCount = int.Parse(Console.ReadLine());
        Console.Write("WinCode: ");
        car.WinCode = Console.ReadLine();
        Console.Write("DriveTime: ");
        car.DriveTime = double.Parse(Console.ReadLine());
        Console.Write("DrivePath: ");
        car.DrivePath = Console.ReadLine();
        return car;
    }
    static Bicycle NewBicycle()
    {

        Bicycle bicycle = new Bicycle();
        Console.Write("WheelThickness: ");
        bicycle.WheelThickness = double.Parse(Console.ReadLine());
        Console.Write("PedalKind: ");
        bicycle.PedalKind = Console.ReadLine();
        Console.Write("DriveTime: ");
        bicycle.DriveTime = double.Parse(Console.ReadLine());
        Console.Write("DrivePath: ");
        bicycle.DrivePath = Console.ReadLine();
        return bicycle;
    }
    static Plane CreatePlane()
    {

        Plane plane = new Plane();
        Console.Write("HorsePower: ");
        plane.HorsePower = int.Parse(Console.ReadLine());
        Console.Write("TankSize: ");
        plane.TankSize = double.Parse(Console.ReadLine());
        Console.Write("CurrentOil: ");
        plane.CurrentOil = double.Parse(Console.ReadLine());
        Console.Write("FuelType: ");
        plane.FuelType = Console.ReadLine();
        Console.Write("WingLength: ");
        plane.WingLength = double.Parse(Console.ReadLine());
        Console.Write("DriveTime: ");
        plane.DriveTime = double.Parse(Console.ReadLine());
        Console.Write("DrivePath: ");
        plane.DrivePath = Console.ReadLine();
        return plane;
    }
}