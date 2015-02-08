using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_abstract_factory
{
    class ConcreteProductBusDriver : AbstractProductDriver
    {
        private static ConcreteProductBusDriver _instance; 
       public int getId()
        {
            return this.DriverId;
        }
 public ConcreteProductBusDriver() 
 {
     Random rnd = new Random();
     DriverId = rnd.Next(1, 13); 
 }
 
        public static ConcreteProductBusDriver Instance()
        {
            if (_instance == null)
            { _instance = new ConcreteProductBusDriver(); }
            return _instance;
        }
    }
}
