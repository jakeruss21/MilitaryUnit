using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class MRAP : WheeledVic
    {
        public int transPersons;

        public MRAP()
        {
            this.vicSpeed = 65;
            this.personnelReqs = 3;
            this.weaponSystem = "M2 'Ma Deuce'";
            this.armorType = "light";
            this.mobility = "limited";
            this.wheels = 4;
            this.transPersons = 4;
        }

    }
}
