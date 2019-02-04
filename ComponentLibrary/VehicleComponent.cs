using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public interface IVehicleComponent
    {
        VehicleComponentType Type { get; }

        string FileName { get; set; }

        string Key { get; }

        string Name { get; set; }
    }
}
