using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class IndirectFire : WeaponCache
    {

        override public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("5.56mm NATO round");
        }

        override public void Reload(int time)    // Reload
        {
            base.Reload(time);
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

        virtual public void AreaofEffect()  // Area of effect
        {
            Console.WriteLine("Those within 10 meters of the target will also be affected by this weapon");
        }

    }
}
