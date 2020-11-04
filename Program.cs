using System;

namespace helloGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car firstCar = new Car("Audi");
            firstCar.printCarByGeneric();
        }
    }

    class VehicleHepler
    {
        public static void heluGeneric(Action _printNameDelegate) 
        {
            _printNameDelegate.Invoke();
        }
    }

    class Car 
    {
        private string _Name { get; set; }

        public Car(string _name)
        {
            _Name = _name;
        }

        public void printCar()
        {
            Console.WriteLine(_Name);
        }

        public void printCarByGeneric()
        {
            VehicleHepler.heluGeneric(printCar);
        }
    }
}
