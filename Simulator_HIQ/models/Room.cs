using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_HIQ.models
{
    class Room
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Room(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Room(Point size)
        {
            Width = size.X;
            Height = size.Y;
        }
    }
}
