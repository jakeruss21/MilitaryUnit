using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class XM256_120mm : IndirectFire
    {
        override public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("120mm high explosive round");
        }

        override public void FireWeapon()
        {
            Console.WriteLine("KABOOM!");
        }

        override public void Reload(int time = 10)    // Reload
        {
            base.Reload(10);
        }

        override public void MissionLoadout() // Mission loadout
        {
            Console.WriteLine("Basic mission loadout of 50 rounds");
        }

        override public void FireRPM()   // Rate of Fire
        {
            Console.WriteLine("Firing rate of 6 rounds per minute");
        }

        override public void RangeofWeapon() // Range
        {
            Console.WriteLine("3000 meter effective range");
        }

        override public void MagazineSize()  // Magazine
        {
            Console.WriteLine("There is 1 round in each barrel");
        }

        override public void AreaofEffect()  // Area of effect
        {
            Console.WriteLine("Those within 20 meters of the target will also be affected by this weapon");
        }

    }
}
