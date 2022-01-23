using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight_Pattern
{
    internal class VehicleFactory
    {
        Dictionary<string, Vehicle> _vehicles=new Dictionary<string, Vehicle>();

        public Vehicle getVehicle(string type)
        {
            Vehicle vehicle = null;

            if (_vehicles.ContainsKey(type))
                vehicle=_vehicles[type];
            else
            {
                switch (type)
                {
                    case "Car":
                        vehicle = new Car();
                        break;

                    case "Bike":
                        vehicle=new Bike();
                        break;

                    case "Rikshaw":
                        vehicle = new Rikshaw();
                        break;
                }

                _vehicles.Add(type, vehicle);
            }
                
            return vehicle;
        }


    }
}
