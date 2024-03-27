using GarageApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GarageApp.Models
{
    public abstract class Garage<V> : IEnumerable<V> where V : Vehicle
    {

        internal int capacity = 1;
        internal Vehicle[] parkedVehicles;
       


        public void AddVehicle(Vehicle vehicle)
        {
            //listOfVehicles.Add(vehicle);
        }

        public IEnumerator<V> GetEnumerator()
        {
            throw new NotImplementedException();
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}


public class Garage : Garage<Vehicle>
{

    public Garage(int capacity)
    {

        this.capacity = capacity;
        this.parkedVehicles = new Vehicle[capacity];

    }
}
