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
        public Personnel[] apcCrew = new Personnel[3];
        public Personnel[] supportCrew = new Personnel[4];

        MaDeuce m2 = new MaDeuce();

        public M113APC()
        {
            this.vicSpeed = 42;
            this.personnelReqs = apcCrew.Length;
            this.weaponSystem = "M2 'Ma Deuce'";
            this.armorType = "medium";
            this.mobility = "All-terrain";
            this.passangers = supportCrew.Length;
            apcCrew[0] = new PlatoonLeader();
            apcCrew[1] = new Driver();
            apcCrew[2] = new Gunner();
            supportCrew[0] = new TeamLeader();
            supportCrew[1] = new Grenadier();
            supportCrew[2] = new Rifleman();
            supportCrew[3] = new Rifleman();
        }

        override public void StartEngine()
        {
            Console.WriteLine("VRUM!");
        }

        override public void FireWeapon()
        {
            m2.FireWeapon();
            m2.Reload();
        }

        public override void Drive()
        {
            Console.WriteLine($"This vehicle goes {vicSpeed} mph.");
        }
    }
}
