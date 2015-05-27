using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCursor
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var moveCursor = new MoveCursor();

            eventLoop.LeftHandler += moveCursor.ToTheLeft;
            eventLoop.RightHandler += moveCursor.ToTheRight;
            eventLoop.UpHandler += moveCursor.ToTheUp;
            eventLoop.DownHandler += moveCursor.ToTheDown;

            eventLoop.Run();
        }
    }
}
