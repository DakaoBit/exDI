using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03.MyDIContainerV2
{
    // 自製 DI 容器 v2
    static class MyDIContainer
    {
        static readonly Dictionary<Type, Type> typeMap = new Dictionary<Type, Type>();

        public static void Rigister<TypeToResolve, ConcreteType>()
        {
            typeMap[typeof(TypeToResolve)] = typeof(ConcreteType);
        }

        public static TypeToResolve Resolve<TypeToResolve>()
        {
            Type concreteType = typeMap[typeof(TypeToResolve)];
            Object instance = Activator.CreateInstance(concreteType);

            return (TypeToResolve)instance;
        } 
    }
}
