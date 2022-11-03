using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string TruckBed { get; set; }
        public string ToolBoxCase { get; set; }
        public bool HasFourWheels { get; set; }
        public bool HasFourDoors { get; set; }
        public bool HasTwoAirBags { get; set; }
        public bool NeedsGas { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Motto { get; set; }

        public void TruckStats()
        {
            Console.WriteLine($"The {Name} has a {Logo} logo envoking that simple Western aesthetic. Their motto is {Motto}. This is a work truck as it has 2 doors. Since its been at a work site, it needs a gas refill.");
        }
    }
}

