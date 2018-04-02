using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator_HIQ.Actions;
namespace Simulator_HIQ.models
{
    class MonsterTruck: Vehicle
    {
        public MonsterTruck()
        { }
        public MonsterTruck(Riktning direction, Point location)
            : base(direction, location)
        { }
        public override void MoveForwardsBy(int step)
        {
            MoveInDirection(CurrentDirection, step);
        }

        public override void MoveBackwardsBy(int step)
        {
            MoveInDirection(CurrentDirection, -step);
        }

        public override void TurnRight()
        {
            CurrentDirection = (Riktning)MathHelper.Mod((int)CurrentDirection - 90, 360);
        }

        public override void TurnLeft()
        {
            CurrentDirection = (Riktning)MathHelper.Mod((int)CurrentDirection + 90, 360);
        }
    }
}
