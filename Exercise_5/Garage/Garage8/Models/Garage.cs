using GarageApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace GarageApp.Models
{
    public  class Garage<V> : IEnumerator<Vehicle> { 
        // MEMBERS
        private int capacity = 1;
        private int parking_spot = 0;
        private Vehicle[] parkedVehicles;


        public Garage(int capacity)
        {
            this.capacity = capacity;

            Vehicle vehicle = new Car();

            this.parkedVehicles = new Vehicle[capacity];
            parkedVehicles[parking_spot] = vehicle;
        }

        public Vehicle Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();





        // METHODS



        public void AddVehicle(Vehicle vehicle)
        {
            parking_spot++;
            parkedVehicles[parking_spot] = vehicle;
            
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            int vin = vehicle.VIN;
            foreach(Vehicle v in parkedVehicles)
            {
                if (v.VIN == vin)
                {
                    parkedVehicles[parking_spot] = 0;
                }
            }
            parkedVehicles[capacity] = null;       
        }


        public void ShowAllVehicles()
        {
            //foreach (Vehicle vehicle in listOfVehicles)
            //{
            //    vehicle.Print();
            //}

            
        }


        // ENUMERATOR FOR VEHICLES
        public VehiclesEnumerator GetEnumerator()
        {
            return new VehiclesEnumerator(this);
        }

        //public bool MoveNext()
        //{
        //    nIndex++;
        //    return (nIndex < parkedVehicles.items.Length);
        //}

        public void Reset() { }
        public void Dispose() { }



        // Declare the enumerator class:  
        public class VehiclesEnumerator
        {
            int nIndex;
            Vehicle[] parkedVehicles;
            private Garage<V> garage;

            public VehiclesEnumerator(Vehicle[] coll)
            {
                parkedVehicles = coll;
                nIndex = -1;
            }

            public VehiclesEnumerator(Garage<V> garage)
            {
                this.garage = garage;
            }

            //public bool MoveNext()
            //{
            //    nIndex++;
            //    return (nIndex < parkedVehicles.items.Length);
            //}

            public int Current => parkedVehicles.items[nIndex];
        }

    }
}

