using Ocp.Vehicles;
using System;

namespace Ocp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TypeVehicle type = TypeVehicle.MOTORCYCLE;

            if (type == TypeVehicle.CAR)
            {
                Car vehicle = new Car("Azul", 2022, 2.0, 5, 4);
            } else
            {
                Motorcycle vehicle = new Motorcycle("Vermelha", 2023, 250);
            }

            Console.ReadLine();
        }
    }
}
