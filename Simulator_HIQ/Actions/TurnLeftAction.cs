using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator_HIQ.models;
namespace Simulator_HIQ.Actions
{
    class TurnLeftAction : IAction
    {
        public string Identifier { get { return "L"; } }
        public void Execute(Vehicle rcVehicle)
        {
            rcVehicle.TurnLeft();
        }
    }
}
