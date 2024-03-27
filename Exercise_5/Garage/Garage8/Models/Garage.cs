﻿using GarageApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GarageApp.Models
{
    public  class Garage<V> : IEnumerable<V> where V : Vehicle
    {
        // MEMBERS
        private int capacity = 1;
        private Vehicle[] parkedVehicles;


        public Garage(int capacity)
        {
            this.capacity = capacity;

            Vehicle vehicle = new Car();

            this.parkedVehicles = new Vehicle[capacity];
            parkedVehicles[capacity] = vehicle;
        }





        // METHODS

        public IEnumerator<V> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            
            parkedVehicles[capacity] = vehicle;
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            parkedVehicles[capacity] = null;       
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

