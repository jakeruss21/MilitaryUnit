using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class HUMMVEE : WheeledVic
    {
        public Personnel[] humveeCrew = new Personnel[3];

        M240B weapon = new M240B();

        public HUMMVEE()
        {
            this.vicSpeed = 55;
            this.personnelReqs = humveeCrew.Length;
            this.weaponSystem = "M240B";
            this.armorType = "light";
            this.mobility = "limited";
            this.wheels = 4;
            humveeCrew[0] = new PlatoonLeader();
            humveeCrew[1] = new Driver();
            humveeCrew[2] = new Gunner();
        }

        override public void FireWeapon()
        {
            weapon.FireWeapon();
            weapon.Reload();
        }

        override public void StartEngine()
        {
            Console.WriteLine("Vroom!");
        }

        override public void Drive()
        {
            Console.WriteLine($"The Humvee goes {vicSpeed} mph.");
        }

    }
}
