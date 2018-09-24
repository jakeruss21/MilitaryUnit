using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class M9Pistol : DirectFire
    {

        override public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("9mm round");
        }

        override public void Reload()    // Reload
        {
            Console.WriteLine("2 second reload time per magazine");
        }

        override public void MissionLoadout() // Mission loadout
        {
            Console.WriteLine("Basic mission loadout of 90 rounds");
        }

        override public void FireRPM()   // Rate of Fire
        {
            Console.WriteLine("Firing rate of 100 rounds per minute");
        }

        override public void RangeofWeapon() // Range
        {
            Console.WriteLine("50 meter effective range");
        }

        override public void MagazineSize()  // Magazine
        {
            Console.WriteLine("There are 15 rounds in each magazine");
        }

    }
}
