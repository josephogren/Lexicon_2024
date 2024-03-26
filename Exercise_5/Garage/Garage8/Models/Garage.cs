using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Garage.Models
{
    internal abstract class Garage
    {

        //private readonly V _value;
        //private readonly string _name;
        //private readonly string _description;
        //private readonly string _type;
        

        private List<Vehicle> listOfVehicles = new List<Vehicle>();

        public Garage()
        {
                listOfVehicles = new List<Vehicle>();

            
        }


        public void AddVehicle(Vehicle vehicle)
        {
            listOfVehicles.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            listOfVehicles.Remove(vehicle);
        }


        public void ShowAllVehicles()
        {
            foreach (Vehicle vehicle in listOfVehicles)
            {
                vehicle.Print();
            }

            
        }

    }
}
