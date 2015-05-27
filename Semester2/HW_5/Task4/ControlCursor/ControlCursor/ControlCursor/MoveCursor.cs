using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCursor
{
    public class MoveCursor
    {
        private int currentX = 0;
        private int currentY = 0;

        /// <summary>
        /// Move cursor left.
        /// </summary>
        public void ToTheLeft(object sender, EventArgs args)
        {
            if (currentX != 0)
            {
                Console.SetCursorPosition(--currentX, currentY);
            }
        }

        /// <summary>
        /// Move cursor right.
        /// </summary>
        public void ToTheRight(object sender, EventArgs args)
        {
            if (currentX != 79)
            {
                Console.SetCursorPosition(++currentX, currentY);
            }
        }

        /// <summary>
        /// Move cursor up.
        /// </summary>
        public void ToTheUp(object sender, EventArgs args)
        {
            if (currentY != 0)
            {
                Console.SetCursorPosition(currentX, --currentY);
            }
        }

        /// <summary>
        /// Move cursor down.
        /// </summary>
        public void ToTheDown(object sender, EventArgs args)
        {
            if (currentY != 299)
            {
                Console.SetCursorPosition(currentX, ++currentY);
            }
        }
    }
}
