using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class Rifleman : Soldier
    {
        public M4Carbine carbine = new M4Carbine();

        public Rifleman()
        {
            this.personName = "Billy Forgotmycac";
            this.rosterNumber = "BF9435";
            this.saying = "For Atropia!";
            this.rank = "PVT";
        }

        public override void FireWeapon()
        {
            carbine.FireWeapon();
            carbine.Reload();
        }

    }
}
