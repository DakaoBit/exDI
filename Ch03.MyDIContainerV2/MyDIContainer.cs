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

        //Register 是個泛型方法，用來供呼叫端註冊一項型別對應資訊。
        //呼叫端可透過泛型參數 TypeToResolve 和 ConcreteType 
        //來分別指定當應用程式需要型別 TypeToResolve 時，
        //此 DI 容器實際上會建立 ConcreteType 的執行個體。
        public static void Rigister<TypeToResolve, ConcreteType>()
        {
            typeMap[typeof(TypeToResolve)] = typeof(ConcreteType);
        }

        //Resolve 現在也是泛型方法了。
        //當應用程式需要建立 TypeToResolve 型別的物件時，便可呼叫此方法
        public static TypeToResolve Resolve<TypeToResolve>()
        {
            Type concreteType = typeMap[typeof(TypeToResolve)];
            Object instance = Activator.CreateInstance(concreteType);

            return (TypeToResolve)instance;
        } 
    }
}
