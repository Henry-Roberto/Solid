using Isp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Azul", 2022, 4.5, 5, 2);
            Motorcycle motorcycle = new Motorcycle("Branca", 2023, 600);

            Console.ReadLine();
        }
    }
}
