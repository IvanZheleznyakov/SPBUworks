using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExpression
{
    public interface ITreeElement
    {
        void AddElement(ITreeElement newTreeElement);

        int CountIt();

        string PrintElement();
    }
}