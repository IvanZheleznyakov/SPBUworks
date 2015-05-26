using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExpression
{
    [Serializable]
    public class WrongOperatorException : ApplicationException
    {
        public WrongOperatorException() { }
        public WrongOperatorException(string message) : base(message) { }
        public WrongOperatorException(string message, Exception inner) : base(message, inner) { }
        protected WrongOperatorException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
