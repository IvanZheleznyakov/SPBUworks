using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    [Serializable]
    public class AddInfoDuringWorking : ApplicationException
    {
        public AddInfoDuringWorking() { }
        public AddInfoDuringWorking(string message) : base(message) { }
        public AddInfoDuringWorking(string message, Exception inner) : base(message, inner) { }
        protected AddInfoDuringWorking(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
