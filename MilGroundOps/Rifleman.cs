using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class Rifleman : Soldier
    {

        public Rifleman()
        {
            this.personName = "Billy Forgotmycac";
            this.rosterNumber = "BF9435";
            this.saying = "For Atropia!";
            this.rank = "PVT";
        }

        // Weapon - M4/AT4 - randomly assign (1/6 chance of carrying AT4)

    }
}
