using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator_HIQ.models;
namespace Simulator_HIQ.Actions
{
    interface IAction
    {
        string Identifier { get; }
        void Execute(Vehicle rcVehicle);
    }
}
