using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch03.Common.Services;
 

namespace Ch03.MyDIContainerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 向 DI 容器註冊型別對應。
            MyDIContainer.Rigister<IMessageService, SMSService>();
            var demo = new Ch03.MyDIContainerV2.MainApp();
            demo.Login("nick", "1234");

        }
    }

    class MainApp
    {
        public void Login(string userId, string pwd)
        {
            var msgService = MyDIContainer.Resolve<IMessageService>();
            var authService = new AuthenticationService(msgService); // 注入相依物件。

            if (authService.TwoFactorLogin(userId, pwd))
            {
                // 請使用者收信，然後回來輸入信中提示的驗證碼。
                string userInputToken = "123456";
                if (authService.VerifyToken(userInputToken))
                {
                    // 登入成功。
                }
            }
            // 登入失敗。
        }
    }
}
