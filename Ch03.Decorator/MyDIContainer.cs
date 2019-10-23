using Ch03.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03.MyDIContainerV1
{
    static class MyDIContainer
    {
        private static Dictionary<string, Type> typeMap;// 用來保存型別對應表

        static MyDIContainer()
        {
            // 建立型別對應表。
            typeMap = new Dictionary<string, Type>();
            typeMap.Add("EmailService", typeof(EmailService));
            typeMap.Add("SMSService", typeof(SMSService));
            // 若往後需要增加其他型別對應，就加在這裡。
        }

        public static object Reslove(string typeName)
        {
            // 查表，取得型別名稱所對應的型別物件。
            var resolvedType = typeMap[typeName];

            // 利用 reflection 機制來呼叫型別的預設建構函式，以建立物件。
            object instance = Activator.CreateInstance(resolvedType);
            return instance;
        }
    }
}
