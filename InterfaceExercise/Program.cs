using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car();
            car.CDPlayer = true;
            car.DrivesManual = true;
            car.HasFourDoors = true;
            car.HasFourWheels = true;
            car.NeedsGas = true;
            car.HasTwoAirBags = true;
            car.Name = "Honda";
            car.Logo = "Silver H";
            car.Motto = "The Power of Dreams";
            car.CarStats();
            Console.WriteLine();


            var suv = new SUV();
            suv.HasFourDoors = true;
            suv.HasFourWheels = true;
            suv.NeedsGas = false;
            suv.HasTwoAirBags = true;
            suv.CanCarryCargo = true;
            suv.Logo = "Circle VW";
            suv.Motto = "Volkswagen. Das Auto.";
            suv.Name = "Volkswagen Taos";
            suv.SUVStats();
            Console.WriteLine();

            var truck = new Truck();
            truck.HasFourDoors = false;
            truck.HasFourWheels = true;
            truck.NeedsGas = true;
            truck.HasTwoAirBags = true;
            truck.Name = "Ford";
            truck.Logo = "Ford in Cursive";
            truck.Motto = "Built Ford Tough";
            truck.TruckStats();
            Console.WriteLine();

        }
    }
}
