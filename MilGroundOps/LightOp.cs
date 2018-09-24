using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class LightOp : MissionSet
    {
        public WheeledVic[] mrapSquad = new MRAP[4]; //{ new MRAP, new MRAP, new MRAP, new MRAP};
        public WheeledVic[] humveeTeam = new HUMMVEE[4]; //{ new HUMMVEE, new HUMMVEE, new HUMMVEE, new HUMMVEE};

        public Commander commander;

        public LightOp()
        {
            this.mrapSquad[0] = new MRAP();
            this.mrapSquad[1] = new MRAP();
            this.mrapSquad[2] = new MRAP();
            this.mrapSquad[3] = new MRAP();

            this.humveeTeam[0] = new HUMMVEE();
            this.humveeTeam[1] = new HUMMVEE();
            this.humveeTeam[2] = new HUMMVEE();
            this.humveeTeam[3] = new HUMMVEE();

            this.commander = new Commander();

        }

        public void Company()
        {
            Console.WriteLine($"{commander.rank} {commander.personName} is standing by with {mrapSquad.Length} MRAPs " +
                              $"and {humveeTeam.Length} Humvees.");

            Console.WriteLine("Fire the MRAP's weapon!");
            mrapSquad[0].FireWeapon();
            Console.WriteLine("Fire the HUMVEE's weapons!");
            humveeTeam[0].FireWeapon();

            Console.WriteLine("Mission success!");

        }
    }
}
