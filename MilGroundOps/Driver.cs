using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class Driver : Soldier
    {
        public M4Carbine carbine = new M4Carbine();

        public Driver()
        {
            this.personName = "Rusty Nails";
            this.rosterNumber = "RN0666";
            this.saying = "I have a need, a need for speed!";
            this.rank = "SPC";
        }

        public override void FireWeapon()
        {
            carbine.FireWeapon();
            carbine.Reload();
        }

    }
}
