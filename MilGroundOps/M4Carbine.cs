using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class M4Carbine : DirectFire
    {

        override public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("5.56mm NATO round");
        }

        override public void Reload(int time = 2)    // Reload
        {
            Console.WriteLine("2 second reload time");
        }

        override public void MissionLoadout() // Mission loadout
        {
            Console.WriteLine("Basic mission loadout of 210 rounds");
        }

        override public void FireRPM()   // Rate of Fire
        {
            Console.WriteLine("Firing rate of 200 rounds per minute");
        }

        override public void RangeofWeapon() // Range
        {
            Console.WriteLine("400 meter point effective range");
        }

        override public void MagazineSize()  // Magazine
        {
            Console.WriteLine("There are 30 rounds in each magazine");
        }

    }
}
