using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class MaDeuce : DirectFire
    {

        override public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("50 caliber round");
        }

        override public void Reload()    // Reload
        {
            Console.WriteLine("30 second reload time per magazine");
        }

        override public void MissionLoadout() // Mission loadout
        {
            Console.WriteLine("Basic mission loadout of 2000 rounds");
        }

        override public void FireRPM()   // Rate of Fire
        {
            Console.WriteLine("Firing rate of 850 rounds per minute");
        }

        override public void RangeofWeapon() // Range
        {
            Console.WriteLine("1000 meter effective range");
        }

        override public void MagazineSize()  // Magazine
        {
            Console.WriteLine("There are 500 rounds in each magazine");
        }

    }
}
