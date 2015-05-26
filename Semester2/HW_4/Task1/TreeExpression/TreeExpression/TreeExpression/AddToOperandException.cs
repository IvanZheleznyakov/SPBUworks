using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExpression
{
    [Serializable]
    public class AddToOperandException : ApplicationException
    {
        public AddToOperandException() { }
        public AddToOperandException(string message) : base(message) { }
        public AddToOperandException(string message, Exception inner) : base(message, inner) { }
        protected AddToOperandException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
