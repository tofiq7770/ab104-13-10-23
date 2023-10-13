using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_13_10_23
{
    public class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }

        public Car(string factoryName, string model, string color, double driveTime, double drivePath, int doorCount, bool isElectricCar)
            : base(factoryName, model, color, driveTime, drivePath)
        {
            DoorCount = doorCount;
            IsElectricCar = isElectricCar;
        }
        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine("Low Electric");
            }
            else
            {
                Console.WriteLine("High Gasoline");
            }
        }
    }
}