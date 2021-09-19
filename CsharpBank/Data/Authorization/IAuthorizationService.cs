using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBank.Data.Authorization
{
    public interface IAuthorizationService
    {
        User Login(string Login, string Password);
        void Registration(string Login, string Password, string Phone);
    }
}
