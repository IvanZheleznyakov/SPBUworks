using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStack
{
    [Serializable]
    public class AddedWrongValueToCalc : ApplicationException
    {
        public AddedWrongValueToCalc() { }
        public AddedWrongValueToCalc(string message) : base(message) { }
        public AddedWrongValueToCalc(string message, Exception inner) : base(message, inner) { }
        protected AddedWrongValueToCalc(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
