using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch02.NullObject;

namespace Ch02.Decorator
{
    class DecoratedLogger : ILogger
    {
        private ILogger logger;

        public DecoratedLogger(ILogger log)
        {
            logger = log;
        }

        /// <summary>
        /// 用 DecoratedLogger 加設時間
        /// </summary>
        /// <param name="msg"></param>
        public void Log(string msg)
        {
            logger.Log(DateTime.Now.ToString() + " - " + msg);
        }
    }
}
