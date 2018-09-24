using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class HUMMVEE : WheeledVic
    {

        public HUMMVEE()
        {
            this.vicSpeed = 55;
            this.personnelReqs = 3;
            this.weaponSystem = "M240B";
            this.armorType = "light";
            this.mobility = "limited";
            this.wheels = 4;
        }

    }
}
