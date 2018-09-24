using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class M113APC : TrackVic
    {
        public int passangers;

        public M113APC()
        {
            this.vicSpeed = 42;
            this.personnelReqs = 3;
            this.weaponSystem = "M2 'Ma Deuce'";
            this.armorType = "medium";
            this.mobility = "All-terrain";
            this.passangers = 6;
        }

    }
}
