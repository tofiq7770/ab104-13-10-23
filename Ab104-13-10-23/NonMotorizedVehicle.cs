using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_13_10_23
{
    public class NonMotorizedVehicle : Vehicle
    {
        public NonMotorizedVehicle(string factoryName, string model, string color, double driveTime, double drivePath, DateTime productionDate)
            : base(factoryName, model, color, driveTime, drivePath, productionDate)
        {
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("Non-Motorized");
        }
    }
}
