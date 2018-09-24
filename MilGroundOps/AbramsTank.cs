using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class AbramsTank : TrackVic
    {
        XM256_120mm bigCannon = new XM256_120mm();
        //PlatoonLeader tankCommander = new PlatoonLeader();
        //TeamLeader bigSarge = new TeamLeader();
        //Driver driver = new Driver();
        //Gunner bigBoomer = new Gunner();
        
        public AbramsTank()
        {
            this.vicSpeed = 45;
            this.personnelReqs = 4;
            this.weaponSystem = "XM256 120mm cannon";
            this.armorType = "Heavy";
            this.mobility = "All Terrain";
        }

        /*override*/ public void StartEngine()
        {
            Console.WriteLine("VRUM!");
        }

        /*override*/ public void FireWeapon()
        {
            Random rand = new Random();
            bigCannon.FireWeapon();
            int hit = rand.Next();
            if (hit % 2 == 0)
            {
                Console.WriteLine("Direct hit!");
            }
            else
            {
                Console.WriteLine("Target missed, reloading...");
                bigCannon.Reload();
            }
        }

    }
}
