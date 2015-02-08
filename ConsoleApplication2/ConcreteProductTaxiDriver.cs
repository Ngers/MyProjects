using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_abstract_factory
{
    class ConcreteProductTaxiDriver : AbstractProductDriver
    {
        private static ConcreteProductTaxiDriver _instance;
        public ConcreteProductTaxiDriver() 
       
 {
     Random rnd = new Random();
     DriverId = rnd.Next(1, 5); 
 }

        public static ConcreteProductTaxiDriver Instance()
        {
            if (_instance == null)
            { _instance = new ConcreteProductTaxiDriver(); }
            return _instance;
        }
    }
}
