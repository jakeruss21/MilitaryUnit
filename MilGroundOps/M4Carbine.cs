using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class M4Carbine : DirectFire
    {

        public M4Carbine()
        {
            this.ammunitionType = 5.62;
            this.reloadTime = 2;
            this.missionLoadout = 210;
            this.fireRate = 2;
            this.range = 400;
            this.magazine = 30;
        }

        override public void FireWeapon()
        {
            Console.WriteLine("Pew pew pew!");
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
