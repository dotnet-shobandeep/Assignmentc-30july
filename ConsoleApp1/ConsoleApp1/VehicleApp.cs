using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignEnum30;
using AssignEnum30.Sample;

namespace ConsoleApp1
{
    class VehicleApp
    {
        static void Main()
        {
            Vehicle car = new Vehicle("cielo","Red");
            Vehicle truck = new Vehicle("Tata", "blue", 4, "Truck", "diesel");
            car.start(1);
            truck.stop(2);
            Console.Read();
        }
    }
}
