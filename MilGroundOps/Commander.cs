using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class Commander : Leader
    {
        public M9Pistol pistola = new M9Pistol();

        public Commander()
        {
            this.personName = "Jonathan Knowsbetter";
            this.rosterNumber = "JK0987";
            this.saying = "Today we liberate the peoples of Atropi";
            this.rank = "CPT";
        }

        public override void FireWeapon()
        {
            pistola.FireWeapon();
            pistola.Reload();
        }

    }
}
