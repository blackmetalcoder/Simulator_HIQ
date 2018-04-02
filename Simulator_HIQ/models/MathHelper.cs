using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_HIQ.models
{
    class MathHelper
    {
        public static int Mod(int number, int mod)
        {
            return (number % mod + mod) % mod;
        }
    }
}
