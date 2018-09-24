using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class M240B : DirectFire
    {

        override public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("7.62mm NATO round");
        }

        override public void Reload()    // Reload
        {
            Console.WriteLine("15 second reload time per magazine");
        }

        override public void MissionLoadout() // Mission loadout
        {
            Console.WriteLine("Basic mission loadout of 1000 rounds");
        }

        override public void FireRPM()   // Rate of Fire
        {
            Console.WriteLine("Firing rate of 950 rounds per minute");
        }

        override public void RangeofWeapon() // Range
        {
            Console.WriteLine("3700 meter effective range");
        }

        override public void MagazineSize()  // Magazine
        {
            Console.WriteLine("There are 200 rounds in each magazine");
        }

    }
}
