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
        public Personnel[] tankCrew = new Personnel[4];
        
        public AbramsTank()
        {
            this.vicSpeed = 45;
            this.personnelReqs = tankCrew.Length;
            this.weaponSystem = "XM256 120mm cannon";
            this.armorType = "Heavy";
            this.mobility = "All Terrain";
            this.tankCrew[0] = new PlatoonLeader();
            this.tankCrew[1] = new TeamLeader();
            this.tankCrew[2] = new Driver();
            this.tankCrew[3] = new Gunner();

        }

        override public void StartEngine()
        {
            Console.WriteLine("VRUM!");
        }

        override public void FireWeapon()
        {
            Console.WriteLine(tankCrew[3].saying);
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

        public override void Drive()
        {
            Console.WriteLine($"This vehicle goes {vicSpeed} mph.");
        }

    }
}
