using Ab104_13_10_23;
using System;


Vehicle[] vehicles = new Vehicle[]
{
  new Car("Toyota", "Prado", "Black", 2.7, 150, 4, true),
  new Car("BMW", "M5", "Blue", 2.5, 200, 5, false),
  new Bicycle("Salcano", "Bike", "Orange", 0, 30, "Mountain"),
   new Bicycle("Toba", "Bike", "Black", 0, 20, "City")
};

foreach (var vehicle in vehicles)
{
    Console.WriteLine("Vehicle Information:");
    vehicle.GetInfo();
    vehicle.DefineNatureHarmness();
    Console.WriteLine("Output: " + vehicle);
    Console.WriteLine();
}
