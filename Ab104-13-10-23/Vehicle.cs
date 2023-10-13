using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_13_10_23
{
     public abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
        public DateTime ProductionDate { get; }

        public Vehicle(string factoryName, string model, string color, double driveTime, double drivePath, DateTime productionDate)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;
            ProductionDate = productionDate;
        }

        protected Vehicle(string factoryName, string model, string color, double driveTime, double drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }

        public abstract void DefineNatureHarmness();

        public double AverageSpeed()
        {
            if (DriveTime == 0)
            {
                Console.WriteLine("DriveTime cant be zero."); 
            }
            return DrivePath / DriveTime;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Factory Name: " + FactoryName);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Drive Time: " + DriveTime + " hours");
            Console.WriteLine("Drive Path: " + DrivePath + " kilometers");
            Console.WriteLine("Production Date: " + ProductionDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Average Speed: " + AverageSpeed() + " km/h");
        }

        public override string ToString()
        {
            return "Factory Name: " + FactoryName + ", Model: " + Model;
        }
    }
}
