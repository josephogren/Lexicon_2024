//using System.Runtime.Remoting.Channels;

using System.Drawing;
using System.Reflection;

namespace Garage.Models
{

    // The different colors a vehicle may have (including None for no color)
    internal enum vColor
    {
        None = 0,
        White, Black, Red, Green, Blue
    }



    /// <summary>
    ///  
    /// 
    /// </summary>
    internal  class Vehicle
    {
        public int? VIN { get; set; }           /* Vehicle Identification Number (unique int) */

        public string? vMake { get; set; }      /* The make of the vechicle  */
        public string? vModel { get; set; }      /* The model of the vehicle  */
        public string? RegPlate { get; set; }    /* Registratin Plate (string) */

        public vColor? vColor { get; set; }      /* The color of the vehicle */
        public int? nWheels { get; set; }        /* The number of wheels on the vehicle (can be 0) */



        public Vehicle()
        {
            this.VIN = null;
            this.vColor = Models.vColor.None;
            this.nWheels = 4;
        }

        public void Print()
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



    internal class Car : Vehicle
    {
        public Car()
        {
            this.VIN = null;
        }

        public Car(string model, string make, vColor color)
        {
            this.nWheels = 4;
                    
        }


    }

    internal class Boat : Vehicle
    {
        public Boat()
        {
            this.VIN = null;
        }

        public Boat(string make, string model, vColor color) 
        { 
            this.nWheels = 0; 
            this.vMake = make;
            this.vColor = color;
            this.vModel = model;
        }
    }

    internal class Airplane : Vehicle
    {
        public Airplane(string make, string model, vColor color)
        {
            this.nWheels = 8;
            this.vMake = make;
            this.vColor = color;
            this.vModel = model;
        }
    }


}
