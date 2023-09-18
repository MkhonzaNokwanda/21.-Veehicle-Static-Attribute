using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Veehicle_Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("V001","Toyota","green");
            Vehicle vehicle2 = new Vehicle("V002", "Ferari", "Red");
            Vehicle vehicle3 = new Vehicle("V003", "Mazda", "Black");
            Console.WriteLine("The total number of vehicles registered is: " + Vehicle.vehicleCount);


            //freeze console
            Console.ReadLine();
        }
    }
}
