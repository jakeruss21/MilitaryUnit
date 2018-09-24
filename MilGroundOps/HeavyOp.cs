using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class HeavyOp : MissionSet
    {

        public TrackVic[] tankSquad = new AbramsTank[4]; //{ new AbramsTank, new AbramsTank, new AbramsTank, new AbramsTank};
        public TrackVic[] apcSquad = new M113APC[4]; //{ new M113APC, new M113APC, new M113APC, new M113APC};

        public Commander commander;

        public HeavyOp()
        {
            this.tankSquad[0] = new AbramsTank();
            this.tankSquad[1] = new AbramsTank();
            this.tankSquad[2] = new AbramsTank();
            this.tankSquad[3] = new AbramsTank();

            this.apcSquad[0] = new M113APC();
            this.apcSquad[1] = new M113APC();
            this.apcSquad[2] = new M113APC();
            this.apcSquad[3] = new M113APC();

            this.commander = new Commander();

        }

        public void Company()
        {
            Console.WriteLine($"{commander.rank} {commander.personName} is standing by with {tankSquad.Length} M1Abrams Tanks " +
                              $"and {apcSquad.Length} Personnel carriers");

            Console.WriteLine("Fire the tank's weapon!");
            tankSquad[0].FireWeapon();
            Console.WriteLine("Fire the APC's weapon!");
            apcSquad[0].FireWeapon();

            Console.WriteLine("Mission success!");

        }
    }
}
