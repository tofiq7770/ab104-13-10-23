using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_13_10_23
{
    public class Bicycle : Vehicle
    {
        public string Type { get; set; }

        public Bicycle(string factoryName, string model, string color, double driveTime, double drivePath, string type)
            : base(factoryName, model, color, driveTime, drivePath)
        {
            Type = type;
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("None Non-Motorized");
        }
    }

}
