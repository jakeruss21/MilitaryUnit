using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class WeaponCache
    {
        public double ammunitionType;
        public int reloadTime;
        public int missionLoadout;
        public int fireRate;
        public int range;
        public int magazine;

        virtual public void Reload(int time = 0)    // Reload
        {
            Console.WriteLine("Reloading");
            for (int i = time; i >= 1; i--)
            {
                Console.Write($"{i}... ");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("\nWeapon ready to fire");
            Console.Read();
        }

        virtual public void FireWeapon()
        {
            Console.WriteLine("Pew pew pew");
        }

    }
}
