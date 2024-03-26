//using System.Runtime.Remoting.Channels;

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
    internal abstract class Vehicle
    {
        public int? VIN { get; set; }           /* Vehicle Identification Number (unique int) */
        
        public string? vMake {  get; set; }      /* The make of the vechicle  */       
        public string? vModel { get; set; }      /* The model of the vehicle  */
        public string? RegPlate { get; set; }    /* Registratin Plate (string) */

        public vColor? vColor { get; set; }      /* The color of the vehicle */
        public int? nWheels { get; set; }        /* The number of wheels on the vehicle (can be 0) */



        public Vehicle()
        {
            this.VIN= null;
            this.vColor = Models.vColor.None;
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

    internal class Boat : Vehicle 
    {
        public Boat()
        {
            
        }
    }

    internal class Airplane : Vehicle 
    {
        public Airplane()
        {
            
        }
    }


}
