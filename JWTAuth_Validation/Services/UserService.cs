using JWTAuth_Validation.Controllers;

namespace JWTAuth_Validation.Services
{
    public class UserService : IUserService
    {
        public bool IsValidUserInformation(LoginModel model)
        {
            if (model.UserName.Equals("Jay") && model.Password.Equals("123456")) return true;
            else return false;
        }

        public LoginModel GetUserDetails()
        {
            return new LoginModel { UserName = "Jay", Password = "123456" };
        }
    }
}
