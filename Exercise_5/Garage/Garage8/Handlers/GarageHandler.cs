using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageApp.Models;



namespace GarageApp.Handlers
{
    public class GarageHandler
    {
        private object garage;

        public GarageHandler() { }
        public GarageHandler(string name)
        {
                
        }


        public Garage Build()
        {
            List<Vehicle> list = new List<Vehicle>();

            return new Garage(list);
        }
    }

    
}
