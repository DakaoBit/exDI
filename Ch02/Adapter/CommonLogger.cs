using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch02.NullObject;

namespace Ch02.Adapter
{
    /// <summary>
    /// 連接 第三方套件, 調整只要在此修改
    /// </summary>
    class CommonLogger : ILogger
    {
        private ThirdPartyLogger logger = new ThirdPartyLogger();

        public void Log(string msg)
        {
            logger.WriteEntry(msg);
        }
    }
}
