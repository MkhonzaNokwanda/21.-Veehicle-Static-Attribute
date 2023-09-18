using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Veehicle_Static_Attribute
{
    internal class Vehicle
    {
        public string id;
        public string brand;
        public string color;

        //Static attribute
        public static int vehicleCount;
        //call the constructor
        public Vehicle(string aId,string aBrand,string aColor) {
            id = aId;
            brand = aBrand;
            color = aColor;
            vehicleCount++;
        }
    }
}
