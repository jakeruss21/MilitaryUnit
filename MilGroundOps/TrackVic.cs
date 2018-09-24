using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class TrackVic : Vehicle
    {
        public TrackVic()
        {
            this.vicSpeed = 45;
            this.personnelReqs = 3;
            this.weaponSystem = "M240B";
            this.armorType = "medium";
            this.mobility = "All-terrain";
        }

    }
}
