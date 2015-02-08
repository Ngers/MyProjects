using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_abstract_factory
{
    class ConcreteFactoryTaxiBoard : AbstractFactoryBoard
    {
        public override AbstractProductDriver createProductDriver()
        {
            return new ConcreteProductTaxiDriver();
        }
        

        public override bool isSeatsFree()
        {
            if (passengersCount == 4) return false;
            else return true;
        }

        public override string getType()
        {
            return "такси";
        }

    }
}
