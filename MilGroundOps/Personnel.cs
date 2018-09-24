using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class Personnel
    {

        virtual public void NameofPerson()  // Name (Last, First)
        {
            Console.WriteLine("Doe, John");
        }

        virtual public void RosterNumber()  // Roster # (Two Char, 4 digit int)
        {
            Console.WriteLine("JD1234");
        }

        virtual public void PersonSaying()  // Speech
        {
            Console.WriteLine("For Atropia!");
        }

        virtual public void PersonRank()    // Rank
        {
            Console.WriteLine("Captain");
        }

        virtual public void PersonWeapon()  // Weapon
        {
            Console.WriteLine("M9 weapon equipped");
        }

    }
}
