using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        private readonly int minFloor = 1;
        private readonly int maxFloor = 5;

        private int floor = 1;
        public void PrintFloor()
        {
            Console.WriteLine("Elevator is now on floor: " + Floor);
        }
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > maxFloor)
                {
                    Console.WriteLine("Floor 5 is top floor");
                    floor = maxFloor;
                }
                else if (value < minFloor)
                {
                    Console.WriteLine("Floor 1 is the bottom");
                    floor = minFloor;
                }
                else
                {
                    floor = value;
                }
            }
        }
    }
}
