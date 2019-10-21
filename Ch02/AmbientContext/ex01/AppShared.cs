using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.AmbientContext.ex01
{
    public static class AppShared
    {
        private static ILogger _logger = new Logger();

        public static ILogger Logger
        {
            get { return _logger; }
            set { _logger = value; }
        }
    }
}
