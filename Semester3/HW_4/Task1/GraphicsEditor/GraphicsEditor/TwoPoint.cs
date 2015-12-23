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
        public PointF X { get; set; }
        public PointF Y { get; set; }

        public TwoPoint(PointF x, PointF y)
        {
            X = x;
            Y = y;
        }
    }
}
