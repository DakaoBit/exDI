using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch02.NullObject;

namespace Ch02.Composite
{
    /// <summary>
    /// 建立 CompositeLogger，增加額外屬性或方法
    /// </summary>
    class CompositeLogger : ILogger
    {
        private string Component;

        public CompositeLogger(string component)
        {
            Component = component;
        }

        public void Show()
        {
            Console.WriteLine($"Show Component: {this.Component}");
        }

        public void Log(string msg)
        {
            Console.WriteLine($"{this.Component}" + msg + " : " + DateTime.Now.ToString() );
        }
    }
}
