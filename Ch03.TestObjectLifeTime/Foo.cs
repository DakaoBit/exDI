﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03.TestObjectLifeTime
{
    interface IFoo
    {
        void Hello();
    }

    class Foo: IFoo, IDisposable
    {
        private byte[] buff = new byte[1024 * 1024];

        public void Hello() { }

        public void Dispose()
        {
            Console.WriteLine("Entering Foo.Dispose()");
        }
    }
}
