using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractFactoryBoard factoryBus = new ConcreteFactoryBusBoard();
            Passenger[] myPassBus = new Passenger[6];
            for (int i = 0; i < 6; i++) myPassBus[i] = new Passenger(factoryBus);

            AbstractFactoryBoard factoryTaxi = new ConcreteFactoryTaxiBoard();
            Passenger[] myPassTaxi = new Passenger[6];
            for (int i = 0; i < 6; i++) myPassTaxi[i] = new Passenger(factoryTaxi);

            Console.Read();
        }
    }
}
