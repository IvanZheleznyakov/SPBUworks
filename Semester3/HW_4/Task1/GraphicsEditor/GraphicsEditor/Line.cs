using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    public class Line
    {
        public PointF StartPoint { get; set; }
        public PointF EndPoint { get; set; }

        public Line(PointF x, PointF y)
        {
            StartPoint = x;
            EndPoint = y;
        }
    }
}
