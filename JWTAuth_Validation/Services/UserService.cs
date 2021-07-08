using JWTAuth_Validation.Controllers;

namespace JWTAuth_Validation.Services
{
    public class UserService : IUserService
    {
        public LoginModel GetUserDetails()
        {
            return new LoginModel { UserName = "Jay", Password = "123456" };
        }
    }
}
