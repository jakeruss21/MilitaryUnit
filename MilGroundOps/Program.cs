using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilGroundOps
{
    class Program
    {
        static void Main(string[] args)
        {

            int missionType = 0;

            Console.WriteLine("What type of mission is this?");
            Console.WriteLine("1. Heavy Op");
            Console.WriteLine("2. Light Op");

            Boolean answer = false;

            Console.WriteLine("");
            do
            {

                try
                {
                    missionType = int.Parse(Console.ReadLine());
                    answer = true;
                }
                catch (Exception)
                {
                    Console.Write("Please enter a valid number:  ");
                    answer = false;
                }
            } while (answer == false && (missionType != 1 || missionType != 2));

            switch(missionType)
            {
                case 1:
                    HeavyOp heavy = new HeavyOp();
                    heavy.Company();
                    break;
                case 2:
                    LightOp lightweight = new LightOp();
                    lightweight.Company();
                    break;
                default:
                    break;
            }

        }
    }
}
