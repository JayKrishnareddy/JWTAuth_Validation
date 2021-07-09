using JWTAuth_Validation.Controllers;

namespace JWTAuth_Validation.Services
{
    public interface IUserService
    {
        bool IsValidUserInformation(LoginModel model);
        LoginModel GetUserDetails();        
    }
}
