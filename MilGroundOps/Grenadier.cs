using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class Grenadier : Soldier
    {
        M203 launcher = new M203();

        public Grenadier()
        {
            this.personName = "Luis Boomsalot";
            this.rosterNumber = "LB5655";
            this.saying = "Boom baby!";
            this.rank = "SPC";
        }

        public override void FireWeapon()
        {
            launcher.FireWeapon();
            launcher.Reload();
        }

    }
}
