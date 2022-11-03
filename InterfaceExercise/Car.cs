using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool CDPlayer {get; set;}
        public bool DrivesManual {get; set;}
        public bool HasFourWheels { get ; set ; }
        public bool HasFourDoors { get ; set ; }
        public bool HasTwoAirBags { get ; set ; }
        public bool NeedsGas { get ; set ; }
        public string Name { get ; set ; }
        public string Logo { get ; set ; }
        public string Motto { get ; set ; }

        public void CarStats()
        {
            Console.WriteLine($"The Car {Name} has a {Logo} logo. Their {Motto} motto is what inspires them. This {Name} is an older model, since it drives manually and has a CD player.");
        }
    }
}
