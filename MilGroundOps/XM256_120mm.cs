using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class XM256_120mm : IndirectFire
    {

        public XM256_120mm()
        {
            this.ammunitionType = 120;
            this.reloadTime = 10;
            this.missionLoadout = 50;
            this.fireRate = 6;
            this.range = 3000;
            this.magazine = 1;
            this.areaofAffect = 20;
        }

        override public void FireWeapon()
        {
            Console.WriteLine("KABOOM!");
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
