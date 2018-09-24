using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class PlatoonLeader : Leader
    {
        public M9Pistol pistol = new M9Pistol();

        public PlatoonLeader()
        {
            this.personName = "William Igotmecollege";
            this.rosterNumber = "WI5834";
            this.saying = "I'm pretty sure we were supposed to go the otherway.";
            this.rank = "1LT";
        }

        public override void FireWeapon()
        {
            pistol.FireWeapon();
            pistol.Reload();
        }

    }
}
