using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Adapter
{
    class ThirdPartyLogger
    {
        public void WriteEntry(string msg)
        {
            Console.WriteLine($"ThirdPartyLogger msg: {msg}");
        }
    }
}
