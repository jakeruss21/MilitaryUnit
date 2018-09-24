using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class MissionSet
    {

        virtual public void MissionPersonnelReqs()  // Personnel Requirements - Leadership etc.
        {
            Console.WriteLine("This mission requires 100 personnel");
        }

        virtual public void MissionVicReqs()    // Vehicle Requirements
        {
            Console.WriteLine("This mission requires 2 Abrams Tanks, 4 M113 APCs, 5 Humvees, and 10 MRAPs");
        }

    }
}
