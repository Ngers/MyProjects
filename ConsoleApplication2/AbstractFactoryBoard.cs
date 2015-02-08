using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_abstract_factory
{
    abstract class AbstractFactoryBoard
    {
        public abstract AbstractProductDriver createProductDriver();
        public abstract bool isSeatsFree();
        public abstract string getType();
        

        protected int passengersCount = 0;
        protected bool isDriverHere = false;

        public bool hasDriver()
        {
            return isDriverHere;
        }

        public void setIsDriverHereTrue()
        {
            isDriverHere = true;
        }

        public void putPassenger()
        {
            passengersCount++;
        }

    }
}
