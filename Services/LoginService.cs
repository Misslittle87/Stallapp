using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stallapp.Services
{
    public class LoginService : ILoginRepository
    {
        public async Task<UserInfoModel> Login(string userNameEmail, string password)
        {
            throw new NotImplementedException();
        }
    }
}
