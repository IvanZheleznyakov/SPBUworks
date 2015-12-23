using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    public class History
    {
        private List<List<Line>> undoList = new List<List<Line>>();
        private List<List<Line>> redoList = new List<List<Line>>();

        public void Undo(ref List<Line> lines)
        {
            if (undoList.Count != 0)
            {
                redoList.Add(lines);
                lines = undoList[undoList.Count - 1];
                undoList.RemoveAt(undoList.Count - 1);
            }
        }

        public void Redo(ref List<Line> lines)
        {
            if (redoList.Count != 0)
            {
                undoList.Add(lines);
                lines = redoList[redoList.Count - 1];
                redoList.RemoveAt(redoList.Count - 1);
            }
        }

        public void AddList(List<Line> lines)
        {
            undoList.Add(lines);
        }
    }
}
