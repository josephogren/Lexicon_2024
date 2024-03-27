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
        private Garage garage;

        public GarageHandler() { }
        public GarageHandler(string name)
        {
                
        }


        public Garage Build(int capacity)
        {                    
            return new Garage(capacity);
        }

        public void ListAllVehicles(Garage garage)
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
