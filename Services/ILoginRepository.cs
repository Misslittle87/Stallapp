using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stallapp.Services
{
    public interface ILoginRepository
    {
        Task<UserInfoModel> Login(string userNameEmail, string password);
    }
}
