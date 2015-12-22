using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    public class TwoPoint
    {
        public Point X { get; private set; }
        public Point Y { get; private set; }

        public TwoPoint(Point x, Point y)
        {
            X = x;
            Y = y;
        }
    }
}
