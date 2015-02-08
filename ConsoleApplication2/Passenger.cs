using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_abstract_factory
{

    class Passenger
    {
        private AbstractProductDriver abstructProductDriver;

        //конструктор
        public Passenger(AbstractFactoryBoard factory)
        {
            if (!factory.hasDriver())
            {
                abstructProductDriver = factory.createProductDriver();
                factory.setIsDriverHereTrue();
                Console.WriteLine("Водитель номер: " + abstructProductDriver.DriverId + " сел в " +  factory.getType());
            }

            if (factory.isSeatsFree())
            {
                Console.WriteLine("пассажир сел в " + factory.getType());
                factory.putPassenger();
            }
            else
            {
                Console.WriteLine("нет мест в " + factory.getType());
            }

        }
    }
}

