using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    /// <summary>
    /// Class for exception. It is called when user added wrong links to network.
    /// </summary>
    [Serializable]
    public class WrongLinksAddedException : ApplicationException
    {
        public WrongLinksAddedException() { }
        public WrongLinksAddedException(string message) : base(message) { }
        public WrongLinksAddedException(string message, Exception inner) : base(message, inner) { }
        protected WrongLinksAddedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
