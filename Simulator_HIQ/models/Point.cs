using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_HIQ.models
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static Point ParseFromStrings(string x, string y)
        {
            int tempX;
            int tempY;

            if (!int.TryParse(x, out tempX) || !int.TryParse(y, out tempY))
            {
                return null;
            }
            else
            {
                return new Point(tempX, tempY);
            }
        }

        public override string ToString()
        {
            return "{" + X.ToString() + ", " + Y.ToString() + "}";
        }
    }
}
