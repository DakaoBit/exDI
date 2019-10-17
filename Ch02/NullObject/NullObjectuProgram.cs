using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.NullObject
{
    class NullObjectuProgram
    {      
        static void Main(string[] args)
        {
            //ConsoleLogger
            ILogger log = new ConsoleLogger();
            var demo = new Ch02.NullObject.MainApp();
            demo.DoSomething(log);
         
        }
    }
}
