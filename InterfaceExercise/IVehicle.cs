using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
    public bool HasFourWheels  {get; set;}
    public bool HasFourDoors {get; set;}
    public bool HasTwoAirBags {get; set;}
    public bool NeedsGas {get; set;}

    }
}
