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
    public  class Garage<Vehicle> // : IEnumerator<Vehicle> 
    { 
        // MEMBERS
        private int capacity = 1;
        private int parking_spot = 0;
        static public Vehicle[] parkedVehicles {  get; set; }

        IEnumerator<Vehicle> vEnumerator = new VehiclesEnumerator(parkedVehicles);


        public Garage(int capacity)
        {
            this.capacity = capacity;

            Vehicle vehicle = new Car();

            //this.parkedVehicles = new Vehicle[capacity];
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


        // Declare the enumerator class:  
        public class VehiclesEnumerator : IEnumerator<Vehicle>
        {
            int nIndex;
            Vehicle[] parkedVehicles;
            private Garage<V> garage;

            public VehiclesEnumerator(Vehicle[] coll)
            {
                parkedVehicles = coll;
                nIndex = -1;
            }

            public VehiclesEnumerator(Garage<Vehicle> garage)
            {
                this.garage = garage;
            }

            public bool MoveNext()
            {
                nIndex++;
                return (nIndex < parkedVehicles.Length);
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public Vehicle Current => parkedVehicles[nIndex];

            //object IEnumerator.Current => throw new NotImplementedException();
        }

    }
}

