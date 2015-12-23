using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIterator
{
    [Serializable]
    public class RemoveFromEmptyListException : ApplicationException
    {
        public RemoveFromEmptyListException() { }
        public RemoveFromEmptyListException(string message) : base(message) { }
        public RemoveFromEmptyListException(string message, Exception inner) : base(message, inner) { }
        protected RemoveFromEmptyListException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
