using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExpression
{
    public interface ITreeElement
    {
        /// <summary>
        /// Add new element to current element.
        /// </summary>
        /// <param name="newTreeElement"></param>
        void AddElement(ITreeElement newTreeElement, ref bool elementIsAdded);

        /// <summary>
        /// Count element.
        /// </summary>
        /// <returns></returns>
        int CountIt();

        /// <summary>
        /// Print element.
        /// </summary>
        /// <returns></returns>
        string PrintElement();
    }
}