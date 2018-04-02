using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator_HIQ.models;
namespace Simulator_HIQ.Actions
{
    class MoveForwardsAction: IAction
    {
        public string Identifier { get { return "F"; } }
        public void Execute(Vehicle rcVehicle)
        {
            rcVehicle.MoveForwardsBy(1);
        }
    }
}
