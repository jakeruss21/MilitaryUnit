using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class M203 : IndirectFire
    {
        override public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("40mm explosive round");
        }

        override public void Reload()    // Reload
        {
            Console.WriteLine("10 second reload time");
        }

        override public void MissionLoadout() // Mission loadout
        {
            Console.WriteLine("Basic mission loadout of 10 rounds");
        }

        override public void FireRPM()   // Rate of Fire
        {
            Console.WriteLine("Firing rate of 6 rounds per minute");
        }

        override public void RangeofWeapon() // Range
        {
            Console.WriteLine("400 meter point effective range");
        }

        override public void MagazineSize()  // Magazine
        {
            Console.WriteLine("There is 1 round in each magazine");
        }

        override public void AreaofEffect()  // Area of effect
        {
            Console.WriteLine("Those within 10 meters of the target will also be affected by this weapon");
        }

    }
}
