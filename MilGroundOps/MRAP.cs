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
        public Personnel[] mrapCrew = new Personnel[3];
        public Personnel[] supportCrew = new Personnel[4];

        MaDeuce m2 = new MaDeuce();

        public MRAP()
        {
            this.vicSpeed = 65;
            this.personnelReqs = mrapCrew.Length;
            this.weaponSystem = "M2 'Ma Deuce'";
            this.armorType = "light";
            this.mobility = "limited";
            this.wheels = 4;
            this.transPersons = supportCrew.Length;
            this.mrapCrew[0] = new PlatoonLeader();
            this.mrapCrew[1] = new Driver();
            this.mrapCrew[2] = new Gunner();
            this.supportCrew[0] = new TeamLeader();
            this.supportCrew[1] = new Grenadier();
            this.supportCrew[2] = new Rifleman();
            this.supportCrew[3] = new Rifleman();
        }

        override public void StartEngine()
        {
            Console.WriteLine("Vroom!");
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
