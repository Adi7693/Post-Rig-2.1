using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{

    public class Damper : IVehicleComponent
    {
        Damper()
        {
            Type = VehicleComponentType.Damper;
            Key = Guid.NewGuid().ToString();
        }

        public Damper(string name) : this()
        {
            Name = name;
        }
        
        public VehicleComponentType Type { get; }

        public string FileName { get; set; }
        public string Key { get; }
        public string Name { get; set; }

       
    }
}
