using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator_HIQ.models;
namespace Simulator_HIQ.Actions
{
    class TurnRightAction : IAction
    {
        public string Identifier { get { return "R"; } }
        public void Execute(Vehicle rcVehicle)
        {
            rcVehicle.TurnRight();
        }
    }
}
