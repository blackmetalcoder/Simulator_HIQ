using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator_HIQ.models;
namespace Simulator_HIQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulator simulator = new Simulator();
            Vehicle vehicle = new MonsterTruck();

            if (!simulator.Initialize(vehicle))
            {
                Console.WriteLine("Error occured.");
            }

            simulator.Run();
            simulator.PrintResults();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
