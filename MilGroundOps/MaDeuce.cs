using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class MaDeuce : DirectFire
    {

        public MaDeuce()
        {
            this.ammunitionType = 50;
            this.reloadTime = 20;
            this.missionLoadout = 2000;
            this.fireRate = 850;
            this.range = 1000;
            this.magazine = 500;
        }

        override public void FireWeapon()
        {
            Console.WriteLine("Big pew pew pew!");
            Console.WriteLine($"This weapon has fire rate of {fireRate} rpm.");
            Console.WriteLine($"This weapon has a range of {range} meters.");
            Console.WriteLine($"The magazine holds {magazine} rounds.");

        }

        override public void Reload(int time = 20)    // Reload
        {
            missionLoadout -= magazine;
            base.Reload(reloadTime);
        }
        
    }
}
