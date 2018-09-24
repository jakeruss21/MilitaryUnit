using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class TeamLeader : Leader
    {
        public M4Carbine carbine = new M4Carbine();

        public TeamLeader()
        {
            this.personName = "Old Sarge";
            this.rosterNumber = "OS6348";
            this.saying = "Shut your face-hole and do it anyways.";
            this.rank = "SGT";
        }

        public override void FireWeapon()
        {
            carbine.FireWeapon();
            carbine.Reload();
        }

    }
}
