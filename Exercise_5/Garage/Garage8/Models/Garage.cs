using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    internal class Garage<V>
    {

        private readonly V _value;
        private readonly string _name;
        private readonly string _description;
        private readonly string _type;
        

        private List<V> listOfVehicles = new List<V>();

        public Garage()
        {
                
        }
    }
}
