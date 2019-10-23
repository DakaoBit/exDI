using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03.Common.Services
{
    public interface IAuthenticationService
    {
        bool TwoFactorLogin(string userId, string pwd);

        bool VerifyToken(string token);
    }
}
