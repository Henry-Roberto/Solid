using System;

namespace Ocp.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma moto {color}, {year}, {engine}.");
            StartVehicle();
        }
    }
}
