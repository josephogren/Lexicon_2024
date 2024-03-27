using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage8.Interfaces;
using GarageApp.Models;



namespace GarageApp.Handlers
{
    public class GarageHandler
    {
        
        public Garage<Vehicle> garage;

        
        public GarageHandler() 
        {
        
        }

        public GarageHandler(Garage<Vehicle> garage)
        {
                this.garage = garage;
        }


        public Garage<Vehicle> Build(int capacity)
        {                    
            garage = new Garage<Vehicle>(capacity);
            return garage;
        }

        // Methods

        public void Park(Vehicle vehicle)
        {
            garage.AddVehicle(vehicle);
        }

        public void ListAllVehicles()
        {
            foreach (Vehicle v in garage)
            {
                if (v != null)
                {
                    Console.WriteLine(v);
                }
            }
        }
    }

    
}
