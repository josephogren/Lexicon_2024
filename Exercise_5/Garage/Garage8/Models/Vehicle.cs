//using System.Runtime.Remoting.Channels;

using Garage8.Interfaces;
using System.Drawing;
using System.Reflection;

namespace GarageApp.Models
{

    // The different colors a vehicle may have (including None for no color)
    public enum vColor
    {
        None = 0,
        White, Black, Red, Green, Blue
    }

    public enum vEngineType 
    {
        None = 0,
        SteamEngine, CombustionEngine, Dynamo, ElectricEngine, Hybrid, Diesel, Gasoline, Propeller, JetPropulsion, WarpDrive
    }

    public enum cGearBoxType
    {
        None = 0,
        Automatic, ShiftStick
    }



    /// <summary>
    ///  
    /// 
    /// </summary>
    public  class Vehicle : IVehicle
    {
        public int? VIN { get; set; }           /* Vehicle Identification Number (unique int) */

        public string vMake { get; set; }      /* The make of the vechicle  */
        public string vModel { get; set; }      /* The model of the vehicle  */
        public string RegPlate { get; set; }    /* Registratin Plate (string) */

        public vColor vColor { get; set; }      /* The color of the vehicle */
        public int nWheels { get; set; }        /* The number of wheels on the vehicle (can be 0) */

        public vEngineType vEngineType { get; set; }    /* The type of propulsion technology for the vehicle */
        



        public Vehicle()
        {
            this.VIN = null;
            this.vColor = Models.vColor.None;
            this.vEngineType = vEngineType.None;
            
        }

        public void PrintVehicle()
        {
            if (VIN != null)
            {
                Console.Write("VEHICLE ID="); Console.WriteLine(VIN);

                string strVehicle = string.Empty;

                strVehicle =
                    $"REGNR:{RegPlate},  " +
                    $"COLOR:{this.vColor}, " +
                    $"WHEELS:{nWheels}" +
                    $"MAKE:{vMake}" +
                    $"MODEL:{vModel}";

                System.Console.WriteLine(strVehicle); 
            }

            else Console.WriteLine($"VEHICLE DOES NOT EXIST!");
        }

    }










    /* Subclasses to Vehicle */


    // THE AUTOMOBILE / DAS AUTO
    public class Car : Vehicle
    {   
        private cGearBoxType gear;

        public Car()
        {
            this.VIN= null;
            this.vEngineType= vEngineType.CombustionEngine;
            this.nWheels= 4;
            this.gear= cGearBoxType.None;
        }

        public Car(string model, string make, vColor color)
        {
            
                    
        }

        
    }

    public class Motorcycle : Vehicle { }

    public class Bus : Vehicle { }

    // WATER VESSSEL (NO WHEELS)
    public class Boat : Vehicle
    {

        public bool hasRudder {  get; set; }

        public Boat()
        {
            this.VIN= null;
            this.nWheels= 0;
            this.hasRudder = true;
            this.vEngineType= vEngineType.Propeller;
        }

        public Boat(string make, string model, vColor color) 
        { 
            this.nWheels= 0; 
            this.vMake= make;
            this.vColor= color;
            this.vModel= model;
        }
    }

    /* AIRPLANE - FLYING MACHINES */
    public class Airplane : Vehicle
    {

        private bool hasWings = true;

        public Airplane()
        {
            this.VIN= null;
            this.vEngineType= vEngineType.JetPropulsion;
        }

        public Airplane(string make, string model, vColor color)
        {
            this.nWheels= 8;
            this.vMake= make;
            this.vColor= color;
            this.vModel= model;
        }
    }


}
