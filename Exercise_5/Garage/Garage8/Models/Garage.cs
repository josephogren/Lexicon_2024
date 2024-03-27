using GarageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GarageApp.Models
{
    public abstract class Garage<V>
    {

        //private readonly V _value;
        //private readonly string _name;
        //private readonly string _description;
        //private readonly string _type;
        

        private List<Vehicle> listOfVehicles;

        public Garage()
        {
                listOfVehicles = new List<Vehicle>();
            
        }


        public void AddVehicle(Vehicle vehicle)
        {
            //listOfVehicles.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            //listOfVehicles.Remove(vehicle);
        }


        public void ShowAllVehicles()
        {
            //foreach (Vehicle vehicle in listOfVehicles)
            //{
            //    vehicle.Print();
            //}

            
        }

    }
}


public class Garage : Garage<object>
{

    private List<Vehicle> listOfVehicles;
    //private Garage<Vehicle> garage;
    //private object g;

    public Garage(List<Vehicle> list)
    {
        this.listOfVehicles = list;
        //this.g = g;
    }
}
