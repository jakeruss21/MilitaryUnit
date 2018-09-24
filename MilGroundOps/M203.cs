using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class M203 : IndirectFire
    {

        public M203()
        {
            this.ammunitionType = 40;
            this.reloadTime = 10;
            this.missionLoadout = 10;
            this.fireRate = 6;
            this.range = 400;
            this.magazine = 1;
            this.areaofAffect = 10;
        }

        override public void FireWeapon()
        {
            Console.WriteLine("Thunk!");
            Console.WriteLine($"This weapon has fire rate of {fireRate} rpm.");
            Console.WriteLine($"This weapon has a range of {range} meters.");
            Console.WriteLine($"The area of affect for this weapon is {areaofAffect} meters.");
        }

        override public void Reload(int time = 10)    // Reload
        {
            missionLoadout -= magazine;
            base.Reload(reloadTime);
        }

    }
}
