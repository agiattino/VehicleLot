using System;

namespace vehicleLot
{
    class Program
    {
        public class Vehicle
        {
            protected string VechileMake { get; set; }
            protected string VechileModle { get; set; }
            protected string VechileMilage { get; set; }

        }


        public class Semi : Vehicle
        {
            public string EighteenWheels { get; set; }
            public int PassengerCount = 2;
            public int CubicFeetSpace = 500;

        }

        public class Car : Vehicle
        {
            public int Wheels = 4;
            public int PassengerCount = 5;
        }
        

        static void Main(string[] args)
        {
            Car myCar = new Car();
            
            Console.WriteLine("Hello World!");
        }
    }

     
}
