using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.Day3
{
    internal abstract class Vehicle
    {
        public Vehicle() {
            Console.WriteLine("Vehicle Constructor");
        }
        public void Start()
        {
            Console.WriteLine("Vehicle Satrt");
        }
    }

    internal class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car Constructor");
        }
    }
    class VehicleTesters
    {
        public static void TestOne()
        {
            Vehicle tester = new Car();
            tester.Start();
        }
    }
}
