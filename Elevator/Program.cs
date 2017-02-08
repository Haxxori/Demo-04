using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //this must be done with do while
            Elevator elevator = new Elevator();
            elevator.PrintFloor();
            while(true)
            {
                Console.Write("Please give a new floor 1-5 > ");
                string line = Console.ReadLine();
                int choice;
                bool result = int.TryParse(line, out choice);
                elevator.Floor = choice;
                elevator.PrintFloor();
            }
            Console.ReadLine();

            //elevetor tells at what floor you are

            //tell at what floor you want to go
        }
    }
}
