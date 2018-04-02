using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_HIQ.models
{
    abstract class Vehicle
    {
        public Point Location { get; set; }
        public Riktning CurrentDirection { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(Riktning direction, Point location)
        {
            Location = location;
            CurrentDirection = direction;
        }

        protected void MoveInDirection(Riktning direction, int step)
        {
            switch (direction)
            {
                case Riktning.N:
                    Location.Y += step;
                    break;
                case Riktning.S:
                    Location.Y -= step;
                    break;
                case Riktning.E:
                    Location.X += step;
                    break;
                case Riktning.W:
                    Location.X -= step;
                    break;
                default:
                    throw new ArgumentException("Direction invalid.");
            }
        }

        public virtual void MoveForwardsBy(int step)
        {

        }
        public virtual void MoveBackwardsBy(int step)
        {

        }
        public virtual void TurnRight()
        {

        }
        public virtual void TurnLeft()
        {

        }
    }
}
