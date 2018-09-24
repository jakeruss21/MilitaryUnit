using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class M9Pistol : DirectFire
    {

        public M9Pistol()
        {
            this.ammunitionType = 9;
            this.reloadTime = 2;
            this.missionLoadout = 90;
            this.fireRate = 100;
            this.range = 50;
            this.magazine = 15;
        }

        override public void FireWeapon()
        {
            Console.WriteLine("Tiny pew pew pew!");
            Console.WriteLine($"This weapon has fire rate of {fireRate} rpm.");
            Console.WriteLine($"This weapon has a range of {range} meters.");
            Console.WriteLine($"The magazine holds {magazine} rounds.");
        }

        override public void Reload(int time = 2)    // Reload
        {
            missionLoadout -= magazine;
            base.Reload(reloadTime);
        }

    }
}
