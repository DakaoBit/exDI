using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.NullObject
{
    class MainApp
    {
        public void DoSomething(ILogger logger)
        {
            logger.Log("開始執行 DoSomething 函式。");
        }
    }
}
