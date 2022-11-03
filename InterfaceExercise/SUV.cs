using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool CanCarryCargo { get; set; }
        public string ConvertableSeats { get; set; }
        public bool HasFourWheels { get ; set ; }
        public bool HasFourDoors { get ; set ; }
        public bool HasTwoAirBags { get ; set ; }
        public bool NeedsGas { get ; set ; }
        public string Name { get ; set ; }
        public string Logo { get ; set ; }
        public string Motto { get ; set ; }

        public void SUVStats()

        {
        Console.WriteLine($"The {Name} with a {Logo} logo does not require a gas refill since it came straight out of a car lot. The 2023 model and has plenty of room for passengers and cargo. As the commercial says {Motto}");
        }
    }
}
