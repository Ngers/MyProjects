using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_abstract_factory
{
    class ConcreteFactoryBusBoard : AbstractFactoryBoard
    {
        public override AbstractProductDriver createProductDriver()
        {
            return new ConcreteProductBusDriver();
        }

        public override bool isSeatsFree()
        {
            if (passengersCount == 30) return false;
            else return true;
        }

        public override string getType()
        {
            return "автобус";
        }
    }
}
