using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class MaDeuce : DirectFire
    {

        override public void FireWeapon()
        {
            Console.WriteLine("Big pew pew pew!");
        }

        override public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("50 caliber round");
        }

        override public void Reload(int time = 20)    // Reload
        {
            Console.WriteLine("20 second reload time per magazine");
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
