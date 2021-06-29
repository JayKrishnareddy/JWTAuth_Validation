using JWTAuth_Validation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuth_Validation.Services
{
    public class UserService
    {
        public LoginModel GetUserDetails()
        {
            return new LoginModel { UserName = "Jay", Password = "123456" };
        }
    }
}
