using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class Personnel
    {
        public string personName;
        public string rosterNumber;
        public string saying;
        public string rank;

        public Personnel()
        {
            this.personName = "John Doe";
            this.rosterNumber = "JD1234";
            this.saying = "For Atropia";
            this.rank = "PVT";
        }

        virtual public void PersonWeapon()  // Weapon
        {
            Console.WriteLine("M9 weapon equipped");
        }

    }
}
