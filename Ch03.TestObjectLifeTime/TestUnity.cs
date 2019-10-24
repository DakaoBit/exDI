﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Interception;
using Unity.Lifetime;

namespace Ch03.TestObjectLifeTime
{
    class TestUnity
    {
        public void Run()
        {
            var container = new UnityContainer();
            container.RegisterType<IFoo, Foo>(new ContainerControlledLifetimeManager());

            while (true)
            {
                var obj = container.Resolve<IFoo>();
                obj.Hello();

                Process proc = Process.GetCurrentProcess();
                Console.WriteLine("Memory used: {0} MB", proc.PrivateMemorySize64 / (1024 * 1024));
            }
        }
    }
}
