using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class Vehicle
    {
        public int vicSpeed;
        public int personnelReqs;
        public string weaponSystem;
        public string armorType;
        public string mobility;

        virtual public void VehicleSpeed()// Speed
        {
            Console.WriteLine("Top speed of 100 mph");
        }

        virtual public void VehiclePersonnelReqs() // Personnel reqs
        {
            Console.WriteLine("Requires 3 people to operate: Team Leader, Driver, and the Gunner");
        }

        virtual public void VehicleWeaponSystems() // Weapons
        {
            Console.WriteLine("M240B weapon system mounted");
        }

        virtual public void VehicleArmor() // Armor
        {
            Console.WriteLine("Light armor");
        }

        virtual public void VehicleMobility() // Mobility
        {
            Console.WriteLine("This vehicle has good mobility over most terrain");
        }

    }
}
