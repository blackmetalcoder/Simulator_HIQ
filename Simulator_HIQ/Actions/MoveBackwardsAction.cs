using Simulator_HIQ.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_HIQ.Actions
{
    class MoveBackwardsAction : IAction
    {
        public string Identifier { get { return "B"; } }
        public void Execute(Vehicle rcVehicle)
        {
            rcVehicle.MoveBackwardsBy(1);
        }
    }
}
