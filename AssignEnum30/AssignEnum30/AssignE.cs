using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignEnum30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Sample
    {

        public enum VehType
        {
            Car = 0,
            Truck,
            Bus
        }
        public enum FuelType
        {
            Diesel,
            Petrol,
            CNG
        }

        public class Vehicle
        {
            string name;
            string color;
            int NoOfWheels;
            int Vehtype;
            int Fueltype;

            public Vehicle(string _name, string _color)
            {
                name = _name;
                color = _color;
            }

            public Vehicle(params Object[] arr)
            {
              //  for (int i = 0; i < arr.Length; i++)

                name = (string)arr[0];
                color = (string)arr[1];
                NoOfWheels = (int)arr[3];
                Vehtype = (int)arr[2];
                Fueltype = (int)arr[4];



                //Console.WriteLine(arr[i]);

            }

            public void start(int s)
            {
                if (s == (int)VehType.Bus)
                {
                    Console.WriteLine("Bus has started.....");
                }

                else if (s == (int)VehType.Car)
                {
                    Console.WriteLine("Car has started.....");
                }

                else if (s == (int)VehType.Truck)
                {
                    Console.WriteLine("Truck has started.....");
                }


            }

            public void stop(int s)
            {
                if (s == (int)VehType.Bus)
                {
                    Console.WriteLine("Bus has stoped.....");
                }

                else if (s == (int)VehType.Car)
                {
                    Console.WriteLine("Car has stoped.....");
                }

                else if (s == (int)VehType.Truck)
                {
                    Console.WriteLine("Truck has stoped.....");
                }


            }
        }

    }
    public class AssignE
    {

    }
}
