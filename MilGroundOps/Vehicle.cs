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

        public Vehicle()
        {
            this.vicSpeed = 0;
            this.personnelReqs = 0;
            this.weaponSystem = "None";
            this.armorType = "None";
            this.mobility = "None";
        }

        virtual public void FireWeapon()
        {
            Console.WriteLine("No weapons installed");
        }

        virtual public void StartEngine()
        {
            Console.WriteLine("Vroom!");
        }

        virtual public void Drive()
        {
            Console.WriteLine("It takes you forever to get there, because there is no vehicle assigned");
        }


    }
}
