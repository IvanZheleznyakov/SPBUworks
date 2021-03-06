﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListClass
{
    [Serializable]
    public class RemoveFromEmptyListException : Exception
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
