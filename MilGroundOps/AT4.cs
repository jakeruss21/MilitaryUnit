using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class AT4 : IndirectFire
    {
        override public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("Rocket propelled grenade");
        }

        override public void Reload()    // Reload
        {
            Console.WriteLine("This weapon is not reloaded");
        }

        override public void MissionLoadout() // Mission loadout
        {
            Console.WriteLine("Basic mission loadout of 1 round");
        }

        override public void FireRPM()   // Rate of Fire
        {
            Console.WriteLine("No firing rate as this weapon only has one shot");
        }

        override public void RangeofWeapon() // Range
        {
            Console.WriteLine("500 meter point effective range");
        }

        override public void MagazineSize()  // Magazine
        {
            Console.WriteLine("There only one round");
        }

        override public void AreaofEffect()  // Area of effect
        {
            Console.WriteLine("Those within 15 meters of the target will also be affected by this weapon");
        }

    }
}
