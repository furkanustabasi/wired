using Wired.Service.Models.Request;
using Wired.Service.Models.Response;

namespace Wired.Service.Abstract
{
    public interface IAuthService
    {
        LoginResponseModel Login(LoginRequestModel loginRequestModel);
        int AddUser();
    }
}
