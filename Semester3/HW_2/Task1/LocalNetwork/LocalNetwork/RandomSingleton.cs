using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    public class RandomSingleton
    {
        private static Random instance;

        public static Random GetInstance()
        {
            if (instance == null)
            {
                instance = new Random();
            }

            return instance;
        }
    }
}
