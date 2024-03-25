﻿using System.Runtime.Remoting.Channels;

namespace Garage.Models
{
    internal enum carPaint
    {
        None = 0,   
        White, Black, Red, Green, Blue    
    }

    internal abstract class Vehicle
    {
        public int? registrationNumber { get; set; }
        public carPaint color { get; set; }    
        public int nWheels { get; set; }

        public Vehicle()
        {
            this.registrationNumber= null;
            this.color = carPaint.None;
            this.nWheels= 4;
        }

        public void Print()
        {
            System.Console.WriteLine($"REGNR:{registrationNumber},  COLOR:{this.color}, WHEELS:{nWheels}");
        }

    }


    internal class Car : Vehicle
    {
        public Car()
        {
            this.registrationNumber= null;
        }

            
    }


}