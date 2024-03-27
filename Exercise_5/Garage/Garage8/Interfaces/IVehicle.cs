using GarageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Garage8.Interfaces
{
    internal interface IVehicle
    {

        //string Name { get; }    
        //string Description { get; }


        public int? VIN { get; set; }           /* Vehicle Identification Number (unique int) */

        public string vMake { get; set; }      /* The make of the vechicle  */
        public string vModel { get; set; }      /* The model of the vehicle  */
        public string RegPlate { get; set; }    /* Registratin Plate (string) */

        public vColor vColor { get; set; }      /* The color of the vehicle */
        public int nWheels { get; set; }        /* The number of wheels on the vehicle (can be 0) */

        public vEngineType vEngineType { get; set; }    /* The type of propulsion technology for the vehicle */





        public void Print()
        {            
           
        }

    }
}
