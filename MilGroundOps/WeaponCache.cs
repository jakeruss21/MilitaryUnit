using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class WeaponCache
    {

        virtual public void AmmunitionType()  // Ammunition Type
        {
            Console.WriteLine("5.56mm NATO round");
        }

        virtual public void Reload()    // Reload
        {
            Console.WriteLine("2 second reload time");
        }

        virtual public void MissionLoadout() // Mission loadout
        {
            Console.WriteLine("Basic mission loadout of 210 rounds");
        }

        virtual public void FireRPM()   // Rate of Fire
        {
            Console.WriteLine("Firing rate of 200 rounds per minute");
        }
        
        virtual public void RangeofWeapon() // Range
        {
            Console.WriteLine("400 meter point effective range");
        }
        
        virtual public void MagazineSize()  // Magazine
        {
            Console.WriteLine("There are 30 rounds in each magazine");
        }

    }
}
