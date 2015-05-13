using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    [Serializable]
    public class ExtractFromEmptyStackException : ApplicationException
    {
        public ExtractFromEmptyStackException() { }
        public ExtractFromEmptyStackException(string message) : base(message) { }
        public ExtractFromEmptyStackException(string message, Exception inner) : base(message, inner) { }
        protected ExtractFromEmptyStackException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}