using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class M240B : DirectFire
    {

        public M240B()
        {
            this.ammunitionType = 7.62;
            this.reloadTime = 10;
            this.missionLoadout = 1000;
            this.fireRate = 950;
            this.range = 1000;
            this.magazine = 200;
        }

        override public void FireWeapon()
        {
            Console.WriteLine("Medium pew pew pew!");
            Console.WriteLine($"This weapon has fire rate of {fireRate} rpm.");
            Console.WriteLine($"This weapon has a range of {range} meters.");
            Console.WriteLine($"The magazine holds {magazine} rounds.");
        }

        override public void Reload(int time = 10)    // Reload
        {
            missionLoadout -= magazine;
            base.Reload(reloadTime);
        }

    }
}
